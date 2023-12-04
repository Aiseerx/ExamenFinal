using Microsoft.AspNetCore.Mvc;
using WebApplication1.Context;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotoController : ControllerBase
    {

        public readonly AplicacionContext aplicacionContext;
        public PilotoController(AplicacionContext _aplicacionContext)
        {
            aplicacionContext = _aplicacionContext;
        }
        [HttpGet]
        [Route("MostrarAvion")]
        public async Task<IActionResult> MostrarAvion()
        {
            List<Avion> Avion = aplicacionContext.Avion.OrderByDescending(Avion => Avion.Id).ToList();
            return Ok(Avion);

        }
        [HttpPost]
        [Route("CrearAvion")]
        public async Task<IActionResult> CrearAvion([FromBody] Avion Avion)
        {
            aplicacionContext.TablaEjemplo.Add(Avion);
            aplicacionContext.SaveChanges();
            return Ok(Avion);
        }
        [HttpPut]
        [Route("EditarAvion")]
        public async Task<IActionResult> EditarAvion([FromBody] Avion Avion)
        {
            aplicacionContext.TablaEjemplo.Update(Avion);
            aplicacionContext.SaveChanges();
            return Ok(Avion);
        }
        [HttpDelete]
        [Route("EliminarTablaEjemplo")]
        public async Task<IActionResult> EliminarAvion(int Id)
        {
            TablaEjemplo TablaEjemplo = aplicacionContext.TablaEjemplo.Find(Id);
            aplicacionContext.TablaEjemplo.Remove(Avion);
            aplicacionContext.SaveChanges();
            return Ok(Avion);
        }
    }
}
