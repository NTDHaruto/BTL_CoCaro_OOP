namespace Demo_Caro
{
    partial class frmMP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMP3));
            this.btPREVIEW = new System.Windows.Forms.Button();
            this.btNEXT = new System.Windows.Forms.Button();
            this.btPLAY = new System.Windows.Forms.Button();
            this.btPAUSE = new System.Windows.Forms.Button();
            this.btSTOP = new System.Windows.Forms.Button();
            this.btOPEN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_List = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVOLUME = new System.Windows.Forms.Label();
            this.lbTRACKSTART = new System.Windows.Forms.Label();
            this.lbENDTRACK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgTIMING = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btPREVIEW
            // 
            this.btPREVIEW.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPREVIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPREVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPREVIEW.ForeColor = System.Drawing.SystemColors.Info;
            this.btPREVIEW.Location = new System.Drawing.Point(12, 383);
            this.btPREVIEW.Name = "btPREVIEW";
            this.btPREVIEW.Size = new System.Drawing.Size(119, 55);
            this.btPREVIEW.TabIndex = 0;
            this.btPREVIEW.Text = "Preview";
            this.btPREVIEW.UseVisualStyleBackColor = false;
            this.btPREVIEW.Click += new System.EventHandler(this.btPREVIEW_Click);
            // 
            // btNEXT
            // 
            this.btNEXT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNEXT.ForeColor = System.Drawing.SystemColors.Info;
            this.btNEXT.Location = new System.Drawing.Point(137, 383);
            this.btNEXT.Name = "btNEXT";
            this.btNEXT.Size = new System.Drawing.Size(119, 55);
            this.btNEXT.TabIndex = 1;
            this.btNEXT.Text = "Next";
            this.btNEXT.UseVisualStyleBackColor = false;
            this.btNEXT.Click += new System.EventHandler(this.btNEXT_Click);
            // 
            // btPLAY
            // 
            this.btPLAY.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPLAY.ForeColor = System.Drawing.SystemColors.Info;
            this.btPLAY.Location = new System.Drawing.Point(262, 383);
            this.btPLAY.Name = "btPLAY";
            this.btPLAY.Size = new System.Drawing.Size(119, 55);
            this.btPLAY.TabIndex = 2;
            this.btPLAY.Text = "Play";
            this.btPLAY.UseVisualStyleBackColor = false;
            this.btPLAY.Click += new System.EventHandler(this.btPLAY_Click);
            // 
            // btPAUSE
            // 
            this.btPAUSE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPAUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPAUSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPAUSE.ForeColor = System.Drawing.SystemColors.Info;
            this.btPAUSE.Location = new System.Drawing.Point(387, 383);
            this.btPAUSE.Name = "btPAUSE";
            this.btPAUSE.Size = new System.Drawing.Size(119, 55);
            this.btPAUSE.TabIndex = 3;
            this.btPAUSE.Text = "Pause";
            this.btPAUSE.UseVisualStyleBackColor = false;
            this.btPAUSE.Click += new System.EventHandler(this.btPAUSE_Click);
            // 
            // btSTOP
            // 
            this.btSTOP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSTOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSTOP.ForeColor = System.Drawing.SystemColors.Info;
            this.btSTOP.Location = new System.Drawing.Point(512, 383);
            this.btSTOP.Name = "btSTOP";
            this.btSTOP.Size = new System.Drawing.Size(119, 55);
            this.btSTOP.TabIndex = 4;
            this.btSTOP.Text = "Stop";
            this.btSTOP.UseVisualStyleBackColor = false;
            this.btSTOP.Click += new System.EventHandler(this.btSTOP_Click);
            // 
            // btOPEN
            // 
            this.btOPEN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btOPEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOPEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOPEN.ForeColor = System.Drawing.SystemColors.Info;
            this.btOPEN.Location = new System.Drawing.Point(637, 383);
            this.btOPEN.Name = "btOPEN";
            this.btOPEN.Size = new System.Drawing.Size(119, 55);
            this.btOPEN.TabIndex = 5;
            this.btOPEN.Text = "Open";
            this.btOPEN.UseVisualStyleBackColor = false;
            this.btOPEN.Click += new System.EventHandler(this.btOPEN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo_Caro.Properties.Resources.tainghe;
            this.pictureBox1.Location = new System.Drawing.Point(11, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // wmp1
            // 
            this.wmp1.Enabled = true;
            this.wmp1.Location = new System.Drawing.Point(1, 1);
            this.wmp1.Name = "wmp1";
            this.wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp1.OcxState")));
            this.wmp1.Size = new System.Drawing.Size(800, 157);
            this.wmp1.TabIndex = 6;
            // 
            // track_List
            // 
            this.track_List.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.track_List.ForeColor = System.Drawing.SystemColors.Info;
            this.track_List.FormattingEnabled = true;
            this.track_List.ItemHeight = 16;
            this.track_List.Location = new System.Drawing.Point(220, 0);
            this.track_List.Name = "track_List";
            this.track_List.Size = new System.Drawing.Size(505, 196);
            this.track_List.TabIndex = 8;
            this.track_List.SelectedIndexChanged += new System.EventHandler(this.track_List_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar1.Location = new System.Drawing.Point(731, 19);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 174);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(728, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume";
            // 
            // lbVOLUME
            // 
            this.lbVOLUME.AutoSize = true;
            this.lbVOLUME.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbVOLUME.ForeColor = System.Drawing.SystemColors.Info;
            this.lbVOLUME.Location = new System.Drawing.Point(728, 0);
            this.lbVOLUME.Name = "lbVOLUME";
            this.lbVOLUME.Size = new System.Drawing.Size(33, 16);
            this.lbVOLUME.TabIndex = 11;
            this.lbVOLUME.Text = "50%";
            // 
            // lbTRACKSTART
            // 
            this.lbTRACKSTART.AutoSize = true;
            this.lbTRACKSTART.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTRACKSTART.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTRACKSTART.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTRACKSTART.Location = new System.Drawing.Point(27, 9);
            this.lbTRACKSTART.Name = "lbTRACKSTART";
            this.lbTRACKSTART.Size = new System.Drawing.Size(142, 45);
            this.lbTRACKSTART.TabIndex = 12;
            this.lbTRACKSTART.Text = "00 : 00";
            // 
            // lbENDTRACK
            // 
            this.lbENDTRACK.AutoSize = true;
            this.lbENDTRACK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbENDTRACK.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbENDTRACK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbENDTRACK.Location = new System.Drawing.Point(614, 9);
            this.lbENDTRACK.Name = "lbENDTRACK";
            this.lbENDTRACK.Size = new System.Drawing.Size(142, 45);
            this.lbENDTRACK.TabIndex = 13;
            this.lbENDTRACK.Text = "00 : 00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.track_List);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pgTIMING);
            this.panel1.Controls.Add(this.lbVOLUME);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(1, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 296);
            this.panel1.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgTIMING
            // 
            this.pgTIMING.Location = new System.Drawing.Point(11, 202);
            this.pgTIMING.Name = "pgTIMING";
            this.pgTIMING.Size = new System.Drawing.Size(714, 23);
            this.pgTIMING.TabIndex = 15;
            this.pgTIMING.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pgTIMING_MouseDown);
            // 
            // frmMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbENDTRACK);
            this.Controls.Add(this.lbTRACKSTART);
            this.Controls.Add(this.btOPEN);
            this.Controls.Add(this.btSTOP);
            this.Controls.Add(this.btPAUSE);
            this.Controls.Add(this.btPLAY);
            this.Controls.Add(this.btNEXT);
            this.Controls.Add(this.btPREVIEW);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wmp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMP3";
            this.Text = "MP3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMP3_FormClosed);
            this.Load += new System.EventHandler(this.frmMP3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPREVIEW;
        private System.Windows.Forms.Button btNEXT;
        private System.Windows.Forms.Button btPLAY;
        private System.Windows.Forms.Button btPAUSE;
        private System.Windows.Forms.Button btSTOP;
        private System.Windows.Forms.Button btOPEN;
        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox track_List;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbVOLUME;
        private System.Windows.Forms.Label lbTRACKSTART;
        private System.Windows.Forms.Label lbENDTRACK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgTIMING;
    }
}