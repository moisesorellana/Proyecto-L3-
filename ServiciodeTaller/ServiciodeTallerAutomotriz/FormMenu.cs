using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiciodeTallerAutomotriz
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formlogin = new FormLogin();

            formlogin.ShowDialog();
        }

        private void preventivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPreventivo = new FormPreventivo();
            formPreventivo.MdiParent = this;
            formPreventivo.Show();

        }

        private void amortiguadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAmortiguadores = new FormAmortiguadores();
            formAmortiguadores.MdiParent = this;
            formAmortiguadores.Show();
        }

        private void tijerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTijeras = new FormTijeras();
            formTijeras.MdiParent = this;
            formTijeras.Show();
        }

        private void barraEstabilizadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBarraEstabilizadora = new FormBarraEstabilizadora();
            formBarraEstabilizadora.MdiParent = this;
            formBarraEstabilizadora.Show();

        }

        private void correctivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCorrectivo = new FormCorrectivo();
            formCorrectivo.MdiParent = this;
            formCorrectivo.Show();
        }

        private void vehiculoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formVehiculo = new FormVehiculo();
            formVehiculo.MdiParent = this;
            formVehiculo.Show();
        }

        private void motoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMoto = new FormMoto();
            formMoto.MdiParent = this;
            formMoto.Show();
        }

        private void equipoPesadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEquipoPesado = new FormEquipoPesado();
            formEquipoPesado.MdiParent = this;
            formEquipoPesado.Show();

        }

        private void vehiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formVehiculo = new FormVehiculo();
            formVehiculo.MdiParent = this;
            formVehiculo.Show();

        }

        private void motoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formMoto = new FormMoto();
            formMoto.MdiParent = this;
            formMoto.Show();
        }

        private void equipoPesadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formEquipoPesado = new FormEquipoPesado();
            formEquipoPesado.MdiParent = this;
            formEquipoPesado.Show();

        }

        private void vehiculoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formVehiculo = new FormVehiculo();
            formVehiculo.MdiParent = this;
            formVehiculo.Show();

        }

        private void equipoPesadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var formEquipoPesado = new FormEquipoPesado();
            formEquipoPesado.MdiParent = this;
            formEquipoPesado.Show();
        }

        private void ingresoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formIngresoVehiculo = new FormIngresoVehiculo();
            formIngresoVehiculo.MdiParent = this;
            formIngresoVehiculo.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.MdiParent = this;
            formVentas.Show();

        }

        private void puntasDeDireccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPuntasDireccion = new FormPuntasDireccion();
            formPuntasDireccion.MdiParent = this;
            formPuntasDireccion.Show();
        }

        private void anillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAnillos = new FormAnillos();
            formAnillos.MdiParent = this;
            formAnillos.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
