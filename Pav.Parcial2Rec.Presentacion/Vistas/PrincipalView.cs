using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using Pav.Parcial2Rec.Presentacion.Vistas;

namespace Pav.Parcial2Rec.Presentacion.Vistas
{
    public partial class PrincipalView : PrincipalViewWithPresenter, IPrincipalView
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        public event EventHandler IniciarCotizacionClicked
        {
            add { iniciarToolStripMenuItem.Click += value; }
            remove { iniciarToolStripMenuItem.Click -= value; }
        }

        public event EventHandler VerHistorialClicked
        {
            add { historialToolStripMenuItem.Click += value; }
            remove { historialToolStripMenuItem.Click -= value; }
        }

        //public event EventHandler VerTablaCotizacionesClicked
        //{
        //    add { tablaDeCotizacionesToolStripMenuItem.Click += value; }
        //    remove { tablaDeCotizacionesToolStripMenuItem.Click -= value; }
        //}

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalView_Load(object sender, EventArgs e)
        {

        }
    }

    public class PrincipalViewWithPresenter : ViewBase<PrincipalPresenter> { }
}
