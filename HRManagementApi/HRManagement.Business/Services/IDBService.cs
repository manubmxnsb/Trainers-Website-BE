namespace HRManagement.Business.Interface
{
    public interface IDBService
    {
       Task<IEnumerable<Models.CustomerDto>> GetAllCustomers();
    }
}
