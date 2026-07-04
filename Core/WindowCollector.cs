using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Window_Priority_Layout.Models;
using Window_Priority_Layout.Win32;

namespace Window_Priority_Layout.Core
{
    internal class WindowCollector
    {
        // ウィンドウ情報を格納するリスト
        private List<WinInfo> windowlist=new List<WinInfo>();


        // ウィンドウを列挙して、条件に合うウィンドウ情報をリストに追加する
        public List<WinInfo> GetVisibleWindow()
        {
            // リストをクリアしてから列挙を開始する
            windowlist.Clear();


            //ウィンドウを見つけたら、FoundWindowメソッドを呼び出す
            //EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
            Win32API.EnumWindows(FoundWindow, IntPtr.Zero);

            return windowlist;
        }

        public bool FoundWindow(IntPtr hWnd,IntPtr lParam)
        {
            //ウィンドウが表示されていないならtrueを返す。（trueなら続行）
            if (!Win32API.IsWindowVisible(hWnd)) return true;

            // ウィンドウのタイトルを取得する箱
            var title_buf = new StringBuilder(256);
            // 取得したタイトルをtitle_bufに格納(hWnd: ウィンドウのハンドル, title_buf: タイトルを格納するバッファ, title_buf.Capacity: バッファの容量)
            Win32API.GetWindowText(hWnd, title_buf, title_buf.Capacity);
            string title = title_buf.ToString();

            // タイトルが"Program Manager"ならtrueを返す。（trueなら続行）
            if (title == "Program Manager") return true;

            // タイトルが空文字列またはnullならtrueを返す。（trueなら続行）
            if (title == null||title.Length == 0) return true;

            // ウィンドウのプロセス名を取得
            string processName = GetProcessName(hWnd);

            // プロセス名が空文字列またはnullならtrueを返す。（trueなら続行）
            if (processName == null|| processName.Length == 0) return true;
            // ウィンドウ情報をリスト（windowlist）にWinInfoのクラスで追加
            windowlist.Add(new WinInfo
            {
                Handle = hWnd,
                Title = title,
                ProcessName = processName,
                Priority = 0
            });

            return true;
        }

        public string GetProcessName(IntPtr hWnd)
        {
            try
            {
                // ウィンドウのプロセスIDを取得
                uint Id;
                // GetWindowThreadProcessId関数を使用して、ウィンドウのプロセスIDを取得
                Win32API.GetWindowThreadProcessId(hWnd, out Id);
                // プロセスIDからプロセス名を取得
                var process = Process.GetProcessById((int)Id);
                return process.ProcessName;

            }
            catch (Exception)
            {
                return "unknown"; // エラー時は"unknown"を返す
            }
        }

        




    }
}
