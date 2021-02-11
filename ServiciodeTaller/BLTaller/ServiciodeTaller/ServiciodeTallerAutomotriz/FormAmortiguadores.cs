using BLTaller;
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
    public partial class FormAmortiguadores : Form
    {


        SuspensionBL Amortiguadores; 

        public FormAmortiguadores()
        {
            InitializeComponent();

            Amortiguadores = new SuspensionBL();
            listaSuspensionBindingSource.DataSource = Amortiguadores.ObtenerSuspension();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void amortiguadoresDelanterosTextBox_TextChanged(object sender, EventArgs e)
        {


           
        }

        private void FormAmortiguadores_Load(object sender, EventArgs e)
        {

        }
    }
}
