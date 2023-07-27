using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetProject
{
    public class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorList = new List<string>()
        {
            "#3C6255",
            "#AD8E70",
            "#3C2A21",
            "#88A47C",
            "#181D31",
            "#495579",
            "#CE7777",
            "#3D5656",
            "#8B7E74",
            "#5F8D4E",
            "#65647C",
            "#975C8D",
            "#7F669D",
            "#7D8F69",
            "#6D9886",
            "#90A17D",
            "#624F82",
            "#3C4048",
            "#815B5B",
            "#749F82",
            "#628E90",
            "#A1C298",
            "#0F3D3E",
            "#51557E",
            "#5F7161",
            "#A64B2A"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }

            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
