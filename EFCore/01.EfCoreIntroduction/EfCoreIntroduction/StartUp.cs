using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var db = new SoftUniContext();
            Console.WriteLine(RemoveTown(db));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var data = context.Employees.OrderBy(x => x.EmployeeId).ToList();
            var sb = new StringBuilder();

            foreach (var employee in data)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} { employee.JobTitle} {employee.Salary:f2}");
            }

            return sb.ToString();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var data = context.Employees.Where(e => e.Salary > 50000).OrderBy(ep => ep.FirstName).ToList();
            var sb = new StringBuilder();

            foreach (var employee in data)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }
            return sb.ToString();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var data =
                context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary,
                    e.Department.Name
                })
                .OrderBy(ep => ep.Salary)
                .ThenByDescending(ep => ep.FirstName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var employee in data)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Name} - ${employee.Salary:f2}");
            }

            return sb.ToString();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(address);
            context.SaveChanges();

            var employee =
                context.Employees
                .Where(e => e.LastName == "Nakov")
                .FirstOrDefault();

            employee.AddressId = address.AddressId;

            context.SaveChanges();

            var employees =
                context.Employees
                .Select(e =>
                   new
                   {
                       e.Address.AddressText,
                       e.Address.AddressId
                   })
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .ToList();

            var sb = new StringBuilder();

            foreach (var e in employees)
            {
                sb.AppendLine(e.AddressText);
            }
            return sb.ToString();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            //        var data =
            //             context.Employees
            //             .Include(e => e.EmployeesProjects)
            //             .ThenInclude(e => e.Project)
            //             .Where(e => e.EmployeesProjects
            //             .Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))                 
            //             .Select(e => new
            //             {
            //                 employeeFirstName = e.FirstName,
            //                 employeeLastName = e.LastName,
            //                 managerFirstName = e.Manager.FirstName,
            //                 managerLastName = e.Manager.LastName,
            //                 projects = e.EmployeesProjects.Select(p => new
            //                 {
            //                     projectName = p.Project.Name,
            //                     projectStartDate = p.Project.StartDate,
            //                     projectEndDate = p.Project.EndDate
            //                 })
            //             })
            //             .Take(10)
            //             .ToList();

            //        var sb = new StringBuilder();


            //        foreach (var emp in data)
            //        {
            //            //Guy Gilbert - Manager: Jo Brown
            //            //--Half-Finger Gloves - 6/1/2002 12:00:00 AM - 6/1/2003 12:00:00 AM
            //            sb.AppendLine($"{emp.employeeFirstName} {emp.employeeLastName} - Manager: {emp.managerFirstName} {emp.employeeLastName}");

            //            foreach (var project in emp.projects)
            //            {
            //                var endDate =
            //                    project.projectEndDate.HasValue ? project.projectEndDate.Value.ToString() : "not finished";

            //                sb.AppendLine($"--{project.projectName} - {project.projectStartDate} - {endDate}");
            //            }
            //        }
            //        return sb.ToString().TrimEnd();
            //    }
            //}
            StringBuilder content = new StringBuilder();

            var employees =
                context.Employees
                .Include(x => x.Manager)
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Where(employee => employee.EmployeesProjects
                    .Any(project => project.Project.StartDate.Year >= 2001
                                    && project.Project.StartDate.Year <= 2003))
                .Take(10)
                .ToList();

            foreach (var employee in employees)
            {
                content.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.Manager.FirstName} {employee.Manager.LastName}");

                foreach (var project in employee.EmployeesProjects)
                {
                    content.AppendLine($"--{project.Project.Name} -" +
                                       $" {project.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - " +
                                       $"{(project.Project.EndDate == null ? "not finished" : project.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture))}");
                }
            }

            return content.ToString().TrimEnd();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses =
                context.Addresses
                .Include(x => x.Town)
                .OrderByDescending(e => e.Employees.Count)
                .ThenBy(e => e.Town.Name)
                .ThenBy(e => e.AddressText)
                .Select(e => new
                {
                    text = e.AddressText,
                    name = e.Town.Name,
                    count = e.Employees.Count
                })
                .Take(10)
                .ToList();


            var sb = new StringBuilder();

            foreach (var emp in addresses)
            {
                sb.AppendLine($"{emp.text}, {emp.name} - {emp.count} employees");
            }

            return sb.ToString();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var employee =
                context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    projects =
                    e.EmployeesProjects
                    .OrderBy(ep => ep.Project.Name)
                    .Select(ep => new
                    {
                        ep.Project.Name
                    })

                })
                .FirstOrDefault();

            var sb = new StringBuilder();
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");


            foreach (var project in employee.projects)
            {
                sb.AppendLine(project.Name);
            }

            return sb.ToString();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments =
                context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    departmentName = d.Name,
                    managerFirstName = d.Manager.FirstName,
                    managerLastName = d.Manager.LastName,
                    Employees = d.Employees
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                   .Select(e => new
                   {
                       employeeFirstName = e.FirstName,
                       employeeLastName = e.LastName,
                       employeeJobTitle = e.JobTitle
                   })
                });

            var sb = new StringBuilder();

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.departmentName} - {department.managerFirstName} {department.managerLastName}");

                foreach (var employee in department.Employees)
                {
                    sb.AppendLine($"{employee.employeeFirstName} {employee.employeeLastName} - {employee.employeeJobTitle}");
                }
            }

            return sb.ToString();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects =
                context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .ToList();

            var sb = new StringBuilder();

            foreach (var project in projects)
            {
                sb.AppendLine($"{project.Name}");
                sb.AppendLine($"{project.Description}");
                sb.AppendLine($"{project.StartDate.ToString("M/d/yyyy h:mm:ss tt")}");
            }

            return sb.ToString();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            var employees =
                context.Employees
                .Where(e => e.Department.Name == "Engineering" || e.Department.Name == "Tool Design" || e.Department.Name == "Marketing" || e.Department.Name == "Information Services")
                .ToList();

            foreach (var employee in employees)
            {
                employee.Salary = employee.Salary * 1.12M;
            }

            context.SaveChanges();

            var sb = new StringBuilder();

            foreach (var employee in employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
            }

            return sb.ToString();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees =
                context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:f2})");
            }

            return sb.ToString();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            var project =
                context.Projects.Find(2);

            var empProjects =
                context.EmployeesProjects
                .Where(ep => ep.ProjectId == 2)
                .ToList();

            foreach (var proj in empProjects)
            {
                context.Remove(proj);
            }

            context.Projects.Remove(project);

            context.SaveChanges();

            var selectedTenProjects =
                context.Projects.Take(10);

            var sb = new StringBuilder();

            foreach (var proj in selectedTenProjects)
            {
                sb.AppendLine(proj.Name);
            }

            return sb.ToString();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            var town =
                context.Towns
                .Include(a => a.Addresses)
                .FirstOrDefault(t => t.Name == "Seattle");

            var addresIds =
                town.Addresses
                .Select(a => a.AddressId)
                .ToList();

            var employees =
                context.Employees
                .Where(e =>e.AddressId.HasValue && addresIds.Contains(e.AddressId.Value))
                .ToList();


            foreach (var employee in employees)
            {
                employee.AddressId = null;
            }
            
            foreach (var addressId in addresIds)
            {
                var address =
                    context.Addresses
                    .FirstOrDefault(a => a.AddressId == addressId);

                context.Remove(address);
            }

            context.Remove(town);
            context.SaveChanges();


            return $"{addresIds.Count} addresses in Seattle were deleted";
        }
    }
}
