using Microsoft.EntityFrameworkCore;
using Pav.Parcial2.Infraestructura.Datos;
using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using System.Linq.Expressions;

namespace Pav.Parcial2Rec.Infraestructura.Datos.Repositorios;

public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : EntityBase
{
    private readonly PavParcial2Context _dbContext;
    public Repositorio(PavParcial2Context context)
    {
        ArgumentNullException.ThrowIfNull(context);
        _dbContext = context;
    }

    public void Actualizar(TEntity entidad)
    {
        _dbContext.Update(entidad);
        _dbContext.SaveChanges();
    }

    public void Agregar(TEntity entidad)
    {
        _dbContext.Set<TEntity>().Add(entidad);
        _dbContext.SaveChanges();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
        GC.SuppressFinalize(this);
    }

    public void Eliminar(TEntity entidad)
    {
        _dbContext.Set<TEntity>().Remove(entidad);
        _dbContext.SaveChanges();
    }

    public List<TEntity> Listar(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).Where(predicado).ToList();
    }

    public List<TEntity> ListarTodos(params string[] incluidos)
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).ToList();
    }

    public TEntity? ObtenerElPrimero(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).FirstOrDefault(predicado);
    }

    public TEntity? ObtenerPorId(Guid id, params string[] incluidos)
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).SingleOrDefault(e=> e.Id == id);
    }

    private IQueryable<TEntity> Incluir(IQueryable<TEntity> consulta, string[] incluidos) 
    {
        var incluidosConsulta = consulta;

        foreach (var incluido in incluidos)
        {
            incluidosConsulta = incluidosConsulta.Include(incluido);
        }
        return incluidosConsulta;
    }
}
