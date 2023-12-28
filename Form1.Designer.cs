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
            player_holder = new ListBox();
            kill_player = new Button();
            add_foll = new Button();
            remove_foll = new Button();
            change_role = new Button();
            SoundOnTime = new TextBox();
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
            Persons.Location = new Point(216, 5);
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
            Debug.WordWrap = false;
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
            button2.MouseClick += ProcessSeconds;
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
            button3.MouseClick += ProcessSeconds;
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
            NotesBox.Location = new Point(10, 324);
            NotesBox.Margin = new Padding(4, 3, 4, 3);
            NotesBox.Name = "NotesBox";
            NotesBox.Size = new Size(425, 180);
            NotesBox.TabIndex = 10;
            NotesBox.Text = "";
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(216, 293);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(219, 30);
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
            TimerTime.Time = 60;
            TimerTime.Click += OnTimerStop;
            // 
            // player_holder
            // 
            player_holder.BackColor = SystemColors.ControlLight;
            player_holder.BorderStyle = BorderStyle.None;
            player_holder.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            player_holder.FormattingEnabled = true;
            player_holder.ItemHeight = 18;
            player_holder.Location = new Point(10, 5);
            player_holder.Name = "player_holder";
            player_holder.Size = new Size(204, 288);
            player_holder.TabIndex = 12;
            // 
            // kill_player
            // 
            kill_player.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            kill_player.Location = new Point(10, 293);
            kill_player.Margin = new Padding(4, 3, 4, 3);
            kill_player.Name = "kill_player";
            kill_player.Size = new Size(30, 30);
            kill_player.TabIndex = 14;
            kill_player.Text = "K";
            kill_player.UseVisualStyleBackColor = true;
            kill_player.Click += kill_player_Click;
            // 
            // add_foll
            // 
            add_foll.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            add_foll.Location = new Point(40, 293);
            add_foll.Margin = new Padding(4, 3, 4, 3);
            add_foll.Name = "add_foll";
            add_foll.Size = new Size(30, 30);
            add_foll.TabIndex = 15;
            add_foll.Text = "A";
            add_foll.UseVisualStyleBackColor = true;
            add_foll.Click += add_foll_Click;
            // 
            // remove_foll
            // 
            remove_foll.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            remove_foll.Location = new Point(70, 293);
            remove_foll.Margin = new Padding(4, 3, 4, 3);
            remove_foll.Name = "remove_foll";
            remove_foll.Size = new Size(30, 30);
            remove_foll.TabIndex = 16;
            remove_foll.Text = "R";
            remove_foll.UseVisualStyleBackColor = true;
            remove_foll.Click += remove_foll_Click;
            // 
            // change_role
            // 
            change_role.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            change_role.Location = new Point(100, 293);
            change_role.Margin = new Padding(4, 3, 4, 3);
            change_role.Name = "change_role";
            change_role.Size = new Size(114, 30);
            change_role.TabIndex = 17;
            change_role.Text = "Change Role";
            change_role.UseVisualStyleBackColor = true;
            change_role.Click += change_role_Click;
            // 
            // SoundOnTime
            // 
            SoundOnTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SoundOnTime.Location = new Point(216, 42);
            SoundOnTime.Margin = new Padding(4, 3, 4, 3);
            SoundOnTime.Name = "SoundOnTime";
            SoundOnTime.Size = new Size(50, 27);
            SoundOnTime.TabIndex = 18;
            SoundOnTime.Text = "6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(933, 519);
            Controls.Add(SoundOnTime);
            Controls.Add(change_role);
            Controls.Add(remove_foll);
            Controls.Add(add_foll);
            Controls.Add(kill_player);
            Controls.Add(player_holder);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Mafioznik";
            Load += Form1_Load;
            Click += DeselectItem;
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
        private ListBox player_holder;
        private Button kill_player;
        private Button add_foll;
        private Button remove_foll;
        private Button change_role;
        public TextBox SoundOnTime;
    }
}

