namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        public Task Delete(List<long> customerIds);
    }
}
