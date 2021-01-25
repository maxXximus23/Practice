using AutoMapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using TestAlex.DataAccess.Entities;
using TestAlex.Viewmodels;

namespace TestAlex.AutoMapper.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Game, GameViewModel>()
                .ForMember(source => source.Logo, expression => expression.MapFrom(new LogoResolver()));
        }
    }

    public class LogoResolver : IValueResolver<Game, GameViewModel, System.Drawing.Image>
    {
        public Image Resolve(Game source, GameViewModel destination, Image destMember, ResolutionContext context)
        {
            using (var ms = new MemoryStream(source.Logo))
            {
                return Image.FromStream(ms);
            }
        }
    }

}
