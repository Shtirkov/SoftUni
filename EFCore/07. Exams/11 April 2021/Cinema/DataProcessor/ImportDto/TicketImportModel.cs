using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Cinema.DataProcessor.ImportDto
{
    [XmlType("Ticket")]
    public class TicketImportModel
    {
        //  <Ticket>
        //  <ProjectionId>1</ProjectionId>
        //  <Price>7</Price>
        //</Ticket>

        //•	Id – integer, Primary Key
        //•	Price – decimal (non-negative, minimum value: 0.01) (required)
        //•	CustomerId – integer, Foreign key(required)
        //•	Customer – the Ticket’s Customer 
        //•	ProjectionId – integer, Foreign key(required)
        //•	Projection – the Ticket’s Projection

        [XmlElement("ProjectionId")]
        public int ProjectionId { get; set; }

        [Range(0.01, double.MaxValue)]
        [XmlElement("Price")]
        public decimal Price { get; set; }

    }
}
