using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Fract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var t1 = Task.Run(() =>
            {
                while (true)
                { 
                    frames.Invoke(new Action(() => frames.Text = "" + counter));

                    Thread.Sleep(100);
                }
            });
        }
         
        int counter = 0;
        private static double zoom = 1;
        private static double moveX { get; set; } = -0.0978016;
        private static double moveY { get; set; } = 0.0404;

        private static object block = new object();
         

        public void ThreadsCalculation(int w, int h, DirectBitmap bitmap)
        {
            object locker = new object();

            var t0 = Task.Run(() =>
            {
                for (int x = 0; x < w - 1; x++)
                {
                    new Thread(() =>
                     {
                         FractalCalculation.Wr(h, w, x, bitmap, zoom, moveX, moveY, block);
                     }
                     ).Start();
                }
            });
            Task.WaitAll(t0); 
        }
        //List<ParalellCollorMatrix> ListC;

        void ParallelCalculationWithRendering(int w, int h, DirectBitmap bitmap)
        {
            var t0 = Task.Run(() =>
            {
                Dictionary<int, Color[]> dictionary;
                if (!flag)
                    dictionary = dictionary1;
                else
                    dictionary = dictionary2;

                Color[] hColors;
                if (dictionary.Count >= 1)
                {
                    for (int x = 0; x < w; x++)
                    {  
                        hColors = dictionary[x];

                        for (int y = 0; y < h; y++)
                        {
                            bitmap.SetPixel(x, y, hColors[y]);
                        }
                    }
                } 
                pictureBox1.Image = bitmap.Bitmap;
            });
            var t1 = Task.Run(() =>
            {
                Parallel.For(0, w, (i, state) =>
                {
                    DoubleWriting(h, w, i);// , bitmap
                });
            });

            Task.WaitAll(t1, t0); //ожидание окончания задания 
            //Task.WaitAll(t0); //ожидание окончания отрисовки прежнего кадра
            //Task.WaitAll(t1); //ожидание окончания отрисовки прежнего кадра
            //Task.WaitAll(t0); //ожидание окончания отрисовки прежнего кадра
            flag = !flag;

            if (flag)
                dictionary1.Clear();
            else
                dictionary2.Clear(); 
        }
         
        public void OneThreadeDrawing(int w, int h, DirectBitmap bitmap)
        {
            var t1 = Task.Run(() =>
            {
                for (int x = 0; x < w; x++)
                {
                    FractalCalculation.Wr(h, w, x, bitmap, zoom, moveX, moveY, block);
                } 
            });
            Task.WaitAll(t1); //ожидание окончания задания  
        }
         
        private class ParalellCollorMatrix
        {
            public int id;
            public bool readyFlag = false;
            public Color[] colorMass;

            public ParalellCollorMatrix(int id, bool readyFlag, Color[] colorMass)
            {
                this.id = id;
                this.readyFlag = readyFlag;
                this.colorMass = colorMass;
            }
        }
         
        static Dictionary<int, Color[]> dictionary1 = new Dictionary<int, Color[]>();
        static Dictionary<int, Color[]> dictionary2 = new Dictionary<int, Color[]>();

        static bool flag = true;
        private static void DoubleWriting(int h, int w, int x)
        {
            Dictionary<int, Color[]> dictionary;
            if (flag)
                dictionary = dictionary1;
            else
                dictionary = dictionary2;

            double cRe, cIm;
            // вещественная и мнимая части старой и новой
            double oldRe, oldIm;
            // Можно увеличивать и изменять положение

            int maxIterations = 300;
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
                hColors[y] = FractalCalculation.Rainbow(i * 0.85F / 400F); //массив цветов вместо влоутов + 10% 
            }

            lock (block)
            {
                dictionary.Add(x, hColors);
            }
        } 

        private void Button1_Click_1(object sender, EventArgs e)
        {
            StartDrowing();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            zoom = Math.Pow(2.0, ((double)trackBar1.Value / 10));
            StartDrowing();

        }
         
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int newWidth = this.Width - 270; 
            int newHeight = Convert.ToInt32(newWidth / 3 * 1.9);

            if (newHeight + 120 > this.Size.Height)
            {
                newHeight = this.Size.Height - 120;
                newWidth = Convert.ToInt32(newHeight / 1.9 * 3);
            }

            pictureBox1.Size = new Size(newWidth, newHeight);

            dictionary1.Clear();
            dictionary2.Clear();
        }

        DirectBitmap bitmap = new DirectBitmap(1, 1);

        int height = 0;
        int width = 0;
        private void StartDrowing()
        {
            if (width != pictureBox1.Width)
            {
                height = pictureBox1.Height;
                width = pictureBox1.Width;
                bitmap = new DirectBitmap(width, height);//зволяет изменять размер экрана, но ест память 
            }

            Zoom.Text = " " + Convert.ToInt32(zoom);

            if (oneThread.Checked)
            {
                OneThreadeDrawing(width, height, bitmap); //должен работать
                pictureBox1.Image = bitmap.Bitmap;
            }

            else if (manyThreads.Checked)
            {
                ThreadsCalculation(width, height, bitmap);
                pictureBox1.Image = bitmap.Bitmap;
            }

            else if (parallel.Checked)
            {
                ParallelCalculationWithRendering(width, height, bitmap);
            }
             
            FPSGenerator();
            counter++;

            //bitmap.Dispose(); 
            /*bitmap = null; 
            GC.Collect();
            GC.WaitForPendingFinalizers();*/
        }

        private void benchmarkButton_Click(object sender, EventArgs e)
        {
            int height = pictureBox1.Height;
            int width = pictureBox1.Width;
            long countPixels = height * width;
            long startTime;
            long finishTime;
            double result;
            double CountScens = 20;
            startTime = DateTime.UtcNow.Ticks;
            for (int i = 0; i < CountScens; i++)
            {
                zoom = i * i + 1;
                StartDrowing();
            }
            finishTime = DateTime.UtcNow.Ticks;
            result = Math.Round(countPixels* 10000 / ((finishTime - startTime) / CountScens));
            benchmark.Text = "" + result;
        }
         
        private double k = 0.3;  // коэффициент фильтрации, 0.0-1.0, меньше, плавнее
        private long lastTime = 0;
        static double OldFps = 0;
        private void FPSGenerator()
        {
            long deltaTime = DateTime.UtcNow.Ticks - lastTime; //(10,000,000 ТИКов в секунду).
            if (deltaTime == 0) deltaTime = 100; //только до 1000 фпс
             lastTime = DateTime.UtcNow.Ticks;
            double CurrentFps = 1.0 / deltaTime * 10000000;
            OldFps += (CurrentFps - OldFps) * k;
            FPSTextBox.Text = Convert.ToString(Math.Round(OldFps, 2));
        }

        private void HighRezPfoto_Click(object sender, EventArgs e)
        {
            int height = 500;
            int width = Convert.ToInt32(height * 3 / 1.9);
            DirectBitmap bitmap = new DirectBitmap(width, height);
            FractalCalculation.TakeAPhoto(width, height, bitmap, zoom, moveX, moveY, block);
        }
         
    }
}