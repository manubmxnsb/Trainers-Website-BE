using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRManagement.DataAccess.Enums;

namespace HRManagement.DataAccess.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal VAT { get; set; }

        public BillingType BillingType { get; set; }

        public string Details { get; set; }

        public bool IsActive { get; set; }

        public DateTime DateCreated { get; set; }

        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
