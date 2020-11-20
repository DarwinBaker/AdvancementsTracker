using System;
using System.Windows.Forms;

namespace AdvancementsTracker.Controls
{
    public partial class CAdvBasic : UserControl
    {
        private Advancement advancement;

        private string GetFrame() => "frame_" + advancement.Type.ToString().ToLower() + (advancement.IsCompleted ? "_complete" : "_incomplete");
        private void OnCompletionChanged(object sender, EventArgs e) => icon.BackgroundImage = Images.GetImage(GetFrame());

        public CAdvBasic(Advancement advancement)
        {
            InitializeComponent();
            this.advancement = advancement;
            this.advancement.CompletionChanged += OnCompletionChanged;

            label.Text = advancement.Name;
            icon.BackgroundImage = Images.GetImage(GetFrame());
            if (Images.GetImage(advancement.Icon) != null)
                icon.Image = Images.GetImage(advancement.Icon);
        }
    }
}
