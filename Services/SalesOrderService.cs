using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using SalesOrderManagementSystem.DBModels;
using SalesOrderManagementSystem.IServices;

namespace SalesOrderManagementSystem.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        private readonly OrderManagementContext _context;
        public SalesOrderService(OrderManagementContext orderManagement)
        {
            _context = orderManagement;
        }
        public async Task<bool> CreateNewOrders(SalesOrder salesOrder)
        {
            try
            {
                var orderData = await _context.AddAsync(salesOrder);
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }
        [Authorize]
        public async Task<List<SalesOrderModel>> GetAllOrders()
        {
            List<SalesOrderModel> result = await _context.Set<SalesOrderModel>().FromSqlRaw("Exec GetSalesOrders").ToListAsync();
            return result;

        }

        public async Task<bool> GetOrderByCustomer()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers = await _context.Set<Customer>().ToListAsync();
            return customers;
        }

        public async Task<SalesOrder>GetOrderById(int orderId)
        {
            SalesOrder salesOrder = new SalesOrder();
            salesOrder = await _context.SalesOrders.Where(o => o.OrderId == orderId).FirstOrDefaultAsync();
            return salesOrder;
        }
    }
}
