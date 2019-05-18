using NAudio.Wave;
using System;
using System.IO;

namespace SpeechReader
{
    public class Recorder
    {
        // Redefine the capturer instance with a new instance of the LoopbackCapture class
        private WasapiLoopbackCapture CaptureInstance = null;
        // Redefine the audio writer instance with the given configuration
        WaveFileWriter RecordedAudioWriter = null;

        // The root path
        private string _root = "";

        // The software prefix name of the record
        private string _prefix = nameof(SpeechReader);

        public Recorder(string root = "records")
        {
            // Define the output wav file of the recorded audio
            _root = root + "\\";

            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);
        }

        private void CaptureInstance_RecordingStopped(object sender, StoppedEventArgs e)
        {
            RecordedAudioWriter.Dispose();
            RecordedAudioWriter = null;
            CaptureInstance.Dispose();
        }

        private void CaptureInstance_DataAvailable(object sender, WaveInEventArgs e)
        {
            // Write buffer into the file of the writer instance
            RecordedAudioWriter.Write(e.Buffer, 0, e.BytesRecorded);
        }

        public void StartRecording(string name = "")
        {
            name = DateTime.Now.ToString() + "_" + _prefix + name + ".wav";

            // Replacing the danger characters
            name = name.ReplaceAllChars('/','-').ReplaceAllChars(':', '-');
            // End Replacing the danger characters

            CaptureInstance = new WasapiLoopbackCapture();

            // Redefine the audio writer instance with the given configuration
            RecordedAudioWriter = new WaveFileWriter(_root + name, CaptureInstance.WaveFormat);

            // When the capturer receives audio, start writing the buffer into the mentioned file
            CaptureInstance.DataAvailable += CaptureInstance_DataAvailable;

            // When the Capturer Stops, dispose instances of the capturer and writer
            CaptureInstance.RecordingStopped += CaptureInstance_RecordingStopped;

            // Start audio recording !
            CaptureInstance.StartRecording();
        }

        public void StopRecording()
        {
            // Stop audio recording !
            CaptureInstance.StopRecording();
            RecordedAudioWriter.Close();
        }

        public void SetRoot(string v) { _root = v + "\\"; }
    }
}
