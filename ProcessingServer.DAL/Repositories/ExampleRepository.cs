using ProcessingServer.DAL.Entities;
using ProcessingServer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingServer.DAL.Repositories
{
    public class ExampleRepository : IExampleRepository
    {
        public async Task<ExampleEntity> GetExample(ExampleEntity example)
        {
            //ovo je dodano samo da se ispostuje async
            await Task.Delay(1);

            return example;
        }
    }
}
