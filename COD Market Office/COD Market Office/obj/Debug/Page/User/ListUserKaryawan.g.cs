#pragma checksum "..\..\..\..\Page\User\ListUserKaryawan.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "072E7EC10885A7B1F1BF6094E8E077CFE3D793319B652D9EA083F4825BAC1589"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using COD_Market_Office.Page.User;
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


namespace COD_Market_Office.Page.User {
    
    
    /// <summary>
    /// ListUserKaryawan
    /// </summary>
    public partial class ListUserKaryawan : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbOutlet;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFilter;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tblUser;
        
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
            System.Uri resourceLocater = new System.Uri("/COD Market Office;component/page/user/listuserkaryawan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
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
            
            #line 24 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnBackClicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 27 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSearchClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbOutlet = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
            this.cbOutlet.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnOutletSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
            this.cbFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnFilterChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tblUser = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 48 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddClicked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 49 "..\..\..\..\Page\User\ListUserKaryawan.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnEditClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

