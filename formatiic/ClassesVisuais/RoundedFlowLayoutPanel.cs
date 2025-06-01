using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedFlowLayoutPanel : FlowLayoutPanel
{
    private int _borderRadius = 20;

    [Category("Aparência")]
    [Description("Define o raio da borda arredondada.")]
    public int BorderRadius
    {
        get => _borderRadius;
        set { _borderRadius = value; this.Invalidate(); }
    }

    public RoundedFlowLayoutPanel()
    {
        this.BackColor = Color.White;
        this.DoubleBuffered = true;
        this.Resize += (s, e) => this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _borderRadius, _borderRadius));
    }

    // P/ arredondar cantos
    [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
    );
}
