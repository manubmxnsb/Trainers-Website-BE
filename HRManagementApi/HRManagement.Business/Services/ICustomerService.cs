namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        public Task DeleteCustomer(long[] customerIds);
    }
}
