using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Login_Front.Models;

namespace Login_Front.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        [HttpGet("{lineId}")]
        public IActionResult SignIn(string lineId)
        {
            LoginModel loginModel = new LoginModel()
            {
                LineUserId = lineId
            };
            return View(loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginModel loginModel)
        {
            if (loginModel.Password.Equals("password"))
            {
                AuthenticatedModel authenticatedModel = new AuthenticatedModel()
                {
                    Username = loginModel.Username,
                    LineId = loginModel.LineUserId
                };
                return View("Authenticated", authenticatedModel);
            }

            return View("Unauthenticated");
        }
    }
}