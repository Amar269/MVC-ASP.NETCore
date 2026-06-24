using Microsoft.AspNetCore.Mvc;
using MVC_Project.Data;
using MVC_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_Project.Controllers
{
    public class ItemsController : Controller
    {
        private readonly MvcprojectContext _context;

        public ItemsController(MvcprojectContext context)
        {
            _context = context;
        }
        public async Task< IActionResult> Index()
        {
            var item = await _context.Items.ToListAsync();
            return View(item);
        }
    }
}

