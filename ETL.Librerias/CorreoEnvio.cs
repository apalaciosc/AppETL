using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Emailing.Generales;
using System.Net.Mail;
namespace ETL.Librerias
{
    public class CorreoEnvio
    {
        /// <summary>
        /// Proceso que se encarga de realizar el envio de correo Electronico
        /// </summary>
        /// <param name="Correo"></param>
        /// <param name="CorreoCc"></param>
        /// <param name="Mensaje"></param>
        /// <param name="Asunto"></param>
        /// <param name="Prioridad"></param>
        /// <returns></returns>
        public void EnvioCorreo(string Correo, string CorreoCc, string Mensaje, string Asunto, int Prioridad)
        {
            FTextos oFTextos= new FTextos();
            string EmailEnviadode = ""; //De
            string EmailEnviadodeNombre = ""; //Nombre
            string Servidor = "";  //Servidor de correo
            string Contraseña = ""; //Clave

            string Usuario=oFTextos.fGetUsuario();
            string PC=oFTextos.fGetNombPC();
            string IP=oFTextos.FGetIP();
            string[] CorreoEnviar;
            string[] CorreoEnviarCc;

            //Cuerpo HTML
            string HTML = "<html> <head> <body>  <table> <tr> <td> <p style='font-family: Arial, Helvetica, sans-serif'>Usuario: «Usuario» </td> </tr> <tr> <td> <p style='font-family: Arial, Helvetica, sans-serif'>PC: «Pc» </td> </tr> <tr> <td> <p style='font-family: Arial, Helvetica, sans-serif'>IP: «IP» </td> </tr> <tr> <td> <p style='font-family: Arial, Helvetica, sans-serif'>Se ha producido un error en el aplicativo ETL, el cual se detalla a continuación </p> </td> </tr> <tr> <td> <p style='font-family: Arial, Helvetica, sans-serif'>«Error»</p> </td> </tr> </table> </body> </html>";
            //Reemplazando los Caracteres en el HTML a Enviar en el Correo
            HTML = HTML.Replace("«Usuario»",Usuario.ToUpper());
            HTML = HTML.Replace("«Pc»", PC);
            HTML = HTML.Replace("«IP»",IP);
            HTML = HTML.Replace("«Error»",Mensaje);
            //Realizando el Proceso
            try
            {
                MailMessage correo = new MailMessage();
                MailAddress enviadode = new MailAddress(EmailEnviadode,EmailEnviadodeNombre);
                correo.From = enviadode;
                correo.Subject = Asunto;
                correo.Body = HTML;
                CorreoEnviar = Regex.Split(Correo,";");
                CorreoEnviarCc = Regex.Split(CorreoCc,";");
                //Validando que la lista de correos a enviar sea diferente a nulo
                #region  Destinatarios
                if (CorreoEnviar != null)
                {
                    for (int i = 0; i < CorreoEnviar.Length; i++)
                    {
                        correo.To.Add(CorreoEnviar[i]);
                    }
                }

                if (CorreoEnviarCc!=null)
                {
                    for (int i = 0; i < CorreoEnviarCc.Length; i++)
                    {
                        correo.CC.Add(CorreoEnviarCc[i]);
                    }
                }
                #endregion 

                #region Prioridad
                switch (Prioridad)
                {
                    case 1:
                        correo.Priority = MailPriority.High;
                        break;
                    case 2:
                        correo.Priority = MailPriority.Normal;
                        break;
                    case 3:
                        correo.Priority = MailPriority.Low;
                        break;
                }
                #endregion
                correo.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = Servidor;
                System.Net.NetworkCredential credenciales = new System.Net.NetworkCredential(EmailEnviadode, Contraseña);
                smtp.Credentials = credenciales;
                smtp.Send(correo);
            }
            catch (Exception ex)
            {

            }

        }
    }
}
