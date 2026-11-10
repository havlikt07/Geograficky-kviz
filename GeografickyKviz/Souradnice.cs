using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografickyKviz
{
    internal static class Souradnice
    {
        public static Point NaPixely(float relativeX, float relativeY, int boundWidth, int boundHeight)
        {
            int pixelX = (int)(relativeX * boundWidth);
            int pixelY = (int)(relativeY * boundHeight);

            return new Point(pixelX, pixelY);
        }

        public static PointF NaRelativni(int pixelX, int PixelY, int boundWidth, int boundHeight)
        {
            if (boundWidth == 0 || boundHeight == 0) return new PointF(0, 0);

            float relativeX = (float)pixelX / boundWidth;
            float relativeY = (float)PixelY / boundHeight;

            return new PointF(relativeX, relativeY);
        }
    }
}
