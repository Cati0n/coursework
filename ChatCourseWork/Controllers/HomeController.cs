using System.Web.Mvc;

namespace ChatCourseWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var a = 5;
            var b = 6;
            var result = a + b;

            return View(result);
        }

        public ActionResult About()
        {
            var result = ViewBag.Message = "Your application description page.";

            return View(result);
        }

        public ActionResult Contact()
        {
            var result = ViewBag.Message = "Your contact page.";

            return View(result);
        }
    }
}