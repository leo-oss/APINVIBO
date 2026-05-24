using Microsoft.AspNetCore.Mvc;
using APINVIBO.Data;

namespace APINVIBO.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var invitados = _context.Invitados.ToList();
            return View(invitados);
        }
    }
}