using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5_Работа_с_потоками_
{
    // Класс для прорисовки круга
    class CircleDrawing
    {
        int radius;
        Color colorBrush;
        SolidBrush circleBrush;
        Graphics pictureBox;

        // Cвойство радиуса
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Свойство цвета кисти
        public Color ColorBrush
        {
            get { return colorBrush; }
            set
            {
                colorBrush = value;
                circleBrush.Color = value;
            }
        }

        // Конструктор
        public CircleDrawing(Graphics pictureBox, int radius, Color colorBrush)
        {
            this.radius = radius;
            this.colorBrush = colorBrush;
            this.pictureBox = pictureBox;
            this.circleBrush = new SolidBrush(colorBrush);
        }

        // Рисование круга
        public void drawCircle(int x, int y)
        {
            pictureBox.FillEllipse(circleBrush, x - radius, y - radius, radius, radius);
        }
    }
}
