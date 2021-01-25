using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TestAlex.DataAccess.Entities;
using TestAlex.Viewmodels;

namespace TestAlex.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
        }
    }
}
