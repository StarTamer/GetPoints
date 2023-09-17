using Microsoft.AspNetCore.Mvc;
using morePoints.Data.Interfaces;
using morePoints.Data.Models;
using morePoints.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace morePoints.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllJerseys _jerseyRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllJerseys jerseyRep, ShopCart shopCart)
        {
            _jerseyRep = jerseyRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getJerseyItems();
            _shopCart.listJerseyItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _jerseyRep.Jerseys.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);

            }
            return RedirectToAction("Index");
        }
    }
}
