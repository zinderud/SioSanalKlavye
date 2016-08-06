using SioSanalKlavye;
using System;
using System.Windows.Input;


namespace SanalKlavye.VirtualKeyboard
{
 
    public class KeyboardViewModel
    {
        public VKeyboard Model { get; set; }
        public DelegateCommand<VirtualKey> PressKeyCommand { get; set; }

        public KeyboardViewModel()
        {
            Model = new VKeyboard();
 
            PressKeyCommand = new DelegateCommand<VirtualKey>(OnKeyPress);
        }

        private void OnKeyPress(VirtualKey obj)
        {
            //InputSimulator.SimulateTextEntry(obj.KeyCode.ToString());
            obj.Press();
        }

        
    }
}
