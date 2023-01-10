using EmpresaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Config
{
    public class DbEmpresaContext : DbContext
    {
        public DbEmpresaContext(DbContextOptions<DbEmpresaContext> options) : base(options)
        {

        }

        // Empleados es el nombre que tendrá la base de datos, y al DbSet le pasamos por el operador diamante el nombre del modelo que representa a dicha tabla en nuestro back
        public DbSet<Empleado> Empleados { get; set; }


    }
}
