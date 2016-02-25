using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Service.Models;
using System.Linq;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ServiceContext ctx;

        public ValuesController(ServiceContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return ctx.People.Select(p => p.Id.ToString());
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
