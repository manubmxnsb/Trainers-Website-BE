using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface IBusinessLayer
    {
        Task AddNewCustomer(CustomerDto customer);
    }
}