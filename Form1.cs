using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Timers;

namespace Mafioznik
{
    public partial class Form1 : Form
    {
        public SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Print("Mafioznik - Tool for Mafia WEB Game\nDeveloped by Alan Wake\nLogger activated");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public List<ExLabel> Labels = new List<ExLabel>();
        private void ShafleClick(object sender, EventArgs e)
        {
            player.Stream = Core.TimeSound;
            player.Play();
            foreach (ExLabel label in Labels)
                label.Dispose();
            int persons;
            int.TryParse(Persons.Text, out persons);
            int[] apersons = new int[persons];
            List<int> reserved = new List<int>();
            var rand = new Random();
            for (int i = 1; i <= 4; i++)
            {
                int curnum;
                while (true)
                {
                    int randp = rand.Next(0, persons);
                    if (reserved.Contains(randp))
                        continue;
                    curnum = randp;
                    break;
                }
                reserved.Add(curnum);
            }
            apersons[reserved[0]] = (int)Core.ROLES.DON;
            apersons[reserved[1]] = (int)Core.ROLES.MAF;
            apersons[reserved[2]] = (int)Core.ROLES.MAF;
            apersons[reserved[3]] = (int)Core.ROLES.KOM;
            int y = 5;
            for (int i = 0; i < persons; i++)
            {
                Labels.Add(new ExLabel());
                var person = Labels.Last();
                person.AutoSize = true;
                person.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                person.Location = new System.Drawing.Point(12, y);
                person.Name = i.ToString();
                person.Size = new System.Drawing.Size(46, 18);
                person.TabIndex = 0;
                string pretext = i + 1 < 10 ? "0" + (i + 1) : (i + 1).ToString();
                person.pretext = pretext + " - " + Core.RolesName[apersons[i]];
                person.Text = "[" + person.folls + "/4] " + person.pretext;
                person.MouseClick += AddFoll;
                Controls.Add(person);
                y += 19;
                /*Print("Игрок номер " + (i+1) + " создан");*/
            }
            Print("Игроки были успешно зашафлены");
        }
        public void Print(object text)
        {
            var time = DateTime.Now;
            Debug.AppendText("[" + time.Hour + ":" + time.Minute + "] " + text.ToString() + "\n");
            Debug.ScrollToCaret();
        }
        public void AddFoll(object sender, MouseEventArgs e)
        {
            ExLabel panel = sender as ExLabel;
            int lastv = panel.folls;
            panel.folls += e.Button == MouseButtons.Left ? 1 : -1;
            panel.Text = "[" + panel.folls + "/4] " + panel.pretext;
            int ou;
            int.TryParse(panel.Name, out ou);
            string playername = ou + 1 < 10 ? "0" + (ou + 1) : (ou + 1).ToString();
            Print("Игроку " + playername + " был " + (panel.folls > lastv ? "начислен" : "снят") + " игровой фолл");
        }

        private void OnTimerStop(object sender, EventArgs e)
        {
            if (!TimerTime.timer.Enabled)
            {
                TimerTime.SetTime(TimerTime.time == 60 ? 30 : 60);
                Print("Время таймера было изменено");
                return;
            }
            TimerTime.timer.Stop();
            Print("Таймер был остановлен");
        }

        private void TimerStart(object sender, EventArgs e)
        {
            if (TimerTime.time == 0)
                TimerTime.SetTime(60);
            TimerTime.timer.Start();
            Print("Таймер был запущен со временем " + TimerTime.time);
        }

        private void TimerAdd10(object sender, EventArgs e)
        {
            TimerTime.SetTime(TimerTime.time + 10);
            Print("Таймеру было добавлено +10 секунд");
        }

        private void TimerAdd30(object sender, EventArgs e)
        {
            TimerTime.SetTime(TimerTime.time + 30);
            Print("Таймеру было добавлено +30 секунд");
        }

        private void ClearNotes(object sender, EventArgs e)
        {
            NotesBox.Clear();
            Print("Заметки были успешно очищены");
        }

        private void person_Click(object sender, EventArgs e)
        {

        }
    }
}
