namespace Git.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Repository
    {
        [Key]
        [Required]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(RepoNameMaxLength)]
        public string Name { get; set; }

        public DateTime CreatedOn{ get; set; }

        public bool IsPublic { get; set; }

        public string OwnerId { get; set; }

        public User Owner { get; set; }

        public IEnumerable<Commit> Commits { get; set; } = new HashSet<Commit>();
    }
}
