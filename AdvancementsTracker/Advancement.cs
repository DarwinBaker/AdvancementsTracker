using System;
using System.Collections.Generic;
using System.Xml;

namespace AdvancementsTracker
{
    public class Advancement
    {
        public enum AdvancementType { Normal, Goal, Challenge }

        public string ID                                { get; private set; }
        public string Name                              { get; private set; }
        public string Icon                              { get; private set; }
        public bool IsCompleted                         { get; private set; }
        public string CriteriaGoal                      { get; private set; }
        public int CompletedCriteria                    { get; private set; }
        public Dictionary<string, Criterion> Criteria   { get; private set; }
        public AdvancementType Type                     { get; private set; }        

        public event EventHandler CompletionChanged;
        public event EventHandler CriteriaChanged;

        protected virtual void OnCompletionChanged(EventArgs e) => CompletionChanged?.Invoke(this, e);
        protected virtual void OnCriteriaChanged(EventArgs e) => CriteriaChanged?.Invoke(this, e);

        public bool HasCriteria => Criteria != null;

        public Advancement(XmlNode node)
        {
            ID   = node.Attributes["id"]?.Value;
            Name = node.Attributes["name"]?.Value ?? ID;
            Icon = node.Attributes["icon"]?.Value;
            if (Icon == null)
            {
                var idParts = ID.Split('/');
                if (idParts.Length > 0)
                    Icon = idParts[idParts.Length - 1];
            }
            if (Enum.TryParse(node.Attributes["type"]?.Value ?? "normal", true, out AdvancementType parsed))
                Type = parsed;

            if (node.HasChildNodes)
            {
                XmlNode criteriaNode = node.SelectSingleNode("criteria");
                CriteriaGoal = criteriaNode.Attributes["goal"]?.Value ?? "Completed";
                Criteria = new Dictionary<string, Criterion>();
                foreach (XmlNode criterionNode in criteriaNode.ChildNodes)
                {
                    string id = criterionNode.Attributes["id"]?.Value;
                    string name = criterionNode.Attributes["name"]?.Value;
                    string icon = criterionNode.Attributes["icon"]?.Value;
                    Criteria.Add(id, new Criterion(id, name, icon));
                }
            }
        }

        public void Update(AdvJSON json)
        {
            if (IsCompleted != json.IsCompleted(ID))
            {
                IsCompleted = !IsCompleted;
                OnCompletionChanged(EventArgs.Empty);
            }

            if (!HasCriteria)
                return;

            var completedCriteria = json.GetCriteria(ID);
            CompletedCriteria = completedCriteria.Count;
            bool changed = false;
            foreach (var criterion in Criteria.Values)
            {
                bool wasCompleted = criterion.IsCompleted;
                criterion.Update(completedCriteria);
                if (wasCompleted != criterion.IsCompleted)
                    changed = true;
            }
            if (changed)
                OnCriteriaChanged(EventArgs.Empty);
        }
    }
}