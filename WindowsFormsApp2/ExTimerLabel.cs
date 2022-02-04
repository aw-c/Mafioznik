using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mafioznik
{
    public class ExTimerLabel : Label
    {
        public int time = 60;
        public int maxvalue = 60;
        public void SetTime(int s) {time = s; maxvalue = time; Text = time.ToString();}
        public Timer timer = new Timer();
        public void Tick(object sender, EventArgs e)
        {
            time -=1;
            Text = time.ToString();
            var Form = (Form1)Parent;
            Form.TimerBar.Value = time > 100 ? 100 : time;
            if (time == 6 || time == 0)
            {
                Form.Print(time == 6 ? "На таймере остаётся 5 секунд" : "Время на таймере вышло");
                Form.player.SoundLocation = @"C:\Windows\Media\chord.wav";
                Form.player.Play();
            }
            if (time < 1)
                timer.Stop();
        }
        public ExTimerLabel()
        {
            timer.Tick += Tick;
            timer.Interval = 1000;
        }
    }
}
