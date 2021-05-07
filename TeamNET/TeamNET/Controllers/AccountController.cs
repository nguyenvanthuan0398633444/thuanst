using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Entity;
using TeamNET.Models.Request;

namespace TeamNET.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(userName: model.Email, password: model.Password,
                                                                     false,
                                                                     false);
                if (result.Succeeded)
                {
                    var user = await userManager.FindByEmailAsync(model.Email);
                    var role = await userManager.GetRolesAsync(user);
                    if (role.Contains("Student"))
                        return Redirect("/Student/Details/" + user.Id);

                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    ViewBag.Error = "error";
                    
                }
            }
            return View(model);
        }
        [HttpGet("/Account/GetRole/{userId}")]
        public async Task<OkObjectResult> GetRole(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            var role = await userManager.GetRolesAsync(user);
            if (role.Contains("Doctor"))
                return Ok(1);

            return Ok(0);

        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        [Route("/account/getRolesUser")]
        public async Task<IActionResult> GetRolesUser()
        {
            var userId = userManager.GetUserId(HttpContext.User);
            var user = await userManager.FindByIdAsync(userId);
            var roles = userManager.GetRolesAsync(user);
            return Json(new { data = roles });
        }
        [HttpGet]
        [Route("/account/getInfoUser")]
        public async Task<IActionResult> GetInfoUser()
        {
            var userId = userManager.GetUserId(HttpContext.User);
            var user = await userManager.FindByIdAsync(userId);
            var roles = userManager.GetRolesAsync(user);
            return Json(new { data = roles });
        }
    }
}
