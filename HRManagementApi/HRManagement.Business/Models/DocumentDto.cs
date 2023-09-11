using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Models
{
    public class DocumentDto
    {
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[]? Content { get; set; }
    }
}
