using System;
using System.IO;

namespace AdvancementsTracker
{
    public static class Preferences
    {
        private const char   DELIMITER            = '=';
        private const string SETTINGS_FILE        = "preferences.ini";
        private const string KEY_REFRESH_INTERVAL = "refresh_interval_ms";
        private const string KEY_USE_DEFAULT      = "use_default_saves_folder";
        private const string KEY_CUSTOM_FOLDER    = "custom_saves_folder";

        public static int RefreshInterval         = 1000;
        public static bool UseDefaultSavesFolder  = true;
        public static string CustomSavesFolder    = "";
        
        public static string DefaultSavesFolder => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "saves");
        public static string SavesFolder => UseDefaultSavesFolder ? DefaultSavesFolder : CustomSavesFolder;

        public static void Load()
        {
            try
            {
                using (var stream = File.OpenRead(SETTINGS_FILE))
                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        int delimiterIndex = line.IndexOf('=');
                        if (delimiterIndex < 1)
                            continue;

                        string key = line.Substring(0, delimiterIndex);
                        string value = line.Substring(delimiterIndex + 1, line.Length - delimiterIndex - 1);
                        switch (key)
                        {
                            case KEY_REFRESH_INTERVAL:
                                int.TryParse(value, out RefreshInterval);
                                break;
                            case KEY_USE_DEFAULT:
                                bool.TryParse(value, out UseDefaultSavesFolder);
                                break;
                            case KEY_CUSTOM_FOLDER:
                                CustomSavesFolder = value;
                                break;
                        }
                    }
                }
            }
            catch (Exception) 
            {
                Save();
            }
        }

        public static void Save()
        {
            using (var writer = File.CreateText(SETTINGS_FILE))
            {
                writer.WriteLine(KEY_REFRESH_INTERVAL + DELIMITER + RefreshInterval);
                writer.WriteLine(KEY_USE_DEFAULT + DELIMITER + UseDefaultSavesFolder);
                writer.WriteLine(KEY_CUSTOM_FOLDER + DELIMITER + CustomSavesFolder);
            }
        }
    }
}
