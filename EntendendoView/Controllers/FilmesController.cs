using Microsoft.AspNetCore.Mvc;

namespace EntendendoView.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}
