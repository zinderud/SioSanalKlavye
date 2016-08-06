#region ONUR KARADENİZ
// murat onur  ArayuzCalismasi
// SanalKlavye   LogicalKeyPressedEventHandler.cs
// 2013031316:28
// 2013  03
// 13 13
#endregion

using System;
using System.ComponentModel;
using System.Windows;

namespace SanalKlavye.VirtualKeyboard
{
    public class OnScreenKeyEventArgs : RoutedEventArgs
    {
        public VKeyboard VKeyboard { get; private set; }

        public OnScreenKeyEventArgs(RoutedEvent routedEvent, VKeyboard onScreenKey)
            : base(routedEvent)
        {
            VKeyboard = onScreenKey;
        }
    }
    public class LogicalKeyEventArgs : EventArgs
    {
        public ILogicalKey Key { get; private set; }

        public LogicalKeyEventArgs(ILogicalKey key)
        {
            Key = key;
        }
    }

    public delegate void LogicalKeyPressedEventHandler(object sender, LogicalKeyEventArgs e);

    public abstract class LogicalKeyBase : ILogicalKey
    {
        public event LogicalKeyPressedEventHandler LogicalKeyPressed;
        public event PropertyChangedEventHandler PropertyChanged;

        private string _displayName;

        public virtual string DisplayName
        {
            get { return _displayName; }
            set
            {
                if (value != _displayName)
                {
                    _displayName = value;
                    OnPropertyChanged("DisplayName");
                }
            }
        }

        public virtual void Press()
        {
            OnKeyPressed();
        }

        protected void OnKeyPressed()
        {
            if (LogicalKeyPressed != null) LogicalKeyPressed(this, new LogicalKeyEventArgs(this));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                var args = new PropertyChangedEventArgs(propertyName);
                handler(this, args);
            }
        }
    }
}