using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Callcenter_Simulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveCallController : ControllerBase
    {
        // GET: api/<ReceiveCallController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ReceiveCallController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReceiveCallController>
        [HttpPost]
        public ActionResult ReceiveCall([FromForm] PostReceiveCall p)
        {

            StoredProcedureResponse vm = new StoredProcedureResponse();


            if (!string.IsNullOrEmpty(p.phonenumber))
            {
                vm.Status = StoredProcedures.ReceiveCall(p.phonenumber);
            }
            else
            {
                vm.Status = 999;
            }

            vm.Message = Enum.GetName(typeof(ReceivedCallsEnum), vm.Status);
            return Ok(vm);

        }

        // PUT api/<ReceiveCallController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReceiveCallController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
