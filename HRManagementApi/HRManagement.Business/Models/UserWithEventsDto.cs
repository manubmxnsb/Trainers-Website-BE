using HRManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Business.Models
{
    public class UserWithEventsDto
    {
        public long Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleType Role { get; set; }

        public required string Email { get; set; }
        public string JobTitle { get; set; }

        public required string Department { get; set; }
        public byte Picture { get; set; }
        public string PhoneNumber { get; set; }
    
        public int DaysOff { get; set; }
       
        public ICollection<EventsDto> Events { get; set; }  = new List<EventsDto>();
    }
}
