﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.Business.Models
{
    public class CustomerDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public decimal VAT { get; set; }
        public BillingType BillingType { get; set; }
        public string Details { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<DocumentDto> Documents { get; set; } 
    }
    public enum BillingType
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }
}
