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
        private const string PATH_ARCHIVO = "Repuestos.txt";
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsRepuestos objRepuestos = new clsRepuestos();

            objRepuestos.Nombre = txtNombre.Text;
            objRepuestos.Precio = decimal.Parse(txtPrecio.Text);
            objRepuestos.Codigo = txtCodigo.Text;
            objRepuestos.Marca = cmbMarca.Text;

            if (optImportado.Checked == true)
            {
                objRepuestos.origen = "Nacional";
            }

            if (optNacional.Checked)
            {
                objRepuestos.origen = "Importado";
            }
            

            MessageBox.Show("Grabacion Exitosa");
            //MessageBox.Show(objRepuestos.ObtenerDatos());

           LimpiarControles();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta frm = new frmConsulta();
            frm.ShowDialog();
        }

        private void LimpiarControles()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            cmbMarca.Items.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
