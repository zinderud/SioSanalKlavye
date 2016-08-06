using System.Windows;
using System.Windows.Controls.Primitives;

using SanalKlavye.VirtualKeyboard;
namespace SioSanalKlavye.VirtualKeyboard
{
    /// <summary>
    /// Interaction logic for SanalKlavyeDuz.xaml
    /// </summary>
    public partial class SanalKlavyeDuz  
    {
        public SanalKlavyeDuz()
        {
            InitializeComponent();
            DataContext = new KeyboardViewModel();
            var thumb = new Thumb
            {
                Width = 0,
                Height = 0,
            };
            GridSifir.Children.Add(thumb);

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
