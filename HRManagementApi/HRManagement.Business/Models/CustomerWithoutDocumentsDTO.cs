﻿using HRManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Business.Models
{
    public class CustomerWithoutDocumentsDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public decimal? VAT { get; set; }
        public BillingType? BillingType { get; set; }
        public string? Details { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime? DateCreated { get; set; }
    }
}