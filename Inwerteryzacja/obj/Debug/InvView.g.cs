﻿#pragma checksum "..\..\InvView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F4BF6775A59875AC12748288A40EC5DF8392EEB414DF99C235626FBE111C5F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Inwerteryzacja;
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


namespace Inwerteryzacja {
    
    
    /// <summary>
    /// InvView
    /// </summary>
    public partial class InvView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CompNameTextField;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNameText;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ComputerDataList;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MessageLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button downloadButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_button;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditAddButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\InvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label messageLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Inwerteryzacja;component/invview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InvView.xaml"
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
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.CompNameTextField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.userNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ComputerDataList = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 6:
            this.MessageLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.downloadButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\InvView.xaml"
            this.downloadButton.Click += new System.Windows.RoutedEventHandler(this.OnClickDownload);
            
            #line default
            #line hidden
            return;
            case 8:
            this.passText = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.back_button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\InvView.xaml"
            this.back_button.Click += new System.Windows.RoutedEventHandler(this.OnClickBackButton);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 30 "..\..\InvView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickReload);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EditAddButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\InvView.xaml"
            this.EditAddButton.Click += new System.Windows.RoutedEventHandler(this.EditAddButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.messageLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
