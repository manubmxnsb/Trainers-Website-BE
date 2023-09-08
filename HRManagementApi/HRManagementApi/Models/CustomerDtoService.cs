using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;

namespace HRManagementApi.Models
{
    public class CustomerDtoService
    {      
            public long Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Country { get; set; }
            public decimal VAT { get; set; }
            public BillingType BillingType { get; set; }
            public string Details { get; set; }
            public bool IsActive { get; set; }
            public DateTime DateCreated { get; set; }
            public ICollection<DocumentDto> Documents { get; set; } = new List<DocumentDto>();
    }
}

