using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Resources.Components
{
    public class RoundedPanel : Panel
    {
        private int _radius = 16;
        private Color _borderColor = ColorTranslator.FromHtml("#E2E8F0");
        private int _borderThickness = 1;

        [Category("Appearance")]
        [DefaultValue(16)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Radius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        [DefaultValue(1)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = value; Invalidate(); }
        }

        // Color has no simple DefaultValue, so tell the designer when to skip saving it
        private bool ShouldSerializeBorderColor() => _borderColor != ColorTranslator.FromHtml("#E2E8F0");
        private void ResetBorderColor() => _borderColor = ColorTranslator.FromHtml("#E2E8F0");

        public RoundedPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (var path = GetRoundPath(rect, _radius))
            using (var brush = new SolidBrush(BackColor))
            using (var pen = new Pen(_borderColor, _borderThickness))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(pen, path);
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            using (var path = GetRoundPath(new Rectangle(0, 0, Width, Height), _radius))
                Region = new Region(path);
        }

        private static GraphicsPath GetRoundPath(Rectangle r, int radius)
        {
            int d = Math.Max(1, radius * 2);
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
