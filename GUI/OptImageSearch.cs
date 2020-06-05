using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class RectangleExtension
    {
        public static Point Center(this Rectangle rect)
        {
            return new Point(rect.Left + rect.Width / 2,
                             rect.Top + rect.Height / 2);
        }
    }
    public class OptImageSearch
    {
        public static bool Find(string fileName, Rectangle rectangle)
        {
            using (Image<Bgr, byte> source = new Image<Bgr, byte>(Dependencies.ScreenShot.CopyScreen(rectangle)))
            using (Image<Gray, float> result = source.MatchTemplate(new Image<Bgr, byte>($@"RegWinAI32\SearchWin64\{fileName}"), TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                source.Dispose(); result.Dispose();
                if (maxValues[0] > 0.85f)
                {
                    return true;
                }
            }
            return false;
        }
        public static Rectangle FindCoods(string fileName, Rectangle rectangle)
        {

            using (Image<Bgr, byte> source = new Image<Bgr, byte>(Dependencies.ScreenShot.CopyScreen(rectangle)))
            using (Image<Bgr, byte> template = new Image<Bgr, byte>($@"RegWinAI32\SearchWin64\{fileName}"))
            using (Image<Gray, float> result = source.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                if (maxValues[0] > 0.92f)
                {
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    return match;
                }
                else
                {
                    return new Rectangle(0, 0, 0, 0);
                }
            }
        }
    }
}
