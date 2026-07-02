using System.Collections.Generic;
using Window_Priority_Layout.Models;
using Window_Priority_Layout.Win32;

namespace Window_Priority_Layout.Core
{
    internal class WindowMover
    {
        public void MoveWindows(List<(LayoutSlot Slot, WinInfo Window)> assigned)
        {
            foreach (var SW in assigned)
            {
                Win32API.MoveWindow(
                    SW.Window.Handle,
                    SW.Slot.X,
                    SW.Slot.Y,
                    SW.Slot.Width,
                    SW.Slot.Height,
                    true);
            }
        }
    }
}
