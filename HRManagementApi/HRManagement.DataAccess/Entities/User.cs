﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRManagement.DataAccess.Enums;

namespace HRManagement.DataAccess.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public RoleType Role { get; set; }

        public string Email { get; set; }

        public string JobTitle { get; set; }

        public string Department { get; set; }

        public byte[] Picture { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();

        public int DaysOff { get; set; }
    }
}
