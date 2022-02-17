using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConfigClassLibrary;

namespace corrector
{
    public partial class frmConfirmarSalida : Form
    {
        private bool salir;
        private AppConfig myConfig;
        private Assembly myAssembly;
        private string archivoConfig;
        private string rutaConfig; 
        public frmConfirmarSalida()
        {
            InitializeComponent();
        }

        private void frmConfirmarSalida_Load(object sender, EventArgs e)
        {
            //Se configuran la ruta y el nombre del archivo de configuración.- 
            myAssembly = Assembly.GetExecutingAssembly();
            rutaConfig = Path.GetDirectoryName(myAssembly.Location);
            archivoConfig = "corrector.ini";
        }

        public bool Mostrar()
        {
            this.ShowDialog();
            return salir;
        }

        private void btnConfirmarSalida_Click(object sender, EventArgs e)
        {
            salir = true;
            if (chkNoConfirmarSalida.Checked)
                actualizarConfirmacionDeSalida(); 
            
            this.Close();
        }

        private void btnCancelarSalida_Click(object sender, EventArgs e)
        {
            salir = false;
            if (chkNoConfirmarSalida.Checked)
                actualizarConfirmacionDeSalida();   

            this.Close();
        }

        private void actualizarConfirmacionDeSalida()
        {
            myConfig = new AppConfig(rutaConfig, archivoConfig, AppConfig.Formatos.ArchivoINI);

            string clave = "NoConfirmarSalida";
            string valor = "true";


            try
            {
                myConfig.GuardarValor("corrector", clave, valor);
                myConfig.Grabar();
            }
            catch (AppConfigClassLibrary.ClaveNoEncontradaException)
            {
                myConfig.AgregarLinea("corrector", clave, valor);
                myConfig.Grabar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar el parámetro de confirmación de salida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
