using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Callcenter_Simulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAgentController : ControllerBase
    {
        // GET: api/<LoginAgentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginAgentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginAgentController>
        [HttpPost]
        public ActionResult LoginAgent([FromForm] PostLoginAgent p)
        {

            StoredProcedureResponse vm = new StoredProcedureResponse();


            if (!string.IsNullOrEmpty(p.agentid.ToString()) &&
                !string.IsNullOrEmpty(p.agentpin.ToString()) &&
                !string.IsNullOrEmpty(p.stationid.ToString())
                )
            {
                vm.Status = StoredProcedures.LoginAgent(p.agentid, p.agentpin, p.stationid);
            }
            else
            {
                vm.Status = 999;
            }
            vm.Message = Enum.GetName(typeof(LoginAgentEnum), vm.Status);
            return Ok(vm);

        }

        // PUT api/<LoginAgentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginAgentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
