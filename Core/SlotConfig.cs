using System.Collections.Generic;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Core
{
    internal class SlotConfig
    {
        // 引数のスロットとウィンドウリストを受け取り、スロットにウィンドウを割り当てる
        public List<(LayoutSlot Slot, WinInfo Window)> Config(List<LayoutSlot> slots, List<WinInfo> windows)
        {
            //割当先のスロットと割り当てるウィンドウのリストを作成
            var result = new List<(LayoutSlot, WinInfo)>();

            // スロットとウィンドウの数を比較し、少ない方の数だけループする
            int count =windows.Count;
            if (slots.Count < windows.Count) count=slots.Count;

            // スロットとウィンドウを順番に割り当てる
            for (int i = 0; i < count; i++)
            {
                result.Add((slots[i], windows[i]));
            }

            return result;
        }


        
    }
}
