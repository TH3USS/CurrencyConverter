using Microsoft.AspNetCore.Mvc;
using ConversorDeMoedas.Models;

namespace ConversorDeMoedas.Controllers
{
    public class ConversorController : Controller
    {
        // Exibe o formulário para conversão
        public IActionResult Index()
        {
            return View();
        }

        // Recebe os dados e faz a conversão
        [HttpPost]
        public IActionResult Converter(ConversorMoeda conversorMoeda)
        {
            if (ModelState.IsValid)
            {
                conversorMoeda.Converter();
                return View("Resultado", conversorMoeda);
            }
            return View("Index");
        }
    }
}
