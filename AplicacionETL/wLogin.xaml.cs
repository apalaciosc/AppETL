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
using Emailing.Generales;
namespace AplicacionETL
{
    /// <summary>
    /// Lógica de interacción para wLogin.xaml
    /// </summary>
    public partial class wLogin : Window
    {
        #region AAPC: Constructor
        public wLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region AAPC: Botón ingresar
        private void bntIngresar_Click_1(object sender, RoutedEventArgs e)
        {
            FActiveDirectory oAD = new FActiveDirectory();
            string Usuario;
            string Contraseña;
            bool Proceso;

            Usuario = txtUsuario.Text;
            Contraseña = txtPass.Password;

            //Validando que el campo contraseña no sea vacio
            if (String.IsNullOrWhiteSpace(Contraseña))
            {
                MessageBox.Show("Debe de ingresar la contraseña", "ETL", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            //Proceso de validacion por el AD
            Proceso = oAD.LoginAD(Usuario, Contraseña);

            //Verificando que se haya realizado el proceso de validación 
            if (Proceso == true)
            {
                wProcesoValidacion oValidacion = new wProcesoValidacion();
                oValidacion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales Erroneas", "ELT", MessageBoxButton.OK, MessageBoxImage.Stop);
                txtPass.Password = "";
                return;
            }
        }
        #endregion

        #region AAPC: Botón salir
        private void btnSalir_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region AAPC: Eventos
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            FTextos ofTextos = new FTextos();
            string Usuario = ofTextos.fGetUsuario();
            txtUsuario.Text = Usuario;
            txtPass.Focus();
        }

        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            RoutedEventArgs ex = new RoutedEventArgs();

            if (e.Key == Key.Escape)
            {
                this.Close();
            }

            if (e.Key == Key.Enter)
            {
                bntIngresar_Click_1(sender, ex);
            }
        }
        #endregion
    }
}
