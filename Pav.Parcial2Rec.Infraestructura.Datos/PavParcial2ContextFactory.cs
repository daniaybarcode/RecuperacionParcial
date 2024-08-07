using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Pav.Parcial2.Infraestructura.Datos
{
    internal class PavParcial2ContextFactory : IDesignTimeDbContextFactory<PavParcial2Context>
    {
        public PavParcial2Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PavParcial2Context>();
            optionsBuilder.UseSqlServer(PavParcial2Context.CadenaDeConexion);

            return new PavParcial2Context(optionsBuilder.Options);
        }
    }
}
