 using SanalKlavye.VirtualKeyboard;
 using UserControl = System.Windows.Controls.UserControl;

namespace SioSanalKlavye.VirtualKeyboard
{
    /// <summary>
    /// Interaction logic for KeyboardView.xaml
    /// </summary>
    public partial class KeyboardView2 : UserControl
    {
        public KeyboardView2()
        {
            InitializeComponent();
            DataContext = new KeyboardViewModel();
        }

       
    }
}
