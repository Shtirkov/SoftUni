using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ImportDto
{
    //•	Id – integer, Primary Key
    //•	Name – text with min length 3 and max length 25 (required)
    //•	Cells - collection of type Cell

    public class DepartmentsCellsInputModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Name { get; set; }
        public ICollection<CellInputModel> Cells { get; set; }
    }

    public class CellInputModel
    {
        //•	Id – integer, Primary Key
        //•	CellNumber – integer in the range[1, 1000] (required)
        //•	HasWindow – bool (required)
        //•	DepartmentId - integer, foreign key(required)
        //•	Department – the cell's department (required)
        //•	Prisoners - collection of type Prisoner

        [Range(1, 1000)]
        public int CellNumber { get; set; }
        public bool HasWindow { get; set; }
    }
}
