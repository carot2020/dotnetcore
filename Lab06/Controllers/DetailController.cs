using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab06.Data;
using Lab06.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab06.Controllers
{
    public class DetailController : Controller
    {
        private readonly ProductData productData;
        public DetailController(ProductData productData)
        {
            this.productData = productData;
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            ProductModel productModel = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            return View(productModel);
        }
    }
}