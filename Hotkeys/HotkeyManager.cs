using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Window_Priority_Layout.Win32;

namespace Window_Priority_Layout.Hotkeys
{
    internal class HotkeyManager
    {
        // Windows APIの定数を定義
        public const int WM_HOTKEY = 0x0312;

        // 修飾キーの定数を定義
        public const int MOD_ALT = 0x0001;
        public const int MOD_CONTROL = 0x0002;

        public const int hotkeyId = 1; // ホットキーのIDを定義

        public bool Register(IntPtr hWnd, uint vk)
        {
            // ホットキーを登録する
            return Win32API.RegisterHotKey(hWnd, hotkeyId, MOD_CONTROL | MOD_ALT, vk);
        }

        public bool Unregister(IntPtr hWnd)
        {
            // ホットキーを解除する
            return Win32API.UnregisterHotKey(hWnd, hotkeyId);
        }
    }
}
