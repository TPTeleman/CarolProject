using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPictureBox : PictureBox
{
    public RoundedPictureBox()
    {
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;
        this.Resize += (s, e) => MakeCircular();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
        MakeCircular();
    }

    private void MakeCircular()
    {
        if (this.Width > 0 && this.Height > 0)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                this.Region = new Region(path);
            }
        }
    }
}
