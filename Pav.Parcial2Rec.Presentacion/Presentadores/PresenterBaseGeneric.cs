using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using static System.Windows.Forms.MonthCalendar;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

/// <summary>
/// Clase base que implementa la interfaz <see cref="IPresenter{TView}"/>.
/// Tiene asociación fuertemente tipada a la vista vinculada
/// (del tipo de parámetro genérico TView respectivamente).
/// </summary>
/// <para>
/// Los miembros se definieron virtuales para poder sobreescribirse en las clases derivadas.
/// </para>
/// <typeparam name="TView">Representa el tipo de la vista asociada.</typeparam>
public class PresenterBase<TTask, TView> : IPresenter<TTask, TView>
    where TView : class, IView
    where TTask : class, ITask
{
    /// <summary>
    /// Simple implementación de la propiedad <see cref="IPresenter{TTask, TView}.Tarea"/>
    /// Representa una asociación fuertemente tipada a la tarea enlazada.
    /// <para>
    /// Para su uso ver <see cref="IPresenter{TTask, TView}.Tarea"/>
    /// </para>
    /// </summary>
    public virtual TTask? Tarea { get; set; }

    /// <summary>
    /// Simple implementación de la propiedad <see cref="IPresenter{TTask, TView}.Vista"/>
    /// Representa una asociación fuertemente tipada a la vista enlazada.
    /// <para>
    /// Para su uso ver <see cref="IPresenter{TTask, TView}.Vista"/>
    /// </para>
    /// </summary>
    public virtual TView? Vista { get; set; }

    /// <summary>
    /// Implementación de <see cref="IPresenter.Tarea"/> 
    /// como puerta de enlace a la propiedad fuertemente tipada
    /// <see cref="IPresenter{TTask, TView}.Tarea"/>
    /// </summary>
    ITask? IPresenter.Tarea
    {
        get { return Tarea; }
        set { Tarea = value as TTask; }
    }

    /// <summary>
    /// Implementación de <see cref="IPresenter.Vista"/> 
    /// como puerta de enlace a la propiedad fuertemente tipada
    /// <see cref="IPresenter{TTask, TView}.Vista"/>
    /// </summary>
    IView? IPresenter.Vista
    {
        get { return Vista; }
        set { Vista = value as TView; }
    }

    /// <summary>
    /// Constructor definido para que la vista sea inyectada (via DI).
    /// Se asocia el mismo presentador a la vista, para que ésta pueda invocarlo.
    /// </summary>
    /// <param name="vista">Tipo asociado a la vista</param>
    public PresenterBase(TView vista)
    {
        Vista = vista;
        Vista.Presentador = this;
        Vista.VistaClosed += Vista_VistaClosed;
    }

    /// <summary>
    /// Handler del evento <see cref="IView.VistaClosed"/> que se produce cuando la 
    /// vista se cierra
    /// </summary>
    /// <param name="sender">objeto que inicia el evento</param>
    /// <param name="e">argumento pasado</param>
    private void Vista_VistaClosed(object? sender, EventArgs e)
    {
        Dispose();
    }

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
            Vista = null;
        }
    }
    #endregion
}
