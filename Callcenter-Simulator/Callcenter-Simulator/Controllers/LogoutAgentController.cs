using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Callcenter_Simulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutAgentController : ControllerBase
    {
        // GET: api/<LogoutAgentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LogoutAgentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LogoutAgentController>
        [HttpPost]
        public ActionResult LogoutAgent([FromForm] PostLogoutAgent p)
        {

            StoredProcedureResponse vm = new StoredProcedureResponse();


            if (!string.IsNullOrEmpty(p.agentid.ToString()))
            {
                vm.Status = StoredProcedures.LogoutAgent(p.agentid);
            }
            else
            {
                vm.Status = 999;
            }
            vm.Message = Enum.GetName(typeof(LogoutAgentEnum), vm.Status);
            return Ok(vm);

        }

        // PUT api/<LogoutAgentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LogoutAgentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
