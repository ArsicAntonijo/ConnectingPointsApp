using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgApp
{
    public class CDot
    {
        public TextObject TextObject{ get; set; }
        public Point Location { get; set; }
        public Point Normalized { get; set; }

        public CDot(TextObject to, Point location, Point nor) { TextObject = to; Location = location; Normalized = nor; }
    }
}
