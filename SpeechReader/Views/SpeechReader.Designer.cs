namespace SpeechReader
{
    partial class SpeechReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeechReader));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomPictureBox = new System.Windows.Forms.PictureBox();
            this.FunctionBarPanel = new System.Windows.Forms.Panel();
            this.VoicesComboBox = new System.Windows.Forms.ComboBox();
            this.BtnsPanel = new System.Windows.Forms.Panel();
            this.FolderBtn = new System.Windows.Forms.PictureBox();
            this.RecBtn = new System.Windows.Forms.PictureBox();
            this.ReadBtn = new System.Windows.Forms.PictureBox();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CogBtn = new System.Windows.Forms.PictureBox();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPictureBox)).BeginInit();
            this.FunctionBarPanel.SuspendLayout();
            this.BtnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.TopBarPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CogBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.FunctionBarPanel);
            this.MainPanel.Controls.Add(this.ContentTextBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.MainPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(864, 517);
            this.MainPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.BottomPanel.Controls.Add(this.statusStrip1);
            this.BottomPanel.Controls.Add(this.BottomPictureBox);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 492);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(862, 23);
            this.BottomPanel.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(93)))), ((int)(((byte)(115)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(30, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(27, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(10, 17);
            this.StatusLabel.Text = " ";
            // 
            // BottomPictureBox
            // 
            this.BottomPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.BottomPictureBox.Image = global::SpeechReader.Properties.Resources.min_loader_static;
            this.BottomPictureBox.Location = new System.Drawing.Point(0, 0);
            this.BottomPictureBox.Name = "BottomPictureBox";
            this.BottomPictureBox.Size = new System.Drawing.Size(35, 23);
            this.BottomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BottomPictureBox.TabIndex = 4;
            this.BottomPictureBox.TabStop = false;
            // 
            // FunctionBarPanel
            // 
            this.FunctionBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionBarPanel.Controls.Add(this.VoicesComboBox);
            this.FunctionBarPanel.Controls.Add(this.BtnsPanel);
            this.FunctionBarPanel.Controls.Add(this.SpeedTrackBar);
            this.FunctionBarPanel.Location = new System.Drawing.Point(3, 32);
            this.FunctionBarPanel.Name = "FunctionBarPanel";
            this.FunctionBarPanel.Size = new System.Drawing.Size(856, 32);
            this.FunctionBarPanel.TabIndex = 2;
            // 
            // VoicesComboBox
            // 
            this.VoicesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VoicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoicesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoicesComboBox.Font = new System.Drawing.Font("Calibri", 10F);
            this.VoicesComboBox.Location = new System.Drawing.Point(3, 5);
            this.VoicesComboBox.MaxDropDownItems = 5;
            this.VoicesComboBox.Name = "VoicesComboBox";
            this.VoicesComboBox.Size = new System.Drawing.Size(236, 23);
            this.VoicesComboBox.TabIndex = 1;
            this.VoicesComboBox.TabStop = false;
            this.VoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.VoicesComboBox_SelectedIndexChanged);
            // 
            // BtnsPanel
            // 
            this.BtnsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnsPanel.Controls.Add(this.FolderBtn);
            this.BtnsPanel.Controls.Add(this.RecBtn);
            this.BtnsPanel.Controls.Add(this.ReadBtn);
            this.BtnsPanel.Location = new System.Drawing.Point(376, 3);
            this.BtnsPanel.Name = "BtnsPanel";
            this.BtnsPanel.Size = new System.Drawing.Size(476, 28);
            this.BtnsPanel.TabIndex = 8;
            // 
            // FolderBtn
            // 
            this.FolderBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.FolderBtn.Image = global::SpeechReader.Properties.Resources.folder;
            this.FolderBtn.Location = new System.Drawing.Point(311, 0);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(55, 28);
            this.FolderBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FolderBtn.TabIndex = 11;
            this.FolderBtn.TabStop = false;
            this.FolderBtn.Visible = false;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            this.FolderBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseDown);
            this.FolderBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseUp);
            // 
            // RecBtn
            // 
            this.RecBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RecBtn.Image = global::SpeechReader.Properties.Resources.rec;
            this.RecBtn.Location = new System.Drawing.Point(366, 0);
            this.RecBtn.Name = "RecBtn";
            this.RecBtn.Size = new System.Drawing.Size(55, 28);
            this.RecBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecBtn.TabIndex = 10;
            this.RecBtn.TabStop = false;
            this.RecBtn.Click += new System.EventHandler(this.RecBtn_Click);
            this.RecBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseDown);
            this.RecBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseUp);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReadBtn.Image = global::SpeechReader.Properties.Resources.speak;
            this.ReadBtn.Location = new System.Drawing.Point(421, 0);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(55, 28);
            this.ReadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReadBtn.TabIndex = 9;
            this.ReadBtn.TabStop = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            this.ReadBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseDown);
            this.ReadBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseUp);
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SpeedTrackBar.AutoSize = false;
            this.SpeedTrackBar.Location = new System.Drawing.Point(248, 3);
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(129, 25);
            this.SpeedTrackBar.TabIndex = 2;
            this.toolTip.SetToolTip(this.SpeedTrackBar, "Velocidade de leitura");
            this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.AllowDrop = true;
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContentTextBox.Location = new System.Drawing.Point(3, 68);
            this.ContentTextBox.MaxLength = 50000000;
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentTextBox.Size = new System.Drawing.Size(856, 422);
            this.ContentTextBox.TabIndex = 0;
            this.ContentTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ContentTextBox_DragDrop);
            this.ContentTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ContentTextBox_DragEnter);
            this.ContentTextBox.DragOver += new System.Windows.Forms.DragEventHandler(this.ContentTextBox_DragOver);
            this.ContentTextBox.DragLeave += new System.EventHandler(this.ContentTextBox_DragLeave);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopBarPanel.Controls.Add(this.TopLeftPanel);
            this.TopBarPanel.Controls.Add(this.CogBtn);
            this.TopBarPanel.Controls.Add(this.MinBtn);
            this.TopBarPanel.Controls.Add(this.MaxBtn);
            this.TopBarPanel.Controls.Add(this.ExitBtn);
            this.TopBarPanel.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TopBarPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopBarPanel.Location = new System.Drawing.Point(1, 1);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(862, 26);
            this.TopBarPanel.TabIndex = 1;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            this.TopBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseMove);
            this.TopBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseUp);
            // 
            // TopLeftPanel
            // 
            this.TopLeftPanel.Controls.Add(this.MainLabel);
            this.TopLeftPanel.Controls.Add(this.LogoPictureBox);
            this.TopLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TopLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLeftPanel.Name = "TopLeftPanel";
            this.TopLeftPanel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.TopLeftPanel.Size = new System.Drawing.Size(200, 26);
            this.TopLeftPanel.TabIndex = 6;
            // 
            // MainLabel
            // 
            this.MainLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.DimGray;
            this.MainLabel.Location = new System.Drawing.Point(40, 4);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MainLabel.Size = new System.Drawing.Size(153, 18);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Speech Reader";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoPictureBox.Image = global::SpeechReader.Properties.Resources.document_512_0_5x;
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(40, 18);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 4;
            this.LogoPictureBox.TabStop = false;
            // 
            // CogBtn
            // 
            this.CogBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CogBtn.Image = global::SpeechReader.Properties.Resources.cog_min;
            this.CogBtn.Location = new System.Drawing.Point(710, 0);
            this.CogBtn.Name = "CogBtn";
            this.CogBtn.Size = new System.Drawing.Size(41, 26);
            this.CogBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CogBtn.TabIndex = 5;
            this.CogBtn.TabStop = false;
            this.CogBtn.Click += new System.EventHandler(this.CogBtn_Click);
            this.CogBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseDown);
            this.CogBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btns_MouseUp);
            // 
            // MinBtn
            // 
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.MinBtn.ForeColor = System.Drawing.Color.DimGray;
            this.MinBtn.Location = new System.Drawing.Point(751, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(37, 26);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.Text = "_";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Calibri", 7F);
            this.MaxBtn.ForeColor = System.Drawing.Color.DimGray;
            this.MaxBtn.Location = new System.Drawing.Point(788, 0);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(37, 26);
            this.MaxBtn.TabIndex = 1;
            this.MaxBtn.Text = "[  ]";
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ExitBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ExitBtn.Location = new System.Drawing.Point(825, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(37, 26);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "x";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.SystemColors.Control;
            this.toolTip.ForeColor = System.Drawing.Color.DimGray;
            // 
            // SpeechReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 517);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(864, 517);
            this.Name = "SpeechReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeechReader";
            this.Load += new System.EventHandler(this.SpeechReader_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPictureBox)).EndInit();
            this.FunctionBarPanel.ResumeLayout(false);
            this.BtnsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.TopBarPanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CogBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Panel FunctionBarPanel;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Panel BtnsPanel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox BottomPictureBox;
        private System.Windows.Forms.PictureBox FolderBtn;
        private System.Windows.Forms.PictureBox ReadBtn;
        private System.Windows.Forms.PictureBox CogBtn;
        private System.Windows.Forms.ComboBox VoicesComboBox;
        private System.Windows.Forms.PictureBox RecBtn;
        private System.Windows.Forms.Panel TopLeftPanel;
    }
}