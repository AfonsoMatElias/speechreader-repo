using System;
using System.IO;

namespace SpeechReader
{
    public static class Logger
    {
        static string folder = AppDomain.CurrentDomain.BaseDirectory + "log";
        public static void LogError(string txt)
        {
            // Checking if the folder doesn't exists
            if (!Directory.Exists(folder))
                // Creating the folder
                Directory.CreateDirectory(folder);
            
            //Getting the date
            var date = DateTime.Now.ToString();
            //Building the file name
            var fileName = "Log_Error - " + DateTime.Now.ToShortDateString().ReplaceAllChars('/', '-') + ".txt";

            //Creating a log
            File.AppendAllText(folder + "/" + fileName, $"[{date}]: {txt}");
        }

        public static void Log(string txt)
        {
            // Checking if the folder doesn't exists
            if (!Directory.Exists(folder))
                // Creating the folder
                Directory.CreateDirectory(folder);

            //Getting the date
            var date = DateTime.Now.ToString();
            //Building the file name
            var fileName = "Log - " + DateTime.Now.ToShortDateString().ReplaceAllChars('/', '-') + ".txt";

            //Creating a log
            File.AppendAllText(folder + "/" + fileName, $"[{date}]: {txt}");
        }

    }
}
