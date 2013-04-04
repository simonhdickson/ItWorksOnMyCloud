using System.Web.Mvc;

namespace ItWorksOnMyCloudSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogService service;

        public HomeController(BlogService service)
        {
            this.service = service;
        }

        [OutputCache(Duration = 60, VaryByParam = "*")]
        public ActionResult Index()
        {
            return View(service.GetBlogPosts());
        }
    }
}
