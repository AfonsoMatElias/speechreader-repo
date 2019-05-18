
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SpeechReader
{
    public partial class Settings : Form
    {
        private bool IsAppRestart = false;
        public static Settings Instance = null;
        // Helper to check if the theme is dark
        public static bool IsDark = false;

        public Settings()
        {
            InitializeComponent();
            Instance = this;
        }

        #region TopBar Mouse Events

        private int _mX = 0;
        private int _mY = 0;
        private bool _dragging = false;

        #region Main Form Actions

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Dispose();
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.ForeColor = Color.DimGray;
        }

        private void ExitBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ExitBtn.ForeColor = Color.White;
        }

        #endregion

        private void TopBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Setting the position value to the var
            _mX = Cursor.Position.X - this.Left;
            // Setting the position value to the var
            _mY = Cursor.Position.Y - this.Top;
            // Signing that is dragging
            _dragging = true;
        }

        private void TopBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // Signing that drag stopped
            _dragging = false;
        }

        private void TopBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Checking if is dragging
            if (_dragging)
            {
                // Setting the component position
                this.Left = Cursor.Position.X - _mX;
                this.Top = Cursor.Position.Y - _mY;
            }
        }

        #endregion

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            // Starting loader
            LoaderPictureBox.Image = global::SpeechReader.Properties.Resources.min_loader;

            // Getting the path 
            var val = RootPathTextBox.Text.Trim() != "" ? RootPathTextBox.Text : ConfigHelperManager.GetValue(".configd.sr", "RecordPath").ToString();

            var rEver = "";
            if (RecordEverComboBox.SelectedItem != null)
                rEver = (string)RecordEverComboBox.SelectedItem;

            var auto = "";
            if (AutoSpeakComboBox.SelectedItem != null)
                auto = (string)AutoSpeakComboBox.SelectedItem;

            var lang = LangComboBox.SelectedItem;

            // Creating the config file
            ConfigHelperManager.CreateSRConfig(
                ThemeComboBox.SelectedItem.ToString(),
                rEver == "True" ? true : false,
                val,
                SpeechSpeedTrackBar.Value,
                auto == "True" ? true : false,
                lang != null ? lang.ToString() : "");

            // Setting the ui
            SpeechReader.Instance.SetUIRootPath(val);

            // Check to restart
            if(IsAppRestart)
                Application.Restart();

            // Dispose
            this.Dispose();

        }

        private void Settings_Load(object sender, EventArgs e)
        {

            /* Default Value */
            // TODO:

            // Looping the results
            foreach (var item in ConfigHelperManager.GetValue(".configd.sr", "Theme").AsJEnumerable())
                ThemeComboBox.Items.Add(item.ToString());
            ThemeComboBox.SelectedItem = ConfigHelperManager.GetValue(".config.sr", "Theme").ToString();

            // Looping the results
            foreach (var item in ConfigHelperManager.GetValue(".configd.sr", "RecordEver").AsJEnumerable())
                RecordEverComboBox.Items.Add(item.ToString());
            RecordEverComboBox.SelectedItem = ConfigHelperManager.GetValue(".config.sr", "RecordEver").ToString();

            // Setting the default value
            var val1 = ConfigHelperManager.GetValue(".config.sr", "RecordPath").ToString();
            RootPathTextBox.Text = val1 != "" ? val1 : ConfigHelperManager.GetValue(".configd.sr", "RecordPath").ToString();

            // Looping the results
            foreach (var item in ConfigHelperManager.GetValue(".configd.sr", "AutoRead").AsJEnumerable())
                AutoSpeakComboBox.Items.Add(item.ToString());
            AutoSpeakComboBox.SelectedItem = ConfigHelperManager.GetValue(".config.sr", "AutoRead").ToString();

            foreach (var item in ConfigHelperManager.GetValue(".configd.sr", "DefaultLang").AsJEnumerable())
                LangComboBox.Items.Add(item.ToString());
            // Setting the default value
            LangComboBox.SelectedItem = ConfigHelperManager.GetValue(".config.sr", "DefaultLang").ToString();

            // Setting value
            var val2 = ConfigHelperManager.GetValue(".config.sr", "SpeechSpeed").ToString();
            SpeechSpeedTrackBar.Value = val2 != "" ? int.Parse(val2) : ConfigHelperManager.GetValue(".configd.sr", "SpeechSpeed").ToObject<int>();

            // Setting the default value
            SerialTextBox.ForeColor = ConfigHelperManager.CheckSerial(ConfigHelperManager.GetValue(".bin.me.sr", "Serial").ToString()) ? Color.Green : Color.Red;

            // Getting and setting the value from config
            if (ConfigHelperManager.GetValue(".config.sr", "Theme").ToString() == "Escuro")
                IsDark = this.BlackTheme(new PictureBox());

            ApplyBtn.Focus();

        }

        private void TestSerialBtn_Click(object sender, EventArgs e)
        {
            ConfigHelperManager.CreateMySerial(SerialTextBox.Text);

            SerialTextBox.ForeColor = ConfigHelperManager.CheckSerial(ConfigHelperManager.GetValue(".bin.me.sr", "Serial").ToString()) ? Color.Green : Color.Red;

        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            // Getting the current path
            var path = ConfigHelperManager.GetValue(".config.sr", "RecordPath").ToString();
            // Getting the default path
            var defaultPath = ConfigHelperManager.GetValue(".configd.sr", "RecordPath").ToString();

            // Checking if the paths are the same
            if (path == "")
                path = defaultPath;

            Process.Start("explorer.exe", path);
        }

        private void SpeechSpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            // Setting the value on main ui
            SpeechReader.Instance.SetUISpeed(SpeechSpeedTrackBar.Value);
        }

        private void ThemeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IsAppRestart = !IsAppRestart ? true : false;
            ApplyBtn.FlatAppearance.BorderColor = IsAppRestart ? Color.Red : Color.FromArgb(49, 175, 145);
        }
    }
}
