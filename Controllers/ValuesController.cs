using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial1.Controllers
{
    [Route("[controller]")]
    public class ValuesController : Controller
    {
        private string[] names = new string[] { "Pedro", "Luis", "mayko" };
        
        [HttpGet]
        public string[] Get()
        {
            return names;
        }

        [HttpGet("{name}")]
        public string Get(string name)
        {
            return names.FirstOrDefault(x => x == name);
        }
    }
}