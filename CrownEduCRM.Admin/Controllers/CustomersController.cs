using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrownEduCRM.Service;
using Microsoft.AspNetCore.Mvc;

namespace CrownEduCRM.Admin.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService customerService;
        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        public IActionResult Index()
        {
            var customers = customerService.GetAll();
            return View(customers);
        }
    }
}