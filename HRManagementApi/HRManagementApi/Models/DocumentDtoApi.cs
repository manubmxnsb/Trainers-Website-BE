using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRManagement.DataAccess.Entities;

namespace HRManagementApi.Models
{
    public class DocumentDtoApi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public long CustomerId { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[]? Content { get; set; }
    }
}
