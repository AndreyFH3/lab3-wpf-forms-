using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3._1
{
    class HoverButton : Button
    {
        public HoverButton() : base()
        {
            ForeColor = Color.White;
            Font = new Font("Microsoft YaHei UI",
             20.25F,
             FontStyle.Bold,
             GraphicsUnit.Point,
             0);
        }
        private Color color = Color.Aquamarine;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (Image == null | color == Color.Green)
            {
                BackColor = Color.Red;
                Image = Properties.Resources._1;
                color = Color.Red;
                ImageAlign = ContentAlignment.MiddleLeft;
                ForeColor = Color.Yellow;
                Text = "biblethumb";
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";
            }
            else if (color == Color.Red)
            {
                BackColor = Color.White;
                Image = Properties.Resources._2;
                color = Color.White;
                ForeColor = Color.Black;
                Text = "kappapride";
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";

            }
            else if (color == Color.White)
            {
                BackColor = Color.Purple;
                Image = Properties.Resources._3;
                color = Color.Purple;
                ImageAlign = ContentAlignment.MiddleLeft;
                ForeColor = Color.Green;
                Text = "kappapride";
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";

            }
            else if (color == Color.Purple)
            {
                BackColor = Color.Green;
                Image = Properties.Resources._8;
                color = Color.Green;
                ImageAlign = ContentAlignment.MiddleLeft;
                ForeColor = Color.Purple;
                Text = "seemsgood";
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";
            }

        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (color == Color.Red)
            {
                ImageAlign = ContentAlignment.MiddleLeft;
                Text = "biblethumb";
                ForeColor = Color.Yellow;
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";

            }
            else if (color == Color.White)
            {
                ImageAlign = ContentAlignment.MiddleLeft;
                Text = "kappapride";
                ForeColor = Color.Black;
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";

            }
            else if (color == Color.Purple)
            {
                ImageAlign = ContentAlignment.MiddleLeft;
                Text = "CoolStoryBob";
                ForeColor = Color.Green;
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";


            }
            else if (color == Color.Green)
            {
                ImageAlign = ContentAlignment.MiddleLeft;
                Text = "seemsgood";
                ForeColor = Color.Purple;
                TextAlign = ContentAlignment.TopRight;
                Text += "\n\n\n\n\n\n\n\n\n\n Тупа 12 из 10!!!!";
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (color == Color.Red)
            {
                ImageAlign = ContentAlignment.MiddleCenter;
                Text = "biblethumb";
                TextAlign = ContentAlignment.BottomRight;
            }
            else if (color == Color.White)
            {
                ImageAlign = ContentAlignment.MiddleCenter;
                Text = "kappapride";
                TextAlign = ContentAlignment.BottomRight;
            }
            else if (color == Color.Purple)
            {
                ImageAlign = ContentAlignment.MiddleCenter;
                Text = "CoolStoryBob";
                TextAlign = ContentAlignment.BottomRight;
            }
            else if (color == Color.Green)
            {
                ImageAlign = ContentAlignment.MiddleCenter;
                Text = "seemsgood";
                TextAlign = ContentAlignment.BottomRight;
            }
        }
    }
}
