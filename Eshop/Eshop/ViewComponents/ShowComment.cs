using Domain.IRepositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using System.Security.Claims;
using Application.Interface;
using Application.Sender;
using Domain.Models;
using Domain.Models.Enums;
using TopLearn.Core.Convertor;
using Domain.ViewModels.User;

namespace Eshop.ViewComponents
{
    public class ShowComment:ViewComponent
    {
        private IProductService _productService;
        IUserService _userService;

        public ShowComment(IProductService productService, IUserService userService)
        {
            _productService = productService;
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var comments = await _productService.GetAllCommentsByProductId(id);

            return await Task.FromResult((IViewComponentResult) View("_ShowComment", comments));
        }
    }
}
