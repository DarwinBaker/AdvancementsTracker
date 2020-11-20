using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AdvancementsTracker.Controls
{
    public partial class CPixelBox : PictureBox
    {
        //Dumb custom picture box to support nearest-neighbor upscaling
        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            if (Image == null)
                return;
            ImageAnimator.UpdateFrames(Image);
            paintEventArgs.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            paintEventArgs.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            paintEventArgs.Graphics.DrawImage(Image, new Rectangle(Width / 2 - 16, Height / 2 - 16, 32 , 32));
        }
    }
}
