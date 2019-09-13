using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechReader
{
    public partial class SpeechReader : Form
    {

        #region Main Attributes

        // Helper to access this instanced class or obj
        public static SpeechReader Instance = null;
        // Helper to check if it must record
        private bool _recOn = false;
        // Helper to check if its recording 
        private bool _recording = false;
        // Helper to check if its reading
        private bool _reading = false;
        // Helper to store the current rec img 
        private Image _imgStored = null;
        // The Synthesis
        private Speaker _speaker = null;
        // The Recorder
        private Recorder _recorder = null;
        // Helper to check if the theme is dark
        public static bool IsDark = false;
        public static int StartTextPosition { get; set; } = 0;

        public static List<string> _voices = new List<string>();

        #endregion

        #region Default Constructor

        public SpeechReader()
        {

            InitializeComponent();
            Instance = this;

        }

        #endregion

        #region Main Software Actions

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            // Checking if is not recording
            if (!_reading)
            {
                var text = ContentTextBox.Text;

                if (ContentTextBox.SelectionLength > 0)
                {
                    StartTextPosition = text.IndexOf(ContentTextBox.SelectedText);
                    text = ContentTextBox.SelectedText;
                }

                _speaker.StartSpeaking(text);
                BeginReading();
            }
            else
            {
                _speaker.StopSpeaking();
                EndReading();
            }
        }

        private void RecBtn_Click(object sender, EventArgs e)
        {
            RecBtn_Click_Helper();
        }

        public void RecBtn_Click_Helper()
        {
            if (_reading)
                return;

            // Checking if is not signed to record
            if (!_recOn)
            {
                // Signing that it must record
                _recOn = true;

                // Setting the img to record checked img
                RecBtn.Image = global::SpeechReader.Properties.Resources.rec_check;

                // Enabling the rec function btns
                Show_HideRecFunctionBtns(_recOn);
            }
            else
            {
                // Signing not to record
                _recOn = false;

                // Setting img to not record one
                RecBtn.Image = global::SpeechReader.Properties.Resources.rec;

                // Enabling the rec function btns
                Show_HideRecFunctionBtns(_recOn);
            }
        }

        private void FolderBtn_Click(object sender, EventArgs e)
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

        private void Btns_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void Btns_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = IsDark ? ContentTextBox.BackColor : Color.WhiteSmoke;
        }

        private void CogBtn_Click(object sender, EventArgs e)
        {
            // Checking if the is already an instance
            if (Settings.Instance == null)
            {
                // Initializind
                var form = new Settings();
                // Showing the form
                form.Show();
            }
            else
            {
                // Setting the focus on opened form
                Settings.Instance.Focus();
            }
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            SetUISpeed(SpeedTrackBar.Value);
        }

        private void SpeechReader_Load(object sender, EventArgs e)
        {
            /* Speaker Initialization */

            // Enable loader
            this.Loading(true);

            // Setting text
            this.StatusText("Inicializando...");

            _speaker = new Speaker();

            foreach (var item in _speaker._voices)
                _voices.Add(item.VoiceInfo.Name);

            // Checking if there is an config file to initialized the software
            ConfigHelperManager.IsConfig();

            // Getting and setting the value from config
            var speed = ConfigHelperManager.GetValue(".config.sr", "SpeechSpeed").ToString();

            // Checking if is valid
            if (speed == "")
                // Signing the default value
                speed = ConfigHelperManager.GetValue(".configd.sr", "SpeechSpeed").ToString();

            // Getting and setting the value from config
            if (ConfigHelperManager.GetValue(".config.sr", "RecordEver").ToString() == "True")
                RecBtn_Click_Helper();

            // Getting and setting the value from config
            if (ConfigHelperManager.GetValue(".config.sr", "Theme").ToString() == "Escuro")
                IsDark = this.BlackTheme(CogBtn);

            // Setting the value
            SpeedTrackBar.Value = _speaker.SetSpeed(int.Parse(speed));

            VoicesComboBox.Items.AddRange(_voices.ToArray());
            VoicesComboBox.SelectedItem = ConfigHelperManager.GetValue(".config.sr", "DefaultLang").ToString();
            _speaker.SetVoice((string)VoicesComboBox.SelectedItem);

            ContentTextBox.Focus();

            // Setting text
            this.StatusText("Inicializado.");

            // Enable loader
            this.Loading(false);

            // Setting text
            this.StatusText("");

            /* Recorder Initialization */
            var val1 = ConfigHelperManager.GetValue(".config.sr", "RecordPath").ToString();
            val1 = val1 == "" ? ConfigHelperManager.GetValue(".configd.sr", "RecordPath").ToString() : val1;
            _recorder = new Recorder(val1);

        }

        private void VoicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _speaker.SetVoice((string)VoicesComboBox.SelectedItem);
        }

        #endregion

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

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.ForeColor = IsDark ? Color.WhiteSmoke : Color.DimGray;
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

        #region Helpers

        public void MarkReadingText(int s, int l) {

            ContentTextBox.Select(s, l);
        }

        public void Loading(bool b)
        {

            if (b)
                // Setting the animated loader
                BottomPictureBox.Image = global::SpeechReader.Properties.Resources.min_loader;
            else
                // Setting the static loader
                BottomPictureBox.Image = global::SpeechReader.Properties.Resources.min_loader_static;
        }

        public void StatusText(string v)
        {
            StatusLabel.Text = v;
        }

        public void Show_HideRecFunctionBtns(bool b)
        {
            //Applying the b value to the btns
            FolderBtn.Visible = b;
        }

        public void AddVoices(string v)
        {
            VoicesComboBox.Items.Add(v);
        }

        public void BeginReading()
        {
            // Storing the older img of the rec button
            _imgStored = RecBtn.Image;

            // Signing that is reading
            _reading = true;

            // Checking if the record btn is check to record
            if (_recOn)
            {
                // Setting the rec btn img to is recording img
                RecBtn.Image = global::SpeechReader.Properties.Resources.rec_check_recording;

                // Signing that is recording
                _recording = true;

                // Start recording
                _recorder.StartRecording();

            }

            // Enable loader
            this.Loading(true);

            // Setting text
            this.StatusText("Lendo...");
        }

        public void EndReading()
        {
            StartTextPosition = 0;
            // Signing that read stopped 
            _reading = false;

            if (_recording)
                _recorder.StopRecording();

            // Signing that record stopped 
            _recording = false;

            // Restoring the old img
            RecBtn.Image = _imgStored;

            // Enable loader
            this.Loading(false);

            // Setting text
            this.StatusText("");
        }

        public void SetUISpeed(int v)
        {
            SpeedTrackBar.Value = v;
            _speaker.SetSpeed(v);
        }

        public static void Completed()
        {

            var _obj = typeof(SpeechReader);
            var action = _obj.GetMethod("EndReading");
            action.Invoke(Instance, null);
        }

        public static void Started()
        {
            //var _obj = typeof(SpeechReader);
            //var action = _obj.GetMethod("Loading");
            //action.Invoke(Instance, new object[] { true });
        }

        public void SetUIRootPath(string v) => _recorder.SetRoot(v);

        #endregion

        #region Drag and Drop Zone

        private void ContentTextBox_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void ContentTextBox_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void ContentTextBox_DragLeave(object sender, EventArgs e)
        {

        }

        private void ContentTextBox_DragOver(object sender, DragEventArgs e)
        {

        }

        #endregion
    }
}
