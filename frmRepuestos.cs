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
        List<clsRepuestos> ListarRepuestos = new List<clsRepuestos>(); //listar, list es como si fuera un vector pero dinamico, NEW es un instanciamiento, crea un nuevo objeto en la memoria.

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

            ListarRepuestos.Add(objRepuestos); // se crea para desues poder listar

            MessageBox.Show("Grabacion Exitosa");
            MessageBox.Show(objRepuestos.ObtenerDatos());

           LimpiarControles();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            foreach (clsRepuestos leer in ListarRepuestos)
            { 
               // listar en un listbox: listBox1.Items.Add(leer.Codigo + " || " + leer.Nombre + " || " + leer.Marca + " || " + leer.Precio + " || " + leer.origen);
            }
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
    }
}
