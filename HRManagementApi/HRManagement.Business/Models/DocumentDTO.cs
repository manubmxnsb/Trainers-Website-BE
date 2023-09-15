namespace HRManagement.Business.Models
{
    public class DocumentDto
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public DateTime? CreationDate { get; set; }

        public byte[]? Content { get; set; }
    }
}
