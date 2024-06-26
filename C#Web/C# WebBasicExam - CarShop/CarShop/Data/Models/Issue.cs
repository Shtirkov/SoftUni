﻿namespace CarShop.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Issue
    {
        [Required]
        [Key]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string Description { get; set; }

        public bool IsFixed { get; set; }

        [Required]
        public string CarId { get; set; }

        public virtual Car Car { get; set; }

    }
}
