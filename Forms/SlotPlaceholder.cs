using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Window_Priority_Layout.Forms
{
    internal class SlotPlaceholder : Form
    {
        public string SlotLabel { get; private set; }

        public SlotPlaceholder(string label,int x,int y, int width, int height)
        {
            SlotLabel = label;

            this.FormBorderStyle = FormBorderStyle.SizableToolWindow; // 細いタイトルバー、リサイズ可能
            this.Text = label;
            this.BackColor = Color.LightSteelBlue;
            this.Opacity = 0.75;         // 半透明：下のウィンドウが透けて見える
            this.TopMost = true;         // 常に最前面に表示
            this.ShowInTaskbar = false;  // タスクバーを汚さない
            this.ControlBox = false;      // タイトルバーのボタンを非表示

            this.StartPosition = FormStartPosition.Manual; // 手動で位置を指定
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);

            var labelContorol = new Label
            {
                Text = label,
                Dock= DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("MS UI Gothic", 16, FontStyle.Bold),
            };
            this.Controls.Add(labelContorol);
        }
    }
}
