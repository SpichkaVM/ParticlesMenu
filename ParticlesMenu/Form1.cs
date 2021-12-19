using ParticleMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParticlesMenu.Emitter;

namespace ParticlesMenu
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        //Поменял GravityPoint 
        public PainterPoint paint1;
        public PainterPoint paint2;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            emitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.2f,
                ParticlesPerTick = 10,
            };

            emitters.Add(this.emitter);


            paint1 = new PainterPoint
            {
                PointColor = Color.Blue,
                X = (picDisplay.Width / 2) - 200,
                Y = (picDisplay.Height / 2) - 100,
                Rad = 50,
            };
            paint2 = new PainterPoint
            {
                PointColor = Color.Red,
                X = (picDisplay.Width / 2) + 200,
                Y = (picDisplay.Height / 2) - 100,
                Rad = 50,
            };
            tbRad.Value = 50; 

            emitter.impactPoints.Add(paint1);
            emitter.impactPoints.Add(paint2);

            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var emitter in emitters)
            {
                //Обновление состояния всех элементов эмиттера
                emitter.UpdateState();

                using (var g = Graphics.FromImage(picDisplay.Image))
                {
                    g.Clear(Color.Black);
                    //Рендер всех элементов эмиттера
                    emitter.Render(g);
                }
            }
            picDisplay.Invalidate();
        }
        
        
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                emitter.impactPoints.Add(new CounterPoint
                {
                    X = e.X,
                    Y = e.Y,
                    Rad = tbRad.Value,
                });
            }
            else if (e.Button == MouseButtons.Right)
            {
                foreach (var point in emitter.impactPoints.ToArray())
                {
                    //Если impactpoint - счётчик
                    if (point is CounterPoint)
                    {
                        //то проверяем на пересечение с местом клика мышью
                        CounterPoint cpoint = point as CounterPoint;
                        float gX = cpoint.X - e.X;
                        float gY = cpoint.Y - e.Y;
                        double r = Math.Sqrt((gX * gX) + (gY * gY));
                        if (r <= cpoint.Rad)
                        {
                            //и при пересечении удаляем счётчик.
                            emitter.impactPoints.Remove(point);
                        }
                    }
                }
            }
        }

        private void XPaint1_Scroll(object sender, EventArgs e)
        {
            paint1.X = XPaint1.Value;
        }

        private void YPaint1_Scroll(object sender, EventArgs e)
        {
            paint1.Y = YPaint1.Value;
        }

        private void RadPaint1_Scroll(object sender, EventArgs e)
        {
            paint1.Rad = RadPaint1.Value;
        }

        private void XPaint2_Scroll(object sender, EventArgs e)
        {
            paint2.X = XPaint2.Value;
        }

        private void YPaint2_Scroll(object sender, EventArgs e)
        {
            paint2.Y = YPaint2.Value;
        }

        private void RadPaint2_Scroll(object sender, EventArgs e)
        {
            paint2.Rad = RadPaint2.Value;
        }


        private void ColorPaint1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            paint1.PointColor = colorDialog.Color;
            ColorPaint1.BackColor = paint1.PointColor;
        }

        private void ColorPaint2_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            paint2.PointColor = colorDialog.Color;
            ColorPaint2.BackColor = paint2.PointColor;
        }

        

        private void tbRad_Scroll(object sender, EventArgs e)
        {

        }
    }
}
