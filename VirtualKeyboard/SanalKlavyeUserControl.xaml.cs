using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SanalKlavye.VirtualKeyboard;

namespace SioSanalKlavye.VirtualKeyboard
{
    /// <summary>
    /// Interaction logic for SanalKlavyeUserControl.xaml
    /// </summary>
    public partial class SanalKlavyeUserControl : UserControl
    {
        public SanalKlavyeUserControl()
        {
            InitializeComponent();
            DataContext = new KeyboardViewModel();
            //var thumb = new Thumb
            //{
            //    Width = 0,
            //    Height = 0,
            //};
            //GridSifir.Children.Add(thumb);

            //MouseDown += (sender, e) =>
            //{
            //    thumb.RaiseEvent(e);
            //};

            //thumb.DragDelta += (sender, e) =>
            //{
            //    HorizontalOffset += e.HorizontalChange;
            //    VerticalOffset += e.VerticalChange;
            //};
        }
        
    }
}
