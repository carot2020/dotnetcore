﻿using Lab08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab08.Data
{
    public class ProductData
    {
        public List<ProductModel> ProductList { get; set; }
        public static ProductData initData()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.AddRange(new List<ProductModel>
            {
                 new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now

                },
                 new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                       Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                   CreateDate = DateTime.Now

                },
                 new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                       Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                   CreateDate = DateTime.Now

                },
                 new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                       Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now

                },
                  new ProductModel()
                {
                    ProductName = "iphoneX",
                    ProductImage = "iphoneX.png",
                       Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now

                }
            }); ;
            return new ProductData()
            {
                ProductList = products
            };
        }
    }
}
