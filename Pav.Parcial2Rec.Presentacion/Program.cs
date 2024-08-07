using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using Pav.Parcial2Rec.Infraestructura.Transversal;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Tareas;
using Pav.Parcial2Rec.Presentacion.Vistas;
using System.Configuration;
using System.Windows.Forms;
using Pav.Parcial2Rec.Infraestructura.Datos;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Infraestructura.Datos.Repositorios;
using Pav.Parcial2.Infraestructura.Datos;

namespace Pav.Parcial2Rec.Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            PavParcial2Context.CadenaDeConexion = ConfigurationManager.ConnectionStrings[1].ConnectionString;

            var service = new ServiceCollection();
            service
                .AddDbContext<PavParcial2Context>(options =>
                {
                    options.UseSqlServer(PavParcial2Context.CadenaDeConexion);
                })
                .AddSingleton<Navigator>()
                .AddTransient<IPrincipalView, PrincipalView>()
                .AddTransient<IHistorialView, HistorialView>()
                .AddTransient<ICotizacionView, CotizacionView>()
                .AddTransient<PrincipalPresenter>()
                .AddTransient<HistorialPresenter>()
                .AddTransient<CotizacionPresenter>()
                .AddTransient<PrincipalTarea>()
                .AddTransient<HistorialTarea>()
                .AddTransient<CotizacionTarea>()
                .AddTransient(typeof(IRepositorio<>), typeof(Repositorio<>));
            
             using var serviceProvider = service.BuildServiceProvider();
            Factoria.Instance.SetContenedor(serviceProvider);

            AdministradorDeTareas.Instance.Iniciar<PrincipalTarea>();
            Application.Run(Application.OpenForms[0]!);
        }
    }
}
