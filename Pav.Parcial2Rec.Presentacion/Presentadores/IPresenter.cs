
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

/// <summary>
/// Todos los presentadores deben implementar la interfaz.
/// En la práctica es más útil heredar de <see cref="PresenterBase"/> 
/// o la versión genérica <see cref="PresenterBase{View}"/> que
/// implementan los miembros de IPresentador.
/// </summary>
public interface IPresenter: IDisposable
{
    /// <summary>
    /// Enlaza el presentador con el objeto de contexto <see cref="ITask"/>
    /// y que sirve para relacionar varios presentadores y como medio para compartir
    /// datos.
    /// <para>
    /// El método setter de la propiedad Tarea se puede utilizar para inicializar lo
    /// necesario en el presentador.
    /// <code>
    /// class MiPresentador : PresentadorBase
    /// {
    ///     public override ITarea Tarea
    ///     {
    ///         get { return base.Tarea; }
    ///         set
    ///         {
    ///             base.Tarea = value;
    ///             //Inicializar lo necesario
    ///         }
    ///     }
    /// }
    /// </code>
    /// </para>
    /// </summary>
    ITask? Tarea { get; set; }

    /// <summary>
    /// Enlaza al presentador con su vista. De acuerdo al patrón MVP, el presentador
    /// accede a su vista.
    /// <para>
    /// El método setter de la propiedad Vista se puede utilizar para inicializar lo
    /// necesario en la vista.
    /// <code>
    /// class MiPresentador : PresentadorBase
    /// {
    ///     public override IVista Vista
    ///     {
    ///         get { return base.Vista; }
    ///         set
    ///         {
    ///             base.Vista = value;
    ///             //Inicializar lo necesario en la vista
    ///         }
    ///     }
    /// }
    /// </code>
    /// </para>
    /// </summary>
    IView? Vista { get; set; }
}
