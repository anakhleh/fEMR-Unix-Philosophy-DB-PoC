using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleManagerService.Managers;

namespace SimpleManagerService.Controllers
{
    [ApiController]
    public class SimpleController : ControllerBase
    {
        private readonly SimpleManager __SimpeManager;

        public SimpleController(SimpleManager s){
            __SimpeManager = s;
        }

        // GET api/values
        [HttpGet]
        [Route("/simplemanagerservice/showall")]
        public Object ShowAll()
        {
            return __SimpeManager.ShowAll();
        }

        // [HttpPost]
        // [Route("/simplemanagerservice/addsubject")]
        // public ActionResult<IEnumerable<string>> AddSubject()
        // {
        //     return new string[] { "value1", "value2" };
        // }
        
        // [HttpPost]
        // [Route("/simplemanagerservice/addsubjectinfo")]
        // public ActionResult<IEnumerable<string>> AddSubjectInfo()
        // {
        //     return new string[] { "value1", "value2" };
        // }



        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
