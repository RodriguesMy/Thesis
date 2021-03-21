using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace SPOSRest.Controllers
{
    [RoutePrefix("Users")]
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("validate/{password}")]
        public ActionResult validateUser(int password)
        {
            POSEntities1 db = new POSEntities1();
            db.validateUser(password);
            
            return View("ok");
        }
    }
}