using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Business.Models
{
    public class CustomersForDeletionDto
    {   
        public required long[] Ids { get; set; }
    }
}
