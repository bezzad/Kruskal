namespace Kruskal_Graphs
{
    partial class FormK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormK));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStriptxtNumEdge = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSolve = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnClean = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Click to ...";
            // 
            // toolStrip
            // 
            this.toolStrip.AllowItemReorder = true;
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.CanOverflow = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriptxtNumEdge,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripBtnSolve,
            this.toolStripBtnClean,
            this.toolStripBtnHelp,
            this.toolStripBtnAbout,
            this.toolStripBtnExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(557, 58);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 3;
            this.toolStrip.TabStop = true;
            // 
            // toolStriptxtNumEdge
            // 
            this.toolStriptxtNumEdge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStriptxtNumEdge.AutoToolTip = true;
            this.toolStriptxtNumEdge.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStriptxtNumEdge.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStriptxtNumEdge.MaxLength = 3;
            this.toolStriptxtNumEdge.Name = "toolStriptxtNumEdge";
            this.toolStriptxtNumEdge.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStriptxtNumEdge.Size = new System.Drawing.Size(100, 58);
            this.toolStriptxtNumEdge.Tag = "1";
            this.toolStriptxtNumEdge.Text = "Number of Edge";
            this.toolStriptxtNumEdge.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStriptxtNumEdge.ToolTipText = "Enter Number Of Edge in Original Graph\r\nThen Press Enter Key!";
            this.toolStriptxtNumEdge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStriptxtNumEdge_KeyDown);
            this.toolStriptxtNumEdge.MouseLeave += new System.EventHandler(this.toolStriptxtNumEdge_MouseLeave);
            this.toolStriptxtNumEdge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStriptxtNumEdge_KeyPress);
            this.toolStriptxtNumEdge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStriptxtNumEdge_KeyUp);
            this.toolStriptxtNumEdge.TextChanged += new System.EventHandler(this.toolStriptxtNumEdge_TextChanged);
            this.toolStriptxtNumEdge.Click += new System.EventHandler(this.toolStriptxtNumEdge_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripBtnSolve
            // 
            this.toolStripBtnSolve.AutoSize = false;
            this.toolStripBtnSolve.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnSolve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSolve.BackgroundImage")));
            this.toolStripBtnSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripBtnSolve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSolve.DoubleClickEnabled = true;
            this.toolStripBtnSolve.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSolve.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripBtnSolve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSolve.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripBtnSolve.Name = "toolStripBtnSolve";
            this.toolStripBtnSolve.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBtnSolve.Size = new System.Drawing.Size(80, 55);
            this.toolStripBtnSolve.Text = "&Solve";
            this.toolStripBtnSolve.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnSolve.ToolTipText = "Go to Solve Graph";
            this.toolStripBtnSolve.Click += new System.EventHandler(this.toolStripBtnSolve_Click);
            // 
            // toolStripBtnClean
            // 
            this.toolStripBtnClean.AutoSize = false;
            this.toolStripBtnClean.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripBtnClean.BackgroundImage")));
            this.toolStripBtnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripBtnClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnClean.DoubleClickEnabled = true;
            this.toolStripBtnClean.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnClean.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripBtnClean.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripBtnClean.Name = "toolStripBtnClean";
            this.toolStripBtnClean.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBtnClean.Size = new System.Drawing.Size(80, 55);
            this.toolStripBtnClean.Text = "&Clear All";
            this.toolStripBtnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnClean.ToolTipText = "Go to Clean All Textbox";
            this.toolStripBtnClean.Click += new System.EventHandler(this.toolStripBtnClean_Click);
            // 
            // toolStripBtnHelp
            // 
            this.toolStripBtnHelp.AutoSize = false;
            this.toolStripBtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHelp.BackgroundImage")));
            this.toolStripBtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnHelp.DoubleClickEnabled = true;
            this.toolStripBtnHelp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripBtnHelp.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripBtnHelp.Name = "toolStripBtnHelp";
            this.toolStripBtnHelp.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBtnHelp.Size = new System.Drawing.Size(80, 55);
            this.toolStripBtnHelp.Text = "&Help";
            this.toolStripBtnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnHelp.ToolTipText = "Go to Help of Krustkal\'s Algorithm";
            this.toolStripBtnHelp.Click += new System.EventHandler(this.toolStripBtnHelp_Click);
            // 
            // toolStripBtnAbout
            // 
            this.toolStripBtnAbout.AutoSize = false;
            this.toolStripBtnAbout.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAbout.BackgroundImage")));
            this.toolStripBtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripBtnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAbout.DoubleClickEnabled = true;
            this.toolStripBtnAbout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnAbout.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripBtnAbout.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripBtnAbout.Name = "toolStripBtnAbout";
            this.toolStripBtnAbout.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBtnAbout.Size = new System.Drawing.Size(80, 55);
            this.toolStripBtnAbout.Text = "&About";
            this.toolStripBtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnAbout.ToolTipText = "Go to About Program";
            this.toolStripBtnAbout.Click += new System.EventHandler(this.toolStripBtnAbout_Click);
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.AutoSize = false;
            this.toolStripBtnExit.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExit.BackgroundImage")));
            this.toolStripBtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripBtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnExit.DoubleClickEnabled = true;
            this.toolStripBtnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripBtnExit.Size = new System.Drawing.Size(80, 55);
            this.toolStripBtnExit.Text = "E&xit";
            this.toolStripBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripBtnExit.ToolTipText = "Exit";
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AllowDrop = true;
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 63);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = resources.GetString("lblTitle.Text");
            // 
            // FormK
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 554);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kruskal Graphs";
            this.Load += new System.EventHandler(this.FormK_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.ToolStripTextBox toolStriptxtNumEdge;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnSolve;
        private System.Windows.Forms.ToolStripButton toolStripBtnClean;
        private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripBtnAbout;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.Label lblTitle;
    }
}

