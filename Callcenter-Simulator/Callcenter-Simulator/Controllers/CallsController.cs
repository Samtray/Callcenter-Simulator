using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Callcenter_Simulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        // GET: api/<CallsController>
        [HttpGet]
        public ActionResult<string> Get()
        {
            CallViewModel vm = new CallViewModel();
            vm.Status = 0;
            vm.Calls = Call.GetAll();
            return Ok(vm);
        }

        // GET api/<CallsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CallsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CallsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CallsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
