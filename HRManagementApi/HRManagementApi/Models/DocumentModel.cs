namespace HRManagementApi.Models
{
    public class DocumentModel
    {
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[]? Content { get; set; }
    }
}
