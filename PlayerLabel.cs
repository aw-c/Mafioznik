using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mafioznik
{
    public class PlayerLabel
    {
        public int VoteIndex = -1;
        public int Votes = 0;
        public int Index = 0;
        public int Fools = 0;
        public Core.ROLES Role;
        public bool Killed = false;
        public PlayerLabel(int index) 
        { 
            Index = index;
        }
        private string GetSeparator()
        {
            return Index < 10 ? " —" : " ";
        }
        private string GetKilledSuffix()
        {
            return Killed ? "[K]" : string.Empty;
        }
        public override string ToString()
        {
            return $"{GetKilledSuffix()}[{Fools}/4] {Index}{GetSeparator()}— {Core.RolesName[(int)Role]}";
        }
    }
}
