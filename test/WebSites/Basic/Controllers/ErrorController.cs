using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    [Route("api/Error")]
    public class ErrorController : Controller
    {
        public string Index()
        {
            return "test";
        }
    }
}