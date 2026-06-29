using System;
using System.Collections.Generic;
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

            var rules = new List<SortRule>
            {
                new SortRule { Keyword = "chrome",  Priority = 10, Target = MatchTarget.ProcessName },
                new SortRule { Keyword = "devenv",  Priority = 9,  Target = MatchTarget.ProcessName },
                new SortRule { Keyword = "notepad", Priority = 5,  Target = MatchTarget.ProcessName },
            };
            // WindowCollector クラスのインスタンスを作成し、
            // GetVisibleWindow メソッドを呼び出して、現在表示されているウィンドウの情報を取得する
            var c = new WindowCollector();
            var windows = c.GetVisibleWindow();

            var Sorter = new WindowSorter(rules);
            var sort = Sorter.Sort(windows);

            // 取得したウィンドウ情報について、それぞれのタイトルとプロセス名を表示する
            foreach (var win in sort)
            {
                // Visual Studio の「出力」ウィンドウに表示される
               listBox1.Items.Add($"Priority: {win.Priority} | Title: {win.Title} | Process: {win.ProcessName}");
            }
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
