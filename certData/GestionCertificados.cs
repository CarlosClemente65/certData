using System;
using System.IO;

namespace certData
{
    public class GestionCertificados
    {
        public InfoCertificado infoCertificado = new InfoCertificado();



        public void obtenerDatosSubject(string subject, InfoCertificado info)
        {
            //Carga los datos del certificado en las propiedades de la clase
            bool juridica = false;
            if (subject.Contains("2.5.4.97")) juridica = true;
            string nombrePF = string.Empty; ;
            string apellidoPF = string.Empty;
            string nombrePJ = string.Empty;
            string nombreRepresentante = string.Empty;
            string apellidoRepresentante = string.Empty;
            string nifCertificado = string.Empty;


            string[] partes = subject.Split(',');
            foreach (string parte in partes)
            {
                string[] elementos = parte.Trim().Split('=');
                string elemento = string.Empty;
                string valor = string.Empty;
                if (elementos.Length == 2)
                {
                    elemento = elementos[0];
                    valor = elementos[1];
                }

                switch (elemento)
                {
                    case "G": //Nombre del titular del certificado o del representante si es juridica
                        if (juridica)
                        {
                            nombreRepresentante = valor;
                        }
                        else
                        {
                            nombrePF = valor;
                        }
                        break;

                    case "SN": //Apellido del titular del certificado o del representante si es juridica
                        if (juridica)
                        {
                            apellidoRepresentante = valor;
                        }
                        else
                        {
                            apellidoPF = valor;
                        }
                        break;

                    case "SERIALNUMBER": //NIF del titular del certificado o del representante si es juridica
                        if (juridica)
                        {
                            info.NifRepresentante = valor.Substring(6);
                        }
                        else
                        {
                            nifCertificado = valor.Substring(6);
                        }
                        break;

                    case "O": //Nombre de la sociedad
                        nombrePJ = valor;
                        break;

                    case "OID.2.5.4.97": //NIF de la sociedad
                        nifCertificado = valor.Substring(6);
                        break;

                    case "CN": //Datos representante
                        if (juridica)
                        {
                            info.DatosRepresentante = valor;
                        }
                        break;
                }

                if (string.IsNullOrEmpty(info.NifCertificado)) info.NifCertificado = nifCertificado;
                if (string.IsNullOrEmpty(info.TitularCertificado) || string.IsNullOrEmpty(info.NombreRepresentante))
                {
                    if (juridica)
                    {
                        info.TitularCertificado = nombrePJ;
                        if (!string.IsNullOrEmpty(nombreRepresentante))
                        {
                            info.NombreRepresentante = apellidoRepresentante + " " + nombreRepresentante;
                        }
                    }
                    else
                    {
                        info.TitularCertificado = apellidoPF + " " + nombrePF;
                    }
                }
            }
        }

        public void exportarDatosCertificados(string rutaArchivo, InfoCertificado info)
        {
            //Permite grabar un fichero con los datos de los certificados
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine($"NIF titular: {info.NifCertificado}");
                writer.WriteLine($"Nombre titular: {info.TitularCertificado}");
                writer.WriteLine($"Válido desde: {info.FechaEmision.ToShortDateString()}");
                writer.WriteLine($"Válido hasta: {info.FechaValidez.ToShortDateString()}");
                writer.WriteLine($"NIF representante: {info.NifRepresentante}");
                writer.WriteLine($"Nombre representante: {info.NombreRepresentante}");
                writer.WriteLine($"Datos representante: {info.DatosRepresentante}");
                writer.WriteLine($"Número de serie: {info.SerieCertificado}");
                writer.WriteLine($"Huella certificado: {info.HuellaCertificado}");
            }
        }
    }

    public class InfoCertificado
    {
        //Clase que representa las propiedades de los certificados que necesitamos
        //Se ponen esas propiedades para que al generar la salida se pongan esos textos
        public string NifCertificado { get; set; }
        public string TitularCertificado { get; set; }
        private DateTime _fechaEmision;
        public DateTime FechaEmision
        {
            get => _fechaEmision.Date;
            set => _fechaEmision = value.Date;
        }

        private DateTime _fechaValidez;
        public DateTime FechaValidez
        {
            get => _fechaValidez.Date;
            set => _fechaValidez = value.Date;
        }
        public string NifRepresentante { get; set; }
        public string NombreRepresentante { get; set; }
        public string DatosRepresentante { get; set; }
        public string SerieCertificado { get; set; }
        public string HuellaCertificado { get; set; }

        public InfoCertificado()
        {
            NifCertificado = string.Empty;
            TitularCertificado = string.Empty;
            FechaEmision = DateTime.MinValue;
            FechaValidez = DateTime.MinValue;
            NifRepresentante = string.Empty;
            NombreRepresentante = string.Empty;
            DatosRepresentante = string.Empty;
            SerieCertificado = string.Empty;
            HuellaCertificado = string.Empty;
        }
    }
}
