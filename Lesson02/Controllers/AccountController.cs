using Microsoft.AspNetCore.Mvc;
using Lesson02.Models;
using System;
using System.Collections.Generic;

namespace Lesson02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                     Id = 1,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/1.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 2,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/2.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 3,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/3.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 4,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/4.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 5,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/5.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                     Id = 6,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/Avatar/6.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
        public IActionResult Profile()
        {
            Account account=new Account()
            {
                Id = 6,
                Name = "Hoàng Anh",
                Email = "anh@gmail.com",
                Phone = "0986456789",
                Address = "Hà Nội",
                Avatar = Url.Content("~/Avatar/6.jpg"),
                Gender = 1,
                Bio = "My name is small",
                Birthday = new DateTime(1998, 7, 15)
            };
            ViewBag.account = account;
            return View();
        }
        
    }
}
