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
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
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

       //     var stringFormat = new StringFormat(); // создаем экземпляр класса
       //     stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
       //     stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали

       //     var text = $"Я гравитон\nc силой {Power}";
       //     var font = new Font("Verdana", 10);

       //     // вызываем MeasureString, чтобы померить размеры текста
       //     var size = g.MeasureString(text, font);

       //     g.FillRectangle(
       //    new SolidBrush(Color.Red),
       //    X - size.Width / 2, // так как я выравнивал текст по центру то подложка должна быть центрирована относительно X,Y
       //    Y - size.Height / 2,
       //    size.Width,
       //    size.Height
       //);

       //     g.DrawString(
       //     text,
       //     font,
       //     new SolidBrush(Color.White),
       //     X,
       //     Y,
       //     stringFormat
       // );
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
}
