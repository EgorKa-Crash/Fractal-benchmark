using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fract
{
    public class FractalCalculation
    {
        public static void TakeAPhoto(int w, int h, DirectBitmap bitmap, double zoom, double moveX, double moveY, object block)
        {
            var t1 = Task.Run(() =>
            {
                Parallel.For(0, w, (i, state) =>
                {
                    Wr(h, w, i, bitmap,   zoom,   moveX,   moveY,   block);
                });
            });
            Task.WaitAll(t1); //ожидание окончания задания
            DateTime now = DateTime.Now;//текущие дата и время 
            string patch = "C:/Users/Егор/Pictures/Uplay/fract" + System.Guid.NewGuid() + ".png";//now.TimeOfDay 
            bitmap.Bitmap.Save(patch, System.Drawing.Imaging.ImageFormat.Png);
        }

        public static void Wr(int h, int w, int x, DirectBitmap bitmap, double zoom, double moveX, double moveY, object block)
        {
            double cRe, cIm;
            // вещественная и мнимая части старой и новой
            double oldRe, oldIm;
            // Можно увеличивать и изменять положение

            int maxIterations = 300;//300
            cRe = -0.39054;
            cIm = -0.58679;

            Color[] hColors = new Color[h];
            for (int y = 0; y < h; y++)
            {
                int i = 0;
                double newRe = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                double newIm = (y - h / 2) / (0.5 * zoom * h) + moveY;
                while ((newRe * newRe + newIm * newIm) < 4 && i < maxIterations)
                {

                    oldRe = newRe;
                    oldIm = newIm;

                    newRe = oldRe * oldRe - oldIm * oldIm + cRe;
                    newIm = 2 * oldRe * oldIm + cIm;

                    i++;
                }
                hColors[y] = Rainbow(i * 0.85F / 400F); //массив цветов вместо влоутов + 10%
            }

            lock (block) //вынесение дало + 10%
            {
                for (int y = 0; y < h; y++)
                {
                    bitmap.SetPixel(x, y, hColors[y]);
                }
            }
        }

        public static Color Rainbow(float progress)
        {
            float div = (Math.Abs(progress % 1) * 6);
            int ascending = (int)((div % 1) * 255);
            int descending = 255 - ascending;

            switch ((int)div)
            {
                case 0:
                    return Color.FromArgb(255, 255, ascending, 0);
                case 1:
                    return Color.FromArgb(255, descending, 255, 0);
                case 2:
                    return Color.FromArgb(255, 0, 255, ascending);
                case 3:
                    return Color.FromArgb(255, 0, descending, 255);
                case 4:
                    return Color.FromArgb(255, ascending, 0, 255);
                default: // case 5:
                    return Color.FromArgb(255, 255, 0, descending);
            }
        }



    }
}
