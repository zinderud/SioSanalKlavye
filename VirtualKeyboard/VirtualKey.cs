#region ONUR KARADENİZ
// murat onur  ArayuzCalismasi
// SanalKlavye   VirtualKey.cs
// 2013031316:44
// 2013  03
// 13 13
#endregion

using System.Collections.Generic;
using SioSanalKlavye.GirisSimulator;
  
namespace SanalKlavye.VirtualKeyboard
{
    public class VirtualKey : LogicalKeyBase
    {
        private VirtualKeyCode _keyCode;
      

        public static List<VirtualKey> SKey = new List<VirtualKey>();
        public virtual VirtualKeyCode KeyCode
        {
            get { return _keyCode; }
            set
            {
                if (value != _keyCode)
                {
                    _keyCode = value;
                    OnPropertyChanged("KeyCode");
                }
            }
        }
        public static void ekle(VirtualKey key)
        {
            SKey.Add(key);
        }

        public VirtualKey(VirtualKeyCode keyCode, string displayName)
        {
            DisplayName = displayName;
            KeyCode = keyCode;
        }

        public VirtualKey(VirtualKeyCode keyCode)
        {
            KeyCode = keyCode;
        }

        public VirtualKey()
        {
        }

        public override void Press()
        {
            InputSimulator.SimulateKeyPress(_keyCode);
            base.Press();
        }
    }
}