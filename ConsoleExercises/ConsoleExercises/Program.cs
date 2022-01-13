using System;

namespace ConsoleExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            //Create Menu with to check available exercises
            Console.Clear();
            Console.WriteLine("Welcome to Available Apps");
            Console.WriteLine("===========================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Show Basic formats");
            Console.WriteLine("1.  Show Datetimes formats");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("X.  Exit.");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ShowDateTimeFormats();
                    return true;
                case "X":
                    return false;
                default:
                    return true;
            }
        }

        private static void ShowDateTimeFormats()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Date Time Formats \n");
            Console.WriteLine("DateTime.Now.ToString('MM/dd/yyyy') -- Will Display : \n" + DateTime.Now.ToString("MM/dd/yyyy") + "\n");
            Console.WriteLine("DateTime.Now -- Will Display : \n" + DateTime.Now + "\n");
            Console.WriteLine("DateTime.Now.ToString('HH: mm:ss') -- Will Display : \n" + DateTime.Now.ToString("HH:mm:ss") + "\n");
            Console.WriteLine("DateTime.Now.ToString('hh: mm:ss tt') -- Will Display : \n" + DateTime.Now.ToString("hh:mm:ss tt") + "\n");            
            Console.WriteLine("DateTime.Now.ToShortDateString() -- Will Display : \n" + DateTime.Now.ToShortDateString() + "\n");
            Console.WriteLine("DateTime.Now.ToString('dddd, MMM dd yyyy, hh: mm:ss') -- Will Display : \n" + DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss") + "\n");
            Console.WriteLine("Please refer to:  http://www.geekzilla.co.uk/View00FF7904-B510-468C-A2C8-F859AA20581F.htm ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
