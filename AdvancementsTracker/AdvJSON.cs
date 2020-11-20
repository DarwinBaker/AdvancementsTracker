using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AdvancementsTracker
{
    public class AdvJSON
    {
        private FileStream stream;
        private StreamReader reader;
        private dynamic json;
        private string file;

        public bool IsCompleted(string adv) => json?[adv]?["done"] == true;
        public bool IsOpen                  => json != null;
        public string CurrentSave           => file != null ? Directory.GetParent(Directory.GetParent(file).FullName).Name : null;

        public void Open(string newFile)
        {
            if (file == newFile)
                return;

            Close();
            file = newFile;
            stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            reader = new StreamReader(stream);
            Update();
        }

        public void Close()
        {
            stream?.Close();
            reader?.Close();
            json = null;
            file = null;
        }

        public List<string> GetCriteria(string adv)
        {
            var list = new List<string>();
            dynamic criteria = json?[adv]?["criteria"];
            if (criteria != null)
            {
                foreach (string line in criteria.ToString().Split('\n'))
                {
                    string[] values = line.Trim().Split('"');
                    if (values.Length > 1)
                        list.Add(values[1]);
                }
            }
            return list;
        }

        public void Update()
        {
            try
            {
                stream.Position = 0;
                json = JsonConvert.DeserializeObject(reader.ReadToEnd());
            }
            catch (Exception) { }
        }
    }
}
