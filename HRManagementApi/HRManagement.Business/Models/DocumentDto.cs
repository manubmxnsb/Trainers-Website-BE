using HRManagement.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.Business.Models
{
    public class DocumentDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime? CreationDate { get; set; }
        public byte[]? Content { get; set; }
    }
}
