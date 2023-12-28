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
using System.Diagnostics.CodeAnalysis;

namespace Mafioznik
{
    public partial class Form1 : Form
    {
        public SoundPlayer player = new SoundPlayer(Properties.Resources.ding);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Print("Mafioznik - Tool for Mafia WEB Game\nDeveloped by Alan Wake\nLogger activated");
        }
        private PlayerLabel SearchNext(Random r)
        {
            var i = r.Next(0, player_holder.Items.Count);
            foreach (PlayerLabel item in player_holder.Items)
            {
                if (item.Index == i)
                    if (item.Role == Core.ROLES.CIT)
                        return item;
            }
            return SearchNext(r);
        }
        private void ShafleClick(object sender, EventArgs e)
        {
            player_holder.Items.Clear();
            player.Play();
            int persons;
            int.TryParse(Persons.Text, out persons);

            for (int i = 1; i <= persons; i++)
            {
                PlayerLabel player = new(i);
                player_holder.Items.Add(player);
            }
            var rand = new Random();
            foreach (Core.ROLES item in Enum.GetValues(typeof(Core.ROLES)))
            {
                PlayerLabel player;
                if (item == Core.ROLES.MAF)
                {
                    player = SearchNext(rand);
                    player.Role = item;
                    UpdatePlayer(player);
                }

                player = SearchNext(rand);
                player.Role = item;
                UpdatePlayer(player);
            }
            Print("Роли были зашафлены");
        }
        public void Print(object text)
        {
            var time = DateTime.Now;
            Debug.AppendText($"[{time.Hour}:{time.Minute}] {text.ToString()}\n");
            Debug.ScrollToCaret();
        }

        private int GetNextTime(int time)
        {
            switch (time)
            {
                case 60: return 15;
                case 30: return 60;
                case 15: return 30;
                default: return 60;
            }
        }

        private void OnTimerStop(object sender, EventArgs e)
        {
            if (!TimerTime.timer.Enabled)
            {
                int prevTime = TimerTime.Time;
                TimerTime.Time = GetNextTime(TimerTime.Time);
                Print($"Время таймера с {prevTime} было изменено на {TimerTime.Time}");
                return;
            }
            TimerTime.timer.Stop();
            Print("Таймер был остановлен");
        }

        private void TimerStart(object sender, EventArgs e)
        {
            if (TimerTime.Time == 0)
                TimerTime.Time = 60;
            TimerTime.timer.Start();
            Print("Таймер был запущен со временем " + TimerTime.Time);
        }

        private void ClearNotes(object sender, EventArgs e)
        {
            NotesBox.Clear();
            Print("Заметки были успешно очищены");
        }

        private bool TryGetPlayer(object? o, [NotNullWhen(true)] out PlayerLabel? player)
        {
            if (o is PlayerLabel && o is not null)
            {
                player = (PlayerLabel)o;
                return true;
            }
            player = null;
            return false;
        }

        private void UpdatePlayer(PlayerLabel player)
        {
            player_holder.DisplayMember = player.ToString();
        }

        private void ProcessFoll(bool toAdd)
        {
            if (TryGetPlayer(player_holder.SelectedItem, out var item))
            {
                item.Fools += toAdd ? 1 : -1;
                UpdatePlayer(item);
                string separator = toAdd ? "начислен" : "снят";
                Print($"Игроку {item.Index} был {separator} игровой фолл");
            }
        }

        private void add_foll_Click(object sender, EventArgs e)
        {
            ProcessFoll(true);
        }

        private void remove_foll_Click(object sender, EventArgs e)
        {
            ProcessFoll(false);
        }

        private void kill_player_Click(object sender, EventArgs e)
        {
            if (TryGetPlayer(player_holder.SelectedItem, out var item))
            {
                item.Killed = !item.Killed;
                UpdatePlayer(item);
                string separator = item.Killed ? "убран" : "возвращён";
                Print($"Игрок {item.Index} был {separator}");
            }
        }
        private Core.ROLES GetNextRole(PlayerLabel player)
        {
            switch (player.Role)
            {
                case Core.ROLES.CIT:
                    return Core.ROLES.MAF;
                case Core.ROLES.KOM:
                    return Core.ROLES.DON;
                case Core.ROLES.MAF:
                    return Core.ROLES.KOM;
                case Core.ROLES.DON:
                    return Core.ROLES.CIT;
            }
            return Core.ROLES.CIT;
        }

        private void change_role_Click(object sender, EventArgs e)
        {
            if (TryGetPlayer(player_holder.SelectedItem, out var item))
            {
                Core.ROLES perviosRole = item.Role;
                item.Role = GetNextRole(item);
                UpdatePlayer(item);
                Print($"Игроку {item.Index} была изменена роль с {Core.RolesName[(int)perviosRole]} на {Core.RolesName[(int)item.Role]}");
            }
        }

        private void ProcessSeconds(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            int toAdd = int.Parse(button.Text);
            bool isAdd = true;
            TimerTime.Time += isAdd ? toAdd : -toAdd;
            string separator = isAdd ? "добавлено" : "убрано";
            Print($"Таймеру было {separator} {toAdd} секунд");
        }

        private void DeselectItem(object sender, EventArgs e)
        {
            player_holder.SelectedItem = null;
        }
    }
}
