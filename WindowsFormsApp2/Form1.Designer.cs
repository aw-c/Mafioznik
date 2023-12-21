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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Shafle = new System.Windows.Forms.Button();
            this.Persons = new System.Windows.Forms.TextBox();
            this.Debug = new System.Windows.Forms.RichTextBox();
            this.person = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TimerBar = new System.Windows.Forms.ProgressBar();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.TimerTime = new Mafioznik.ExTimerLabel();
            this.SuspendLayout();
            // 
            // Shafle
            // 
            this.Shafle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shafle.Location = new System.Drawing.Point(234, 4);
            this.Shafle.Name = "Shafle";
            this.Shafle.Size = new System.Drawing.Size(143, 26);
            this.Shafle.TabIndex = 1;
            this.Shafle.Text = "Шафлить";
            this.Shafle.UseVisualStyleBackColor = true;
            this.Shafle.Click += new System.EventHandler(this.ShafleClick);
            // 
            // Persons
            // 
            this.Persons.Location = new System.Drawing.Point(185, 6);
            this.Persons.Name = "Persons";
            this.Persons.Size = new System.Drawing.Size(43, 20);
            this.Persons.TabIndex = 2;
            this.Persons.Text = "10";
            // 
            // Debug
            // 
            this.Debug.Location = new System.Drawing.Point(383, 4);
            this.Debug.Name = "Debug";
            this.Debug.ReadOnly = true;
            this.Debug.Size = new System.Drawing.Size(405, 434);
            this.Debug.TabIndex = 3;
            this.Debug.Text = "";
            this.Debug.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // person
            // 
            this.person.Location = new System.Drawing.Point(0, 0);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(100, 23);
            this.person.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(234, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TimerStart);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(306, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "10";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.TimerAdd10);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(342, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "30";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TimerAdd30);
            // 
            // TimerBar
            // 
            this.TimerBar.Location = new System.Drawing.Point(234, 68);
            this.TimerBar.Name = "TimerBar";
            this.TimerBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimerBar.Size = new System.Drawing.Size(143, 23);
            this.TimerBar.TabIndex = 8;
            this.TimerBar.Click += new System.EventHandler(this.OnTimerStop);
            // 
            // NotesBox
            // 
            this.NotesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesBox.Location = new System.Drawing.Point(12, 281);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(365, 157);
            this.NotesBox.TabIndex = 10;
            this.NotesBox.Text = "";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(234, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearNotes);
            // 
            // TimerTime
            // 
            this.TimerTime.AutoSize = true;
            this.TimerTime.BackColor = System.Drawing.Color.Transparent;
            this.TimerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerTime.Location = new System.Drawing.Point(295, 71);
            this.TimerTime.Name = "TimerTime";
            this.TimerTime.Size = new System.Drawing.Size(21, 16);
            this.TimerTime.TabIndex = 9;
            this.TimerTime.Text = "60";
            this.TimerTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimerTime.Click += new System.EventHandler(this.OnTimerStop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.TimerTime);
            this.Controls.Add(this.TimerBar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.Persons);
            this.Controls.Add(this.Shafle);
            this.Controls.Add(this.person);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Mafioznik";
            this.Load += new System.EventHandler(this.Form1_Load);
            /*this.Click += new System.EventHandler(this.Form1_Click);*/
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Shafle;
        private System.Windows.Forms.TextBox Persons;
        public System.Windows.Forms.RichTextBox Debug;
        private System.Windows.Forms.Label person;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ProgressBar TimerBar;
        public ExTimerLabel TimerTime;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.Button button4;
    }
}

