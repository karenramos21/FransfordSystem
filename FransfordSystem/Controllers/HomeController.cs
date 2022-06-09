﻿using FransfordSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FransfordSystem.Areas.Identity.Pages.Account.Manage;
using Microsoft.AspNetCore.Identity;


namespace FransfordSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }

            return Redirect("Identity/Account/Login");
            
        }

        public IActionResult Login()
        {
            return View();

        }

        public IActionResult Desarrollo()
        {
            return View();

        }





        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult IndexCliente()
        {
            return RedirectToAction("Index", "Clientes");
        }
        public ActionResult IndexExamen()
        {
            return RedirectToAction("Index", "Examenes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult IndexUsuario()
        {
            return RedirectToAction("Index", "Usuario");
        }




    }
}