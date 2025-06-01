using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 30;

    public RoundedPanel()
    {
        this.Resize += (s, e) => this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using (GraphicsPath path = GetRoundedRectPath(this.ClientRectangle, CornerRadius))
        {
            this.Region = new Region(path);
        }
    }

    private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
    {
        int diameter = radius * 2;
        GraphicsPath path = new GraphicsPath();

        path.StartFigure();
        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        return path;
    }
}
