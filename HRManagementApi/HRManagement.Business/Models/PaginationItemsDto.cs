namespace HRManagement.Business.Models
{
    public class PaginationItemsDto
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string? Search { get; set; }

        public bool? CustomerStatus { get; set; }
    }
}
