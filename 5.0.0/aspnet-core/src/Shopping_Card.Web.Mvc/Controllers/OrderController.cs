using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shopping_Card.Controllers;
using Shopping_Card.Customer;

namespace Shopping_Card.Web.Controllers
{
    public class OrderController : Shopping_CardControllerBase
    {
        private readonly ICustomerService customerService;

        public OrderController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        public IActionResult CreateOrder()
        {
            //ViewBag.ListOfCustomers = customerService.GetAllCustomer().ToList();
            return View();
        }
    }
}