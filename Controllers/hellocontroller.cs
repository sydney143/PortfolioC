using Microsoft.AspNetCore.Mvc;

namespace firstASP.Controllers
{
    public class hellocontroller : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "This is my index";
        }
        [HttpGet("projects")]

        public string projects()
        {
            return "These are my projects";
        }
       [HttpGet("contact")]

        public string contact()
        {
            return "These are my Contact";
        } 
    }
}