using Pav.Parcial2Rec.Infraestructura.Transversal;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;

namespace Pav.Parcial2Rec.Presentacion.Presentadores;

/// <summary>
/// Clase para facilitar la navegación entre presentadores
/// </summary>
public sealed class Navigator
{
    /// <summary>
    /// Propiedad que mantiene una referencia a la vista contenedor MDI
    /// </summary>
    public IView? MdiPadre { get; set; }

    public ITask? Tarea { get; set; }

    /// <summary>
    /// Inicia un nuevo presentador (y su vista asociada)
    /// La vista podrá ser un modal o incluirse en un contenedor MDI
    /// </summary>
    /// <typeparam name="TPresentador">Tipo del presentador que debe iniciarse</typeparam>
    /// <param name="esDialogo">Si la vista asociada al presentador se inicia como modal</param>
    public void NavegarA<TPresentador>(bool esDialogo = false)
    where TPresentador : IPresenter
    {
        var presentador = Factoria.Instance.Crear<TPresentador>();
        if (presentador is null || presentador.Vista is null) return;
        if (MdiPadre is null && presentador.Vista.IsMdiPadre)
            MdiPadre = presentador.Vista;
        presentador.Tarea = Tarea;
        if (esDialogo)
        {
            presentador.Vista.MostrarComoDialogo();
        }
        else
        {
            presentador.Vista.Mostrar(MdiPadre);
        }
    }
}
