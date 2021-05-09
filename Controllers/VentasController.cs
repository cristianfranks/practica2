using Microsoft.AspNetCore.Mvc;

namespace practica2.Controllers
{
    public class VentasController : Controller
    {
        //Pagina Servicios 
        public IActionResult Servicios()
        {
            return View();
        }

        //Pagina Productos
        public IActionResult Productos()
        {
            return View();
        }
        //Pagina Productos Destacados
        public IActionResult ProductosDestacados()
        {
            return View();
        }
        
    }
}