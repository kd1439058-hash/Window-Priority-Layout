namespace Window_Priority_Layout.Forms
{
    partial class RuleEdit
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.numPriority = new System.Windows.Forms.NumericUpDown();
            this.radioTitle = new System.Windows.Forms.RadioButton();
            this.radioProcessName = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.Color.White;
            this.txtKeyword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKeyword.Location = new System.Drawing.Point(12, 28);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtKeyword.Size = new System.Drawing.Size(175, 54);
            this.txtKeyword.TabIndex = 0;
            // 
            // numPriority
            // 
            this.numPriority.Location = new System.Drawing.Point(193, 47);
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(109, 25);
            this.numPriority.TabIndex = 1;
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioTitle.Location = new System.Drawing.Point(15, 88);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(79, 28);
            this.radioTitle.TabIndex = 2;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            // 
            // radioProcessName
            // 
            this.radioProcessName.AutoSize = true;
            this.radioProcessName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioProcessName.Location = new System.Drawing.Point(130, 88);
            this.radioProcessName.Name = "radioProcessName";
            this.radioProcessName.Size = new System.Drawing.Size(172, 28);
            this.radioProcessName.TabIndex = 3;
            this.radioProcessName.TabStop = true;
            this.radioProcessName.Text = "ProcessName";
            this.radioProcessName.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(12, 141);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 39);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncancel.Location = new System.Drawing.Point(166, 139);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(136, 43);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // RuleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 199);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioProcessName);
            this.Controls.Add(this.radioTitle);
            this.Controls.Add(this.numPriority);
            this.Controls.Add(this.txtKeyword);
            this.Name = "RuleEdit";
            this.Text = "RuleEdit";
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.NumericUpDown numPriority;
        private System.Windows.Forms.RadioButton radioTitle;
        private System.Windows.Forms.RadioButton radioProcessName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btncancel;
    }
}