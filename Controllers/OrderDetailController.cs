﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesOrderManagementSystem.DBModels;
using SalesOrderManagementSystem.IServices;

namespace SalesOrderManagementSystem.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly ISalesOrderService _orderService;

        public OrderDetailController(ISalesOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            List<SalesOrderModel> salesOrdes = new List<SalesOrderModel>();
            salesOrdes = await _orderService.GetAllOrders();
            return View(salesOrdes);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int orderId)
        {
            SalesOrder salesOrder = new SalesOrder();
            if (orderId != 0)
            {
                salesOrder = await _orderService.GetOrderById(orderId);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Customers = await _orderService.GetCustomers();
            return View(salesOrder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(SalesOrder salesOrder)
        {
            if (ModelState.IsValid)
            {
                await _orderService.CreateNewOrders(salesOrder);
                return RedirectToAction(nameof(Index));
            }
            return View(salesOrder);
        }

    }
}
