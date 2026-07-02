using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Priority_Layout.Models
{
    internal class LayoutSlot
    {
        // ウィンドウの位置とサイズを表すプロパティ
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        // ウィンドウのラベルを表すプロパティ
        public string Label { get; set; }
    }
}
