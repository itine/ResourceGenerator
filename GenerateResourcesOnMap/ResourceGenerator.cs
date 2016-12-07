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
        public static Random rnd = new Random();

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

        public static int GenerateDecoration(int local)
        {
            if (local >= 1 && local <= 10)
                return 24;
            if (local > 10 && local <= 20)
                return 25;
            if (local > 20 && local <= 30)
                return 26;
            if (local > 30 && local <= 40)
                return 27;
            if (local > 40 && local <= 50)
                return 28;
            if (local > 50 && local <= 60)
                return 29;
            if (local > 60 && local <= 70)
                return 30;
            if (local > 70 && local <= 80)
                return 31;
            if (local > 80 && local <= 90)
                return 32;
            if (local > 90 && local <= 100)
                return 33;
            return -1;
        }

        public static int GenerateResource(int local)
        {
            if (local >= 1 && local <= 20)
                return 34;
            if (local >= 20 && local <= 30)
                return 35;
            if (local >= 30 && local <= 36)
                return 36;
            if (local >= 36 && local <= 52)
                return 37;
            if (local >= 52 && local <= 68)
                return 38;
            if (local >= 68 && local <= 75)
                return 39;
            if (local >= 75 && local <= 82)
                return 40;
            if (local >= 82 && local <= 89)
                return 41;
            if (local >= 89 && local <= 96)
                return 42;
            if (local >= 96 && local <= 98)
                return 43;
            if (local >= 98 && local <= 100)
                return 44;
            return -1;
        }

        public static int GenerateArtifact(int local)
        {
            if (local >= 1 && local <= 86)
                return rnd.Next(45,68);
            if (local > 86 && local <= 89)
                return 68;
            if(local > 89 && local <= 90)
                return 69;
            if (local > 90 && local <= 100)
                return 70;
            return -1;
        }

        public static int GenerateMonster(int zone, int local)
        {
            switch (zone)
            {
                case 1:
                    if (local >= 1 && local <= 68)
                        return 72;
                    if (local > 68 && local <= 81)
                        return 73;
                    if (local > 81 && local <= 89)
                        return 74;
                    if (local > 89 && local <= 94)
                        return 75;
                    if (local > 94 && local <= 97)
                        return 76;
                    if (local > 97 && local <= 99)
                        return 77;
                    if (local > 99 && local <= 100)
                        return 78;
                    break;
                case 2:
                    if (local >= 1 && local <= 13)
                        return 72;
                    if (local > 13 && local <= 69)
                        return 73;
                    if (local > 69 && local <= 82)
                        return 74;
                    if (local > 82 && local <= 90)
                        return 75;
                    if (local > 90 && local <= 95)
                        return 76;
                    if (local > 95 && local <= 98)
                        return 77;
                    if (local > 98 && local <= 100)
                        return 78;
                    break;
                case 3:
                    if (local >= 1 && local <= 8)
                        return 72;
                    if (local > 8 && local <= 21)
                        return 73;
                    if (local > 21 && local <= 71)
                        return 74;
                    if (local > 71 && local <= 84)
                        return 75;
                    if (local > 84 && local <= 92)
                        return 76;
                    if (local > 92 && local <= 97)
                        return 77;
                    if (local > 97 && local <= 100)
                        return 78;
                    break;
                case 4:
                    if (local >= 1 && local <= 5)
                        return 72;
                    if (local > 5 && local <= 13)
                        return 73;
                    if (local > 13 && local <= 26)
                        return 74;
                    if (local > 26 && local <= 74)
                        return 75;
                    if (local > 74 && local <= 87)
                        return 76;
                    if (local > 87 && local <= 95)
                        return 77;
                    if (local > 95 && local <= 100)
                        return 78;
                    break;
                case 5:
                    if (local >= 1 && local <= 8)
                        return 78;
                    if (local > 8 && local <= 21)
                        return 77;
                    if (local > 21 && local <= 71)
                        return 76;
                    if (local > 71 && local <= 84)
                        return 75;
                    if (local > 84 && local <= 92)
                        return 74;
                    if (local > 92 && local <= 97)
                        return 73;
                    if (local > 97 && local <= 100)
                        return 72;
                    break;
                case 6:
                    if (local >= 1 && local <= 13)
                        return 78;
                    if (local > 13 && local <= 69)
                        return 77;
                    if (local > 69 && local <= 82)
                        return 76;
                    if (local > 82 && local <= 90)
                        return 75;
                    if (local > 90 && local <= 95)
                        return 74;
                    if (local > 95 && local <= 98)
                        return 73;
                    if (local > 98 && local <= 100)
                        return 72;
                    break;
                case 7:
                    if (local >= 1 && local <= 68)
                        return 78;
                    if (local > 68 && local <= 81)
                        return 77;
                    if (local > 81 && local <= 89)
                        return 76;
                    if (local > 89 && local <= 94)
                        return 75;
                    if (local > 94 && local <= 97)
                        return 74;
                    if (local > 97 && local <= 99)
                        return 73;
                    if (local > 99 && local <= 100)
                        return 72;
                    break;
            }
            return -1;
        }

    }
}
