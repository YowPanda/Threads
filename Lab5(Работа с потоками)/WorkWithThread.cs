using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace Lab5_Работа_с_потоками_
{
    // Класс работы с потоками
    class WorkWithThread
    {
        Thread thread;
        CircleDrawing circle;
        ThreadPriority priority;
        Random coordinate = new Random();
        int speed;
        int width;
        int height;
        object propertyChangeLocker;
        bool pause;

        // Событие пауза
        ManualResetEvent eventPause;

        // Свойство скорости
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        // Свойство паузы
        public bool Pause
        {
            get { return pause; }
        }

        // Свойство круга
        public CircleDrawing Circle
        {
            get { return circle; }
            set { circle = value; }
        }

        // Свойство приоритета
        public ThreadPriority Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        // Свойство цвета кисти
        public Color ColorBrush
        {
            get { return circle.ColorBrush; }

            set
            {
                lock (propertyChangeLocker)
                {
                    circle.ColorBrush = value;
                }
            }
        }

        // Конструктор
        public WorkWithThread(Graphics pictureBox, int radius, int speed, Color colorBrush, ThreadPriority priority, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.speed = speed;
            this.priority = priority;
            circle = new CircleDrawing(pictureBox, radius, colorBrush);
            thread = new Thread(createCircles);
            // Задаем поток как фоновый
            thread.IsBackground = true;
            eventPause = new ManualResetEvent(false);
            propertyChangeLocker = new object();
            pause = false;
        }

        // Деструктор
        ~WorkWithThread()
        {
            Abort();
        }

        // Остановка и удаление потока
        public void Abort()
        {
            eventPause.Set();
            thread.Abort();
        }

        // Создание кругов
        public void createCircles()
        {
            // Бесконечно рисуем круги
            while (true)
            {
                // Во время прорисовки ордного круга фиксируем его координаты 
                lock (propertyChangeLocker)
                {
                    circle.drawCircle(coordinate.Next(width), coordinate.Next(height));
                }

                // Пауза
                Thread.Sleep(speed);
                while (eventPause.WaitOne(0))
                    Thread.Sleep(500);
            }
        }
        
        // Стартуем поток
        public void startThread()
        {
            thread.Priority = priority;
            thread.Start();
        }

        // Останавливаем поток
        public void suspendThread()
        {
            eventPause.Set();
            pause = true;
        }

        // Возобновление потока
        public void resumeThread()
        {
            eventPause.Reset();
            pause = false;
        }
    }
}
