using System.Web.Mvc;

namespace ChatCourseWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return null;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return null;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return null;
        }
    }
}