using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancementsTracker
{
    public class Criterion
    {
        public string ID            { get; private set; }
        public string Name          { get; private set; }
        public string Icon          { get; private set; }
        public bool IsCompleted     { get; private set; }

        public void Update(List<string> completed) => IsCompleted = completed.Contains(ID);

        public Criterion(string id, string name = null, string icon = null)
        {
            ID = id;
            var idParts = ID.Split(':');
            string shortID = idParts.Length > 0 ? idParts[idParts.Length - 1] : null;
            Name = name ?? new CultureInfo("en-US", false).TextInfo.ToTitleCase(shortID.Replace('_', ' '));
            Icon = icon ?? shortID;
        }
    }
}
