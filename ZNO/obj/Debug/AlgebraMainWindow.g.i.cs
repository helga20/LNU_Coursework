﻿#pragma checksum "..\..\AlgebraMainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A39E8DA2BAB87D15F36A6A5E9BEB3C8B9C606EC1B1398642BBEA98D43A46A754"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using ZNO;


namespace ZNO {
    
    
    /// <summary>
    /// AlgebraMainWindow
    /// </summary>
    public partial class AlgebraMainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\AlgebraMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button plural_button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AlgebraMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nsd_button;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AlgebraMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fractions_button;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AlgebraMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit_menu;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\AlgebraMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\AlgebraMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next_page;
        
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
            System.Uri resourceLocater = new System.Uri("/ZNO;component/algebramainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AlgebraMainWindow.xaml"
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
            this.plural_button = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.nsd_button = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.fractions_button = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.exit_menu = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\AlgebraMainWindow.xaml"
            this.exit_menu.Click += new System.Windows.RoutedEventHandler(this.Exit_Menu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\AlgebraMainWindow.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.Back_Menu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.next_page = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\AlgebraMainWindow.xaml"
            this.next_page.Click += new System.Windows.RoutedEventHandler(this.Back_Menu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

