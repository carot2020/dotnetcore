using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab08.Models;
using Lab08.Data;
using AutoMapper;
using Lab08.Models.Domain;

namespace Lab08.Controllers
{
    public class HomeController : Controller
    {
      

        private ProductData productData;
        DataContext dataContext;
        IMapper mapper;
        public HomeController(ProductData productData,DataContext dataContext, IMapper mapper)
        {
            this.productData = productData;
            this.dataContext = dataContext;
            this.mapper = mapper;
            
        }

        public IActionResult Index()
        {
            List<ProductModel> products = new List<ProductModel>();
            List<Product> productss = dataContext.Products.ToList();
            foreach (var item in productss)
            {
                products.Add(mapper.Map<ProductModel>(item));
            }
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
