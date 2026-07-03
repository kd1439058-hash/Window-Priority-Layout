using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Window_Priority_Layout.Core;
using Window_Priority_Layout.Forms;
using Window_Priority_Layout.Hotkeys;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout
{
    public partial class Form1 : Form
    {
        private HotkeyManager _hotkeyManager = new HotkeyManager();
        private RulesStore _store = new RulesStore();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool registered = _hotkeyManager.Register(this.Handle, (uint)Keys.X);

            if (!registered)
            {
                MessageBox.Show("ホットキーの登録に失敗しました。");
            }
        }

        private void Form1_closing(object sender, FormClosingEventArgs e)
        {
            _hotkeyManager.Unregister(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == HotkeyManager.WM_HOTKEY)
            {
                // ホットキーが押されたので、自動配置を実行する
                ArrangeWindows();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrangeWindows();

        }

        private void ArrangeWindows()
        {
            var rules = _store.Load();
            // ウィンドウのソートルールを定義する
            /*var rules = new List<SortRule>
            {
                new SortRule { Keyword = "Claude",  Priority = 10, Target = MatchTarget.ProcessName },
                new SortRule { Keyword = "chrome",  Priority = 9,  Target = MatchTarget.ProcessName },
                new SortRule { Keyword = "Gemini", Priority = 5,  Target = MatchTarget.ProcessName },
            };*/
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
            var mover = new WindowMover();
            mover.MoveWindows(assigned);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ruleSetting = new RuleSetting();
            ruleSetting.ShowDialog();
        }
    }
}
