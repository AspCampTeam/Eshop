﻿using Application.Interface;
using Application.Security;
using Application.Services;
using Domain.ViewModels.ProductCategory;
using Eshop.Common;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Areas.Admin.Controllers.Product
{
    [CheckPermission(Permissions.ProductCategories)]
    public class ProductCategory : AdminBaseController
    {
        #region Injections

        private IProductService _productService;

        public ProductCategory(IProductService productService)
        {
            _productService = productService;
        }

        #endregion

        
        [Route("Categories")]
        public async Task<IActionResult> Categories(FilterCategoryProduct filter)
        {
            var res = await _productService.GetCategoriesForAdmin(filter);
            return View(res);
        }



        [Route("SubCategories/{id}")]
        public async Task<IActionResult> SubCategories(FilterCategoryProduct filter, int id)
        {
            var res = await _productService.GetSubCategoriesForAdmin(filter, id);
            if (res == null)
            {
                ViewBag.NoSubCat = true;
                ModelState.AddModelError("Category", "زیر گروهی یافت نشد");
                return View(res);
            }
            return View(res);
        }

        #region Add Category
        [CheckPermission(Permissions.AddCategory)]
        [Route("AddCategory/{parentId?}")]
        public async Task<IActionResult> AddCategory(int? parentId)
        {
            return View("CategoryManager");
        }

       [HttpPost("AddCategory/{parentId?}")]
     
        public async Task<IActionResult> AddCategory(EditOrAddCategoryProduct model, int? parentId)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryManager", model);
            }

            if (parentId != null)
                model.ParentId = parentId;
            else
                model.ParentId = null;

            await _productService.AddCategory(model);
            return Redirect("/Admin/Categories");
        }

        #endregion

        #region Edit Category

        [CheckPermission(Permissions.EditCategory)]
        [Route("EditCategory/{id}/{parentId?}")]
        public async Task<IActionResult> EditCategory(int? parentId, int id)
        {
            var category = await _productService.GetCategoryByIdForAdmin(id, parentId);
            ViewBag.IsEditing = true;

            return View("CategoryManager", category);
        }

        [HttpPost("EditCategory/{id}/{parentId?}")]
        public async Task<IActionResult> EditCategory(EditOrAddCategoryProduct model, int? parentId, int id)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryManager", model);
            }
            ViewBag.IsEditing = true;

            if (parentId != null)
                model.ParentId = parentId;
            else
                model.ParentId = null;
            model.IsDeleted = false;
            model.CategoryId = id;
            await _productService.UpdateCategory(model);
            return Redirect("/Admin/Categories");
        }


        #endregion


        #region Delete Category

        [CheckPermission(Permissions.DeleteCategory)]
        [Route("DeleteCategory/{id}/{parentId?}")]
        public async Task<IActionResult> DeleteCategory(int? parentId, int id)
        {
            ViewBag.IsDeleteing = true;
            var category = await _productService.GetCategoryByIdForAdmin(id, parentId);

            return View("CategoryManager", category);
        }

        [HttpPost("DeleteCategory/{id}/{parentId?}")]
        public async Task<IActionResult> DeleteCategory(EditOrAddCategoryProduct model, int? parentId, int id)
        {
            ViewBag.IsDeleteing = true;
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("subCategoryName", "خطا");
                return View("CategoryManager", model);
            }

            if (parentId != null)
                model.ParentId = parentId;
            else
                model.ParentId = null;
            model.IsDeleted = true;
            model.CategoryId = id;
            await _productService.UpdateCategory(model);
            return Redirect("/Admin/Categories");
        }

        #endregion


    }
}
