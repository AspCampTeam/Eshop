using Application.Interface;
using Domain.ViewModels.DynamicPage;
using Microsoft.AspNetCore.Mvc;

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
    }
}
