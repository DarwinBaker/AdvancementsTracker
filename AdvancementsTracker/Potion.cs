using System.Collections.Generic;
using System.Xml;

namespace AdvancementsTracker
{
    public struct Potion
    {
        public string Name                  { get; private set; }
        public string Icon                  { get; private set; }
        public List<string> Ingredients     { get; private set; }

        public Potion(XmlNode node)
        {
            Icon = node.Attributes["icon"]?.Value;
            Name = node.Attributes["name"]?.Value;
            Ingredients = new List<string>();
            foreach (XmlNode ingredient in node.SelectNodes("ingredient"))
                Ingredients.Add(ingredient.Attributes["id"]?.Value ?? "");
        }
    }
}
