using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancementsTracker.Controls
{
    public partial class CAdvCriteria : UserControl
    {
        private Advancement adv;
        private Dictionary<string, Label> criteriaLabels;

        private void Advancement_CompletionChanged(object sender, EventArgs e) => UpdateFrame();
        private void Advancement_CriteriaChanged(object sender, EventArgs e) => UpdateCriteria();
        private string GetFrame() => "frame_" + adv.Type.ToString().ToLower() + (adv.IsCompleted ? "_complete" : "_incomplete");


        public CAdvCriteria(Advancement adv)
        {
            InitializeComponent();
            this.adv = adv;
            this.adv.CompletionChanged += Advancement_CompletionChanged;
            this.adv.CriteriaChanged += Advancement_CriteriaChanged;

            criteriaLabels = new Dictionary<string, Label>();
            foreach (var criterion in adv.Criteria.Values)
            {
                var label = new Label();
                label.Text = new string(' ', 6) + criterion.Name;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.ImageAlign = ContentAlignment.MiddleLeft;
                label.Image = Images.GetImage(criterion.Icon);
                criteriaLabels.Add(criterion.ID, label);
                flow.Controls.Add(label);
            }

            label.Text = adv.Name;
            var image = Images.GetImage(adv.Icon);
            if (image != null)
                icon.Image = image;

            UpdateFrame();
            UpdateCriteria();
        }

        private void UpdateCriteria()
        {
            foreach (var id in adv.Criteria.Keys)
                criteriaLabels[id].Enabled = adv.Criteria[id].IsCompleted;

            int percent = adv.IsCompleted ? 100 : (int)((double)adv.CompletedCriteria / adv.Criteria.Count * 100);
            labelProgress.Text = adv.CriteriaGoal + ": " + adv.CompletedCriteria + " / " + adv.Criteria.Count;
            labelPercent.Text = "(" + percent + "%)";
            progress.Value = percent;
        }

        private void UpdateFrame()
        {
            icon.BackgroundImage = Images.GetImage(GetFrame());
        }
    }
}
