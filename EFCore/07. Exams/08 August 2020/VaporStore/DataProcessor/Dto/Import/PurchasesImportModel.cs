using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using VaporStore.Data.Models.Enums;

namespace VaporStore.DataProcessor.Dto.Import
{
    [XmlType("Purchase")]
    public class PurchasesImportModel
    {
        //•	Id – integer, Primary Key
        //•	Type – enumeration of type PurchaseType, with possible values(“Retail”, “Digital”) (required) 
        //•	ProductKey – text, which consists of 3 pairs of 4 uppercase Latin letters and digits, separated by dashes(ex. “ABCD-EFGH-1J3L”) (required)
        //•	Date – Date(required)
        //•	CardId – integer, foreign key(required)
        //•	Card – the purchase’s card(required)
        //•	GameId – integer, foreign key(required)
        //•	Game – the purchase’s game(required)

        [XmlAttribute("title")]
        [Required]
        public string Title { get; set; }

        [XmlElement("Type")]
        [EnumDataType(typeof(PurchaseType))]
        public PurchaseType Type { get; set; }

        [RegularExpression(@"^[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}$")]
        [XmlElement("Key")]
        [Required]
        public string Key { get; set; }

        [XmlElement("Card")]
        [RegularExpression(@"^[A-Z0-9]{4} [A-Z0-9]{4} [A-Z0-9]{4} [A-Z0-9]{4}$")]
        [Required]
        public string Card { get; set; }

        [XmlElement("Date")]
        [Required]
        public string Date { get; set; }

    }
}
