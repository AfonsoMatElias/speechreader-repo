namespace SpeechReader
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SerialTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TestSerialBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LangComboBox = new System.Windows.Forms.ComboBox();
            this.RecordEverComboBox = new System.Windows.Forms.ComboBox();
            this.AutoSpeakComboBox = new System.Windows.Forms.ComboBox();
            this.SpeechSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.RootPathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.TopLeftPanel = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LoaderPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeechSpeedTrackBar)).BeginInit();
            this.TopBarPanel.SuspendLayout();
            this.TopLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.SerialTextBox);
            this.MainPanel.Controls.Add(this.TestSerialBtn);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.LangComboBox);
            this.MainPanel.Controls.Add(this.RecordEverComboBox);
            this.MainPanel.Controls.Add(this.AutoSpeakComboBox);
            this.MainPanel.Controls.Add(this.SpeechSpeedTrackBar);
            this.MainPanel.Controls.Add(this.ThemeComboBox);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.OpenBtn);
            this.MainPanel.Controls.Add(this.RootPathTextBox);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.ApplyBtn);
            this.MainPanel.Controls.Add(this.TopBarPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(392, 493);
            this.MainPanel.TabIndex = 0;
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SerialTextBox.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.SerialTextBox.ForeColor = System.Drawing.Color.Red;
            this.SerialTextBox.Location = new System.Drawing.Point(22, 417);
            this.SerialTextBox.Mask = "CCCCCCCC-CCCC-CCCC-CCCC-CCCCCCCCCCCC";
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.PasswordChar = '*';
            this.SerialTextBox.PromptChar = '$';
            this.SerialTextBox.Size = new System.Drawing.Size(308, 23);
            this.SerialTextBox.TabIndex = 28;
            this.SerialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SerialTextBox.UseSystemPasswordChar = true;
            // 
            // TestSerialBtn
            // 
            this.TestSerialBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.TestSerialBtn.BackgroundImage = global::SpeechReader.Properties.Resources.check;
            this.TestSerialBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TestSerialBtn.FlatAppearance.BorderSize = 0;
            this.TestSerialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestSerialBtn.ForeColor = System.Drawing.Color.White;
            this.TestSerialBtn.Location = new System.Drawing.Point(337, 416);
            this.TestSerialBtn.Name = "TestSerialBtn";
            this.TestSerialBtn.Size = new System.Drawing.Size(32, 23);
            this.TestSerialBtn.TabIndex = 9;
            this.TestSerialBtn.UseVisualStyleBackColor = false;
            this.TestSerialBtn.Click += new System.EventHandler(this.TestSerialBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Serial";
            // 
            // LangComboBox
            // 
            this.LangComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LangComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LangComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LangComboBox.Font = new System.Drawing.Font("Calibri", 11F);
            this.LangComboBox.Location = new System.Drawing.Point(22, 360);
            this.LangComboBox.MaxDropDownItems = 5;
            this.LangComboBox.Name = "LangComboBox";
            this.LangComboBox.Size = new System.Drawing.Size(346, 26);
            this.LangComboBox.TabIndex = 7;
            // 
            // RecordEverComboBox
            // 
            this.RecordEverComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RecordEverComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RecordEverComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordEverComboBox.Font = new System.Drawing.Font("Calibri", 11F);
            this.RecordEverComboBox.Location = new System.Drawing.Point(22, 123);
            this.RecordEverComboBox.MaxDropDownItems = 5;
            this.RecordEverComboBox.Name = "RecordEverComboBox";
            this.RecordEverComboBox.Size = new System.Drawing.Size(346, 26);
            this.RecordEverComboBox.TabIndex = 1;
            // 
            // AutoSpeakComboBox
            // 
            this.AutoSpeakComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoSpeakComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AutoSpeakComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoSpeakComboBox.Font = new System.Drawing.Font("Calibri", 11F);
            this.AutoSpeakComboBox.Location = new System.Drawing.Point(22, 302);
            this.AutoSpeakComboBox.MaxDropDownItems = 5;
            this.AutoSpeakComboBox.Name = "AutoSpeakComboBox";
            this.AutoSpeakComboBox.Size = new System.Drawing.Size(346, 26);
            this.AutoSpeakComboBox.TabIndex = 6;
            // 
            // SpeechSpeedTrackBar
            // 
            this.SpeechSpeedTrackBar.AutoSize = false;
            this.SpeechSpeedTrackBar.BackColor = System.Drawing.Color.White;
            this.SpeechSpeedTrackBar.Location = new System.Drawing.Point(25, 241);
            this.SpeechSpeedTrackBar.Name = "SpeechSpeedTrackBar";
            this.SpeechSpeedTrackBar.Size = new System.Drawing.Size(343, 25);
            this.SpeechSpeedTrackBar.TabIndex = 5;
            this.SpeechSpeedTrackBar.Scroll += new System.EventHandler(this.SpeechSpeedTrackBar_Scroll);
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ThemeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ThemeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeComboBox.Font = new System.Drawing.Font("Calibri", 11F);
            this.ThemeComboBox.Location = new System.Drawing.Point(22, 66);
            this.ThemeComboBox.MaxDropDownItems = 5;
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(346, 26);
            this.ThemeComboBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.ThemeComboBox, "Requer o reinicio do sistema para poder aplicar esta modifição!");
            this.ThemeComboBox.SelectionChangeCommitted += new System.EventHandler(this.ThemeComboBox_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lingua Padrão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gravar Sempre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Leitura Automática";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Velocidade da Fala";
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(124)))), ((int)(((byte)(181)))));
            this.OpenBtn.BackgroundImage = global::SpeechReader.Properties.Resources.folder;
            this.OpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBtn.Location = new System.Drawing.Point(336, 183);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(32, 23);
            this.OpenBtn.TabIndex = 4;
            this.toolTip.SetToolTip(this.OpenBtn, "Copie o caminho da pasta onde preferes que seja salvo as gravações.");
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // RootPathTextBox
            // 
            this.RootPathTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RootPathTextBox.Font = new System.Drawing.Font("Calibri", 10F);
            this.RootPathTextBox.Location = new System.Drawing.Point(22, 183);
            this.RootPathTextBox.Name = "RootPathTextBox";
            this.RootPathTextBox.Size = new System.Drawing.Size(308, 24);
            this.RootPathTextBox.TabIndex = 3;
            this.RootPathTextBox.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Caminho para Gravações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tema";
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ApplyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtn.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ApplyBtn.ForeColor = System.Drawing.Color.White;
            this.ApplyBtn.Location = new System.Drawing.Point(0, 457);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(390, 34);
            this.ApplyBtn.TabIndex = 10;
            this.ApplyBtn.Text = "Aplicar";
            this.ApplyBtn.UseVisualStyleBackColor = false;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopBarPanel.Controls.Add(this.TopLeftPanel);
            this.TopBarPanel.Controls.Add(this.LoaderPictureBox);
            this.TopBarPanel.Controls.Add(this.ExitBtn);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.TopBarPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(390, 26);
            this.TopBarPanel.TabIndex = 2;
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
            this.MainLabel.ForeColor = System.Drawing.Color.DimGray;
            this.MainLabel.Location = new System.Drawing.Point(40, 4);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(153, 18);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Configurações";
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
            // LoaderPictureBox
            // 
            this.LoaderPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoaderPictureBox.Location = new System.Drawing.Point(318, 0);
            this.LoaderPictureBox.Name = "LoaderPictureBox";
            this.LoaderPictureBox.Size = new System.Drawing.Size(35, 26);
            this.LoaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoaderPictureBox.TabIndex = 5;
            this.LoaderPictureBox.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ExitBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ExitBtn.Location = new System.Drawing.Point(353, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(37, 26);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "x";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*";
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 493);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeechSpeedTrackBar)).EndInit();
            this.TopBarPanel.ResumeLayout(false);
            this.TopLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.TextBox RootPathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.TrackBar SpeechSpeedTrackBar;
        private System.Windows.Forms.ComboBox AutoSpeakComboBox;
        private System.Windows.Forms.ComboBox RecordEverComboBox;
        private System.Windows.Forms.Button TestSerialBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox LangComboBox;
        private System.Windows.Forms.MaskedTextBox SerialTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox LoaderPictureBox;
        private System.Windows.Forms.Panel TopLeftPanel;
    }
}