using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO; //Manejo de Archivos
using ETL.Librerias; //Librerias para ejecutar el proceso
using Emailing.Generales; //Libreria de utiliarios
using System.Diagnostics; //StopWatch
using System.ComponentModel; //BackGroundWorker
namespace AplicacionETL
{

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class wProcesoPrincipal : Window
    {
        #region AAPC: Variables
        public string CorreoEnviar { get; set; }
        public string CorreoEnviarCc { get; set; }
        #endregion

        #region AAPC: Constructor
        public wProcesoPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region AAPC: Botón ejecutar
        //Boton que se encarga de ejectuar el Proceso de carga a la temporal
        private void btnEjecutar_Click_1(object sender, RoutedEventArgs e)
        {
            Stopwatch contarTiempo = new Stopwatch();
            try
            {
                FTextos oFTextos = new FTextos();
                Paquetes_DTS oPaqDts = new Paquetes_DTS(CorreoEnviar, CorreoEnviarCc);
                //DateTime dFechaIni;
                //DateTime dFechaFin;
                DateTime dFechaActual = DateTime.Now;
                string UbicacionPaquete;
                bool proceso;

                if (MessageBox.Show("Desea realizar la ejecución del ETL Temporal", "ETL", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    //Proceso
                    lblMensaje.Visibility = Visibility.Visible;
                    imgTemporal.Visibility = Visibility.Hidden;
                    contarTiempo.Start();
                    UbicacionPaquete = oFTextos.FGetValorApp("CarpetaRaiz") + oFTextos.FGetValorApp("Temporal_Detectta");
                    proceso = oPaqDts.ProcesoEtl(UbicacionPaquete);
                    string MensajeError = oPaqDts.Error;
                    contarTiempo.Stop();
                    imgTemporal.Visibility = Visibility.Visible;
                    if (proceso == true)
                    {
                        string Mensaje = String.Format("Proceso Temporal ejecutado con éxito!", "ETL", MessageBoxButton.OK, MessageBoxImage.Information);
                        establecer_imagen(imgTemporal, "Imagenes/Correcto.png");
                        btnEjecutar.IsEnabled = false;
                        MessageBox.Show(Mensaje, "ETL", MessageBoxButton.OK, MessageBoxImage.Information);
                        lblMensaje.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        establecer_imagen(imgTemporal, "Imagenes/incorrecto.png");
                        MessageBox.Show("Error al realizar el proceso!", "ETL", MessageBoxButton.OK, MessageBoxImage.Information);
                        MessageBox.Show(MensajeError, "ETL", MessageBoxButton.OK, MessageBoxImage.Warning);
                        lblMensaje.Visibility = Visibility.Hidden;
                    }  
                }
                else
                {
                    MessageBox.Show("Operación Cancelada por el Usuario!", "ETL", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                CorreoEnvio oCorreo = new CorreoEnvio();
                oCorreo.EnvioCorreo(CorreoEnviar, CorreoEnviarCc, ex.ToString(), "Error Proceso ETL", 1);
            }
        }
        #endregion

        #region AAPC: Establecer imágen
        //Metodo que se encarga de establecer la imagen para mostrarla
        public void establecer_imagen(Image imagen, string ruta)
        {
            BitmapImage bitima = new BitmapImage();
            bitima.BeginInit();
            bitima.UriSource = new Uri(ruta, UriKind.Relative);
            bitima.EndInit();
            imagen.Source = bitima;
        }
        #endregion

        #region AAPC: Evento Load
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            FTextos oFTexto = new FTextos();
            txtUser.Text = oFTexto.fGetUsuario();
            txtPc.Text = oFTexto.fGetNombPC();
            CorreoEnviar = oFTexto.FGetValorApp("CorreosEnviarError");
            CorreoEnviarCc = oFTexto.FGetValorApp("CorreosEnviarErrorCc");
        }
        #endregion

        #region AAPC: Placeholder para las fechas (SI ES QUE HUBIERAN)
        //private void dtFechaInicio_Loaded_1(object sender, RoutedEventArgs e)
        //{
        //    DatePicker datePicker = sender as DatePicker;
        //    if (datePicker != null)
        //    {
        //        System.Windows.Controls.Primitives.DatePickerTextBox datePickerTextBox = FindVisualChild<System.Windows.Controls.Primitives.DatePickerTextBox>(datePicker);
        //        if (datePickerTextBox != null)
        //        {

        //            ContentControl watermark = datePickerTextBox.Template.FindName("PART_Watermark", datePickerTextBox) as ContentControl;
        //            if (watermark != null)
        //            {
        //                watermark.Content = "Seleccione fecha inicio.";
        //            }
        //        }
        //    }
        //}

        //private void dtFechaFin_Loaded_1(object sender, RoutedEventArgs e)
        //{
        //    DatePicker datePicker = sender as DatePicker;
        //    if (datePicker != null)
        //    {
        //        System.Windows.Controls.Primitives.DatePickerTextBox datePickerTextBox = FindVisualChild<System.Windows.Controls.Primitives.DatePickerTextBox>(datePicker);
        //        if (datePickerTextBox != null)
        //        {

        //            ContentControl watermark = datePickerTextBox.Template.FindName("PART_Watermark", datePickerTextBox) as ContentControl;
        //            if (watermark != null)
        //            {
        //                watermark.Content = "Seleccione fecha fin.";
        //            }
        //        }
        //    }
        //}

        private T FindVisualChild<T>(DependencyObject depencencyObject) where T : DependencyObject
        {
            if (depencencyObject != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depencencyObject); ++i)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depencencyObject, i);
                    T result = (child as T) ?? FindVisualChild<T>(child);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }
        #endregion

        #region AAPC: Evento KeyDown
        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            //
            RoutedEventArgs evento = new RoutedEventArgs();
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
            if (e.Key == Key.Enter)
            {
                btnEjecutar_Click_1(sender, evento);
                return;
            }
        }
        //private void dtFechaFin_KeyDown_1(object sender, KeyEventArgs e)
        //{
        //    e.Handled = true;
        //}
        //private void dtFechaInicio_KeyDown_2(object sender, KeyEventArgs e)
        //{
        //    e.Handled = true;
        //}
        #endregion
    }
}

