namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        public Task DeleteCustomers(List<long> customerIds);
    }
}
