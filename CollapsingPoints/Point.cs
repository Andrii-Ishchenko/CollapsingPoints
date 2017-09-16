using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollapsingPoints
{
    [DebuggerDisplay(@"\{{ID}\}  ({Coords.X}|{Coords.Y}) <{FirstLink.ID}|{SecondLink.ID}>")]
    public class Point
    {
        public static int _id = 0;

        public readonly int ID;
        public PointF Coords { get; set; }
        public PointF NextCoords { get; set; }

        public Point FirstLink { get; set; }
        public Point SecondLink { get; set; }

        public Point(PointF coords)
        {
            Coords = coords;
            ID = _id++;
        }

        public void CalculateNext( float maxDeltaStep)
        {
            var desiredX = (FirstLink.Coords.X + SecondLink.Coords.X) / 2;
            var desiredY = (FirstLink.Coords.Y + SecondLink.Coords.Y) / 2;

            NextCoords = Utils.Lerp(Coords, new PointF(desiredX, desiredY), maxDeltaStep);
        }
    }
}
