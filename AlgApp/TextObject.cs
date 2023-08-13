using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgApp
{
    public class TextObject
    {
        public string Text { get; set; }
        public Font Font { get; set; }
        public Point Point { get; set; }
        public Brush Brush = new SolidBrush(Color.Black);

        public TextObject(string text, Font font, Point point)
        {
            Text = text;
            Font = font;
            Point = point;
        }
    }
}
