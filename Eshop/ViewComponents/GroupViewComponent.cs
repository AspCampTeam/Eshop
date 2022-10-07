using Application.Interface;
using Application.Services;
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

namespace Eshop.ViewComponents
{
    public class GroupViewComponent:ViewComponent
    {
        private IProductService _productService;

        public GroupViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return await Task.FromResult((IViewComponentResult)View("_GroupViewComponent"));

        }

    }
}
