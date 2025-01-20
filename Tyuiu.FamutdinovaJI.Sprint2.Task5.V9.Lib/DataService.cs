using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FamutdinovaJI.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res;
            string mounth;
            string day;

            switch (n)
            {
                case 1:
                    day = "02";
                    break;
                case 2:
                    day = "03";
                    break;
                case 3:
                    day = "04";
                    break;
                case 4:
                    day = "05";
                    break;
                case 5:
                    day = "06";
                    break;
                case 6:
                    day = "07";
                    break;
                case 7:
                    day = "08";
                    break;
                case 8:
                    day = "09";
                    break;
                case 9:
                    day = "10";
                    break;
                case 10:
                    day = "11";
                    break;
                case 11:
                    day = "12";
                    break;
                case 12:
                    day = "13";
                    break;
                case 13:
                    day = "14";
                    break;
                case 14:
                    day = "15";
                    break;
                case 15:
                    day = "16";
                    break;
                case 16:
                    day = "17";
                    break;
                case 17:
                    day = "18";
                    break;
                case 18:
                    day = "19";
                    break;
                case 19:
                    day = "20";
                    break;
                case 20:
                    day = "21";
                    break;
                case 21:
                    day = "22";
                    break;
                case 22:
                    day = "23";
                    break;
                case 23:
                    day = "24";
                    break;
                case 24:
                    day = "25";
                    break;
                case 25:
                    day = "26";
                    break;
                case 26:
                    day = "27";
                    break;
                case 27:
                    day = "28";
                    break;
                case 28:
                    day = "29";
                    break;
                case 29:
                    day = "30";
                    break;
                case 30:
                    day = "31";
                    break;
                case 31:
                    day = "1";
                    break;
                default:
                    throw new ArgumentException("err");
            }
            switch (m)
            {
                case 1:
                    mounth = "01";
                    break;
                case 2:
                    mounth = "02";
                    break;
                case 3:
                    mounth = "03";
                    break;
                case 4:
                    mounth = "04";
                    break;
                case 5:
                    mounth = "05";
                    break;
                case 6:
                    mounth = "06";
                    break;
                case 7:
                    mounth = "07";
                    break;
                case 8:
                    mounth = "08";
                    break;
                case 9:
                    mounth = "09";
                    break;
                case 10:
                    mounth = "10";
                    break;
                case 11:
                    mounth = "11";
                    break;
                case 12:
                    mounth = "12";
                    break;
                default:
                    throw new ArgumentException("err");
            }
            res = day + "." + mounth;
            return res;
        }
    }
}
