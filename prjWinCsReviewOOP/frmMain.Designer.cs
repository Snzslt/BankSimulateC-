namespace prjWinCsReviewOOP
{
    partial class frmMain
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
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOOP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatareader = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLinq = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuATM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(940, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaptersToolStripMenuItem,
            this.mnuATM,
            this.toolStripSeparator1,
            this.mnuQuit});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOOP,
            this.mnuDatareader,
            this.mnuDataset,
            this.mnuLinq,
            this.mnuEntity});
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(374, 44);
            this.chaptersToolStripMenuItem.Text = "Chapters";
            // 
            // mnuOOP
            // 
            this.mnuOOP.Name = "mnuOOP";
            this.mnuOOP.Size = new System.Drawing.Size(344, 44);
            this.mnuOOP.Text = "O O Programming";
            this.mnuOOP.Click += new System.EventHandler(this.mnuOOP_Click);
            // 
            // mnuDatareader
            // 
            this.mnuDatareader.Name = "mnuDatareader";
            this.mnuDatareader.Size = new System.Drawing.Size(344, 44);
            this.mnuDatareader.Text = "Datareader";
            // 
            // mnuDataset
            // 
            this.mnuDataset.Name = "mnuDataset";
            this.mnuDataset.Size = new System.Drawing.Size(344, 44);
            this.mnuDataset.Text = "Dataset";
            // 
            // mnuLinq
            // 
            this.mnuLinq.Name = "mnuLinq";
            this.mnuLinq.Size = new System.Drawing.Size(344, 44);
            this.mnuLinq.Text = "Linq";
            // 
            // mnuEntity
            // 
            this.mnuEntity.Name = "mnuEntity";
            this.mnuEntity.Size = new System.Drawing.Size(344, 44);
            this.mnuEntity.Text = "Entity Framework";
            // 
            // mnuATM
            // 
            this.mnuATM.Name = "mnuATM";
            this.mnuATM.Size = new System.Drawing.Size(374, 44);
            this.mnuATM.Text = "Bank ATM";
            this.mnuATM.Click += new System.EventHandler(this.mnuATM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(371, 6);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuQuit.Size = new System.Drawing.Size(374, 44);
            this.mnuQuit.Text = "Quit Program";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 654);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Windows Application for O.O.P. Review";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOOP;
        private System.Windows.Forms.ToolStripMenuItem mnuDatareader;
        private System.Windows.Forms.ToolStripMenuItem mnuDataset;
        private System.Windows.Forms.ToolStripMenuItem mnuLinq;
        private System.Windows.Forms.ToolStripMenuItem mnuEntity;
        private System.Windows.Forms.ToolStripMenuItem mnuATM;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}