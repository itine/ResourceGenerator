using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateResourcesOnMap
{
    public class ResourceGenerator
    {
        
        public static bool IsEmptyCell(int local)
        {
            if (local <= 80)
                return true;
            return false;
        }
        public static int GenerateStructure(int local)
        {
            if (local == 1)
                return 0;
            if (local == 2)
                return 1;
            if (local == 3)
                return 2;
            if (local == 4)
                return 3;
            if (local == 5)
                return 4;
            if (local == 6)
                return 5;
            if (local == 7)
                return 6;

            if (local > 7 && local <= 10)
                return 7;
            if (local > 10 && local <= 13)
                return 8;
            if (local > 13 && local <= 16)
                return 9;
            if (local > 16 && local <= 19)
                return 10;
            if (local > 19 && local <= 22)
                return 11;
            if (local > 22 && local <= 25)
                return 12;
            
            if (local > 25 && local <= 30)
                return 13;
            if (local > 30 && local <= 35)
                return 14;
            if (local > 35 && local <= 40)
                return 15;
            if (local > 40 && local <= 45)
                return 16;
            if (local > 45 && local <= 50)
                return 17;

            if (local > 50 && local <= 60)
                return 18;
            if (local > 60 && local <= 70)
                return 19;
            if (local > 70 && local <= 80)
                return 20;
            if (local > 80 && local <= 90)
                return 21;
            if (local > 90 && local <= 100)
                return 22;
            return -1;
        }
    }
}
