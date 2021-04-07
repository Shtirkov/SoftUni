namespace TeisterMask.DataProcessor
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.Data.Models.Enums;
    using TeisterMask.DataProcessor.ExportDto;
    using XmlFacade;
    using Formatting = Newtonsoft.Json.Formatting;

    public class Serializer
    {
        public static string ExportProjectWithTheirTasks(TeisterMaskContext context)
        {
            var projects =
                context.Projects
                .ToArray()
                .Where(p => p.Tasks.Count > 0)
                .Select(x => new ProjectTaskExportModel
                {
                    TasksCount = x.Tasks.Count,
                    ProjectName = x.Name,
                    HasEndDate = x.DueDate.HasValue ? "Yes" : "No",
                    Tasks = x.Tasks.Select(t => new TaskExportModel
                    {
                        Name = t.Name,
                        Label = Enum.GetName(typeof(LabelType), t.LabelType),
                    })
                    .OrderBy(t => t.Name)
                    .ToArray()

                })
                .OrderByDescending(t => t.TasksCount)
                .ThenBy(t => t.ProjectName)
                .ToList();

            return XmlConverter.Serialize(projects, "Projects");
        }

        public static string ExportMostBusiestEmployees(TeisterMaskContext context, DateTime date)
        {
            var employees =
                context.Employees
                .Where(e => e.EmployeesTasks.Where(t => t.Task.OpenDate >= date).Any())
                .ToList()
                .Select(e => new
                {
                    Username = e.Username,
                    Tasks = e.EmployeesTasks
                    .Where(t => t.Task.OpenDate >= date)
                     .OrderByDescending(t => t.Task.DueDate)
                    .ThenBy(t => t.Task.Name)
                    .ToList()
                    .Select(t => new
                    {
                        TaskName = t.Task.Name,
                        OpenDate = t.Task.OpenDate.ToString("D", CultureInfo.InvariantCulture),
                        DueDate = t.Task.DueDate.ToString("D", CultureInfo.InvariantCulture),
                        LabelType = Enum.GetName(typeof(LabelType), t.Task.LabelType),
                        ExecutionType = Enum.GetName(typeof(ExecutionType), t.Task.ExecutionType)
                    })
                   
                })
                .OrderByDescending(e => e.Tasks.Count())
                .ThenBy(e => e.Username)
                .Take(10)
                .ToList();
                

            return JsonConvert.SerializeObject(employees, Formatting.Indented);
        }
    }
}