﻿using MovieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c=>c.Id == id);
            return View(customers);
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id=1, Name= "Kevin George"},
                new Customer { Id = 2, Name = "Navin Flavio" }
            };
 }
        
    }
}