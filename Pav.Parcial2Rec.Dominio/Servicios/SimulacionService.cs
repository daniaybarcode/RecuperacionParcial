using System;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Pav.Parcial2Rec.Dominio.Servicios
{
    public class SimulacionService
    {
        private readonly Timer _timer;
        private readonly Random _random;
        public event Action<double>? CotizacionModificada;

        public SimulacionService()
        {
            _timer = new Timer(1000);
            _timer.Elapsed += OnTimedEvent;
            _random = new Random();
        }

        public void Conectar()
        {
            _timer.Start();
        }

        public void Desconectar()
        {
            _timer.Stop();
        }

        private void OnTimedEvent(object? source, ElapsedEventArgs e)
        {
            double cotizacion = _random.Next(100, 1000);
            CotizacionModificada?.Invoke(cotizacion);
        }
    }
}
