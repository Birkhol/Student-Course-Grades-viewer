﻿#pragma checksum "..\..\..\Editor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F6455372B86480B380BC5B54F5BE9CA76D27B013"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LINQassignment;
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


namespace LINQassignment {
    
    
    /// <summary>
    /// Editor
    /// </summary>
    public partial class Editor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sname;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sage;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CourseComboBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GradeComboBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addStudent;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delStudent;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Editor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateStudent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LINQassignment;component/editor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Editor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.sid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.sname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.sage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CourseComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.GradeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.addStudent = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Editor.xaml"
            this.addStudent.Click += new System.Windows.RoutedEventHandler(this.addStudent_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.delStudent = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Editor.xaml"
            this.delStudent.Click += new System.Windows.RoutedEventHandler(this.delStudent_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.updateStudent = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Editor.xaml"
            this.updateStudent.Click += new System.Windows.RoutedEventHandler(this.updateStudent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

