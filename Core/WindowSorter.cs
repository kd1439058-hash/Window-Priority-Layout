using System;
using System.Collections.Generic;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Core
{
    internal class WindowSorter
    {
        public List<SortRule> rules;

        private WindowSorter(List<SortRule> ruless)
        {
            rules = ruless;
        }

        //引数のウィンドウリストを優先度順にソートして返す
        public List<WinInfo> Sort(List<WinInfo> windows)
        {
            //各ウィンドウの優先度を計算して設定
            foreach (var win in windows) {

                //優先度を計算して設定
                win.Priority = GetPriority(win);
            }

            //.sortををそのまま使うと昇順になるので、降順にするためにbとaを入れ替えて比較する
            windows.Sort((a,b) => b.Priority.CompareTo(a.Priority));

            return windows;
        }

        //ウィンドウの優先度を計算して返す
        private int GetPriority(WinInfo win)
        {
            foreach(var rule in rules)
            {
                //個別のターゲットがtitleなら今回のターゲットはタイトル、そうでなければプロセス名
                string target = rule.Target == MatchTarget.Title ? win.Title : win.ProcessName;

                //ターゲットにルールのキーワードが含まれているかを確認（大文字小文字を区別しない）
                if (target.IndexOf(rule.Keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    //ルールの優先度を返す
                    return rule.Priority;
                }
            }
            //どのルールにもマッチしなかった場合は0を返す
            return 0;
        }
}
}
