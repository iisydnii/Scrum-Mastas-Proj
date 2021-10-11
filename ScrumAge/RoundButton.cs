using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Button;

namespace ScrumAge
{
    class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the OnPaint method of the base class.
            base.OnPaint(e);

            // Declare and instantiate a new pen that will be disposed of at the end of the method.
            using var myPen = new Pen(Color.Aqua);

            // Create a rectangle that represents the size of the control, minus 1 pixel.
            var area = new Rectangle(new Point(0, 0), new Size(this.Size.Width - 1, this.Size.Height - 1));

            // Draw an aqua rectangle in the rectangle represented by the control.
            e.Graphics.DrawRectangle(myPen, area);
        }
    }
}
