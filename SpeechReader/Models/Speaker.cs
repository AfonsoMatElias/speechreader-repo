using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Speech.Synthesis;

namespace SpeechReader
{
    public class Speaker
    {
        private SpeechSynthesizer _speak = null;
        private Prompt _prompt = null;
        public IReadOnlyCollection<InstalledVoice> _voices = new List<InstalledVoice>();
        public int _speed => _speak.Rate; 

        public Speaker()
        {
            _speak = new SpeechSynthesizer();
            _speak.SpeakStarted += _speak_SpeakStarted;
            _speak.SpeakCompleted += _speak_SpeakCompleted;
            _voices = _speak.GetInstalledVoices();

        }

        public void SetVoice(string v)
        {
            try
            {
                _speak.SelectVoice(v);
            }
            catch (Exception ex)
            { Debugger.Log(0, "Setting Voice Error", ex.Message); }
        }

        public int SetSpeed(int v)
        {
            try
            {
                _speak.Rate = v;
                return v;
            }
            catch (Exception ex)
            { Debugger.Log(0, "Setting Speed Error", ex.Message); }
            return 0;
        }

        public void StartSpeaking(string v)
        {

            if (v == null || v.Trim() == "")
                return;

            try
            {
                _prompt = new Prompt(v);
                _speak.SpeakAsync(_prompt);
            }
            catch (Exception ex)
            { Debugger.Log(0, "Speaking Error", ex.Message); }
            
        }

        public void StopSpeaking()
        {
            try
            {
                _speak.SpeakAsyncCancel(_prompt);
            }
            catch (Exception ex)
            { Debugger.Log(0, "Voice Selection", ex.Message); }
        }

        public void _speak_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            Debugger.Log(0, "Note", "Speaking Done");
            SpeechReader.Completed();
        }

        public void _speak_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            Debugger.Log(0, "Note", "Speaking started");
            SpeechReader.Started();
        }


    }
}
