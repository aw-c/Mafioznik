using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mafioznik
{
    public static class Core
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public enum ROLES
        {
            CIT = 0,
            KOM = 1,
            MAF = 2,
            DON = 3,
        }
        public static List<string> RolesName = new List<string>(){
            "Мирный",
            "Комиссар",
            "Мафия",
            "Дон",
        };
    }
}