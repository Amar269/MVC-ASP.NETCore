using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() { Name = "Nothing" };
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id : " + id);


        }
}
}