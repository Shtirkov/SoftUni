using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Cinema.DataProcessor.ImportDto
{
    [XmlType("Customer")]
    public class CustomerImportModel
    {
        //  <FirstName>Randi</FirstName>
        //  <LastName>Ferraraccio</LastName>
        //  <Age>20</Age>
        //  <Balance>59.44</Balance>
        //  <Tickets>

        //•	Id – integer, Primary Key
        //•	FirstName – text with length[3, 20] (required)
        //•	LastName – text with length[3, 20] (required)
        //•	Age – integer in the range[12, 110] (required)
        //•	Balance - decimal (non-negative, minimum value: 0.01) (required)
        //•	Tickets - collection of type Ticket

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [XmlElement("FirstName")]
        public string FirstName { get; set; }


        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [XmlElement("LastName")]
        public string LastName { get; set; }

        [Range(12, 110)]
        [XmlElement("Age")]
        public int Age { get; set; }

        [Range(0.01, double.MaxValue)]
        [XmlElement("Balance")]
        public decimal Balance { get; set; }

        [XmlArray]
        public List<TicketImportModel> Tickets { get; set; }
    }
}
