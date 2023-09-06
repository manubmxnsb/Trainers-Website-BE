using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DataAccess.Entities
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public long CustomerId { get; set; }

        public string Title { get; set; }

        public DateTime CreationDate { get; set; }

        public byte[] Content { get; set; }

    }
}
