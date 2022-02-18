using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConfigClassLibrary;


namespace corrector
{
    public partial class frmPrincipal : Form
    {
        Pedido pedidoActual;
        private AppConfig myConfig;
        private Assembly myAssembly;
        private string rutaConfig;
        private string archivoConfig;
        private bool noConfirmarSalida;
        private bool cargaEnProgreso;

        private const string ST_JUDE = "St. Jude";
        private const string PANALAB = "PANALAB";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (noConfirmarSalida)
            {
                //Se guarda el tamaño y la poisición actual del formulario.-
                saveFormSizeAndLocation();
            }
            else
            {
                frmConfirmarSalida f = new frmConfirmarSalida();
                if (f.Mostrar())
                {
                    //Se guarda el tamaño y la poisición actual del formulario.-
                    saveFormSizeAndLocation();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Se configuran la ruta y el nombre del archivo de configuración.- 
            myAssembly = Assembly.GetExecutingAssembly();
            rutaConfig = Path.GetDirectoryName(myAssembly.Location);
            archivoConfig = "corrector.ini";

            cargaEnProgreso = true;
            cmbClientes.Items.Add(PANALAB);
            cmbClientes.Items.Add(ST_JUDE);
            cargaEnProgreso = false;
            cmbClientes.SelectedIndex = 0;

            //Se configura el tamaño y posición del formulario.-
            setFormSizeAndLocation();
            pedidoActual = null;
            configurarGUI();

            configurarCliente();
        }

        private void frmPrincipal_LocationChanged(object sender, EventArgs e)
        {
            updateFormSizeAndLocationData();
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            updateFormSizeAndLocationData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string pedidoBuscado = txtNumeroDePedido.Text;

            try
            {
                pedidoActual = new Pedido(pedidoBuscado, cmbClientes.Text);
                mostrarPedidoActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            pedidoActual = null;
            configurarGUI();
        }

        private void btnActualizarDatosInterfaz_Click(object sender, EventArgs e)
        {
            try
            {
                pedidoActual.LiberarPedido();
                mostrarPedidoActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /******************/

        private void mostrarPedidoActual()
        {
            lblNumeroDePedido.Text = pedidoActual.Numero;
            lblPropietario.Text = pedidoActual.Propietario;
            lblFechaHoraDeAlta.Text = pedidoActual.FechaDeAlta.ToString();
            lblUsuarioDeAlta.Text = pedidoActual.UsuarioDeAlta;
            lblEstado.Text = pedidoActual.Estado.ToString();
            lblNumeroDeCorrida.Text = pedidoActual.NumeroDeCorrida;
            lblFechaDeCorrida.Text = pedidoActual.FechaDeCorrida.ToString();

            dgvLineas.Rows.Clear();
            object[] valores = new object[7];
            List<LineaDePedido> lineas = pedidoActual.ObtenerLineas();
            foreach (LineaDePedido l in lineas)
            {
                valores[0] = l.Numero;
                valores[1] = l.CodigoSKU;
                valores[2] = l.Cantidad;
                valores[3] = l.UnidadMedida;
                valores[4] = l.LoteCliente;
                valores[5] = l.LoteSAP;
                valores[6] = l.FechaVencimiento;
                dgvLineas.Rows.Add(valores);
            }

            tslCantidadDeLineas.Text = lineas.Count.ToString();
            btnRefrescar.Enabled = true;
            btnActualizarDatosInterfaz.Enabled = true;

            if (pedidoActual.Estado == EstadosDePedido.Pendiente)
                btnActualizarDatosInterfaz.Enabled = false;
            else
                btnActualizarDatosInterfaz.Enabled = true;
        }

        private void configurarGUI()
        {
            tslCantidadDeLineas.Text = "0";
            dgvLineas.Rows.Clear();

            lblNumeroDePedido.Text = "";
            lblPropietario.Text = "";
            lblFechaHoraDeAlta.Text = "";
            lblUsuarioDeAlta.Text = "";
            lblEstado.Text = "";
            lblNumeroDeCorrida.Text = "";
            lblFechaDeCorrida.Text = "";

            btnRefrescar.Enabled = false;
            btnActualizarDatosInterfaz.Enabled = false;

            txtNumeroDePedido.Text = "";
            txtNumeroDePedido.Focus();

            cmbClientes.SelectedIndex = 0;  
        }

        /// <summary>
        /// Sets the form size and location.-
        /// </summary>
        private void setFormSizeAndLocation()
        {
            FormWindowState WindowSate;
            string Width = "";
            string Height = "";
            string X = "";
            string Y = "";

            try
            {
                myConfig = new AppConfig(rutaConfig, archivoConfig, AppConfig.Formatos.ArchivoINI);
                Width = myConfig.DevolverValor(this.Name, "width");
                Height = myConfig.DevolverValor(this.Name, "height");
                X = myConfig.DevolverValor(this.Name, "x");
                Y = myConfig.DevolverValor(this.Name, "y");
                noConfirmarSalida = System.Convert.ToBoolean(myConfig.DevolverValor("corrector", "NoConfirmarSalida"));

                Enum.TryParse(myConfig.DevolverValor(this.Name, "WindowState"), out WindowSate);

                this.WindowState = WindowSate;
                this.Size = new Size(System.Convert.ToInt32(Width), System.Convert.ToInt32(Height));
                this.Location = new Point(System.Convert.ToInt32(X), System.Convert.ToInt32(Y));
            }
            catch (Exception)
            {
                //do nothing.-
            }
        }

        /// <summary>
        /// Saves the form size and location.-
        /// </summary>
        private void saveFormSizeAndLocation()
        {
            myConfig = new AppConfig(rutaConfig, archivoConfig, AppConfig.Formatos.ArchivoINI);

            string clave = "";
            string valor = "";
            for (int i = 1; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                        clave = "WindowState";
                        valor = this.WindowState.ToString();
                        break;
                    case 2:
                        clave = "width";
                        valor = this.Width.ToString();
                        break;
                    case 3:
                        clave = "height";
                        valor = this.Height.ToString();
                        break;
                    case 4:
                        clave = "x";
                        valor = this.Location.X.ToString();
                        break;
                    case 5:
                        clave = "y";
                        valor = this.Location.Y.ToString();
                        break;
                    default:
                        break;
                }

                try
                {
                    myConfig.GuardarValor(this.Name, clave, valor);
                    myConfig.Grabar();
                }
                catch (AppConfigClassLibrary.ClaveNoEncontradaException)
                {
                    myConfig.AgregarLinea(this.Name, clave, valor);
                    myConfig.Grabar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar los datos de tamaño y posición del formulario.-", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Actualiza en la barra de estado los datos de ubicación y tamaño del formulario.-
        /// </summary>
        private void updateFormSizeAndLocationData()
        {
            tslFormSizeAndLocation.Text = "Size: " + this.Size.Width.ToString() + ", " + this.Size.Height.ToString();
            tslFormSizeAndLocation.Text += " | Location: " + this.Location.X.ToString() + ", " + this.Location.Y.ToString();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            configurarCliente(); 
        }

        private void configurarCliente()
        {
            if (cargaEnProgreso == false)
            {
                if (cmbClientes.Text == ST_JUDE)
                {
                    lblAlmacen.Text = "wmwhse1";
                    lblPropietario.Text = "ST JUDE";
                    lblBaseDeDatos.Text = "LPFAD";
                }
                else
                {
                    lblAlmacen.Text = "wmwhse2";
                    lblPropietario.Text = "PANALAB";
                    lblBaseDeDatos.Text = "LPFAD";
                }
            }
        }


        private void txtNumeroDePedido_Enter(object sender, EventArgs e)
        {
            txtNumeroDePedido.SelectAll(); 
        }
    }
}
