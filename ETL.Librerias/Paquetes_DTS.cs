using System;
using Microsoft.SqlServer.Dts.Runtime;
using Emailing.Generales;
namespace ETL.Librerias
{
    public class Paquetes_DTS
    {
        public string Error { get; set; }
        public string CorreoEnviar { get; set; }
        public string CorreoEnviarCc { get; set; }

        public Paquetes_DTS(string Correo, string CorreoCc)
        {
            CorreoEnviar = Correo;
            CorreoEnviarCc = CorreoCc;
        }
      
        /// <summary>
      /// Metodo que se encarga de realizar la Ejecución del Paquete
      /// </summary>
      /// <param name="Ruta"></param>
      /// <returns></returns>
        public bool ProcesoEtl(string Ruta)
        {
            string RutaDts;
            Package Paquete;
            Microsoft.SqlServer.Dts.Runtime.Application Aplicacion;
            DTSExecResult Ejecucion;
            try
            {
                RutaDts = Ruta;
                Aplicacion = new Microsoft.SqlServer.Dts.Runtime.Application();
                Paquete = Aplicacion.LoadPackage(RutaDts, null);
                //Parámetros del ETL (Si tuviera)
                //Parameters par = Paquete.Parameters;
                //par["dFecInicio"].Value = dFechaIni;
                //par["dFecFin"].Value = dFechaFin;

                Ejecucion = Paquete.Execute();

                //Validando si el proceso es correcto
                if (Ejecucion == DTSExecResult.Success)
                {
                    return true;
                }
                else
                {
                    foreach (DtsError error in Paquete.Errors)
                    {
                        Error = String.Concat(Error, " ", error.Description.ToString());
                    }
                    CorreoEnvio oCorreo = new CorreoEnvio();
                    oCorreo.EnvioCorreo(CorreoEnviar, CorreoEnviarCc, Error, "Error Proceso ETL", 1);
                    return false;
                }
            }
            catch (Exception ex)
            {
                FTextos ofTextos= new FTextos();
                string Usuarios=ofTextos.fGetUsuario();
                string Fecha = DateTime.Now.ToString();
                string Asunto;
                Asunto = "ETL - Error [Helpdesk] [" + Usuarios+"] ["+Fecha+"]";
                CorreoEnvio oCorreo = new CorreoEnvio();
                oCorreo.EnvioCorreo(CorreoEnviar, CorreoEnviarCc, ex.ToString(), "Error Proceso ETL", 1);
                throw;
            }
        }

    }
}
