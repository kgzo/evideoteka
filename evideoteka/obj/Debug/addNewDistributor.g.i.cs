﻿#pragma checksum "..\..\addNewDistributor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0DBC49CAAE80C78EBDF35798B9EB79F0"
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
using System.Windows.Forms.Integration;
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


namespace evideoteka {
    
    
    /// <summary>
    /// addNewDistributor
    /// </summary>
    public partial class addNewDistributor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxName;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxAddress;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxPhone;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxFax;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxEmail;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxOib;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddDistributor;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\addNewDistributor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseDistributor;
        
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
            System.Uri resourceLocater = new System.Uri("/evideoteka;component/addnewdistributor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addNewDistributor.xaml"
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
            this.txtBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtBoxAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtBoxPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBoxFax = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtBoxEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtBoxOib = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAddDistributor = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\addNewDistributor.xaml"
            this.btnAddDistributor.Click += new System.Windows.RoutedEventHandler(this.btnAddDistributor_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCloseDistributor = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

