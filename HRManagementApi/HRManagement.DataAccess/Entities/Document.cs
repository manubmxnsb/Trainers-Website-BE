
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace HRManagement.DataAccess.Entities
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public string Title;
        public DateTime CreationDate;
        public byte[] Content;
    }
}
