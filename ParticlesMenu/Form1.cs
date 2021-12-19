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
                ParticlesPerTick = 2,
            };

            emitters.Add(this.emitter);


            paint1 = new PainterPoint
            {
                PointColor = Color.White,
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
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            
        }

    }
}
