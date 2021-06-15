using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    [ApiController]
    [Route("demo")]
    public class DemoController
    {
        [HttpGet]
        public string GetString()
        {
            return "<h1>Hello World I'm tanmay fuse<h1>";
        }
    }
}