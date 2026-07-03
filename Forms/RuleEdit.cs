using System;
using System.Windows.Forms;
using Window_Priority_Layout.Models;

namespace Window_Priority_Layout.Forms
{
    public partial class RuleEdit : Form
    {
        private string _processNameValue = "";
        private string _titleValue = "";
        private bool Initaialize = false;
        public RuleEdit()
        {
            InitializeComponent();

            radioTitle.CheckedChanged += Radio_CheckedChanged;
            radioProcessName.CheckedChanged += Radio_CheckedChanged;
        }

        internal void SetValues(string processName,string title, int priority, MatchTarget target)
        {

            Initaialize = true;
            _processNameValue = processName;
            _titleValue = title;

            numPriority.Value = priority;
            radioTitle.Checked = target == MatchTarget.Title;
            radioProcessName.Checked = target == MatchTarget.ProcessName;

            Initaialize = false;
            // 現在選択中のTargetに応じたKeywordを表示
            UpdateKeywordText();
        }

        internal void SetValuesForEdit(string keyword, int priority, MatchTarget target)
        {
            Initaialize = true;

            _processNameValue = keyword;
            _titleValue = keyword;

            
            numPriority.Value = priority;
            radioTitle.Checked = target == MatchTarget.Title;
            radioProcessName.Checked = target == MatchTarget.ProcessName;

            Initaialize = false;

            txtKeyword.Text = keyword;
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Initaialize) return;
            UpdateKeywordText();
        }

        private void UpdateKeywordText()
        {
            txtKeyword.Text = radioTitle.Checked ? _titleValue : _processNameValue;
        }

        internal SortRule GetResult()
        {
            return new SortRule
            {
                Keyword = txtKeyword.Text,
               // Priority = 0,
                Priority = (int)numPriority.Value,
                Target = radioTitle.Checked ? MatchTarget.Title : MatchTarget.ProcessName
            }; 
        }
    }
}
