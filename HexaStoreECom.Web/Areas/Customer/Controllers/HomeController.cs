﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HexaStoreECom.Entities.Models;
using HexaStoreECom.Entities.Repositories;
using HexaStoreECom.Entities.ViewModels;
using HexaStoreECom.Utilities;
using System.Linq;
using System.Security.Claims;
using X.PagedList;
using Microsoft.AspNetCore.Localization;
using System;

namespace HexaStoreECom.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public HomeController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public IActionResult Index(int ? page)
        {
            var PageNumber = page ?? 1;
            int PageSize = 8;


            var products = _unitofwork.Product.GetAll().ToPagedList(PageNumber,PageSize);
            return View(products);
        }

        public IActionResult Details(int ProductId)
        {
            ShoppingCart obj = new ShoppingCart()
            {
                ProductId = ProductId,
                Product = _unitofwork.Product.GetFirstorDefault(v => v.Id == ProductId, Includeword: "Category"),
                Count = 1
            };
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            shoppingCart.ApplicationUserId = claim.Value;

            ShoppingCart Cartobj = _unitofwork.ShoppingCart.GetFirstorDefault(
                u => u.ApplicationUserId == claim.Value && u.ProductId == shoppingCart.ProductId);

            if (Cartobj == null)
            {
                _unitofwork.ShoppingCart.Add(shoppingCart);
                _unitofwork.Complete();
                HttpContext.Session.SetInt32(SD.SessionKey,
                    _unitofwork.ShoppingCart.GetAll(x=>x.ApplicationUserId == claim.Value).ToList().Count()
                   );
                
            }
            else
            {
                _unitofwork.ShoppingCart.IncreaseCount(Cartobj, shoppingCart.Count);
                _unitofwork.Complete();
            }
            

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(2) }
            );
            return LocalRedirect(returnUrl);
        }

    }
}
