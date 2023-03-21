using AutoMapper;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Services.AutoMapper.MapProfiles
{
    public class ArticleProfile : Profile
    {
        protected ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>().ForMember(destinationMember => destinationMember.CreatedDate,memberOptions => memberOptions.MapFrom(x => x.DateTime.Date.Day));
            CreateMap<ArticleUpdateDto, Article>();
        }
    }
}
