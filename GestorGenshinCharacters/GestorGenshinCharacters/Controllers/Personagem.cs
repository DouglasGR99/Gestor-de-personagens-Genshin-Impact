using Microsoft.AspNetCore.Mvc;

namespace GestorGenshinCharacters.Controllers
{
    public class Personagem : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
