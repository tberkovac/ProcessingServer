using AutoMapper;
using ProcessingServer.BLL.DTO;
using ProcessingServer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingServer.BLL
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<ExampleEntity, ExampleEntityDto>().ReverseMap();
        }
    }
}
