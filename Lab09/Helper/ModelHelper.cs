using AutoMapper;
using Lab09.Models;
using Lab09.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab09.Helper
{
    public class ModelHelper: Profile
    {
        public ModelHelper()
        {
            CreateMap<Product, ProductModel>();
            CreateMap<UserRegistrationModel, User>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
