using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace MoarBytes
{
    public class MoarProgressBar : Control
    {
        private BigInteger _maximum = 100;
        private BigInteger _minimum = 0;
        private BigInteger _value = 0;
        private Color _backgroundColor = Color.Gray;
        private Color _barColor = Color.Green;
        private Color _borderColor = Color.Black;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Максимальное значение.")]
        public BigInteger Maximum
        {
            get { return _maximum; }
            set { _maximum = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Минимальное значение.")]
        public BigInteger Minimum
        {
            get { return _minimum; }
            set { _minimum = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Текущее значение.")]
        public BigInteger Value
        {
            get { return _value; }
            set
            {
                _value = BigInteger.Min(BigInteger.Max(value, _minimum), _maximum);
                Invalidate();
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Цвет фона.")]
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Цвет полосы прокрутки.")]
        public Color BarColor
        {
            get { return _barColor; }
            set { _barColor = value; Invalidate(); }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Цвет границы.")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        public MoarProgressBar()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // Заливка фона
            using (SolidBrush backgroundBrush = new SolidBrush(_backgroundColor))
            {
                g.FillRectangle(backgroundBrush, ClientRectangle);
            }

            // Расчет ширины полосы прокрутки
            BigInteger range = _maximum - _minimum;
            float fraction = (float)(_value - _minimum) / (float)range;
            int barWidth = (int)(fraction * ClientRectangle.Width);

            // Рисование полосы прокрутки
            using (SolidBrush barBrush = new SolidBrush(_barColor))
            {
                g.FillRectangle(barBrush, 0, 0, barWidth, ClientRectangle.Height);
            }

            // Рисование границы
            using (Pen borderPen = new Pen(_borderColor))
            {
                g.DrawRectangle(borderPen, 0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            }

            // Отображение процентов
            string percentText = $"{(int)(fraction * 100)}%";
            SizeF textSize = g.MeasureString(percentText, Font);
            PointF textPosition = new PointF(ClientRectangle.Width / 2 - textSize.Width / 2, ClientRectangle.Height / 2 - textSize.Height / 2);
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            {
                g.DrawString(percentText, Font, textBrush, textPosition);
            }
        }
    }
}
