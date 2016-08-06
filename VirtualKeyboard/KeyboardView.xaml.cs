 
using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using SanalKlavye.VirtualKeyboard;
using UserControl = System.Windows.Controls.UserControl;

namespace SioSanalKlavye.VirtualKeyboard
{
    /// <summary>
    /// Interaction logic for KeyboardView.xaml
    /// </summary>
    public partial class KeyboardView  
    {
        public KeyboardView()
        {
            InitializeComponent();
            DataContext = new KeyboardViewModel();
            var thumb = new Thumb
            {
                Width = 0,
                Height = 0,
            };
            Gridust.Children.Add(thumb);

            MouseDown += (sender, e) =>
            {
                thumb.RaiseEvent(e);
            };

            thumb.DragDelta += (sender, e) =>
            {
                HorizontalOffset += e.HorizontalChange;
                VerticalOffset += e.VerticalChange;
            };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sanalkalavye.IsOpen = false;
        }

  

    }


}
