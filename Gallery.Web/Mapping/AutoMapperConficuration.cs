using AutoMapper;
using Gallery.Data.Models;
using Gallery.Web.Models;
using Microsoft.AspNetCore.Identity;
using System.Runtime;

namespace Gallery.Web.Mapping
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            this.CreateMap<PictureInputModel, Picture>()
                .ForMember(x => x.Name, y => y.MapFrom(s => s.Name));
        }
    }
}
