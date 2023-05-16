using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A982065_linebot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NpcContrpllerController : ControllerBase
    {
        // GET: api/NpcContrpller
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/NpcContrpller/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NpcContrpller
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/NpcContrpller/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/NpcContrpller/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
