using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Работа_с_потоками_
{
    public partial class MainForm : Form
    {
        public void Start() { }
        // Список потоков
        List<WorkWithThread> listThread;
        // Номер потока
        byte numberThread = 1;
        // Номер выбранного потока
        byte selectedThread;
        // Главный поток
        //Thread MainThread = new Thread(new ThreadStart());

        // Инициализация формы
        public MainForm()
        {
            InitializeComponent();
            
            // Выбираем приоритет "Средний"
            PriorityComboBox.SelectedIndex = 2;
            // Выбираем приоритет главного потока "Средний"
            MainThreadPriorityComboBox.SelectedIndex = 2;
            // По умолчанию задаем черный цвет для прорисовки кругов
            ColorDialog.Color = Color.Black;
            // Окрашиваем кнопку в этот цвет
            ColorButton.BackColor = Color.Black;
            // Добавляем новый поток в список
            listThread = new List<WorkWithThread>();
        }

        // Меняем цвет кнопки в зависимости от выбранного
        private void ColorButton_Click(object sender, EventArgs e)
        {           
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorButton.BackColor = ColorDialog.Color;
            }
        }

        // Создание нового потока
        private void CreateThreadButton_Click(object sender, EventArgs e)
        {
            // Добавляем новый поток
            listThread.Add(new WorkWithThread(MainPictureBox.CreateGraphics(),
                          (int)RadiusNumericUpDown.Value,
                          (int)SpeedNumericUpDown.Value,
                          ColorDialog.Color,
                          (ThreadPriority)PriorityComboBox.SelectedIndex,
                          MainPictureBox.Width,
                          MainPictureBox.Height));
            // Запускаем поток
            listThread.Last().startThread();
            // Добавляем его в выпадающий список
            ThreadСomboBox.Items.Insert(ThreadСomboBox.Items.Count, "Поток " + numberThread);
            // Задаем его выбранным в выпадающем списке
            ThreadСomboBox.SelectedIndex = ThreadСomboBox.Items.Count - 1;
            // Меняем кнопку на кнопку останова
            StopResumeThreadButton.Text = "Остановить поток";
            numberThread++;
        }

        // Возобновление и остановка потока
        private void StopResumeThreadButton_Click(object sender, EventArgs e)
        {
            // Если какой-либо поток выбран
            if (ThreadСomboBox.SelectedItem != null)
            {
                selectedThread = Convert.ToByte(ThreadСomboBox.SelectedIndex);

                // Если поток остановлен
                if (listThread[selectedThread].Pause)
                {
                    StopResumeThreadButton.Text = "Остановить поток";
                    listThread[selectedThread].resumeThread();
                }

                // Если возобновляем поток
                else
                {
                    StopResumeThreadButton.Text = "Возобновить поток";
                    listThread[selectedThread].suspendThread();
                }
            }
            // Если никакой поток не выбран
            else MessageBox.Show("Выберите поток!");
        }

        // Меняем данные о потоке в соответствии с выбором
        private void ThreadСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Берем номер выбранного потока
            selectedThread = Convert.ToByte(ThreadСomboBox.SelectedIndex);

            // Если поток остановлен
            if (listThread[selectedThread].Pause)
            {
                StopResumeThreadButton.Text = "Возобновить поток";
            }
            // Если возобновляем поток
            else
            {
                StopResumeThreadButton.Text = "Остановить поток";
            }

            // Пишем радиус
            RadiusNumericUpDown.Value = listThread[selectedThread].Circle.Radius;

            // Пишем скорость
            SpeedNumericUpDown.Value = listThread[selectedThread].Speed;

            // Меняем цвет кнопки
            ColorButton.BackColor = listThread[selectedThread].ColorBrush;
            ColorDialog.Color = listThread[selectedThread].ColorBrush;
        }

        // Удаление потока
        private void DeleteThreadButton_Click(object sender, EventArgs e)
        {
            if (ThreadСomboBox.SelectedItem != null)
            {
                // Берем номер выбранного потока
                selectedThread = Convert.ToByte(ThreadСomboBox.SelectedIndex);
                // Удаляем поток
                listThread[selectedThread].Abort();
                // Удаляем его из выпадающего списка
                ThreadСomboBox.Items.RemoveAt(ThreadСomboBox.SelectedIndex);
                // Удаляем его из списка
                listThread.RemoveAt(selectedThread);

                // Встаем на первый поток
                if (listThread.Count != 0)
                    ThreadСomboBox.SelectedIndex = 0;
            }
            else MessageBox.Show("Выберите поток!");
        }

        // События при закрытии формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < listThread.Count; i++)
            {
                if (listThread[i] != null)
                {
                    listThread[i].Abort();
                }
            }
        }

        // При загрузке формы задаем приоритет
        private void MainForm_Load(object sender, EventArgs e)
        {
            //MainThread = Thread.CurrentThread;
        }

        // Меняем приоритет главного потока
        private void MainThreadPriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MainThread.Priority = (ThreadPriority)MainThreadPriorityComboBox
        }
    }
}
