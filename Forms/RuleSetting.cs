using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Window_Priority_Layout.Core;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Forms
{
    public partial class RuleSetting : Form
    {
        // ルールのリストを保持するフィールド
        private List<SortRule> _rules;
        private RulesStore _store = new RulesStore();

        public RuleSetting()
        {
            InitializeComponent();
        }

        // フォームがロードされたときに呼び出されるイベントハンドラ
        private void RuleSetting_Load(object sender, EventArgs e)
        {
            LoadRunningWindows();
            // ルールをストアから読み込む
            _rules = _store.Load();
            SortRulesByPriority();
            RefreshRuleList();
        }

        // 今開いているウィンドウのプロセス名を取得してリストに表示するメソッド
        private void LoadRunningWindows()
        {
            ListRunning.Items.Clear();
            var collector = new WindowCollector();
            var windows = collector.GetVisibleWindow();
            // 取得したウィンドウのプロセス名をリストに追加
            foreach (var win in windows)
            {
                var item = new ListViewItem(win.ProcessName);
                item.SubItems.Add(win.Title);
                ListRunning.Items.Add(item);
            }
        }

        private void SortRulesByPriority()
        {
            _rules.Sort((a, b) => b.Priority.CompareTo(a.Priority));
        }
        /*private void RePriority()
        {
            int total=_rules.Count;
            for (int i = 0; i < _rules.Count; i++)
            {
                _rules[i].Priority = total - i;
            }
        }*/

        // ソートルールのリストを更新するメソッド
        private void RefreshRuleList()
        {
            listRules.Items.Clear();

            for(int i=0;i < _rules.Count; i++)
            {
                var rule = _rules[i];
                
                var item = new ListViewItem(rule.Priority.ToString());
                item.SubItems.Add(rule.Keyword);
                item.SubItems.Add(rule.Target.ToString());
                item.SubItems.Add((i + 1).ToString());
                listRules.Items.Add(item);
            }
        }
        // ルールをストアから読み込む

        private int GetNextDefaultPriority()
        {
            if (_rules.Count == 0) return 10;
            int max = 0;
            foreach (var r in _rules)
            {
                if (r.Priority > max) max = r.Priority;
            }
            return max + 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 新しいルールを追加するためのフォームを表示
            var ruleAdd = new RuleEdit();

            int newPriority = GetNextDefaultPriority();
            // ルール編集フォームをモーダルで表示
            if (ListRunning.SelectedItems.Count > 0)
            {
                // 選択されているプロセス名を取得して、ルール編集フォームに渡す
                var selected = ListRunning.SelectedItems[0];
                string processName = selected.SubItems[0].Text;
                string title = selected.SubItems[1].Text;

                ruleAdd.SetValues(processName, title, newPriority, MatchTarget.ProcessName);
            }
            // ルール編集フォームでOKが押された場合、新しいルールを取得してリストに追加
            if (ruleAdd.ShowDialog() == DialogResult.OK)
            {
             
                _rules.Add(ruleAdd.GetResult());
                SortRulesByPriority();
                RefreshRuleList();
               // _store.Save(_rules); // ルールを保存)
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listRules.SelectedItems.Count == 0) return;

            //右側のリストで選択されているルールを取得
            int index = listRules.SelectedIndices[0];
            var rule = _rules[index];

            var ruleEdit = new RuleEdit();
            ruleEdit.SetValuesForEdit(rule.Keyword, rule.Priority, rule.Target);

            if(ruleEdit.ShowDialog() == DialogResult.OK)
            {
                var result = ruleEdit.GetResult();
                result.Priority = rule.Priority; // 優先度は編集前のものを維持
                _rules[index] = result;
                SortRulesByPriority();
                RefreshRuleList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listRules.SelectedItems.Count == 0) return;
            // 右側のリストで選択されているルールを削除
            int index = listRules.SelectedIndices[0];
            _rules.RemoveAt(index);
            SortRulesByPriority();
            RefreshRuleList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {   // ルールを保存する
                _store.Save(_rules);
                MessageBox.Show("ルールを保存しました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
    }

        private void listRules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMoveup_Click(object sender, EventArgs e)
        {
            if (listRules.SelectedIndices.Count == 0) return;

            int index = listRules.SelectedIndices[0];

            // 先頭のときは何もしない
            if (index == 0) return;

            // リスト内で1つ上と入れ替える
            SwapRules(index, index - 1);
            SortRulesByPriority();
            RefreshRuleList();

            // 移動後も同じ項目が選択された状態を保つ
            listRules.Items[index - 1].Selected = true;
        }

        private void btnMovedown_Click(object sender, EventArgs e)
        {
            if (listRules.SelectedIndices.Count == 0) return;

            int index = listRules.SelectedIndices[0];

            // 末尾のときは何もしない
            if (index == _rules.Count - 1) return;

            SwapRules(index, index + 1);
            SortRulesByPriority();
            RefreshRuleList();

            listRules.Items[index + 1].Selected = true;
        }

        private void SwapRules(int index1, int index2)
        {
            var temp = _rules[index1];
            _rules[index1] = _rules[index2];
            _rules[index2] = temp;

            var temp2 = _rules[index1].Priority;
            _rules[index1].Priority = _rules[index2].Priority;
            _rules[index2].Priority = temp2;
        }
    }
}

