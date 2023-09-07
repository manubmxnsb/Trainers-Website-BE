using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Interface
{
    public interface IBusinessLayer
    {
        public void DeleteCustomer(long customerId);
    }
}
