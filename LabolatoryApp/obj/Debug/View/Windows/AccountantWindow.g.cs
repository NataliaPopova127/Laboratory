#pragma checksum "..\..\..\..\View\Windows\AccountantWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F26C1472FEB4EDCAA9E2F5AF2C3873470334F96FE23742116015563E64298068"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LabolatoryApp.View.Windows;
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


namespace LabolatoryApp.View.Windows {
    
    
    /// <summary>
    /// AccountantWindow
    /// </summary>
    public partial class AccountantWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\View\Windows\AccountantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Windows\AccountantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbRole;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\Windows\AccountantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignOut;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\View\Windows\AccountantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenReportsList;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Windows\AccountantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMakeReport;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Windows\AccountantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame mainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/LabolatoryApp;component/view/windows/accountantwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\AccountantWindow.xaml"
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
            this.tbName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tbRole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnSignOut = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\View\Windows\AccountantWindow.xaml"
            this.btnSignOut.Click += new System.Windows.RoutedEventHandler(this.btnSignOut_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnOpenReportsList = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\View\Windows\AccountantWindow.xaml"
            this.btnOpenReportsList.Click += new System.Windows.RoutedEventHandler(this.btnOpenReportsList_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnMakeReport = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\View\Windows\AccountantWindow.xaml"
            this.btnMakeReport.Click += new System.Windows.RoutedEventHandler(this.btnMakeReport_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

