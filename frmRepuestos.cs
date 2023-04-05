using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniAutoCor_SP1
{
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsRepuestos objRepuestos = new clsRepuestos();

            objRepuestos.Nombre = txtNombre.Text;
            objRepuestos.Precio = Convert.ToInt32(txtPrecio.Text);
            objRepuestos.Codigo = Convert.ToInt32(txtCodigo.Text);
            objRepuestos.Marca = cmbMarca.Text;

            if (optImportado.Checked == true)
            {
                objRepuestos.origen = false;
            }

            if (optNacional.Checked)
            {
                objRepuestos.origen = true;
            }

            MessageBox.Show("Grabacion Exitosa");
            MessageBox.Show(objRepuestos.ObtenerDatos());
        }
    }
}
