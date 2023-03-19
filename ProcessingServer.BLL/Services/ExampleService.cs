using AutoMapper;
using ProcessingServer.BLL.DTO;
using ProcessingServer.BLL.Interfaces;
using ProcessingServer.DAL.Entities;
using ProcessingServer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingServer.BLL.Services
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository _exampleRepository;
        private readonly IMapper _mapper;

        public ExampleService(IExampleRepository exampleRepository, IMapper mapper)
        {
            _exampleRepository = exampleRepository;
            _mapper = mapper;
        }

        public async Task<ExampleEntity> GetExample(ExampleEntityDto exampleDto)
        {
            var entity = _mapper.Map<ExampleEntity>(exampleDto);
            return await _exampleRepository.GetExample(entity);  
        }
    }
}
