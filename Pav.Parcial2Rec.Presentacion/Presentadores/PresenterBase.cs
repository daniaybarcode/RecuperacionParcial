using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

/// <summary>
/// Implementación simple de la interfaz <see cref="IPresenter"/>.
/// Los miembros se definen como virtuales para poder ser sobreescritos en las clases derivadas.
/// <para>
/// Se recomienda el uso de la versión genérica de la clase <see cref="PresenterBase{Task, View}"/>
/// con asociaciones fuertemente tipadas.
/// </para>
/// </summary>
public class PresenterBase : IPresenter
{
    /// <summary>
    /// Propiedad que representa la tarea asociada al presentador.
    /// Puede ser sobreescrita en las clases derivadas <see cref="IPresenter.Tarea"/>
    /// </summary>
    public virtual ITask? Tarea { get; set; }

    /// <summary>
    /// Propiedad que representa la vista asociada al presentador.
    /// Puede ser sobreescrita en las clases derivadas <see cref="IPresenter.Vista"/>
    /// </summary>
    public virtual IView? Vista { get; set; }
    

    //Implementación del patrón Dispose básico
    #region Dispose
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            Vista?.Dispose();
        }
    }
    #endregion
}
