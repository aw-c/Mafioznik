using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mafioznik
{
    public class ExTimerLabel : Label
    {
        public SoundPlayer Player = new SoundPlayer(Properties.Resources.chord);
        private int _Time = 60;
        public int Time { get { return _Time; } 
            set 
            {
                _Time = value;
                Text = value.ToString();
            } 
        }
        public int MaxValue = 70;
        public System.Windows.Forms.Timer timer = new();
        public void Tick(object sender, EventArgs e)
        {
            Time--;
            var Form = (Form1)Parent;
            Form.TimerBar.Value = Time;
            var parsedTime = int.Parse(Form.SoundOnTime.Text);

            if (Time == parsedTime || Time == 0)
            {
                Form.Print(Time == parsedTime ? $"На таймере остаётся {Time} секунд" : "Время на таймере вышло");
                Player.Play();
            }
            if (Time < 1)
                timer.Stop();
        }
        public ExTimerLabel()
        {
            timer.Tick += Tick;
            timer.Interval = 1000;
        }
    }
}
