namespace Lab5_Работа_с_потоками_
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ParametresGroupBox = new System.Windows.Forms.GroupBox();
            this.StopResumeThreadButton = new System.Windows.Forms.Button();
            this.SpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.RadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.DeleteThreadButton = new System.Windows.Forms.Button();
            this.CreateThreadButton = new System.Windows.Forms.Button();
            this.ThreadСomboBox = new System.Windows.Forms.ComboBox();
            this.ThreadLabel = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.MainThreadLabel = new System.Windows.Forms.Label();
            this.MainThreadPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.ParametresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ParametresGroupBox
            // 
            this.ParametresGroupBox.Controls.Add(this.StopResumeThreadButton);
            this.ParametresGroupBox.Controls.Add(this.SpeedNumericUpDown);
            this.ParametresGroupBox.Controls.Add(this.SpeedLabel);
            this.ParametresGroupBox.Controls.Add(this.RadiusNumericUpDown);
            this.ParametresGroupBox.Controls.Add(this.ColorButton);
            this.ParametresGroupBox.Controls.Add(this.ColorLabel);
            this.ParametresGroupBox.Controls.Add(this.RadiusLabel);
            this.ParametresGroupBox.Controls.Add(this.PriorityComboBox);
            this.ParametresGroupBox.Controls.Add(this.PriorityLabel);
            this.ParametresGroupBox.Controls.Add(this.DeleteThreadButton);
            this.ParametresGroupBox.Controls.Add(this.CreateThreadButton);
            this.ParametresGroupBox.Controls.Add(this.ThreadСomboBox);
            this.ParametresGroupBox.Controls.Add(this.ThreadLabel);
            this.ParametresGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametresGroupBox.Location = new System.Drawing.Point(570, 22);
            this.ParametresGroupBox.Name = "ParametresGroupBox";
            this.ParametresGroupBox.Size = new System.Drawing.Size(439, 423);
            this.ParametresGroupBox.TabIndex = 0;
            this.ParametresGroupBox.TabStop = false;
            this.ParametresGroupBox.Text = "Управление потоками:";
            // 
            // StopResumeThreadButton
            // 
            this.StopResumeThreadButton.Location = new System.Drawing.Point(30, 145);
            this.StopResumeThreadButton.Name = "StopResumeThreadButton";
            this.StopResumeThreadButton.Size = new System.Drawing.Size(380, 35);
            this.StopResumeThreadButton.TabIndex = 13;
            this.StopResumeThreadButton.Text = "Остановить поток";
            this.StopResumeThreadButton.UseVisualStyleBackColor = true;
            this.StopResumeThreadButton.Click += new System.EventHandler(this.StopResumeThreadButton_Click);
            // 
            // SpeedNumericUpDown
            // 
            this.SpeedNumericUpDown.Location = new System.Drawing.Point(106, 319);
            this.SpeedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedNumericUpDown.Name = "SpeedNumericUpDown";
            this.SpeedNumericUpDown.Size = new System.Drawing.Size(91, 27);
            this.SpeedNumericUpDown.TabIndex = 12;
            this.SpeedNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(26, 319);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(64, 20);
            this.SpeedLabel.TabIndex = 11;
            this.SpeedLabel.Text = "Пауза:";
            // 
            // RadiusNumericUpDown
            // 
            this.RadiusNumericUpDown.Location = new System.Drawing.Point(106, 272);
            this.RadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            this.RadiusNumericUpDown.Size = new System.Drawing.Size(91, 27);
            this.RadiusNumericUpDown.TabIndex = 10;
            this.RadiusNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(106, 368);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(91, 28);
            this.ColorButton.TabIndex = 9;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(26, 368);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(57, 20);
            this.ColorLabel.TabIndex = 8;
            this.ColorLabel.Text = "Цвет:";
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(26, 272);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(74, 20);
            this.RadiusLabel.TabIndex = 6;
            this.RadiusLabel.Text = "Радиус:";
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Items.AddRange(new object[] {
            "Низкий",
            "Ниже среднего",
            "Средний",
            "Выше среднего",
            "Высокий"});
            this.PriorityComboBox.Location = new System.Drawing.Point(139, 219);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(157, 28);
            this.PriorityComboBox.TabIndex = 5;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Location = new System.Drawing.Point(26, 219);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(107, 20);
            this.PriorityLabel.TabIndex = 4;
            this.PriorityLabel.Text = "Приоритет:";
            // 
            // DeleteThreadButton
            // 
            this.DeleteThreadButton.Location = new System.Drawing.Point(223, 99);
            this.DeleteThreadButton.Name = "DeleteThreadButton";
            this.DeleteThreadButton.Size = new System.Drawing.Size(187, 35);
            this.DeleteThreadButton.TabIndex = 3;
            this.DeleteThreadButton.Text = "Удалить поток";
            this.DeleteThreadButton.UseVisualStyleBackColor = true;
            this.DeleteThreadButton.Click += new System.EventHandler(this.DeleteThreadButton_Click);
            // 
            // CreateThreadButton
            // 
            this.CreateThreadButton.Location = new System.Drawing.Point(30, 99);
            this.CreateThreadButton.Name = "CreateThreadButton";
            this.CreateThreadButton.Size = new System.Drawing.Size(187, 35);
            this.CreateThreadButton.TabIndex = 2;
            this.CreateThreadButton.Text = "Создать поток";
            this.CreateThreadButton.UseVisualStyleBackColor = true;
            this.CreateThreadButton.Click += new System.EventHandler(this.CreateThreadButton_Click);
            // 
            // ThreadСomboBox
            // 
            this.ThreadСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThreadСomboBox.FormattingEnabled = true;
            this.ThreadСomboBox.Location = new System.Drawing.Point(96, 49);
            this.ThreadСomboBox.Name = "ThreadСomboBox";
            this.ThreadСomboBox.Size = new System.Drawing.Size(157, 28);
            this.ThreadСomboBox.TabIndex = 1;
            this.ThreadСomboBox.SelectedIndexChanged += new System.EventHandler(this.ThreadСomboBox_SelectedIndexChanged);
            // 
            // ThreadLabel
            // 
            this.ThreadLabel.AutoSize = true;
            this.ThreadLabel.Location = new System.Drawing.Point(26, 49);
            this.ThreadLabel.Name = "ThreadLabel";
            this.ThreadLabel.Size = new System.Drawing.Size(66, 20);
            this.ThreadLabel.TabIndex = 0;
            this.ThreadLabel.Text = "Поток:";
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(552, 556);
            this.MainPictureBox.TabIndex = 3;
            this.MainPictureBox.TabStop = false;
            // 
            // MainThreadLabel
            // 
            this.MainThreadLabel.AutoSize = true;
            this.MainThreadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainThreadLabel.Location = new System.Drawing.Point(596, 465);
            this.MainThreadLabel.Name = "MainThreadLabel";
            this.MainThreadLabel.Size = new System.Drawing.Size(252, 20);
            this.MainThreadLabel.TabIndex = 4;
            this.MainThreadLabel.Text = "Приоритет главного потока:";
            // 
            // MainThreadPriorityComboBox
            // 
            this.MainThreadPriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MainThreadPriorityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainThreadPriorityComboBox.FormattingEnabled = true;
            this.MainThreadPriorityComboBox.Items.AddRange(new object[] {
            "Низкий",
            "Ниже среднего",
            "Средний",
            "Выше среднего",
            "Высокий"});
            this.MainThreadPriorityComboBox.Location = new System.Drawing.Point(600, 498);
            this.MainThreadPriorityComboBox.Name = "MainThreadPriorityComboBox";
            this.MainThreadPriorityComboBox.Size = new System.Drawing.Size(157, 28);
            this.MainThreadPriorityComboBox.TabIndex = 6;
            this.MainThreadPriorityComboBox.SelectedIndexChanged += new System.EventHandler(this.MainThreadPriorityComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 554);
            this.Controls.Add(this.MainThreadPriorityComboBox);
            this.Controls.Add(this.MainThreadLabel);
            this.Controls.Add(this.MainPictureBox);
            this.Controls.Add(this.ParametresGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №5, Менькина Дарья, Работа с потоками";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ParametresGroupBox.ResumeLayout(false);
            this.ParametresGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ParametresGroupBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Button DeleteThreadButton;
        private System.Windows.Forms.Button CreateThreadButton;
        private System.Windows.Forms.ComboBox ThreadСomboBox;
        private System.Windows.Forms.Label ThreadLabel;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.NumericUpDown RadiusNumericUpDown;
        private System.Windows.Forms.Button StopResumeThreadButton;
        private System.Windows.Forms.NumericUpDown SpeedNumericUpDown;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label MainThreadLabel;
        private System.Windows.Forms.ComboBox MainThreadPriorityComboBox;
    }
}

