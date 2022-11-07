using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Callcenter_Simulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndCallController : ControllerBase
    {
        // GET: api/<EndCallController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EndCallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EndCallController>
        [HttpPost]
        public ActionResult EndCall([FromForm] PostEndCall p)
        {

            StoredProcedureResponse vm = new StoredProcedureResponse();


            if (!string.IsNullOrEmpty(p.phonenumber) &&
                !string.IsNullOrEmpty(p.statusendid.ToString())
                )
            {
                vm.Status = StoredProcedures.EndCall(p.phonenumber, p.statusendid);
            }
            else
            {
                vm.Status = 999;
            }
            vm.Message = Enum.GetName(typeof(EndCallEnum), vm.Status);
            return Ok(vm);

        }

        // PUT api/<EndCallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EndCallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
