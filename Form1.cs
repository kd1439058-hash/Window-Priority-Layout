using System;
using System.Diagnostics;
using System.Windows.Forms;
using Window_Priority_Layout.Core;

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
            var c = new WindowCollector();
            var windows = c.GetVisibleWindow();

            foreach (var win in windows)
            {
                // Visual Studio の「出力」ウィンドウに表示される
                MessageBox.Show($"Title: {win.Title} | Process: {win.ProcessName}");
            }
          
        }
    }
}
