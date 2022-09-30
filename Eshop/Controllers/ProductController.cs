using Application.Interface;
using Application.Security;
using Domain.Models.Product;
using Domain.ViewModels.Product;
using Eshop.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class ProductController : BaseSiteController
    {
        #region Injection

        private IProductService _productService;
        IUserService _userService;

        public ProductController(IProductService productService, IUserService userService)
        {
            _productService = productService;
            _userService = userService;
        }

        #endregion

        [Route("Product/{id}")]
        public async Task<IActionResult> Index(int id, bool comment = false)
        {
            var product = await _productService.GetProductByIdForDetail(id);
             ViewData["Features"]  =await _productService.GetAllFeaturesSelected(id);
             var res = await _productService.GetAllPricesOfProduct(id);
             ViewData["productPrice"] = res;
             ViewData["FeaturevValues"] = await _productService.GetAllFeatureValues();
             ViewData["Prices"] =await _productService.GetAllPricesOfProduct(id);
            if (comment == true)
            {
                ViewBag.Comment = true;
            }
            return View(product);
        }

        [Route("AddComment/{id}")]
        public async Task<IActionResult> AddComment(int id, int? parentId)
        {
            string img = await _productService.GetDefaultImageById(id);
            ViewBag.DefaultImage = img;

            return View(new AddCommentViewModel { ProductId = id, ParentId = parentId });
        }

        [Route("AddComment/{id}")]
        [HttpPost]
        public async Task<IActionResult> AddComment(AddCommentViewModel model)
        {
            model.SenderId = User.GetUserId();
            if (!ModelState.IsValid)
            {
                return View();
            }

            int id = await _productService.AddCommentFromUser(model);
            return Redirect("/Product/" + model.ProductId + "?comment=true");
        }

        [Route("AddFavoriteProduct")]
        public async Task<IActionResult> AddFavoriteProduct(long id)
        {
            int Id = Convert.ToInt32(id);
            int UserId = User.GetUserId();
            var res = await _productService.AddFavoriteProduct(Id, UserId);

            return Json(res);
        }

        [Route("FilterProduct/{id}")]
        public async Task<IActionResult> ProductFilter(FilterProductByCategory model, int id)
        {
            var res = await _productService.GetProductByCategorty(model, id);
            return View(res);
        }
    }
}
