﻿namespace CarShop.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Required]
        [Key]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(DataConstants.DefaultMaxLength)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsMechanic { get; set; }
    }
}
