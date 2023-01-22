using Microsoft.AspNetCore.Mvc;
using MVC_Odev.Models;
using System;
using System.Collections.Generic;

namespace MVC_Odev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id)
        {
            foreach (var item in Program.sepet)
            {
                if (id == item.Id)
                {
                    item.Amount += 1;
                    break;
                }
            }
            return View();
        }

        public IActionResult Products()
        {
            ViewBag.Products = Program.products;
            return View();
        }

        public IActionResult ProductCreate()
        {
            ViewBag.Products = Program.products;
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(Product product)
        {
            product.Id = Program.products.Count + 1;
            Program.products.Add(product);  
            return View();
        }

        public IActionResult Customers()
        {
            ViewBag.Customer = Program.customers;
            return View();
        }
        public IActionResult CustomerCreate()
        {
            ViewBag.Customer = Program.customers;
            return View();
        }
        [HttpPost]
        public IActionResult CustomerCreate(Customer customer)
        {
            Program.customers.Add(customer);
            return View();
        }
        public IActionResult Orders()
        {
            ViewBag.Orders = Program.orders;
            return View();
        }
        public IActionResult Employee()
        {
            ViewBag.Employee = Program.employees;
            return View();
        }
        public IActionResult EmployeeCreate()
        {
            ViewBag.Employee = Program.employees;
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeCreate(Employee employee)
        {
            employee.Id = Program.employees.Count + 1;
            Program.employees.Add(employee);
            return View();
        }
        public IActionResult Sepet()
        {
            ViewBag.Sepet = Program.sepet;
            return View();
        }
        [HttpPost]
        public IActionResult Sepet(Order order)
        {
            order.Id = Program.orders.Count + 1;
            order.OrderDate = DateTime.Now;
            Program.orders.Add(order);
            foreach (var item in Program.sepet)
            {
                item.Amount = 0;
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

    }
}
