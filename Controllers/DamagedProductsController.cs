﻿using Dashboard1.Data;
using Dashboard1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard1.Controllers
{
    public class DamagedProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public DamagedProductsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }



        [HttpPost]
        public IActionResult AddDemag(Damegedproducts damagedProducts)
        {
            if (ModelState.IsValid)
            {

                //التحقق اذا كان قد تم اضافة المنتج مسبقا او ل ا 
                var existingProduct = _context.damegedproducts
                    .FirstOrDefault(dp => dp.ProductId == damagedProducts.ProductId);

                if (existingProduct != null)
                {
                    TempData["ErrorMessage"] = "لقد تم اضافة المنتج مسبقا!";
                }
                else
                {
                    _context.damegedproducts.Add(damagedProducts);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "تم اضافة المنتج بنجاح";
                }
            }
            else
            {
                TempData["ErrorMessage"] = "يرجى التحقق من ملء الحقول المطلوبة ";
            }

            return RedirectToAction("Demag", "Home");
        }






    }
}