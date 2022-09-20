﻿using Application.Interface;
using Domain.ViewModels.DynamicPage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Eshop.Areas.Admin.Controllers.Common
{
    public class DynamicPageController : AdminBaseController
    {
        private IDynamicPageService _dynamicPageService;

        public DynamicPageController(IDynamicPageService dynamicPageService)
        {
            _dynamicPageService = dynamicPageService;
        }

        [Route("Pages")]
        public async Task<IActionResult> Pages(FilterDynamicPageViewModel filter)
        {
            var model = await _dynamicPageService.GetAllPagesForAdmin(filter);
            return View(model);
        }

        [Route("AddPage")]
        public async Task<IActionResult> AddPages()
        {
            return View();
        }

        [Route("AddPage")]
        [HttpPost]
        public async Task<IActionResult> AddPages(DynamicPageViewModelAdmin model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }


            var id = await _dynamicPageService.AddDynamicPage(model);
            if (id==0)
            {
                return BadRequest();
            }

            return Redirect("/Admin/Pages");
        }

        [Route("DeletePage/{id}")]
        public async Task<IActionResult> DeletePages(int id)
        {
            var res = await _dynamicPageService.DeleteDynamicPage(id);
            if (res != true)
            {
                return BadRequest();
            }

            return Redirect("/Admin/Pages");
        }

    }
}
