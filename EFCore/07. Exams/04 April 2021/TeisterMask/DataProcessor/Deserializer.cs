namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.Data.Models;
    using TeisterMask.Data.Models.Enums;
    using TeisterMask.DataProcessor.ImportDto;
    using XmlFacade;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";



        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {
           
            var sb = new StringBuilder();
            var projects = XmlConverter.Deserializer<ProjectTaskImportModel>(xmlString, "Projects");
            var projectsToAdd = new List<Project>();

            foreach (var currentProject in projects)
            {
                var isValidOpenDate = DateTime.TryParseExact(currentProject.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var openDate);

                if (!IsValid(currentProject) || !IsValid(isValidOpenDate))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                DateTime? dueDate;
                if (!String.IsNullOrEmpty(currentProject.DueDate))
                {
                    var isValidDueDate = DateTime.TryParseExact(currentProject.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var projectDueDate);

                    if (!isValidDueDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    dueDate = projectDueDate;
                }
                else
                {
                    dueDate = null;
                }

                var project = new Project
                {
                    Name = currentProject.Name,
                    OpenDate = openDate,
                    DueDate = dueDate
                };

               // context.Projects.Add(project);
                //context.SaveChanges();

                var tasks = currentProject.Tasks;

                foreach (var currentTask in tasks)
                {
                    var isValidTaskOpenDate = DateTime.TryParseExact(currentTask.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var taskOpenDate);
                    var isValidTaskDueDate = DateTime.TryParseExact(currentTask.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var taskDueDate);

                    if (!IsValid(currentTask) || !isValidTaskOpenDate || !isValidTaskDueDate || taskOpenDate < project.OpenDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (project.DueDate.HasValue)
                    {
                        if (project.DueDate.Value < taskDueDate)
                        {
                            sb.AppendLine(ErrorMessage);
                            continue;
                        }
                    }

                    var task = new Task
                    {
                        Name = currentTask.Name,
                        OpenDate = taskOpenDate,
                        DueDate = taskDueDate,
                        ExecutionType = (ExecutionType)currentTask.ExecutionType,
                        LabelType = (LabelType)currentTask.LabelType
                    };

                    //context.Tasks.Add(task);
                    project.Tasks.Add(task);                    
                }
                projectsToAdd.Add(project);
                sb.AppendLine($"Successfully imported project - {project.Name} with {project.Tasks.Count} tasks.");
            }
            context.Projects.AddRange(projectsToAdd);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var employees =
                JsonConvert.DeserializeObject<ICollection<EmployeeTaskImportModel>>(jsonString);

            foreach (var emp in employees)
            {
                if (!IsValid(emp))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var employee = new Employee
                {
                    Username = emp.Username,
                    Email = emp.Email,
                    Phone = emp.Phone
                };

                context.Employees.Add(employee);

                var empTasks = emp.Tasks.Distinct();

                foreach (var t in empTasks)
                {
                    var task = context.Tasks.FirstOrDefault(x => x.Id == t);

                    if (task == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var actualTask = new EmployeeTask
                    {
                        EmployeeId = employee.Id,
                        TaskId = task.Id
                    };

                    employee.EmployeesTasks.Add(actualTask);
                    context.SaveChanges();
                }

                sb.AppendLine($"Successfully imported employee - {employee.Username} with {employee.EmployeesTasks.Count} tasks.");
            }

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}