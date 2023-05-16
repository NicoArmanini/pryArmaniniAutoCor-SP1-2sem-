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

        private void Inicializar()
        {
            txtCodigo.Text = ""; 
            txtNombre.Text = "";
            txtPrecio.Text = "";
            
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Marca A");
            cmbMarca.Items.Add("Marca B");
            cmbMarca.Items.Add("Marca C");
            cmbMarca.SelectedIndex = 0;
            
            optNacional.Checked = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()) // si los datos son correctos
            {
                 
                clsRepuestos nuevoRep = CrearRepuesto();
                
                Archivo Repuestos = new Archivo();
                Repuestos.NombreArchivo = PATH_ARCHIVO;
                Repuestos.GrabarRepuesto(nuevoRep);
                
                Inicializar();
            }
            else 
            {
                MessageBox.Show("Datos incorrectos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private clsRepuestos CrearRepuesto()
        {
            // se crea un nuevo objeto de tipo Repuesto
            clsRepuestos nuevoRep = new clsRepuestos();
            // se asignan los valores a todas sus propiedades
            nuevoRep.Codigo = txtCodigo.Text;
            nuevoRep.Nombre = txtNombre.Text;
            nuevoRep.Marca = cmbMarca.SelectedItem.ToString();
            nuevoRep.Precio = decimal.Parse(txtPrecio.Text);
            if (optNacional.Checked)
            {
                nuevoRep.origen = "Nacional";
            }
            else
            {
                nuevoRep.origen = "Importado";
            }
            return nuevoRep; // devuelve el objeto creado con sus valores
        }

        private bool ValidarDatos()
        {
            
            bool resultado = false;
            if (txtCodigo.Text != "") 
            {
                if (txtNombre.Text != "") 
                {
                    if (txtPrecio.Text != "") 
                    {
                        Archivo Repuestos = new Archivo();
                        Repuestos.NombreArchivo = PATH_ARCHIVO;
                        // controla que no se repita el código del repuesto
                        if (Repuestos.BuscarCodigoRepuesto(txtCodigo.Text) ==
                        false)
                        {
                            resultado = true; 
                        }
                    }
                }
            }
            return resultado;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
             frmConsulta frm = new frmConsulta(PATH_ARCHIVO);
             frm.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
