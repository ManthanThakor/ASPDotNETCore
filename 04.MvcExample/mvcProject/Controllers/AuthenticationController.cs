﻿using Microsoft.AspNetCore.Mvc;

namespace mvcProject.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
