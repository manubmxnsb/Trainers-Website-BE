
using HRManagement.DataAccess.Entities;
using System.Globalization;

namespace HRManagement.Business.Models
{
   public class UserDto
    {
        public long Id { get; set; } 
        public required string FirstName { get; set; }   
        public string LastName { get; set; }
        public RoleType Role { get; set; }

        public required string Email { get; set; }  
        public string JobTitle { get; set; }

        public required string Department { get; set; }
        public byte[] Picture { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<EventsDto> Events { get; set; } = new List<EventsDto>();
        public int DaysOff { get; set; }
      
    }
}
