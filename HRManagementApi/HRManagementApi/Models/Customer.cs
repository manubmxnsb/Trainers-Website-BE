namespace HRManagementApi.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
    }

}
