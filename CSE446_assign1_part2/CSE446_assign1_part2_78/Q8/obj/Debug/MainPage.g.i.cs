﻿#pragma checksum "C:\Users\wxx\Desktop\STUDY\CSE446\CSE446_assign1_part2\CSE446_assign1_part2_78\Q8\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BAC2031F64EE42B36707EFFAD77BC923"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Q8 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard headStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox Lowtxt;
        
        internal System.Windows.Controls.TextBox Uptxt;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.TextBox guesstxt;
        
        internal System.Windows.Controls.Button guessBtn;
        
        internal System.Windows.Controls.TextBlock atmptTxt;
        
        internal System.Windows.Controls.TextBlock numtxt;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Shapes.Ellipse ellipse;
        
        internal System.Windows.Media.TranslateTransform headMove;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Q8;component/MainPage.xaml", System.UriKind.Relative));
            this.headStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("headStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Lowtxt = ((System.Windows.Controls.TextBox)(this.FindName("Lowtxt")));
            this.Uptxt = ((System.Windows.Controls.TextBox)(this.FindName("Uptxt")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.guesstxt = ((System.Windows.Controls.TextBox)(this.FindName("guesstxt")));
            this.guessBtn = ((System.Windows.Controls.Button)(this.FindName("guessBtn")));
            this.atmptTxt = ((System.Windows.Controls.TextBlock)(this.FindName("atmptTxt")));
            this.numtxt = ((System.Windows.Controls.TextBlock)(this.FindName("numtxt")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.ellipse = ((System.Windows.Shapes.Ellipse)(this.FindName("ellipse")));
            this.headMove = ((System.Windows.Media.TranslateTransform)(this.FindName("headMove")));
        }
    }
}

