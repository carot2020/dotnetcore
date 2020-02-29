using AutoMapper;
using Lab06.Models;
using Lab06.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06.Helper
{
    public class ModelHelper: Profile
    {
        public ModelHelper()
        {
            CreateMap<Product, ProductModel>();
        }
    }
}
