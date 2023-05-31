using Microsoft.AspNetCore.Mvc;

namespace Ders12_taghelper.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        } public IActionResult Create() 
        {
            return View();
        } public IActionResult Detail( int id)
        {
            ViewBag.Id = id;
            return View();
        }
        
           
      
    }
}
