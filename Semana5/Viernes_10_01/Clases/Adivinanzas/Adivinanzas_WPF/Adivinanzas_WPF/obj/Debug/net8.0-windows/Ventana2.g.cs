﻿#pragma checksum "..\..\..\Ventana2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8B8D0B032E371414B094ADAB7B0083D482082AF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Adivinanzas_WPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Adivinanzas_WPF {
    
    
    /// <summary>
    /// Ventana2
    /// </summary>
    public partial class Ventana2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelPais;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCapital;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPais;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCapital;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonIngresar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonVolver;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonJugar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Ventana2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxRegiones;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Adivinanzas_WPF;component/ventana2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventana2.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelPais = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelCapital = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textBoxPais = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textBoxCapital = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ButtonIngresar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Ventana2.xaml"
            this.ButtonIngresar.Click += new System.Windows.RoutedEventHandler(this.ButtonIngresar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonVolver = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Ventana2.xaml"
            this.buttonVolver.Click += new System.Windows.RoutedEventHandler(this.buttonVolver_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonJugar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Ventana2.xaml"
            this.buttonJugar.Click += new System.Windows.RoutedEventHandler(this.buttonJugar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.listBoxRegiones = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

