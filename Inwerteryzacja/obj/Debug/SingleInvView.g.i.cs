﻿#pragma checksum "..\..\SingleInvView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8A04E1D7F3BE8FD19BCC9D3570EC7C2E432C107C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
    /// SingleInvView
    /// </summary>
    public partial class SingleInvView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\SingleInvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CompNameTextField;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\SingleInvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userNameText;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\SingleInvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ComputerDataList;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\SingleInvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MessageLabel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SingleInvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button downloadButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\SingleInvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\SingleInvView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back_button;
        
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
            System.Uri resourceLocater = new System.Uri("/Inwerteryzacja;component/singleinvview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SingleInvView.xaml"
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
            this.CompNameTextField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.userNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ComputerDataList = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.MessageLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.downloadButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\SingleInvView.xaml"
            this.downloadButton.Click += new System.Windows.RoutedEventHandler(this.OnClickDownload);
            
            #line default
            #line hidden
            return;
            case 6:
            this.passText = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.back_button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\SingleInvView.xaml"
            this.back_button.Click += new System.Windows.RoutedEventHandler(this.OnClickBackButton);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 30 "..\..\SingleInvView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClickReload);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

