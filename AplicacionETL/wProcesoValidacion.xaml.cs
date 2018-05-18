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
using System.Windows.Shapes;
using System.IO;
using Emailing.Generales;
namespace AplicacionETL
{
    /// <summary>
    /// Lógica de interacción para wProcesoValidacion.xaml
    /// </summary>
    public partial class wProcesoValidacion : Window
    {
        bool Validacion;

        #region AAPC: Constructor
        public wProcesoValidacion()
        {
            InitializeComponent();
        }
        #endregion

        #region AAPC: Botones
        private void btnValidar_Click_1(object sender, RoutedEventArgs e)
        {
            bool val1 = false,
                 val2 = false;
            //Validando si existe la carpeta
            #region AAPC: Validar Carpeta
            if (Directory.Exists(txtCarpeta.Text))
            {
                val1 = true;
                txtCarpeta.Background = Brushes.LightGreen;
            }
            else
            {
                txtCarpeta.Background = Brushes.LightCoral;

                if (MessageBox.Show("La carpeta no existe, desea crearla", "ETL", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Directory.CreateDirectory(@"C:\Archivos FTP");
                    RoutedEventArgs evento = new RoutedEventArgs();
                    btnValidar_Click_1(sender, evento);
                }
                else
                {
                    return;
                }

            }
            #endregion
            //Validar la descarga
            #region AAPC: Validar DTS Descarga FTP

            if (File.Exists(txtRutaDescarga.Text))
            {
                val2 = true;
                txtRutaDescarga.Background = Brushes.LightGreen;
            }
            else
            {
                txtRutaDescarga.Background = Brushes.LightCoral;
            }

            #endregion
            //Validación Final
            #region AAPC: Validaciones
            if (val2 == true)
            {
                Validacion = true;
                btnContinuar.IsEnabled = true;
            }
            else
            {
                Validacion = true;
            }
            #endregion
        }

        private void btnContinuar_Click_1(object sender, RoutedEventArgs e)
        {
            //Validando que todo este OK
            wProcesoPrincipal oWProceso = new wProcesoPrincipal();
            oWProceso.Show();
            this.Close();
        }
        #endregion

        #region AAPC: Eventos
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            //Mostrando los Textos
            FTextos ofTextos = new FTextos();
            txtRutaDescarga.Text = ofTextos.FGetValorApp("CarpetaRaiz") + ofTextos.FGetValorApp("Temporal_Detectta");
        }

        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            RoutedEventArgs evento = new RoutedEventArgs();
            if (e.Key == Key.Escape)
            {
                this.Close();
            }

            if (btnContinuar.IsEnabled == true)
            {
                if (e.Key == Key.Enter)
                {
                    btnContinuar_Click_1(sender, evento);
                }
            }

            if (e.Key == Key.Enter)
            {
                btnValidar_Click_1(sender, evento);
                return;
            }
        }
        #endregion

    }
}
