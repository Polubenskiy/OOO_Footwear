using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace OOO_Footwear.Classes
{
    static class CaptchaImage
    {
        private static string text;

        static Int16[] rotate = { 3, -3, 4, -4, 5, -5, 6, -6, 7, -7, 8, -8};

        public static String Text { get { return text; } }

        private static Random random = new Random();
        public static Bitmap Image { get; set; }

        public static Bitmap GenerateImage(int captchaWidth, int captchaHeight)
        {
            int Xpos = random.Next(0, 25);
            int Ypos = random.Next(0, 5);

            Bitmap bitmap = new Bitmap(captchaWidth,
                captchaHeight,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            // Generate text
            text = String.Empty;
            String ALF = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < 5; i++)
                text += ALF[random.Next(ALF.Length)];

            // Setting style
            FontStyle style = FontStyle.Strikeout;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;    
            format.LineAlignment= StringAlignment.Near;

            SolidBrush myBrush = new SolidBrush(Color.FromArgb(0xFF, 0xB3, 0xF4, 0xE9));

            graphics.RotateTransform(random.Next(4, 10));

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.DrawString(text, new Font("Arial", 20, style),
                myBrush,
                  new PointF(Xpos, Ypos), format
                );

            graphics.Dispose();

            return bitmap;
        }
    }
}
