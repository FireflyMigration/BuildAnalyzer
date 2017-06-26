﻿using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
using NorthwindTest.Shared.Theme;
namespace NorthwindTest.Printing
{
    /// <summary>Print - Order(P#6)</summary>
    partial class Print_OrderC1 : NorthwindTest.Shared.Theme.Printing.ReportLayout 
    {
        Print_Order _controller;
        internal Print_OrderC1(Print_Order controller) : base(controller)
        {
            _controller = controller;
            InitializeComponent();
        }
    }
}
