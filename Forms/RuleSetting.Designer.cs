namespace Window_Priority_Layout.Forms
{
    partial class RuleSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListRunning = new System.Windows.Forms.ListView();
            this.プロセス名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listRules = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMoveup = new System.Windows.Forms.Button();
            this.btnMovedown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListRunning
            // 
            this.ListRunning.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.プロセス名,
            this.columnHeader1});
            this.ListRunning.FullRowSelect = true;
            this.ListRunning.GridLines = true;
            this.ListRunning.HideSelection = false;
            this.ListRunning.Location = new System.Drawing.Point(1, -1);
            this.ListRunning.Name = "ListRunning";
            this.ListRunning.Size = new System.Drawing.Size(365, 391);
            this.ListRunning.TabIndex = 0;
            this.ListRunning.UseCompatibleStateImageBehavior = false;
            this.ListRunning.View = System.Windows.Forms.View.Details;
            // 
            // プロセス名
            // 
            this.プロセス名.Text = "ProcessName";
            this.プロセス名.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 80;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(70, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 56);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEdit.Location = new System.Drawing.Point(212, 418);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 53);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDelete.Location = new System.Drawing.Point(354, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 56);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.Location = new System.Drawing.Point(496, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 53);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listRules
            // 
            this.listRules.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listRules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listRules.FullRowSelect = true;
            this.listRules.GridLines = true;
            this.listRules.HideSelection = false;
            this.listRules.HoverSelection = true;
            this.listRules.Location = new System.Drawing.Point(382, -1);
            this.listRules.Name = "listRules";
            this.listRules.Size = new System.Drawing.Size(480, 391);
            this.listRules.TabIndex = 7;
            this.listRules.UseCompatibleStateImageBehavior = false;
            this.listRules.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "優先度";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Keyword";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Target";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Priority";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMoveup
            // 
            this.btnMoveup.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMoveup.Location = new System.Drawing.Point(634, 414);
            this.btnMoveup.Name = "btnMoveup";
            this.btnMoveup.Size = new System.Drawing.Size(132, 53);
            this.btnMoveup.TabIndex = 8;
            this.btnMoveup.Text = "上へ";
            this.btnMoveup.UseVisualStyleBackColor = true;
            this.btnMoveup.Click += new System.EventHandler(this.btnMoveup_Click);
            // 
            // btnMovedown
            // 
            this.btnMovedown.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMovedown.Location = new System.Drawing.Point(772, 414);
            this.btnMovedown.Name = "btnMovedown";
            this.btnMovedown.Size = new System.Drawing.Size(132, 53);
            this.btnMovedown.TabIndex = 9;
            this.btnMovedown.Text = "下へ";
            this.btnMovedown.UseVisualStyleBackColor = true;
            this.btnMovedown.Click += new System.EventHandler(this.btnMovedown_Click);
            // 
            // RuleSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 497);
            this.Controls.Add(this.btnMovedown);
            this.Controls.Add(this.btnMoveup);
            this.Controls.Add(this.listRules);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ListRunning);
            this.Name = "RuleSetting";
            this.Text = "RuleSetting";
            this.Load += new System.EventHandler(this.RuleSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListRunning;
        private System.Windows.Forms.ColumnHeader プロセス名;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listRules;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnMoveup;
        private System.Windows.Forms.Button btnMovedown;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}