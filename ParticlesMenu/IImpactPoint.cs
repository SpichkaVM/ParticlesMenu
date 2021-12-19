using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ParticleMenu;

namespace ParticlesMenu
{
    public abstract class IImpactPoint
    {
        public float X; // ну точка же, вот и две координаты
        public float Y;

        // абстрактный метод с помощью которого будем изменять состояние частиц
        // например притягивать
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
        public virtual void Render(Graphics g)
        {
            g.FillEllipse( new SolidBrush(Color.Red), X - 5, Y - 5, 10, 10);
        }
    }
    public class GravityPoint : IImpactPoint
    {
        public int Power = 10; // сила притяжения

        
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power / 2) 
            {
                
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }
    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100; // сила отторжения

        
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; 
            particle.SpeedY -= gY * Power / r2; 
        }
    }

    public class PainterPoint : IImpactPoint
    {
        public Color PointColor = Color.White;
        public float Rad = 15;

        public override void ImpactParticle(Particle particle)
        {
            //Проверка попадания частицы в радиус круга
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r - particle.Radius < Rad)
            {
                particle.Color1 = PointColor;
                particle.Color0 = Color.FromArgb(0, PointColor);
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(new Pen(new SolidBrush(PointColor), 2), X - Rad, Y - Rad, Rad * 2, Rad * 2);
        }
    }

    public class CounterPoint : IImpactPoint
    {
        public int Count = 0;
        public float Rad = 15;

        public override void ImpactParticle(Particle particle)
        {
            //Проверка попадания частицы в радиус круга
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r - particle.Radius < Rad)
            {
                particle.Life = 0;
                Count++;
            }
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), X - Rad, Y - Rad, Rad * 2, Rad * 2);
            g.DrawEllipse(new Pen(new SolidBrush(Color.White), 2), X - Rad, Y - Rad, Rad * 2, Rad * 2);

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(
            $"{Count}",
            new Font("Verdana", 10),
            new SolidBrush(Color.White),
            X,
            Y,
            stringFormat
        );
        }
    }
}
