using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace certData
{
    public partial class frmInicio : Form
    {
        string certificadoPath = string.Empty;
        string salida = "certData.txt";
        string password = string.Empty;

        public frmInicio()
        {
            InitializeComponent();

        }

        private void leerCertificado()
        {
            try
            {
                //Carga el certificado
                X509Certificate2 x509 = new X509Certificate2(certificadoPath, password, X509KeyStorageFlags.Exportable);

                //Grabar en un fichero los datos del certificado.
                using (StreamWriter sw = new StreamWriter(salida))
                {
                    string datosCertificado = x509.ToString(true);
                    string cifSociedad = extraeCadena(datosCertificado, "OID.1.3.6.1.4.1.5734.1.7=VATES-", "\r");
                    string sociedad = extraeCadena(datosCertificado, "OID.1.3.6.1.4.1.5734.1.6=", "\r");
                    string apellido1 = extraeCadena(datosCertificado, "OID.1.3.6.1.4.1.5734.1.2=", "\r");
                    string apellido2 = extraeCadena(datosCertificado, "OID.1.3.6.1.4.1.5734.1.3=", "\r");
                    string nombre = extraeCadena(datosCertificado, "OID.1.3.6.1.4.1.5734.1.1=", "\r");

                    if (cifSociedad == "")
                    {
                        string dni = extraeCadena(datosCertificado, "OID.1.3.6.1.4.1.5734.1.4=", "\r");
                        sw.WriteLine("Titular: {0} {1}, {2}", apellido1, apellido2, nombre);
                        sw.WriteLine("NIF: {0}", dni);
                    }
                    else
                    {
                        string dni = extraeCadena(datosCertificado, "OID.1.3.6.1.4.1.5734.1.4=IDCES-", "\r");
                        sw.WriteLine("Representante: {0} {1}, {2}", apellido1, apellido2, nombre);
                        sw.WriteLine("NIF representante: {0}", dni);
                        sw.WriteLine("Titular certificado: {0}", sociedad);
                        sw.WriteLine("CIF titular certificado: {0}", cifSociedad);
                    }
                    sw.WriteLine("Valido desde: {0}", x509.NotBefore);
                    sw.WriteLine("Valido hasta: {0}", x509.NotAfter);
                    sw.WriteLine("Huella digital: {0}", x509.Thumbprint);
                    sw.WriteLine("Numero de serie: {0}", x509.SerialNumber);
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: El fichero {certificadoPath} no existe.");
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Error: No se puede acceder al fichero {certificadoPath} informado.");
            }

            catch (CryptographicException ex)
            {
                MessageBox.Show($"La contraseña del certificado introducida no es correcta. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword1.Text = "";
                txtPassword2.Text = "";
                txtPassword1.Focus();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Certificado leido correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Exit();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword1.Text = "";
                txtPassword2.Text = "";
                txtPassword1.Focus();
            }
        }

        static string extraeCadena(string input, string inicio, string fin)
        {
            string pattern = $"{Regex.Escape(inicio)}(.*?){Regex.Escape(fin)}";
            Match match = Regex.Match(input, pattern);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
