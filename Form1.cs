using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Window_Priority_Layout.Core;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            // ウィンドウのソートルールを定義する
            var rules = new List<SortRule>
            {
                new SortRule { Keyword = "Claude",  Priority = 10, Target = MatchTarget.ProcessName },
                new SortRule { Keyword = "chrome",  Priority = 9,  Target = MatchTarget.ProcessName },
                new SortRule { Keyword = "Gemini", Priority = 5,  Target = MatchTarget.ProcessName },
            };
            // スロットのリストを作成する
            var slots = new List<LayoutSlot>
            {
                new LayoutSlot { X = 0,   Y = 0, Width = 560, Height = 300, Label = "メイン" },
                new LayoutSlot { X = 560, Y = 0, Width = 260, Height = 300,  Label = "サブ上" },
                new LayoutSlot { X = 820, Y = 0, Width = 100, Height = 300, Label = "サブ下" },
            };
            // WindowCollector クラスのインスタンスを作成し、
            // GetVisibleWindow メソッドを呼び出して、現在表示されているウィンドウの情報を取得する
            var c = new WindowCollector();
            var windows = c.GetVisibleWindow();

            //windowsorter クラスのインスタンスを作成し、Sort メソッドを呼び出して、取得したウィンドウ情報をルールに基づいてソートする
            var sorter = new WindowSorter(rules);
            var sortedWIndows = sorter.Sort(windows);

            // LayoutAssigner クラスのインスタンスを作成し、Assign メソッドを呼び出して、ソートされたウィンドウ情報をスロットに割り当てる
            var assigner = new LayoutAssigner();
            var assigned = assigner.Assign(slots, sortedWIndows);


            foreach (var pair in assigned)
            {
                Debug.WriteLine($"[{pair.Slot.Label}] ← {pair.Window.ProcessName} ({pair.Window.Title})");
            }
            // 取得したウィンドウ情報について、それぞれのタイトルとプロセス名を表示する
            foreach (var win in sortedWIndows)
            {
                // Visual Studio の「出力」ウィンドウに表示される
                listBox1.Items.Add($"Priority: {win.Priority} | Title: {win.Title} | Process: {win.ProcessName}");
            }
            var mover = new WindowMover();
            mover.MoveWindows(assigned);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
