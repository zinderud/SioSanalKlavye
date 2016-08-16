#region ONUR KARADENİZ
// murat onur  ArayuzCalismasi
// SanalKlavye   ILogicalKey.cs
// 2013031316:27
// 2013  03

//
#endregion

using System.ComponentModel;

namespace SanalKlavye.VirtualKeyboard
{
    public interface ILogicalKey : INotifyPropertyChanged
    {
        string DisplayName { get; }
        void Press();
        event LogicalKeyPressedEventHandler LogicalKeyPressed;
    }
}
