using Microsoft.AspNetCore.Mvc;
using WebApiZapateria.Entidades;
namespace WebApiZapateria.Controllers
{
    [ApiController]
    [Route("datosExtra")]

    public class DatosExtraController
    {
        //peticion para obtener datos
        [HttpGet]
        public ActionResult<List<DatosExtra>> get()
        {
            return new List<DatosExtra>()
          {
              new DatosExtra() { Id= 1 ,Temporada= "Invierno" , Precio= 1500},
              new DatosExtra() { Id= 2 ,Temporada= "Invierno" , Precio= 2000},
              new DatosExtra() { Id= 3 ,Temporada= "Otoño" , Precio= 800},
              new DatosExtra() { Id= 4 ,Temporada= "Verano" , Precio= 900},
              new DatosExtra() { Id= 5 ,Temporada= "Otoño" , Precio= 1100},
              new DatosExtra() { Id= 6 ,Temporada= "Verano" , Precio= 750},
          };

        }
}
