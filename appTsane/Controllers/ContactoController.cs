using Microsoft.AspNetCore.Mvc;

namespace appTsane.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Contacto(){
            return View();
        }
    }
}