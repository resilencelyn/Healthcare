﻿#pragma checksum "D:\Project\C#\test\Healthcare\Healthcare\InfoDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B13F2CAB735EFA23F5D27A3EFB021ED1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Healthcare {
    
    
    public partial class InfoDetailPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock TBTitle;
        
        internal System.Windows.Controls.TextBlock TBTime;
        
        internal System.Windows.Documents.Run TBCount;
        
        internal System.Windows.Documents.Run TBRcount;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.RichTextBox RTBContent;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Healthcare;component/InfoDetailPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TBTitle = ((System.Windows.Controls.TextBlock)(this.FindName("TBTitle")));
            this.TBTime = ((System.Windows.Controls.TextBlock)(this.FindName("TBTime")));
            this.TBCount = ((System.Windows.Documents.Run)(this.FindName("TBCount")));
            this.TBRcount = ((System.Windows.Documents.Run)(this.FindName("TBRcount")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.RTBContent = ((System.Windows.Controls.RichTextBox)(this.FindName("RTBContent")));
        }
    }
}

