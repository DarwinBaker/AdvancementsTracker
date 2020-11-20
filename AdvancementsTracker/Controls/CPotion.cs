using System.Drawing;
using System.Windows.Forms;

namespace AdvancementsTracker.Controls
{
    public partial class CPotion : UserControl
    {
        public CPotion(Potion potion)
        {
            InitializeComponent();
            group.Text = potion.Name;
            pic.Image = Images.GetImage(potion.Icon);

            var picArrow = new PictureBox();
            picArrow.Size = new Size(32, 32);
            picArrow.Image = Images.GetImage("arrow");
            flow.Controls.Add(picArrow);

            for (int i = 0; i < potion.Ingredients.Count; i++)
            {
                var picIngredient = new CPixelBox();
                picIngredient.Margin = new Padding(0, 0, 16, 0);
                picIngredient.Size = new Size(32, 32);
                picIngredient.Image = Images.GetImage(potion.Ingredients[i]);
                flow.Controls.Add(picIngredient);
            }
        }
    }
}
