using Microsoft.AspNetCore.Mvc;
using ProcessingServer.BLL.DTO;
using ProcessingServer.BLL.Interfaces;
using ProcessingServer.DAL.Entities;

namespace ProcessingServer.Controllers
{
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService _exampleService;

        public ExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet("GetExample")]
        public async Task<ExampleEntity> GetExample([FromQuery] ExampleEntityDto example)
        {
            return await _exampleService.GetExample(example);
        }
    }
}
