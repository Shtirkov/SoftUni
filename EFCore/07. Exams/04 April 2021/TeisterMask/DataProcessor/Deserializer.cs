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

            foreach (var currentProject in projects)
            {
                var isValidOpenDateForProject = DateTime.TryParseExact(currentProject.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var openDateForProject);
                var isValidDueDateForProject = DateTime.TryParseExact(currentProject.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var result);
                DateTime? dueDateForProject = result;

                if (!isValidDueDateForProject)
                {
                    dueDateForProject = null;
                }


                if (!IsValid(currentProject) || !IsValid(isValidOpenDateForProject))// || !IsValid(isValidDueDateForProject))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var project =
                  context.Projects
                  .FirstOrDefault(p => p.Name == currentProject.Name) ??
                   new Project
                   {
                       Name = currentProject.Name,
                       OpenDate = openDateForProject,
                       DueDate = dueDateForProject
                   };

                context.Projects.Add(project);
                context.SaveChanges();

                foreach (var task in currentProject.Tasks)
                {
                    var isValidOpenDateForTask = DateTime.TryParseExact(task.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var openDateForTask);
                    var isValidDueDateForTask = DateTime.TryParseExact(task.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dueDateForTask);

                    if (!IsValid(task) || openDateForTask < openDateForProject || dueDateForTask > dueDateForProject)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var validTask = new Task
                    {
                        Name = task.Name,
                        OpenDate = openDateForTask,
                        DueDate = dueDateForTask,
                        ExecutionType = Enum.Parse<ExecutionType>(task.ExecutionType),
                        LabelType = Enum.Parse<LabelType>(task.LabelType)
                    };

                    context.Tasks
                        .Add(validTask);

                    project.Tasks.Add(validTask);
                }

                sb.AppendLine($"Successfully imported project - {project.Name} with {project.Tasks.Count} tasks.");
            }
            return sb.ToString().TrimEnd();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var employees =
                JsonConvert.DeserializeObject<ICollection<EmployeeTaskImportModel>>(jsonString);

            foreach (var currentEmployee in employees)
            {
                if (!IsValid(currentEmployee))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var employee = new Employee
                {
                    Username = currentEmployee.Username,
                    Email = currentEmployee.Email,
                    Phone = currentEmployee.Phone
                };

                context.Employees.Add(employee);
                context.SaveChanges();

                var taskIds =
                    context.Tasks.Select(t => t.Id)
                    .ToList();

                var uniqueTasks = currentEmployee.Tasks.Distinct();

                foreach (var currentTask in uniqueTasks)
                {
                    if (!taskIds.Contains(currentTask))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var employeeTask = new EmployeeTask
                    {
                        TaskId = currentTask,
                        EmployeeId = employee.Id
                    };

                    employee.EmployeesTasks.Add(employeeTask);

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