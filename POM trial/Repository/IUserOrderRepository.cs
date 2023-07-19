using Microsoft.AspNetCore.Mvc;

namespace POM_trial.Repositories
{
    public interface IUserOrderRepository
    {
       
        Task<IEnumerable<Order>> UserOrders();
    }
}