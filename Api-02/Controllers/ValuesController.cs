using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> ObterTodos()
        {
            var valores = new string[] { "value1", "value2" };

            if (valores.Length < 5000)
                return BadRequest();
            return Ok(valores);
        }

        [HttpGet]
        public ActionResult ObterResultado()
        {
            var valores = new string[] { "value1", "value2" };

            if (valores.Length > 5000)
                return BadRequest();

            return Ok(valores);
        }

        [HttpGet("obter-valores")]
        public IEnumerable<string> ObterValores()
        {
            var valores = new string[] { "value1", "value2" };

            if (valores.Length < 5000)
                return null;
            return valores;
        }


        // GET api/values/obter-por-id/5
        [HttpGet("obter-por-id/{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
