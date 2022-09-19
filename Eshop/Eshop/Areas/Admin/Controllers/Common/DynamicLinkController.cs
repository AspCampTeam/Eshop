using Application.Interface;
using Application.StaticTools;
using Domain.ViewModels.DynamicLinks;
using Microsoft.AspNetCore.Mvc;
using Application.Security;
using Eshop.Common;

namespace Eshop.Areas.Admin.Controllers
{
    public class DynamicLinkController : AdminBaseController
    {
        private IDynamicLinkService _dynamicLinkService;

        public DynamicLinkController(IDynamicLinkService dynamicLinkService)
        {
            _dynamicLinkService = dynamicLinkService;
        }

        [CheckPermission(Permissions.LinkManagement)]
        [Route("Links")]
        public async Task<IActionResult> Index(LinksForAdminViewModel filter)
        {
            var res = await _dynamicLinkService.GetLinksForAdmin(filter);

            return View(res);
        }

        #region Add
        [CheckPermission(Permissions.AddLink)]
        [Route("AddLink")]
        public async Task<IActionResult> AddLink()
        {
            return View();
        }


        [Route("AddLink")]
        [HttpPost]
        public async Task<IActionResult> AddLink(AddLinkViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var addlink = await _dynamicLinkService.AddLink(model);

            return Redirect("/Admin/Links");
        }

        #endregion

        #region Edit
        [Route("EditLink/{id}")]
        [CheckPermission(Permissions.EditLink)]
        public async Task<IActionResult> EditLink(int id)
        {
            var res = await _dynamicLinkService.GetViewModelLinkById(id);
            res.Id = id;
            
            return View(res);
        }

        [Route("EditLink/{id}")]
        [HttpPost]
        public async Task<IActionResult> EditLink(EditLinkViewModel model)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
            }

           
            var status = await _dynamicLinkService.Updatelink(model);

            if (status!=true)
            {
                return BadRequest();
            }

            return Redirect("/Admin/Links");
        }

        #endregion

        #region Delete
        [Route("DeleteLink/{id}")]
        [CheckPermission(Permissions.DeleteLink)]
        public async Task<IActionResult> DeleteLink(int id)
        {
            var res = await _dynamicLinkService.GetLinkById(id);

            if (! await _dynamicLinkService.Deletelink(res.Id))
            {
                return BadRequest();
            }
            else
            {
                return Redirect("/Admin/Links");
            }
        }

        #endregion
    }
}
