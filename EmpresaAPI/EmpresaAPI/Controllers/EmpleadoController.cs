using EmpresaAPI.Config;
using EmpresaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DbEmpresaContext _context;
        public EmpleadoController(DbEmpresaContext context)
        {
            _context = context;
        }

        /*SAVE*/
        [HttpPost("save")]
        public async Task<ActionResult> Post(Empleado empleado)
        {
            _context.Add(empleado); //Añadir al contexto
            await _context.SaveChangesAsync(); //Guardar async, tiene que await
            return Ok(); //Retorna status code 200 si todo ok
        }

        /*LIST*/
        [HttpGet("list")]
        public async Task<ActionResult<List<Empleado>>> Get(Empleado empleado)
        {
            return await _context.Empleados.ToListAsync();
        }

    }
}
