using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using MaterialSkin;
using MaterialSkin.Controls;

namespace certData
{
    public partial class frmInicio : MaterialForm
    {
        string certificadoPath = string.Empty;
        string salida = "certData.txt";
        string password = string.Empty;
        bool leido = false;

        public frmInicio()
        {
            InitializeComponent();

            // Crea una instancia de MaterialSkinManager
            var materialSkinManager = MaterialSkinManager.Instance;

            // Añade el formulario al manager
            materialSkinManager.AddFormToManage(this);

            // Configura el esquema de color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // O DARK si prefieres un tema oscuro

            // Define los colores primarios, oscuros y acentuados
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green600, // Color primario (verde)
                Primary.Green700, // Color oscuro (más oscuro que el primario)
                Primary.Green200, // Color claro (se usa en algunos acentos)
                Accent.LightGreen200, // Color acentuado (se usa en elementos activos como botones)
                TextShade.WHITE // Sombra de texto (blanco o negro)
            );

        }

        private void leerCertificado()
        {
            try
            {
                //Carga el certificado
                X509Certificate2 Certificado = new X509Certificate2(certificadoPath, password, X509KeyStorageFlags.Exportable);
                GestionCertificados gestion = new GestionCertificados();

                leido = true;
                //Obtiene los datos del certificado
                string datosSubject = Certificado.Subject;
                InfoCertificado infoPrevia = new InfoCertificado
                {
                    SerieCertificado = Certificado.SerialNumber,
                    FechaValidez = Certificado.NotAfter,
                    FechaEmision = Certificado.NotBefore,
                    HuellaCertificado = Certificado.Thumbprint.ToString()
                };
                gestion.obtenerDatosSubject(datosSubject, infoPrevia);
                gestion.exportarDatosCertificados(salida,infoPrevia);

            }

            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: El fichero {certificadoPath} no existe.");
                leido = false;
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Error: No se puede acceder al fichero {certificadoPath} informado.");
                leido = false;
            }

            catch (CryptographicException ex)
            {
                MessageBox.Show($"La contraseña del certificado introducida no es correcta. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword1.Text = "";
                txtPassword2.Text = "";
                txtPassword1.Focus();
                leido = false;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                leido = false;
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            txtSeleccion.Text = "";
            if (ofdSeleccion.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta completa del archivo seleccionado
                certificadoPath = ofdSeleccion.FileName;

                // Actualiza el contenido del TextBox con la ruta del archivo
                txtSeleccion.Text = certificadoPath;

                txtPassword1.Focus();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword1.Text != txtPassword2.Text)
                {
                    throw new Exception("Las contraseñas no coinciden.");
                }
                password = txtPassword1.Text;
                leerCertificado();
                if (leido == true)
                {
                    MessageBox.Show("Certificado leido correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Environment.Exit(0);
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword1.Text = "";
                txtPassword2.Text = "";
                txtPassword1.Focus();
            }
        }
    }
}
