﻿#pragma checksum "..\..\..\..\View\MyUsers\UserFournisseurs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F4CE62A6DC8F3E27F7B072A7D26A621FF49E3C03BA2BF4B867C0709C221EA13C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionMVVM.View.MyUsers;
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


namespace GestionMVVM.View.MyUsers {
    
    
    /// <summary>
    /// UserFournisseurs
    /// </summary>
    public partial class UserFournisseurs : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgFournisseurs;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CoolButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox MyListBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid InputBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputTextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button YesButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoButton;
        
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
            System.Uri resourceLocater = new System.Uri("/GestionMVVM;component/view/myusers/userfournisseurs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
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
            
            #line 23 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Lister_Click_All);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 24 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Lister_Click_Social);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 25 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Lister_Click_Localite);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 26 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Lister_Click_Pays);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 27 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Ajouter_un_Fournisseur);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 28 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Supprimer_un_Fournisseur);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgFournisseurs = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.CoolButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            this.CoolButton.Click += new System.Windows.RoutedEventHandler(this.CoolButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MyListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.InputBox = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.InputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.YesButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            this.YesButton.Click += new System.Windows.RoutedEventHandler(this.YesButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.NoButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\View\MyUsers\UserFournisseurs.xaml"
            this.NoButton.Click += new System.Windows.RoutedEventHandler(this.NoButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

