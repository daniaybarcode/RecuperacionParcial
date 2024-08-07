using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;

namespace Pav.Parcial2Rec.Presentacion.Tareas
{
    /// <summary>
    /// Interfaz para implementar en todas las tareas que se definan.
    /// </summary>
    public interface ITask
    {
        /// <summary>
        /// Asocia al presentador con el navegador <see cref="Navigator"/> para el desplazamiento
        /// entre navegadores
        /// </summary>
        Navigator Navigator { get; set; }
        
        void Iniciar();
        void IniciarTarea<TTarea>(IView? mdiPadre = null)
            where TTarea : ITask;
    }
}
