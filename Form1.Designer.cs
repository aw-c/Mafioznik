using System;
namespace Mafioznik
{
    partial class Form1
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
        /// 
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Shafle = new Button();
            Persons = new TextBox();
            Debug = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            TimerBar = new ProgressBar();
            NotesBox = new RichTextBox();
            button4 = new Button();
            TimerTime = new ExTimerLabel();
            SuspendLayout();
            // 
            // Shafle
            // 
            Shafle.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Shafle.Location = new Point(273, 5);
            Shafle.Margin = new Padding(4, 3, 4, 3);
            Shafle.Name = "Shafle";
            Shafle.Size = new Size(167, 30);
            Shafle.TabIndex = 1;
            Shafle.Text = "Шафлить";
            Shafle.UseVisualStyleBackColor = true;
            Shafle.Click += ShafleClick;
            // 
            // Persons
            // 
            Persons.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Persons.Location = new Point(216, 7);
            Persons.Margin = new Padding(4, 3, 4, 3);
            Persons.Name = "Persons";
            Persons.Size = new Size(50, 27);
            Persons.TabIndex = 2;
            Persons.Text = "10";
            // 
            // Debug
            // 
            Debug.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Debug.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Debug.Location = new Point(447, 5);
            Debug.Margin = new Padding(4, 3, 4, 3);
            Debug.Name = "Debug";
            Debug.ReadOnly = true;
            Debug.Size = new Size(472, 500);
            Debug.TabIndex = 3;
            Debug.Text = "";
            Debug.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(273, 42);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(83, 30);
            button1.TabIndex = 5;
            button1.Text = "Пуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += TimerStart;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(357, 42);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(41, 30);
            button2.TabIndex = 6;
            button2.Text = "10";
            button2.UseVisualStyleBackColor = true;
            button2.Click += TimerAdd10;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(399, 42);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(41, 30);
            button3.TabIndex = 7;
            button3.Text = "30";
            button3.UseVisualStyleBackColor = true;
            button3.Click += TimerAdd30;
            // 
            // TimerBar
            // 
            TimerBar.Location = new Point(273, 78);
            TimerBar.Margin = new Padding(4, 3, 4, 3);
            TimerBar.Name = "TimerBar";
            TimerBar.RightToLeft = RightToLeft.No;
            TimerBar.Size = new Size(167, 27);
            TimerBar.TabIndex = 8;
            TimerBar.Click += OnTimerStop;
            // 
            // NotesBox
            // 
            NotesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NotesBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NotesBox.Location = new Point(14, 324);
            NotesBox.Margin = new Padding(4, 3, 4, 3);
            NotesBox.Name = "NotesBox";
            NotesBox.Size = new Size(425, 181);
            NotesBox.TabIndex = 10;
            NotesBox.Text = "";
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(273, 287);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(167, 30);
            button4.TabIndex = 11;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ClearNotes;
            // 
            // TimerTime
            // 
            TimerTime.AutoSize = true;
            TimerTime.BackColor = Color.Transparent;
            TimerTime.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TimerTime.Location = new Point(344, 82);
            TimerTime.Margin = new Padding(4, 0, 4, 0);
            TimerTime.Name = "TimerTime";
            TimerTime.Size = new Size(21, 16);
            TimerTime.TabIndex = 9;
            TimerTime.Text = "60";
            TimerTime.TextAlign = ContentAlignment.MiddleCenter;
            TimerTime.Click += OnTimerStop;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(933, 519);
            Controls.Add(button4);
            Controls.Add(NotesBox);
            Controls.Add(TimerTime);
            Controls.Add(TimerBar);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Debug);
            Controls.Add(Persons);
            Controls.Add(Shafle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Mafioznik";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Shafle;
        private TextBox Persons;
        public RichTextBox Debug;
        private Button button1;
        private Button button2;
        private Button button3;
        public ProgressBar TimerBar;
        public ExTimerLabel TimerTime;
        private RichTextBox NotesBox;
        private Button button4;
    }
}

