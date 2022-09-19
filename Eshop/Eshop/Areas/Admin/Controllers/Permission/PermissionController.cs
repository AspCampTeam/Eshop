using Application.Interface;
using Domain.Models.Role;
using Domain.ViewModels.Permission;
using Microsoft.AspNetCore.Mvc;
using Application.Security;
using Eshop.Common;

namespace Eshop.Areas.Admin.Controllers.Permission
{
    public class PermissionController : AdminBaseController
    {
        private IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [Route("Roles")]
        //[CheckPermission(Permissions.RoleManagement)]
        public async Task<IActionResult> Index()
        {
            return View(await _permissionService.GetAllRoles());
        }

        #region Add

        [Route("AddRole")]
        //[CheckPermission(Permissions.AddRole)]
        public async Task<IActionResult> AddRole()
        {
            ViewData["Permission"] = await _permissionService.GetAllPermission();
            return View();
        }

        [Route("AddRole")]
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var res = await _permissionService.AddRole(model);
            var rer2 = await _permissionService.AddPermissionRole(res, selectedPermission);
            return Redirect("/Admin/Roles");
        }
        #endregion

        //[CheckPermission(Permissions.EditRole)]
        [Route("EditRole/{id}")]
        public async Task<IActionResult> EditRole(int id)
        {
            var role = await _permissionService.GetRoleById(id);
            ViewData["Permission"] = await _permissionService.GetAllPermission();
            ViewData["SelectedPermission"] = await _permissionService.GetPermissionRoles(id);
            return View(new EditRoleViwModel(){Id = role.Id,Title = role.RoleTitle});
        }


        [Route("EditRole/{id}")]
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViwModel model, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var res = await _permissionService.UpdateRole(model);

            var res2 = await _permissionService.EditPermissionRole(model.Id, selectedPermission);

            return Redirect("/Admin/Roles");
        }

        //[CheckPermission(Permissions.DeleteRole)]
        [Route("DeleteRole/{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var Role = await _permissionService.GetRoleById(id);
            var res = await _permissionService.DeleteRole(Role);
            if (res)
            {
                return Redirect("/Admin/Roles");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
