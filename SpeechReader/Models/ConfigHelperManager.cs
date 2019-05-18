using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;

namespace SpeechReader
{
    public static class ConfigHelperManager
    {
        // Config folder name
        static string folder = AppDomain.CurrentDomain.BaseDirectory + "config";

        // Config file path
        static string filePath = folder + "/" + ".configd.sr";

        // Config bin file path
        static string filePathSerial = folder + "/" + ".bin.sr";

        public static bool IsConfig()
        {

            try
            {
                // Reset program
                if(!GetValue(".configd.sr", "User").ToString().Equals(System.Security.Principal.WindowsIdentity.GetCurrent().Name))
                    ResetConfig();
                

                // Checking if the folder doesn't exists
                if (!Directory.Exists(folder))
                    // Creating the folder
                    Directory.CreateDirectory(folder);

                // Checking if the config file exits
                if (!File.Exists(filePath))
                {
                    // Creating the config structer
                    JObject settings = new JObject(
                        new JProperty("User", System.Security.Principal.WindowsIdentity.GetCurrent().Name),
                        new JProperty("Theme", new JArray("Claro", "Escuro")),
                        new JProperty("RecordEver", new JArray(true, false)),
                        new JProperty("RecordPath", AppDomain.CurrentDomain.BaseDirectory + "records"),
                        new JProperty("SpeechSpeed", 4),
                        new JProperty("AutoRead", new JArray(true, false)),
                        new JProperty("DefaultLang", new JArray(SpeechReader._voices.ToArray())));

                    // Creating the file in the folder
                    File.WriteAllText(filePath, Encryptor.Encrypt(settings.ToString()));


                    File.WriteAllText(filePathSerial, Encryptor.Encrypt(new JObject(
                        new JProperty("Serial", "10000000-0000-0000-0000-000000000001"),
                        new JProperty("Date", DateTime.Now.ToString())).ToString()));

                    return true;

                }
            }
            catch (Exception ex) { Logger.LogError("Error: " + ex.Message); }

            Console.WriteLine("Erro: O software não foi capaz de criar os ficheiros de configurações. \n" +
                "Por favor contacte o suporte +244 915 997 790 / Afonsomatumona@hotmail.com.\n" +
                "Agradeço pela preferecia.");

            // Returning true, something is not right
            return false;

        }

        public static bool CreateSRConfig(string theme, bool rEver, string recPath, int speed, bool aRead,string lang)
        {

            try
            {
                // Config file path
                var _filePath = folder + "/" + ".config.sr";

                // Creating the config structer
                JObject settings = new JObject(
                    new JProperty("Theme", theme),
                    new JProperty("RecordEver", rEver),
                    new JProperty("RecordPath", recPath),
                    new JProperty("SpeechSpeed", speed),
                    new JProperty("AutoRead", aRead),
                    new JProperty("DefaultLang", lang));

                // Creating the file in the folder
                File.WriteAllText(_filePath, Encryptor.Encrypt(settings.ToString()));

                return true;

            }
            catch (Exception ex) { Logger.LogError("Error: " + ex.Message); }

            return true;

        }

        public static void CreateMySerial(string serial)
        {
            try
            {
                File.WriteAllText(folder + "/.bin.me.sr", Encryptor.Encrypt(new JObject(
                        new JProperty("Serial", serial),
                        new JProperty("Date", DateTime.Now.ToString())).ToString()));
            }
            catch (Exception ex )
            { Logger.LogError("Error: " + ex.Message); }
        }

        public static JToken GetValue(string configFile, string name)
        {

            configFile = folder + "/" + configFile;

            try
            {
                // Checking if the file exists 
                if (File.Exists(configFile))
                {
                    // Getting the result from reading
                    var result = File.ReadAllText(configFile);

                    // Converting it to JObject
                    var _settings = JObject.Parse(Encryptor.Decrypt(result));

                    // Returning the value
                    return _settings.SelectToken(name);

                }
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); Console.ReadLine(); }

            return "";

        }

        public static bool CheckSerial(string s)
        {
            return GetValue(".bin.sr", "Serial").ToString().Equals(s);
        }

        public static void ResetConfig()
        {
            if(Directory.Exists(folder))
                foreach (var files in Directory.GetFiles(folder))
                {
                    if(File.Exists(files))
                        File.Delete(files);
                }
        }

    }
}
