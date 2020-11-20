using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace AdvancementsTracker
{
    public static class Images
    {
        public const string DIR_IMAGES = "assets/images/";

        private static Dictionary<string, Image> images;

        public static Image GetImage(string key) => images.TryGetValue(key, out var val) ? val : null;

        //Function to recursively load all .png and .gif images in DIR_IMAGES
        public static void LoadImages()
        {
            images = new Dictionary<string, Image>();
            foreach (string file in Directory.EnumerateFiles(DIR_IMAGES, "*.png", SearchOption.AllDirectories))
            {
                try
                {
                    using (var temp = new Bitmap(file))
                        images.Add(Path.GetFileNameWithoutExtension(file), new Bitmap(temp));
                }
                catch (Exception) { }
            }
            foreach (string file in Directory.EnumerateFiles(DIR_IMAGES, "*.gif", SearchOption.AllDirectories))
            {
                try
                {
                    using (var stream = new FileStream(file, FileMode.Open))
                    {
                        var memory = new MemoryStream();
                        stream.CopyTo(memory);
                        memory.Position = 0;
                        images.Add(Path.GetFileNameWithoutExtension(file), Image.FromStream(memory));
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
