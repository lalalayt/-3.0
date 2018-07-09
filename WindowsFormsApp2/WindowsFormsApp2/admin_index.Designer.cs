namespace WindowsFormsApp2
{
    partial class admin_index
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统字典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加器具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.器件出入记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工管理ToolStripMenuItem,
            this.系统字典ToolStripMenuItem,
            this.仓库管理ToolStripMenuItem,
            this.仓库状态ToolStripMenuItem,
            this.添加器具ToolStripMenuItem,
            this.器件出入记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(13, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            this.员工管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.员工管理ToolStripMenuItem.Text = "员工管理";
            // 
            // 系统字典ToolStripMenuItem
            // 
            this.系统字典ToolStripMenuItem.Name = "系统字典ToolStripMenuItem";
            this.系统字典ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.系统字典ToolStripMenuItem.Text = "系统字典";
            // 
            // 仓库管理ToolStripMenuItem
            // 
            this.仓库管理ToolStripMenuItem.Name = "仓库管理ToolStripMenuItem";
            this.仓库管理ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.仓库管理ToolStripMenuItem.Text = "仓库管理";
            // 
            // 仓库状态ToolStripMenuItem
            // 
            this.仓库状态ToolStripMenuItem.Name = "仓库状态ToolStripMenuItem";
            this.仓库状态ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.仓库状态ToolStripMenuItem.Text = "仓库状态";
            // 
            // 添加器具ToolStripMenuItem
            // 
            this.添加器具ToolStripMenuItem.Name = "添加器具ToolStripMenuItem";
            this.添加器具ToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.添加器具ToolStripMenuItem.Text = "添加器件";
            this.添加器具ToolStripMenuItem.Click += new System.EventHandler(this.添加器具ToolStripMenuItem_Click);
            // 
            // 器件出入记录ToolStripMenuItem
            // 
            this.器件出入记录ToolStripMenuItem.Name = "器件出入记录ToolStripMenuItem";
            this.器件出入记录ToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.器件出入记录ToolStripMenuItem.Text = "器件出入记录";
            // 
            // admin_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin_index";
            this.Text = "管理员主页面";
            this.Load += new System.EventHandler(this.admin_index_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统字典ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加器具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 器件出入记录ToolStripMenuItem;
    }
}