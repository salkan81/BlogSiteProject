using BLL.Abstract;
using BLL.Concrete;
using BlogSiteProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSiteProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRegisterService _userRegisterService;
        private readonly IUserService _userService;

        public UserController(IUserRegisterService userRegisterService,IUserService userService)
        {
            _userRegisterService = userRegisterService;
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogInVM logInVM)
        {
            var userRegister = _userRegisterService.GetByEmailAndPassword(logInVM.Email, logInVM.Password);
            if (userRegister == null)
            {
                TempData["Message"] = "Giriş bilgileri hatalı";
            }
            else
            {
                var user = _userService.GetByID(userRegister.Id);
                HttpContext.Session.SetString("username", user.Name);
                if (user.PhotoPath != null)
                {
                    HttpContext.Session.SetString("picPath", user.PhotoPath);
                }

                TempData["Message"] = "Hoşgeldin";
            }
            

            return RedirectToAction("Index", "Home");
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("username");
            TempData["Message"] = "Güle Güle";
            return RedirectToAction("Index", "Home");
        }
    }
}
