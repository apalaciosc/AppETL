﻿#pragma checksum "..\..\..\wProcesoPrincipal.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6CA67F6A79C31652330DFCD68678E25C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AplicacionETL {
    
    
    /// <summary>
    /// wProcesoPrincipal
    /// </summary>
    public partial class wProcesoPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEjecutar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProcesoTemporal;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgTemporal;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgProceso;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPc;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtFechaInicio;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\wProcesoPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtFechaFin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AplicacionETL;component/wprocesoprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\wProcesoPrincipal.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\wProcesoPrincipal.xaml"
            ((AplicacionETL.wProcesoPrincipal)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown_1);
            
            #line default
            #line hidden
            
            #line 4 "..\..\..\wProcesoPrincipal.xaml"
            ((AplicacionETL.wProcesoPrincipal)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnEjecutar = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\wProcesoPrincipal.xaml"
            this.btnEjecutar.Click += new System.Windows.RoutedEventHandler(this.btnEjecutar_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtProcesoTemporal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.imgTemporal = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.imgProceso = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.txtUser = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtPc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.dtFechaInicio = ((System.Windows.Controls.DatePicker)(target));
            
            #line 23 "..\..\..\wProcesoPrincipal.xaml"
            this.dtFechaInicio.Loaded += new System.Windows.RoutedEventHandler(this.dtFechaInicio_Loaded_1);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\wProcesoPrincipal.xaml"
            this.dtFechaInicio.KeyDown += new System.Windows.Input.KeyEventHandler(this.dtFechaInicio_KeyDown_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dtFechaFin = ((System.Windows.Controls.DatePicker)(target));
            
            #line 24 "..\..\..\wProcesoPrincipal.xaml"
            this.dtFechaFin.Loaded += new System.Windows.RoutedEventHandler(this.dtFechaFin_Loaded_1);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\wProcesoPrincipal.xaml"
            this.dtFechaFin.KeyDown += new System.Windows.Input.KeyEventHandler(this.dtFechaFin_KeyDown_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
