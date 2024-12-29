﻿using System.ComponentModel.DataAnnotations;

namespace AssetManager.Entities
{
    public class User
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(50, ErrorMessage = "User name must be a maximum of 50 characters")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

    }
}
