using Pav.Parcial2Rec.Infraestructura.Transversal;
using Pav.Parcial2Rec.Presentacion.Interfaces;

namespace Pav.Parcial2Rec.Presentacion.Tareas
{
    public class AdministradorDeTareas
    {
        #region Implementacion Singleton
        private static volatile AdministradorDeTareas? _instance;
        private static readonly object _syncLock = new();

        private AdministradorDeTareas()
        {

        }

        public static AdministradorDeTareas Instance
        {
            get
            {
                lock (_syncLock)
                {
                    return _instance ??= new AdministradorDeTareas();
                }
            }
        }
        #endregion

        public void Iniciar<TTarea>(IView? mdiPadre = null)
            where TTarea : ITask
        {
            var tarea = Factoria.Instance.Crear<TTarea>();
            if (tarea == null) return;
            tarea.Navigator.MdiPadre = mdiPadre;
            tarea.Iniciar();
        }
    }
}
