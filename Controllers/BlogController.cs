using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var blog = new Blog{
				Title = "Test Title",
				Body = "Test Body."		
			};
            return View(blog);
        }
    }
}