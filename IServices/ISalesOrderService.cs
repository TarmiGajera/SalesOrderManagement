using SalesOrderManagementSystem.DBModels;

namespace SalesOrderManagementSystem.IServices
{
    public interface ISalesOrderService
    {
        Task<List<SalesOrderModel>> GetAllOrders();
        Task<bool> GetOrderByCustomer();
        Task<SalesOrder> GetOrderById(int orderID);
        Task<List<Customer>> GetCustomers();
        Task<bool> CreateNewOrders(SalesOrder salesOrder);

    }
}
