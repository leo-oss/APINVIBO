using Microsoft.AspNetCore.Mvc;
using APINVIBO.Data;
using APINVIBO.Models;

namespace APINVIBO.Controllers
{
    public class RSVPController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RSVPController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Guardar(Invitado invitado)
        {
            try
            {
                _context.Invitados.Add(invitado);
                _context.SaveChanges();

                return RedirectToAction("Gracias");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        public IActionResult Gracias()
        {
            return View();
        }
    }
}