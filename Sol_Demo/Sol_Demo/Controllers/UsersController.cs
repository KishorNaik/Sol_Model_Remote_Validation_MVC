using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Models;

namespace Sol_Demo.Controllers
{
    public class UsersController : Controller
    {
        [BindProperty]
        public UserModel Users { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("onsubmit", Name = "onsubmit")]
        public IActionResult Submit()
        {
            if (base.ModelState.IsValid)
            {
                return Content("Validation Pass");
            }
            else
            {
                return View("Index", Users);
            }
        }

        // Remote Validation (Is Email Id exists or not in server)
        [HttpGet]
        public IActionResult IsEmailExistRemoteValidation(string emailId)
        {
            if (emailId == "kishor.naik011.net@gmail.com")
            {
                return Json(false);
            }
            else
            {
                return Json(true);
            }
        }
    }
}