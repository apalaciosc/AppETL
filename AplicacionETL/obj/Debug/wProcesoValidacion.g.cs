﻿#pragma checksum "..\..\wProcesoValidacion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2654BA3BD34C1AF10728D7D0E0E076D7D15C8978"
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
    /// wProcesoValidacion
    /// </summary>
    public partial class wProcesoValidacion : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\wProcesoValidacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRutaDescarga;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\wProcesoValidacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCarpeta;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\wProcesoValidacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnValidar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\wProcesoValidacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnContinuar;
        
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
            System.Uri resourceLocater = new System.Uri("/AplicacionETL;component/wprocesovalidacion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\wProcesoValidacion.xaml"
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
            
            #line 4 "..\..\wProcesoValidacion.xaml"
            ((AplicacionETL.wProcesoValidacion)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded_1);
            
            #line default
            #line hidden
            
            #line 4 "..\..\wProcesoValidacion.xaml"
            ((AplicacionETL.wProcesoValidacion)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtRutaDescarga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtCarpeta = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnValidar = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\wProcesoValidacion.xaml"
            this.btnValidar.Click += new System.Windows.RoutedEventHandler(this.btnValidar_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnContinuar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\wProcesoValidacion.xaml"
            this.btnContinuar.Click += new System.Windows.RoutedEventHandler(this.btnContinuar_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

