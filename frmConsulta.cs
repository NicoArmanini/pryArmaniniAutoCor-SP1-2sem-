using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniAutoCor_SP1
{
    public partial class frmConsulta : Form
    {
        private string PATH_ARCHIVO;

        public frmConsulta(string Path) // el constructor recibe el nombre del archivo
        {
            InitializeComponent();
            PATH_ARCHIVO = Path;
        }
        private void frmConsulta_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            
            cmbMarca1.Items.Clear();
            cmbMarca1.Items.Add("Marca A");
            cmbMarca1.Items.Add("Marca B");
            cmbMarca1.Items.Add("Marca C");
            cmbMarca1.SelectedIndex = 0;
            
            optNacional1.Checked = true;
        }

        private void btnConsultar1_Click(object sender, EventArgs e)
        {
            // controlar si el archivo existe
            if (!File.Exists(PATH_ARCHIVO))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // leer el contenido del archivo
            Archivo Repuestos = new Archivo();
            Repuestos.NombreArchivo = PATH_ARCHIVO;
            List<clsRepuestos> repuestos = Repuestos.ObtenerRepuestosOrdenados();
            
            dgvTabla.Rows.Clear();
            
            foreach (clsRepuestos repuesto in repuestos) //recorrer lista
            {
                
                if (repuesto.Marca == cmbMarca1.SelectedItem.ToString())
                {
                    
                    if (optImportado1.Checked && repuesto.origen == "Importado")
                    {
                        // agregar el repuesto a la grilla
                        dgvTabla.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                        repuesto.Marca, repuesto.origen,
                        repuesto.Precio.ToString());
                    }
                    else
                    {
                        if (optNacional1.Checked && repuesto.origen == "Nacional")
                        {
                            
                            dgvTabla.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                            repuesto.Marca, repuesto.origen,
                            repuesto.Precio.ToString());
                        }
                        else
                        {
                            if (optAmbos.Checked)
                            {
                                
                                dgvTabla.Rows.Add(repuesto.Codigo, repuesto.Nombre,
                                repuesto.Marca, repuesto.origen,
                                repuesto.Precio.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
