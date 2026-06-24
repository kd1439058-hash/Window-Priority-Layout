using System;

namespace Window_Priority_Layout.Models
{
    // WinInfoクラスは、ウィンドウの情報を格納するためのクラスです。
    internal class WinInfo
    {
        // ウィンドウの番号（ハンドル）を格納するプロパティ
        public IntPtr Handle { get; set; }

        // ウィンドウのタイトルを格納するプロパティ
        //例：”(ユーザー名)-Google Chrome”
        public string Title { get; set; }

        // ウィンドウのプロセス名を格納するプロパティ
        //例：”Google Chrome”
        public string ProcessName { get; set; }

        // ウィンドウの優先度を格納するプロパティ
        public int Priority { get; set; }



    }
}
