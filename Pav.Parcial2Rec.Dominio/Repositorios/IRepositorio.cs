using Pav.Parcial2Rec.Dominio.Entidades;
using System.Linq.Expressions;

namespace Pav.Parcial2Rec.Dominio.Repositorios;

public interface IRepositorio<TEntity> : IDisposable where TEntity : EntityBase
{
    List<TEntity> ListarTodos(params string[] incluidos);
    List<TEntity> Listar(Expression<Func<TEntity, bool>> predicado, params string[] incluidos);
    TEntity? ObtenerElPrimero(Expression<Func<TEntity, bool>> predicado, params string[] incluidos);
    void Agregar(TEntity entidad);
    void Actualizar(TEntity entidad);
    void Eliminar(TEntity entidad);
    TEntity? ObtenerPorId(Guid id, params string[] incluidos);
}
