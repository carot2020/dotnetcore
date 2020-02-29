using AutoMapper;
using Lab07.Models;
using Lab07.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab07.Helper
{
    public class ModelHelper: Profile
    {
        public ModelHelper()
        {
            CreateMap<Product, ProductModel>();
        }
    }
}
