using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorblindProject
{
    class MouseMove
    {

        public Color ChangeFormMainWindow()
        {
            Bitmap bitmap = new Bitmap(1, 1);

            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.CopyFromScreen(Cursor.Position, new Point(0, 0), new Size(1, 1));

            Color color = bitmap.GetPixel(0, 0);

            return color;

        }

        public Color ChangePictureBoxBackground()
        {
            Color backGround = this.ChangeFormMainWindow();

            return backGround;
        }

        public string ChangeRGBValue()
        {
            Color rgb = this.ChangeFormMainWindow();

            string rgbValue = "(" + rgb.R + ", " + rgb.G + ", " + rgb.B + ")"; 

            return rgbValue;
        }

        public string ChangeHexadecimalValue()
        {
            Color rgb = this.ChangeFormMainWindow();

            string hexadecimalValue = rgb.Name.Remove(0 , 2);

            return "#" + hexadecimalValue.ToUpper();
        }

		public string ChangeHSVValue()
		{
			Color rgb = this.ChangeFormMainWindow();

			Color color = Color.FromArgb(rgb.R, rgb.G, rgb.B);

			int max = Math.Max(rgb.R, Math.Max(rgb.G, rgb.B));
			int min = Math.Min(rgb.R, Math.Min(rgb.G, rgb.B));

			double hue = Math.Round(rgb.GetHue(), 0);
			double saturation = ((max == 0) ? 0 : 1d - (1d * min / max)) * 100;
			saturation = Math.Round(saturation, 0);
			double value = Math.Round(((max / 255d) * 100), 0);

			string hsvValue = ("(" + hue + "°" + ", " + saturation + "%" + ", " + value + "%" + ")");

			return hsvValue;
		}
    }
}
