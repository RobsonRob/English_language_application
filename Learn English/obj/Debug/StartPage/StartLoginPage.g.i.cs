﻿#pragma checksum "..\..\..\StartPage\StartLoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "281750E638F778A9CEA72700047D7114257F65A57F0AA60FAC98B17FA55EAF02"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Learn_English.StartPage;
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


namespace Learn_English.StartPage {
    
    
    /// <summary>
    /// StartLoginPage
    /// </summary>
    public partial class StartLoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\StartPage\StartLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMale;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\StartPage\StartLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFemale;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\StartPage\StartLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox boxName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\StartPage\StartLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock blockName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\StartPage\StartLoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK;
        
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
            System.Uri resourceLocater = new System.Uri("/Learn English;component/startpage/startloginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StartPage\StartLoginPage.xaml"
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
            this.btnMale = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\StartPage\StartLoginPage.xaml"
            this.btnMale.Click += new System.Windows.RoutedEventHandler(this.btnMale_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnFemale = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\StartPage\StartLoginPage.xaml"
            this.btnFemale.Click += new System.Windows.RoutedEventHandler(this.btnFemale_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.boxName = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\StartPage\StartLoginPage.xaml"
            this.boxName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.boxName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.blockName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.OK = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

