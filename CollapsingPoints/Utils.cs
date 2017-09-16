using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollapsingPoints
{
    public static class Utils
    {
        public static float Lerp(float min, float max, float alpha)
        {
            return max * alpha + min * (1 - alpha);
        }

        public static PointF Lerp(PointF firstPoint, PointF secondPoint, float by)
        {
            float retX = Lerp(firstPoint.X, secondPoint.X, by);
            float retY = Lerp(firstPoint.Y, secondPoint.Y, by);
            return new PointF(retX, retY);
        }
    }
}
