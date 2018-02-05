using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Login_Front.Controllers
{
    
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }
    }
}