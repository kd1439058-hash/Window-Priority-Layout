using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window_Priority_Layout.Core;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Forms
{
    public partial class LayoutSetting : Form
    {

        private List<LayoutSlot> _slots;
        private LayoutStore _store = new LayoutStore();

        private List<SlotPlaceholder> _placeholders = new List<SlotPlaceholder>();
        public LayoutSetting()
        {
            InitializeComponent();

        }

        private void LayoutSetting_Load(object sender, EventArgs e)
        {
            _slots = _store.Load();
            // ルールをストアから読み込む
            RefreshSlotList();
        }

        private void RefreshSlotList()
        {
            listSlots.Items.Clear();
            foreach (var slot in _slots)
            {
                var item = new ListViewItem(slot.Label);
                item.SubItems.Add(slot.X.ToString());
                item.SubItems.Add(slot.Y.ToString());
                item.SubItems.Add(slot.Width.ToString());
                item.SubItems.Add(slot.Height.ToString());
                listSlots.Items.Add(item);
            }
        }

        private string GetLabel(int index)
        {
            switch (index)
            {
                case 0: return "最優先";
                case 1: return "2番目に優先";
                case 2: return "3番目に優先";
                default: return $"{(index + 1)}番目に優先";
            }
        }

        private void btnStartPlacement_Click(object sender, EventArgs e)
        {
            ClosePlaceholders();

            if (_slots.Count == 0)
            {
                MessageBox.Show(
                    "まだレイアウトが保存されていません。\n「追加」ボタンでスロットを作成してください。",
                    "確認"
                );
                return;
            }

            for (int i = 0; i < _slots.Count; i++)
            {
                var slot = _slots[i];
                var placeholder = new SlotPlaceholder(slot.Label, slot.X, slot.Y, slot.Width, slot.Height   );
                placeholder.Show();
                _placeholders.Add(placeholder);
            }
        }

        private void btnAddSlot_Click(object sender, EventArgs e)
        {
            string label = GetLabel(_placeholders.Count);

            int offset = _placeholders.Count * 40;
            var _placeholder = new SlotPlaceholder(label, 100 + offset, 100 + offset, 200, 150);
            _placeholder.Show();
            _placeholders.Add(_placeholder);
        }

        private void btnRemoveSlot_Click(object sender, EventArgs e)
        {
            if(_placeholders.Count==0) return;

            int cnt = _placeholders.Count-1;
            _placeholders[cnt].Close();
            _placeholders.RemoveAt(cnt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _slots.Clear();

            foreach(var placeholder in _placeholders)
            {
                var slot = new LayoutSlot
                {
                    Label = placeholder.SlotLabel,
                    X = placeholder.Location.X,
                    Y = placeholder.Location.Y,
                    Width = placeholder.Size.Width,
                    Height = placeholder.Size.Height
                };
                _slots.Add(slot);
            }

            ClosePlaceholders();
            RefreshSlotList();
        }



        private void ClosePlaceholders()
        {
            foreach (var placeholder in _placeholders)
            {
                placeholder.Close();
            }
            _placeholders.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _store.Save(_slots);
                MessageBox.Show("レイアウト設定を保存しました。");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // フォームを閉じるときは、開いているプレースホルダーも片付ける
        private void LayoutSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_placeholders.Count > 0)
            {
                var result = MessageBox.Show(
                    "配置が確定されていません。このまま閉じますか？",
                    "確認",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // 閉じるのをキャンセルする
                    return;
                }
            }


            ClosePlaceholders();
        }

    }
}
