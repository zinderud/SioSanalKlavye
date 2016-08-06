using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows;
 using SanalKlavye.VirtualKeyboard;
using SioSanalKlavye.GirisSimulator;

namespace SanalKlavye.VirtualKeyboard
{
    public class VKeyboard : DependencyObject
    {
        public VirtualKey KeyA { get; set; }
        public VirtualKey KeyB { get; set; }
        public VirtualKey KeyC { get; set; }
        public VirtualKey KeyCTr { get; set; }
        public VirtualKey KeyD { get; set; }
        public VirtualKey KeyE { get; set; }
        public VirtualKey KeyF { get; set; }
        public VirtualKey KeyG { get; set; }
        public VirtualKey KeyGTr { get; set; }
        public VirtualKey KeyH { get; set; }
        public VirtualKey KeyI { get; set; }
        public VirtualKey KeyITr { get; set; }
        public VirtualKey KeyJ { get; set; }
        public VirtualKey KeyK { get; set; }
        public VirtualKey KeyL { get; set; }
        public VirtualKey KeyM { get; set; }
        public VirtualKey KeyN { get; set; }
        public VirtualKey KeyO { get; set; }
        public VirtualKey KeyOTr { get; set; }
        public VirtualKey KeyP { get; set; }
        public VirtualKey KeyQ { get; set; }
        public VirtualKey KeyR { get; set; }
        public VirtualKey KeyS { get; set; }
        public VirtualKey KeySTr { get; set; }
        public VirtualKey KeyT { get; set; }
        public VirtualKey KeyU { get; set; }
        public VirtualKey KeyUTr { get; set; }
        public VirtualKey KeyV { get; set; }
        public VirtualKey KeyW { get; set; }
        public VirtualKey KeyX { get; set; }
        public VirtualKey KeyY { get; set; }
        public VirtualKey KeyZ { get; set; }
        public VirtualKey Key1 { get; set; }
        public VirtualKey Key2 { get; set; }
        public VirtualKey Key3 { get; set; }
        public VirtualKey Key4 { get; set; }
        public VirtualKey Key5 { get; set; }
        public VirtualKey Key6 { get; set; }
        public VirtualKey Key7 { get; set; }
        public VirtualKey Key8 { get; set; }
        public VirtualKey Key9 { get; set; }
        public VirtualKey Key0 { get; set; }
        public VirtualKey KeyDoubleQuote { get; set; }
        public VirtualKey KeyTab { get; set; }
        public VirtualKey KeyCaps { get; set; }
        public VirtualKey KeyShift { get; set; }
        public VirtualKey KeyStar { get; set; }
        public VirtualKey KeyDash { get; set; }
        public VirtualKey KeyBack { get; set; }
        public VirtualKey KeyEnter { get; set; }
        public VirtualKey KeyComma { get; set; }
        public VirtualKey KeyPoint { get; set; }
        public VirtualKey KeyAt { get; set; }
        public VirtualKey KeySpace { get; set; }
        public VirtualKey UpArrow { get; set; }
        public VirtualKey DownArrow { get; set; }

        public IList<VirtualKey> VirtualKeys { get; set; }

        public VKeyboard()
        {
            VirtualKeys = new List<VirtualKey>();

            KeyA = new VirtualKey(VirtualKeyCode.VK_A, "A");
            KeyB = new VirtualKey(VirtualKeyCode.VK_B, "B");
            KeyC = new VirtualKey(VirtualKeyCode.VK_C, "C");
            KeyCTr = new VirtualKey(VirtualKeyCode.Turkcece, "Ç");
            KeyD = new VirtualKey(VirtualKeyCode.VK_D, "D");
            KeyE = new VirtualKey(VirtualKeyCode.VK_E, "E");
            KeyF = new VirtualKey(VirtualKeyCode.VK_F, "F");
            KeyG = new VirtualKey(VirtualKeyCode.VK_G, "G");
            KeyGTr = new VirtualKey(VirtualKeyCode.Turkceyumusakg, "Ğ");
            KeyH = new VirtualKey(VirtualKeyCode.VK_H, "H");
            KeyI = new VirtualKey(VirtualKeyCode.VK_I, "I");
            KeyITr = new VirtualKey(VirtualKeyCode.Turkcei, "İ");
            KeyJ = new VirtualKey(VirtualKeyCode.VK_J, "J");
            KeyK = new VirtualKey(VirtualKeyCode.VK_K, "K");
            KeyL = new VirtualKey(VirtualKeyCode.VK_L, "L");
            KeyM = new VirtualKey(VirtualKeyCode.VK_M, "M");
            KeyN = new VirtualKey(VirtualKeyCode.VK_N, "N");
            KeyO = new VirtualKey(VirtualKeyCode.VK_O, "O");
            KeyOTr = new VirtualKey(VirtualKeyCode.TurkceO, "Ö");
            KeyP = new VirtualKey(VirtualKeyCode.VK_P, "P");
            KeyQ = new VirtualKey(VirtualKeyCode.VK_Q, "Q");
            KeyR = new VirtualKey(VirtualKeyCode.VK_R, "R");
            KeyS = new VirtualKey(VirtualKeyCode.VK_S, "S");
            KeySTr = new VirtualKey(VirtualKeyCode.TurkceS, "Ş");
            KeyT = new VirtualKey(VirtualKeyCode.VK_T, "T");
            KeyU = new VirtualKey(VirtualKeyCode.VK_U, "U");
            KeyUTr = new VirtualKey(VirtualKeyCode.TurkceU, "Ü");
            KeyV = new VirtualKey(VirtualKeyCode.VK_V, "V");
            KeyW = new VirtualKey(VirtualKeyCode.VK_W, "W");
            KeyX = new VirtualKey(VirtualKeyCode.VK_X, "X");
            KeyY = new VirtualKey(VirtualKeyCode.VK_Y, "Y");
            KeyZ = new VirtualKey(VirtualKeyCode.VK_Z, "Z");
            Key1 = new VirtualKey(VirtualKeyCode.VK_1, "1");
            Key2 = new VirtualKey(VirtualKeyCode.VK_2, "2");
            Key3 = new VirtualKey(VirtualKeyCode.VK_3, "3");
            Key4 = new VirtualKey(VirtualKeyCode.VK_4, "4");
            Key5 = new VirtualKey(VirtualKeyCode.VK_5, "5");
            Key6 = new VirtualKey(VirtualKeyCode.VK_6, "6");
            Key7 = new VirtualKey(VirtualKeyCode.VK_7, "7");
            Key8 = new VirtualKey(VirtualKeyCode.VK_8, "8");
            Key9 = new VirtualKey(VirtualKeyCode.VK_9, "9");
            Key0 = new VirtualKey(VirtualKeyCode.VK_0, "0");


            KeyDoubleQuote = new VirtualKey(VirtualKeyCode.OEM_3, "''");
            //VirtualKeys.Add(KeyDoubleQuote);
            KeyTab = new VirtualKey(VirtualKeyCode.TAB, "TAB");
            //VirtualKeys.Add(KeyTab);
            KeyCaps = new VirtualKey(VirtualKeyCode.CAPITAL, "CAPS");
            //VirtualKeys.Add(KeyCaps);
            KeyShift = new VirtualKey(VirtualKeyCode.SHIFT, "SHİFT");
            //VirtualKeys.Add(KeyShift);
            KeyStar = new VirtualKey(VirtualKeyCode.Turkceyildiz, "*"); //todo
            //VirtualKeys.Add(KeyStar);
            KeyDash = new VirtualKey(VirtualKeyCode.Turkceenter, "ENT"); //todo
            //VirtualKeys.Add(KeyDash);
            KeyBack = new VirtualKey(VirtualKeyCode.BACK, "GERİ");
            //VirtualKeys.Add(KeyBack);
            KeyEnter = new VirtualKey(VirtualKeyCode.Turkceenter, "ENTER");
            //VirtualKeys.Add(KeyEnter);
            KeyComma = new VirtualKey(VirtualKeyCode.OEM_COMMA, ",");
            //VirtualKeys.Add(KeyComma);
            KeyPoint = new VirtualKey(VirtualKeyCode.OEM_PERIOD, "."); //todo
            //VirtualKeys.Add(KeyPoint);
            KeyAt = new VirtualKey(VirtualKeyCode.OEM_MINUS, "-"); //todo
            //VirtualKeys.Add(KeyAt);
            KeySpace = new VirtualKey(VirtualKeyCode.SPACE);
            //VirtualKeys.Add(KeySpace);
            UpArrow = new VirtualKey(VirtualKeyCode.LEFT, "SAĞ");
            //VirtualKeys.Add(UpArrow);
            DownArrow = new VirtualKey(VirtualKeyCode.RIGHT, "SOL");
            ////VirtualKeys.Add(DownArrow);
        }
    }

    //    public void PressKey(Keys keyCode)
    //    {
           
            
    //    }

    //    public void ReleaseKey(Keys keyCode)
    //    {
           
    //    }





    //    public void ProcessKey(Keys keyCode)
    //    {
    //        //if (keyCode == Keys.Shift)
    //        //{
    //        //    ToggleShift();
    //        //}
    //        //else
    //        //{
    //        //    SendKey(keyCode);
    //        //    if (_shifted) ToggleShift();
    //        //}

    //    }

    //    private bool _shifted;

    //    //private void ToggleShift()
    //    //{
    //    //    _shifted = !_shifted;
    //    //    foreach (var virtualKey in VirtualKeys)
    //    //    {
    //    //        virtualKey.KeyState = _shifted ? KeyState.SecondSet : KeyState.FirstSet;
    //    //    }
    //    //    if (_shifted) PressKey(Keys.LShiftKey); else ReleaseKey(Keys.LShiftKey);
    //    //}

    //    public void SendKey(Keys keyCode)
    //    {
    //        PressKey(keyCode);
    //        ReleaseKey(keyCode);
    //    }

      


        

        
       
    //}
    //public struct INPUT
    //{
        
    //    public uint type;
       
    //    public KEYBDINPUT ki;
    //};
    //public struct KEYBDINPUT
    //{
    //    public ushort wVk;
    //    public ushort wScan;
    //    public uint dwFlags;
    //    public long time;
    //    public uint dwExtraInfo;
 
    //};

   

}

         