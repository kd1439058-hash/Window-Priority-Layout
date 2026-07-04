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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.Color.White;
            this.txtKeyword.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKeyword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKeyword.Location = new System.Drawing.Point(12, 12);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtKeyword.Size = new System.Drawing.Size(344, 98);
            this.txtKeyword.TabIndex = 0;
            // 
            // numPriority
            // 
            this.numPriority.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numPriority.Location = new System.Drawing.Point(151, 127);
            this.numPriority.Name = "numPriority";
            this.numPriority.Size = new System.Drawing.Size(80, 39);
            this.numPriority.TabIndex = 1;
            this.numPriority.ValueChanged += new System.EventHandler(this.numPriority_ValueChanged);
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioTitle.Location = new System.Drawing.Point(12, 177);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(100, 37);
            this.radioTitle.TabIndex = 2;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            // 
            // radioProcessName
            // 
            this.radioProcessName.AutoSize = true;
            this.radioProcessName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioProcessName.Location = new System.Drawing.Point(131, 177);
            this.radioProcessName.Name = "radioProcessName";
            this.radioProcessName.Size = new System.Drawing.Size(225, 37);
            this.radioProcessName.TabIndex = 3;
            this.radioProcessName.TabStop = true;
            this.radioProcessName.Text = "ProcessName";
            this.radioProcessName.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(12, 235);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 43);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncancel.Location = new System.Drawing.Point(220, 235);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(136, 43);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Priority";
            // 
            // RuleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioProcessName);
            this.Controls.Add(this.radioTitle);
            this.Controls.Add(this.numPriority);
            this.Controls.Add(this.txtKeyword);
            this.Name = "RuleEdit";
            this.Text = "RuleEdit";
            this.Load += new System.EventHandler(this.RuleEdit_Load);
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
        private System.Windows.Forms.Label label1;
    }
}