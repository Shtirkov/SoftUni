using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Cinema.DataProcessor.ImportDto
{
    [XmlType("Projection")]
    public class ProjectionImportModel
    {
        //        <Projection>
        //  <MovieId>38</MovieId>
        //  <DateTime>2019-04-27 13:33:20</DateTime>
        //</Projection>

        //•	Id – integer, Primary Key
        //•	MovieId – integer, Foreign key(required)
        //•	Movie – the Projection’s Movie 
        //•	DateTime - DateTime(required)
        //•	Tickets - collection of type Ticket

        [Required]
        [XmlElement("MovieId")]
        public int MovieId { get; set; }

        [Required]
        [XmlElement("DateTime")]
        public string DateTime { get; set; }
    }
}
