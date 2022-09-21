using Application.Interface;
using Domain.ViewModels.Banner;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Areas.Admin.Controllers.Common
{
    public class BannerController : AdminBaseController
    {
        private IBannerService _bannerService;

        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }


        [Route("Banners")]
        public async Task<IActionResult> Banners(FilterBannerViewModel filter)
        {
            var model = await _bannerService.GetAllBannersForAdmin(filter);
            return View(model);
        }

        #region Edit

        [Route("EditBanner/{id}")]
        public async Task<IActionResult> EditBanner(int id)
        {
            var model = await _bannerService.GetBannerById(id);
            ViewBag.Edit = true;
            return View("BannerManger",model);
        }

        [Route("EditBanner/{id}")]
        [HttpPost]
        public async Task<IActionResult> EditBanner(AddOrEditBannerViewModel model)
        {
            if (!ModelState.IsValid)
                return View("BannerManger", model);
            var res =await _bannerService.EditBannerFromAdmin(model);

            return RedirectToAction("Banners");
        }

        #endregion

        #region Add
        [Route("AddBanner")]
        public IActionResult AddBanner()
        {
            ViewBag.AddBanner = true;
            return View("BannerManger"); 
        }


        [Route("AddBanner")]
        [HttpPost]
        public async Task<IActionResult> AddBanner(AddOrEditBannerViewModel model)
        {
            if (!ModelState.IsValid)
                return View("BannerManger",model);
            var res = await _bannerService.AddBannerFromAdmin(model);
            if (!res)
            {
                return BadRequest();
            }
            return RedirectToAction("Banners");
        }

        #endregion

        #region Delete

        [Route("DeleteBanner/{id}")]
        public async Task<IActionResult> DeleteBanner(int id)
        {
            var model = await _bannerService.GetBannerById(id);
            ViewBag.Delete = true;
            return View("BannerManger",model);
        }

        [Route("DeleteBanner/{id}")]
        [HttpPost]
        public async Task<IActionResult> DeleteBanner(AddOrEditBannerViewModel model)
        {
            var res = await _bannerService.DeleteBannerFromAdmin((int)model.Id);
            return RedirectToAction("Banners");
        }

        #endregion
    }
}
