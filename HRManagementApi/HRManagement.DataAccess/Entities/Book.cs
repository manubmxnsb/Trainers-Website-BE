using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.DataAccess.Entities
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public BookGenre Genre { get; set; }    

    }
    public enum BookGenre
    {
        Fiction,
        Educational,
        Bibliography
    }
}
