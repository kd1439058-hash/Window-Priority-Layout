namespace Window_Priority_Layout.Forms
{
    partial class LayoutSetting
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
            this.listSlots = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStartPlacement = new System.Windows.Forms.Button();
            this.btnAddSlot = new System.Windows.Forms.Button();
            this.btnRemoveSlot = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConfirmPlacement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSlots
            // 
            this.listSlots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listSlots.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listSlots.FullRowSelect = true;
            this.listSlots.GridLines = true;
            this.listSlots.HideSelection = false;
            this.listSlots.HoverSelection = true;
            this.listSlots.Location = new System.Drawing.Point(12, 12);
            this.listSlots.Name = "listSlots";
            this.listSlots.Size = new System.Drawing.Size(164, 426);
            this.listSlots.TabIndex = 0;
            this.listSlots.UseCompatibleStateImageBehavior = false;
            this.listSlots.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Slot";
            this.columnHeader1.Width = 120;
            // 
            // btnStartPlacement
            // 
            this.btnStartPlacement.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStartPlacement.Location = new System.Drawing.Point(182, 12);
            this.btnStartPlacement.Name = "btnStartPlacement";
            this.btnStartPlacement.Size = new System.Drawing.Size(163, 80);
            this.btnStartPlacement.TabIndex = 2;
            this.btnStartPlacement.Text = "編集";
            this.btnStartPlacement.UseVisualStyleBackColor = true;
            this.btnStartPlacement.Click += new System.EventHandler(this.btnStartPlacement_Click);
            // 
            // btnAddSlot
            // 
            this.btnAddSlot.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddSlot.Location = new System.Drawing.Point(182, 98);
            this.btnAddSlot.Name = "btnAddSlot";
            this.btnAddSlot.Size = new System.Drawing.Size(163, 80);
            this.btnAddSlot.TabIndex = 3;
            this.btnAddSlot.Text = "スロットを追加";
            this.btnAddSlot.UseVisualStyleBackColor = true;
            this.btnAddSlot.Click += new System.EventHandler(this.btnAddSlot_Click);
            // 
            // btnRemoveSlot
            // 
            this.btnRemoveSlot.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemoveSlot.Location = new System.Drawing.Point(182, 184);
            this.btnRemoveSlot.Name = "btnRemoveSlot";
            this.btnRemoveSlot.Size = new System.Drawing.Size(163, 80);
            this.btnRemoveSlot.TabIndex = 4;
            this.btnRemoveSlot.Text = "スロットを消去";
            this.btnRemoveSlot.UseVisualStyleBackColor = true;
            this.btnRemoveSlot.Click += new System.EventHandler(this.btnRemoveSlot_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.Location = new System.Drawing.Point(182, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 80);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConfirmPlacement
            // 
            this.btnConfirmPlacement.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConfirmPlacement.Location = new System.Drawing.Point(182, 272);
            this.btnConfirmPlacement.Name = "btnConfirmPlacement";
            this.btnConfirmPlacement.Size = new System.Drawing.Size(163, 80);
            this.btnConfirmPlacement.TabIndex = 6;
            this.btnConfirmPlacement.Text = "確定";
            this.btnConfirmPlacement.UseVisualStyleBackColor = true;
            this.btnConfirmPlacement.Click += new System.EventHandler(this.button1_Click);
            // 
            // LayoutSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.btnConfirmPlacement);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveSlot);
            this.Controls.Add(this.btnAddSlot);
            this.Controls.Add(this.btnStartPlacement);
            this.Controls.Add(this.listSlots);
            this.Name = "LayoutSetting";
            this.Text = "LayoutSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LayoutSetting_FormClosing);
            this.Load += new System.EventHandler(this.LayoutSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listSlots;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnStartPlacement;
        private System.Windows.Forms.Button btnAddSlot;
        private System.Windows.Forms.Button btnRemoveSlot;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnConfirmPlacement;
    }
}