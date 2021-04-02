﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VaporStore.Data.Models
{
    public class Developer
    {
        //•	Id – integer, Primary Key
        //•	Name – text(required)
        //•	Games - collection of type Game

        public Developer()
        {
            this.Games = new HashSet<Game>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Game> Games { get; set; }
    }
}