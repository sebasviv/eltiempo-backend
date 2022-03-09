using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pruebasvmvc.Data;
using pruebasvmvc.Models;

namespace pruebasvmvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : ControllerBase
    {
        private readonly dbContext _context;

        public VendedoresController(dbContext contexto)
        {
            _context = contexto;
        }

        //Peticion tipo Get: Api/Vendedores
        [HttpGet]
        public async Task<ActionResult> GetVendedores(){


            var VendedorTable = await _context.Vendedor.Include(x => x.Ciudad).ToListAsync();

            return Ok(VendedorTable);
         }

        //Peticion tipo Get por usuario: Api/Vendedores
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendedor>> GetVendedoresByUser(int id)
        {

            var vendedorByUser = await _context.Vendedor.FindAsync(id);
            if(vendedorByUser == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(vendedorByUser);
            }
        }

        //Peticion tipo Post: Api/Vendedores
        [HttpPost]
        public async Task<ActionResult<Vendedor>> PostVendedores(Vendedor item)
        {
            _context.Vendedor.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVendedoresByUser), new { id = item.Id }, item);
        }

        //Peticion tipo Put: Api/Vendedores
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutVendedores(int Id, Vendedor item)
        {
            if(Id != item.Id)
            {
                return BadRequest();
            }


            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(CreatedAtAction(nameof(GetVendedoresByUser), new { Id = item.Id }, item));
        }

        //Peticion tipo Delete: Api/Vendedores
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteVendedores(int Id)
        {
            var vendedorItem = await _context.Vendedor.FindAsync(Id);   

            if(vendedorItem == null)
            {
                return NotFound();
            }
            else
            {
                _context.Vendedor.Remove(vendedorItem);
                await _context.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
