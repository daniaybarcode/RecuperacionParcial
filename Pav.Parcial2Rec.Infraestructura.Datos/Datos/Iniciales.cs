namespace Pav.Parcial2Rec.Infraestructura.Datos.Datos;

public class Repositorio
{
    private static Repositorio? _instance = null;
    private static readonly object _lock = new();

    private Repositorio()
    {
        Inicializar();
    }

    public static Repositorio Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new Repositorio();
                }
            }
            return _instance;
        }
    }


    private void Inicializar()
    {
       
    }
}

