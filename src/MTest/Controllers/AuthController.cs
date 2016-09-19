using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MTest.Models;
using MTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTest.Controllers
{
    public class AuthController: Controller
    {
        private SignInManager<BTUser> _signInManager;
        public AuthController(SignInManager<BTUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "ItemsContrller");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(vm.Username,
                    vm.Password, true, false);
                if (signInResult.Succeeded)
                {
                    if (string.IsNullOrWhiteSpace(returnUrl)) {
                        return RedirectToAction("Index", "Items");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                    
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password incorrect");
                }
            }
            return View();
        }
    }
}
