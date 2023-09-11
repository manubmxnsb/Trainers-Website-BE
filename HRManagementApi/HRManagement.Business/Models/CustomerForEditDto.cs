using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Business.Models
{
    public class CustomerForEditDto
    {
        //public long? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Country { get; set; }
        public decimal? VAT { get; set; }
        public BillingType? BillingType { get; set; }
        public string? Details { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateCreated { get; set; }
        public Document[]? Documents { get; set; }
    }
}
