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
            Console.WriteLine("2.  Show Environment Details");
            Console.WriteLine("3.  Show Formats in Numerical Data");
            Console.WriteLine("4.  Syntax of the if-else Statement");
            Console.WriteLine("5.  Syntax of the switch Statement");
            Console.WriteLine("6.  Syntax of Conditional Operator");
            Console.WriteLine("7.  While Loop Syntax");
            Console.WriteLine("8.  Do - While Loop Syntax");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("X.  Exit.");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ShowDateTimeFormats();
                    return true;
                case "2":
                    ShowEnvironmentDetails();
                    return true;
                case "3":
                    FormatNumericalData(99999);
                    return true;
                case "4":
                    IfElseSyntax(13);
                    return true;
                case "5":
                    SwitchStatementSyntax(13);
                    return true;
                case "6":
                    ConditionalOperatorSyntax(18,18);
                    return true;
                case "7":
                    WhileLoopSyntax();
                    return true;
                case "8":
                    DoWhileLoopSyntax();
                    return true;
                case "X":
                    Console.WriteLine("Leaving...\a");
                    return false;
                default:
                    return true;
            }
        }

        private static void ShowDateTimeFormats()
        {
            Console.Title = "My Rocking App 2022";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
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
            Console.WriteLine("---Dates and Times-----------------------------------------");
            DateTime dt = new DateTime(2022,01,19);
            Console.WriteLine("The day of {0} is {1}",dt.Date, dt.DayOfWeek);
            Console.WriteLine("The time of day {0} is {1}", dt.Date, dt.TimeOfDay);
            Console.WriteLine("-----------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Enviroment Details \n");
                Console.WriteLine("Drive: {0}",drive);
                Console.WriteLine("OS: {0}", Environment.OSVersion);
                Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
                Console.WriteLine(".Net Core Version: {0}", Environment.Version);
                Console.WriteLine("User: {0}", Environment.UserName);
                Console.WriteLine("Machine Name: {0}", Environment.MachineName);
                Console.WriteLine("-----------------------------------------------------------");
                Console.ReadLine();
            }
        }

        private static void FormatNumericalData(int numberToFormat)
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Formatting Numerical Data \n");
            Console.WriteLine("The Value " + numberToFormat + " in various formats: ");
            Console.WriteLine("c format: {0:c}",numberToFormat);
            Console.WriteLine("d9 format: {0:d9}", numberToFormat);
            Console.WriteLine("f3 format: {0:f3}", numberToFormat);
            Console.WriteLine("n format: {0:n}", numberToFormat);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Determines if letters are upper or lower");
            Console.WriteLine("E format: {0:E}", numberToFormat);
            Console.WriteLine("e format: {0:e}", numberToFormat);
            Console.WriteLine("X format: {0:X}", numberToFormat);
            Console.WriteLine("x format: {0:x}", numberToFormat);
            Console.WriteLine("-----------------------------------------------------------");
            Console.ReadLine();
        }

        private static void IfElseSyntax(int ageUser)
        {
            Console.Title = "If - Else Syntax";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------");
            if (ageUser >= 18)
            {
                Console.WriteLine("You are ready to Work and make money!");
            }
            else
            {
                Console.WriteLine("Keep studying dude!!");
            }
            Console.WriteLine("-----------------------------------------------------------\n");
            Console.WriteLine("-- if (ageUser >= 18)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine('You are ready to Work and make money!');");
            Console.WriteLine("-- }");
            Console.WriteLine("-- else");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine('Keep studying dude!!');");
            Console.WriteLine("-- }");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void SwitchStatementSyntax(int dayOfTheWeek)
        {
            Console.Title = "Switch Statement Syntax";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------");
            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("This number corresponds to MONDAY");
                    break;
                case 2:
                    Console.WriteLine("This number corresponds to TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("This number corresponds to WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("This number corresponds to THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("This number corresponds to FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("This number corresponds to SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("This number corresponds to SUNDAY");
                    break;
                default:
                    Console.WriteLine("This is not a valid option.");
                    break;
            }
            Console.WriteLine("-----------------------------------------------------------\n");
            Console.WriteLine("-- switch (dayOfTheWeek)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   case 1:");
            Console.WriteLine("--     Console.WriteLine('This number corresponds to MONDAY');");
            Console.WriteLine("--     break;");
            Console.WriteLine("--   case 2:");
            Console.WriteLine("--     Console.WriteLine('This number corresponds to TUESDAY');");
            Console.WriteLine("--     break;");
            Console.WriteLine("--   case 3:");
            Console.WriteLine("--     Console.WriteLine('This number corresponds to WEDNESDAY');");
            Console.WriteLine("--     break;");
            Console.WriteLine("--   case 4:");
            Console.WriteLine("--     Console.WriteLine('This number corresponds to THURSDAY');");
            Console.WriteLine("--     break;");
            Console.WriteLine("--   case 5:");
            Console.WriteLine("--     Console.WriteLine('This number corresponds to FRIDAY');");
            Console.WriteLine("--     break;");
            Console.WriteLine("--   case 6:");
            Console.WriteLine("--     Console.WriteLine('This number corresponds to SATURDAY');");
            Console.WriteLine("--     break;");
            Console.WriteLine("--   case 7:");
            Console.WriteLine("--     Console.WriteLine('This number corresponds to SUNDAY');");
            Console.WriteLine("--     break;");
            Console.WriteLine("--   default:");
            Console.WriteLine("--     Console.WriteLine('This is not a valid option.');");
            Console.WriteLine("--     break;");
            Console.WriteLine("-- }");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void ConditionalOperatorSyntax(int numberIni, int numberEnd)
        {
            Console.Title = "Conditional Operator Syntax";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");
            Console.WriteLine("-- Params --> (18, 18)");
            Console.WriteLine("-- decimal result = numberIni >= numberEnd ? .1m : .05m ;");
            Console.WriteLine("-- Console.WriteLine(result);");           
            decimal result = numberIni >= numberEnd ? .1m : .05m ;
            Console.WriteLine(result);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void WhileLoopSyntax()
        {
            Console.Title = "While Loop Syntax";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");
            int i = 1, totalSum = 0;
            while (i < 10)
            {
                totalSum += i;
                i++;
                Console.WriteLine($"Executing While Loop ,value of i: {i} and value of totalSum: {totalSum}");
            }
            Console.WriteLine("-----------Bool Expression Evaluated at the beginning------------------------------------------------\n");
            Console.WriteLine("-- int i = 1, totalSum = 0;");
            Console.WriteLine("-- while (i < 10)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   totalSum += i;");
            Console.WriteLine("--   i++;");
            Console.WriteLine("--   Console.WriteLine($'Executing While Loop ,value of i: {i} and value of totalSum: {totalSum}');");
            Console.WriteLine("-- }");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void DoWhileLoopSyntax()
        {
            Console.Title = "While Loop Syntax";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");
            int i = 1;
            do
            {
                Console.WriteLine($"Executing Do While Loop, Value of i: {i}");
                i++;
            } while (i <= 10);
            Console.WriteLine("-----------Bool Expression Evaluated at the end------------------------------------------------\n");
            Console.WriteLine("-- int i = 0;");
            Console.WriteLine("-- do");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine($'Executing Do While Loop, Value of i: {i}');");
            Console.WriteLine("--   i++;");
            Console.WriteLine("-- }");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }
    }
}
