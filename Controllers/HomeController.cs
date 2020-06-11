﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Partials.Models;

namespace Partials.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create/user")]
        public IActionResult Register(RegUser user)
        {
            if(ModelState.IsValid)
                {
                    // return View("Success");
                    return RedirectToAction("Success");
                } else {
                    return View("Index");
                }
        }

        [HttpPost("login/user")]
        public IActionResult Login(LogUser user)
        {
            if(ModelState.IsValid)
                {
                    return RedirectToAction("Success");
                } else {
                    return View("Index");
                }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
           return View("Success");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
