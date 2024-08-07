using Pav.Parcial2Rec.Presentacion.Tareas;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

/// <summary>
/// Extensión genérica de la interfaz <see cref="IPresenter"/>.
/// Tiene asociación fuertemente tipada a la vista para evitar conversiones de tipos.
/// <para>
/// En vez de implementar esta interfaz directamente conviene heredar de la clase
/// <see cref="PresenterBase{Task, View}"/> que la implementa.
/// </para>
/// </summary>
/// <typeparam name="TView">Representa el tipo de la vista asociada.</typeparam>
/// subtipo de <see cref="ITask"/></typeparam>
/// <typeparam name="TView">Representa el tipo de la vista asociada.</typeparam>
public interface IPresenter<TTask, TView> : IPresenter
    where TView : class
    where TTask : ITask
{
    /// <summary>
    /// Propiedad para acceder a la tarea asociada al tipo genérico.
    /// <para>
    /// Utiliza la palabra reservada new para reutilizar el nombre de la propiedad
    /// definido en la interfaz <see cref="IPresenter"/>
    /// </para>
    /// </summary>
    new TTask? Tarea { get; set; }

    /// <summary>
    /// Propiedad para acceder a la vista asociada al tipo genérico.
    /// <para>
    /// Utiliza la palabra reservada new para reutilizar el nombre de la propiedad
    /// definido en la interfaz <see cref="IPresenter"/>
    /// </para>
    /// </summary>
    new TView? Vista { get; set; }
}
