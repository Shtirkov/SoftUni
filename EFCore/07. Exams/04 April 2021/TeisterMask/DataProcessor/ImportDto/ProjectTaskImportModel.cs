using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TeisterMask.Data.Models.Enums;

namespace TeisterMask.DataProcessor.ImportDto
{
    //•Id - integer, Primary Key
    //•	Name - text with length[2, 40] (required)
    //•	OpenDate - date and time(required)
    //•	DueDate - date and time(can be null)
    //•	Tasks - collection of type Task

    [XmlType("Project")]
    public class ProjectTaskImportModel
    {
        [Required]
        [XmlElement]
        [MinLength(2)]
        [MaxLength(40)]
        public string Name { get; set; }
        
        [Required]
        [XmlElement]
        public string OpenDate { get; set; }

        [XmlElement]
        public string DueDate { get; set; }

        [XmlArray]
        public List<TaskImportModel> Tasks { get; set; }
    }

    [XmlType("Task")]
    public class TaskImportModel
    {
        //•	Id - integer, Primary Key
        //•	Name - text with length[2, 40] (required)
        //•	OpenDate - date and time(required)
        //•	DueDate - date and time(required)
        //•	ExecutionType - enumeration of type ExecutionType, with possible values(ProductBacklog, SprintBacklog, InProgress, Finished) (required)
        //•	LabelType - enumeration of type LabelType, with possible values(Priority, CSharpAdvanced, JavaAdvanced, EntityFramework, Hibernate) (required)
        //•	ProjectId - integer, foreign key(required)
        //•	Project - Project 
        //•	EmployeesTasks - collection of type EmployeeTask

        [Required]
        [XmlElement]
        [MinLength(2)]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [XmlElement]
        public string OpenDate { get; set; }

        [Required]
        [XmlElement]
        public string DueDate { get; set; }

        [XmlElement]
        [EnumDataType(typeof(ExecutionType))]
        public string ExecutionType { get; set; }

        [XmlElement]
        [EnumDataType(typeof(LabelType))]
        public string LabelType { get; set; }
    }
}
