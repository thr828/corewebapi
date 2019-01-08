using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Cors; 

///http://www.cnblogs.com/hbb0b0/p/8035241.html

///public void OnActionExecuted(ActionExecutedContext actionExecutedContext)
///{
///var rs = actionExecutedContext.HttpContext.Response;
///rs.Headers.Add("Access-Control-Allow-Origin", "*");
///rs.Headers.Add("Access-Control-Allow-Headers", "*");
///rs.Headers.Add("Access-Control-Allow-Methods", "*");
///...
///}
namespace CoreWebApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController:ControllerBase {
       // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult < string > Get(int id) {
            return "value"; 
        }
        // GET api/values
        [HttpGet]
        [EnableCors("CorsSample")]
        public IEnumerable < string > Get() {
            return new string[] {DateTime.Now.ToString()}; 
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
