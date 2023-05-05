namespace Demo_Caro
{
    partial class frmCOCARO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCOCARO));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onThisPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withLANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnCHUCHAY = new System.Windows.Forms.Panel();
            this.lbCHUCHAY = new System.Windows.Forms.Label();
            this.pnCOCARO = new System.Windows.Forms.Panel();
            this.tmCHUCHAY = new System.Windows.Forms.Timer(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnCHUCHAY.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.musicToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsComputerToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onThisPCToolStripMenuItem,
            this.withLANToolStripMenuItem});
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.playerVsPlayerToolStripMenuItem.Text = "Player Vs Player";
            // 
            // onThisPCToolStripMenuItem
            // 
            this.onThisPCToolStripMenuItem.Name = "onThisPCToolStripMenuItem";
            this.onThisPCToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.onThisPCToolStripMenuItem.Text = "&On This PC";
            this.onThisPCToolStripMenuItem.Click += new System.EventHandler(this.onThisPCToolStripMenuItem_Click);
            // 
            // withLANToolStripMenuItem
            // 
            this.withLANToolStripMenuItem.Name = "withLANToolStripMenuItem";
            this.withLANToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.withLANToolStripMenuItem.Text = "&With LAN";
            // 
            // playerVsComputerToolStripMenuItem
            // 
            this.playerVsComputerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.playerVsComputerToolStripMenuItem.Name = "playerVsComputerToolStripMenuItem";
            this.playerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.playerVsComputerToolStripMenuItem.Text = "Player Vs Computer";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.musicToolStripMenuItem.Text = "&Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // pnCHUCHAY
            // 
            this.pnCHUCHAY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnCHUCHAY.Controls.Add(this.lbCHUCHAY);
            this.pnCHUCHAY.Location = new System.Drawing.Point(19, 87);
            this.pnCHUCHAY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnCHUCHAY.Name = "pnCHUCHAY";
            this.pnCHUCHAY.Size = new System.Drawing.Size(303, 616);
            this.pnCHUCHAY.TabIndex = 2;
            // 
            // lbCHUCHAY
            // 
            this.lbCHUCHAY.AutoSize = true;
            this.lbCHUCHAY.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Bold);
            this.lbCHUCHAY.Location = new System.Drawing.Point(4, 593);
            this.lbCHUCHAY.Name = "lbCHUCHAY";
            this.lbCHUCHAY.Size = new System.Drawing.Size(39, 15);
            this.lbCHUCHAY.TabIndex = 0;
            this.lbCHUCHAY.Text = "label1";
            // 
            // pnCOCARO
            // 
            this.pnCOCARO.BackColor = System.Drawing.Color.SeaGreen;
            this.pnCOCARO.Location = new System.Drawing.Point(337, 87);
            this.pnCOCARO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnCOCARO.Name = "pnCOCARO";
            this.pnCOCARO.Size = new System.Drawing.Size(668, 617);
            this.pnCOCARO.TabIndex = 0;
            this.pnCOCARO.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCOCARO_Paint);
            this.pnCOCARO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnCOCARO_MouseClick);
            // 
            // tmCHUCHAY
            // 
            this.tmCHUCHAY.Interval = 13;
            this.tmCHUCHAY.Tick += new System.EventHandler(this.tmCHUCHAY_Tick);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::Demo_Caro.Properties.Resources.anh_Undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::Demo_Caro.Properties.Resources.anh_Redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click_1);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click_1);
            // 
            // frmCOCARO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1045, 752);
            this.Controls.Add(this.pnCOCARO);
            this.Controls.Add(this.pnCHUCHAY);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmCOCARO";
            this.Text = "Cờ Caro";
            this.Load += new System.EventHandler(this.frmCOCARO_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnCHUCHAY.ResumeLayout(false);
            this.pnCHUCHAY.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onThisPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withLANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Panel pnCHUCHAY;
        private System.Windows.Forms.Label lbCHUCHAY;
        private System.Windows.Forms.Panel pnCOCARO;
        private System.Windows.Forms.Timer tmCHUCHAY;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
    }
}

