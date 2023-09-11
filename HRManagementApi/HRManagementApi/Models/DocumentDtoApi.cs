using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRManagement.DataAccess.Entities;

namespace HRManagementApi.Models
{
    public class DocumentDtoApi
    {
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[]? Content { get; set; }
    }
}
