using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Points
        {
            public double x, y;
            public UInt32 color;

            public Points(double x, double y, UInt32 color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }
        }

        public Points A, B, C;

        private void Starting_Points()
        {
            A = new Points((int)A_x_coords.Value, (int)A_y_coords.Value, 0xff0000);
            B = new Points((int)B_x_coords.Value, (int)B_y_coords.Value, 0x00ff00);
            C = new Points((int)C_x_coords.Value, (int)C_y_coords.Value, 0x0000ff);
        }

        Bitmap picture;

        private void button1_Click(object sender, EventArgs e)
        {
            Starting_Points();
            Draw_Colored_Triangle();
        }

        public void Draw_Colored_Triangle()
        {
            picture = new Bitmap(DrawingArea.Width, DrawingArea.Height);

            Draw_Pixels();

            DrawingArea.Image = picture;
        }

        public void Draw_Pixels()
        {
            UInt32 Colors;

            for (int y = 0; y < DrawingArea.Height; y++)
            {
                for (int x = 0; x < DrawingArea.Width; x++)
                {
                    Colors = Affin_Color_Pixel(x, y);

                    picture.SetPixel(x, y, Color.FromArgb((int)Colors));
                }
            }
        }

        public UInt32 Affin_Color_Pixel(int x, int y)
        {
            UInt32 pixel_color = 0x000000;

            double range1, range2, range3;

            range1 = ((B.y - C.y) * ((double)(x) - C.x) + (C.x - B.x) * ((double)(y) - C.y));
            range1 /= ((B.y - C.y) * (A.x - C.x) + (C.x - B.x) * (A.y - C.y));

            range2 = ((C.y - A.y) * ((double)(x) - C.x) + (A.x - C.x) * ((double)(y) - C.y));
            range2 /= ((B.y - C.y) * (A.x - C.x) + (C.x - B.x) * (A.y - C.y));

            range3 = 1 - range1 - range2;

            if (range1 >= 0 && range1 <= 1)
            {
                if (range2 >= 0 && range2 <= 1)
                {
                    if (range3 >= 0 && range3 <= 1)
                    {
                        pixel_color = (UInt32)0xFF000000 |
                        ((UInt32)(range1 * ((A.color & 0x00FF0000) >> 16) + range2 * ((B.color & 0x00FF0000) >> 16) + range3 * ((C.color & 0x00FF0000) >> 16)) << 16) |
                        ((UInt32)(range1 * ((A.color & 0x0000FF00) >> 8) + range2 * ((B.color & 0x0000FF00) >> 8) + range3 * ((C.color & 0x0000FF00) >> 8)) << 8) |
                          (UInt32)(range1 * (A.color & 0x000000FF) + range2 * (B.color & 0x000000FF) + range3 * (C.color & 0x000000FF));

                    }
                }
            }

            return pixel_color;
        }
    }

}

