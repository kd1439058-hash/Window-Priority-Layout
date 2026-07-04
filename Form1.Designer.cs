namespace Window_Priority_Layout
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuArrangeNow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenRuleSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenLayoutSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayMenu;
            this.notifyIcon1.Text = "Window Priority Layout";
            // 
            // trayMenu
            // 
            this.trayMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArrangeNow,
            this.menuOpenRuleSetting,
            this.menuOpenLayoutSetting,
            this.toolStripSeparator1,
            this.menuExit});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(186, 138);
            // 
            // menuArrangeNow
            // 
            this.menuArrangeNow.Name = "menuArrangeNow";
            this.menuArrangeNow.Size = new System.Drawing.Size(240, 32);
            this.menuArrangeNow.Text = "ソート";
            this.menuArrangeNow.Click += new System.EventHandler(this.menuArrangeNow_Click);
            // 
            // menuOpenRuleSetting
            // 
            this.menuOpenRuleSetting.Name = "menuOpenRuleSetting";
            this.menuOpenRuleSetting.Size = new System.Drawing.Size(240, 32);
            this.menuOpenRuleSetting.Text = "ルール設定";
            this.menuOpenRuleSetting.Click += new System.EventHandler(this.menuOpenRuleSetting_Click);
            // 
            // menuOpenLayoutSetting
            // 
            this.menuOpenLayoutSetting.Name = "menuOpenLayoutSetting";
            this.menuOpenLayoutSetting.Size = new System.Drawing.Size(240, 32);
            this.menuOpenLayoutSetting.Text = "レイアウト設定";
            this.menuOpenLayoutSetting.Click += new System.EventHandler(this.menuOpenLayoutSetting_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(240, 32);
            this.menuExit.Text = "終了";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 296);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem menuArrangeNow;
        private System.Windows.Forms.ToolStripMenuItem menuOpenRuleSetting;
        private System.Windows.Forms.ToolStripMenuItem menuOpenLayoutSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}

