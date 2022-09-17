using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiZapateria.Entidades;

namespace WebApiZapateria.Controllers
{
    [ApiController]
    [Route("zapatos")]
    public class ZapatosController: ControllerBase
    {
        //peticiones para obtener los datos del calzado
        [HttpGet]

        /*public ActionResult<List<Zapato>> get()
        {
            return new List<Zapato>()
          {
              new Zapato() { Id= 1 ,Codigo= 6011 , Tipo= "Bota" , Marca= "BAMBINO" , Material= "Cuero Cuagulado" , Color= "Latte", Talla=24 },
              new Zapato() { Id= 2 ,Codigo= 4025 , Tipo= "Botin" , Marca= "UH LULU BY EH!" , Material= "Cuero Cuagulado" , Color= "Camel", Talla=22 },
              new Zapato() { Id= 3 ,Codigo= 6357 , Tipo= "Mules" , Marca= "MANHATTAN" , Material= "Piel" , Color= "Negro", Talla=25 },
              new Zapato() { Id= 4 ,Codigo= 5402 , Tipo= "Sneakers" , Marca= "KSWISS" , Material= "Cuero Cuagulado" , Color= "Blanco", Talla=20 },
              new Zapato() { Id= 5 ,Codigo= 3403 , Tipo= "Oxford" , Marca= "UH LULU BY EH!" , Material= "Cuero Cuagulado" , Color= "Negro", Talla=23 },
              new Zapato() { Id= 6 ,Codigo= 2251 , Tipo= "Stiletos" , Marca= "YUYIN" , Material= "Piel" , Color= "Lavanda", Talla=21 },
          };
        }*/

        //con el sig metodo obtendremos los datos directos de la base de datos
        public async Task<ActionResult<List<Zapato>>> get()
        {
            return await dbContext.Zapatos.ToListAsync();
        }

        //peticiones para ingresar datos de algun calzado
        [HttpPost]

        public async Task<ActionResult> Post(Zapato zapato)
        {
            dbContext.Add(zapato);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        private readonly ApplicationDbContext dbContext;
        public ZapatosController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        //peticion put 
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Zapato zapato, int id)
        {
            if(zapato.Id != id)
            {
                return BadRequest("El id del zapato no coincide con el establecido en la url");
            }

            dbContext.Add(zapato);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        //peticion delete 
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Zapatos.AnyAsync(x => x.Id == id);
            if(!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new Zapato()
            {
                Id = id,
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
