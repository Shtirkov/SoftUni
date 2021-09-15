namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.Data.Models.Enums;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using XmlFacade;

    public class Deserializer
    {
        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var data = JsonConvert.DeserializeObject<IEnumerable<DepartmentsCellsInputModel>>(jsonString);

            foreach (var item in data)
            {
                if (!IsValid(item) || 
                    !item.Cells.All(IsValid) || 
                    item.Cells.Count <= 0)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var department = new Department 
                {
                    Name = item.Name,
                    Cells = item.Cells.Select(c => new Cell
                    {
                        CellNumber = c.CellNumber,
                        HasWindow = c.HasWindow
                    }).ToList()
                };

                context.Departments.Add(department);
                sb.AppendLine($"Imported {department.Name} with {department.Cells.Count} cells");
            }

            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var data = JsonConvert.DeserializeObject<IEnumerable<PrisonersMailsInputModel>>(jsonString);

            foreach (var p in data)
            {
                if (!IsValid(p) || !p.Mails.All(IsValid))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                //DateTime date;
                var isValidReleaseDate = DateTime.TryParseExact(p.ReleaseDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate);
                var isValidIncarcerationDate = DateTime.TryParseExact(p.IncarcerationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var incarcerationDate);

                var prisoner = new Prisoner
                {
                    FullName = p.FullName,
                    Nickname = p.Nickname,
                    Age = p.Age,
                    IncarcerationDate = incarcerationDate,
                    ReleaseDate = releaseDate,
                    Bail = p.Bail,
                    CellId = p.CellId,
                    Mails = p.Mails.Select(m => new Mail
                    {
                        Address = m.Address,
                        Description = m.Description,
                        Sender = m.Sender
                    })
                    .ToList()                    
                };

                context.Prisoners.Add(prisoner);
                sb.AppendLine($"Imported {prisoner.FullName} {prisoner.Age} years old");
            }

            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var data = XmlConverter.Deserializer<OfficersPrisonersInputModel>(xmlString, "Officers");

            foreach (var o in data)
            {
                if (!IsValid(o))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var officer = new Officer
                {
                    FullName = o.Name,
                    Salary = o.Money,
                    Position = Enum.Parse<Position>(o.Position),
                    Weapon = Enum.Parse<Weapon>(o.Weapon),
                    DepartmentId = o.DepartmentId,
                    OfficerPrisoners = o.Prisoners.Select(p => new OfficerPrisoner
                    {
                        PrisonerId= p.Id
                    })
                    .ToArray()
                };

                context.Officers.Add(officer);
                sb.AppendLine($"Imported {officer.FullName} ({officer.OfficerPrisoners.Count} prisoners)");
            }

            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
            return isValid;
        }
    }
}