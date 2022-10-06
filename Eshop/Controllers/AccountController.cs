﻿using Application.Interface;
using Application.Services;
using Domain.IRepositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using System.Security.Claims;
using Application.Sender;
using Domain.Models;
using Domain.Models.Enums;
using TopLearn.Core.Convertor;
using Domain.ViewModels.User;
using Eshop.Controllers.Shared;
using Application.Security;

namespace Eshop.Controllers
{
    public class AccountController : BaseSiteController
    {
        private IUserService _userService;
        private IViewRenderService _viewRenderService;
        private ILoggerService _loggerService;

        public AccountController(IUserService userService, IViewRenderService viewRenderService, ILoggerService loggerService)
        {
            _userService = userService;
            _viewRenderService = viewRenderService;
            _loggerService = loggerService;
        }



        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("Register")]
        [HttpPost]
        public IActionResult Register(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Email", "لطفا اطلاعات را صحیح وارد کنید");
                return View(user);
            }


            if (_userService.UserIsExist(user))
            {
                ViewBag.IsExist = true;
                return View(user);
            }


            User GetUser = _userService.RegisterUser(user);

            string body = _viewRenderService.RenderToStringAsync("_activeEmail", GetUser);
            SendEmail.Send(GetUser.Email, "فعالسازی حساب", body);


            
            return View("SuccessRegister");
        }

        #endregion

        #region Login
        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/Login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = _userService.LoginUser(login);
            if (user == null||user.Status==Status.NotActive)
            {
                ViewBag.Error = true;
                ModelState.AddModelError("Email", "کابری با مشخصات وارد شده یافت نشد .");
                return View(login);
            }

            var cliam = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Name, user.Email)
                    };

            var identity = new ClaimsIdentity(cliam, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var properties = new AuthenticationProperties()
            {

                IsPersistent = login.RememberMe
            };

            await HttpContext.SignInAsync(principal, properties);
            await _loggerService.AddLog(user.Id, user.Id, "ورود به حساب کاربری", LogType.UserLogin);
            ViewBag.IsSuccess = true;
            return View();
        }


        #endregion

        #region Logout
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _loggerService.AddLog(User.GetUserId(), User.GetUserId(), "ورود به حساب کاربری", LogType.UserLogin);
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
        #endregion

        #region ActiveAccount

        public IActionResult ActiveAccount(string id)
        {

            ViewBag.IsActive = _userService.ActiveAccount(id);
            return View();
        }

        #endregion

    }
}
