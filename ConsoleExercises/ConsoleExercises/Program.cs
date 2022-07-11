using System;
using System.Linq;

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
            Console.WriteLine("5.  How to evaluate an Even number (Numero Primo)");
            Console.WriteLine("6.  Syntax of the switch Statement");
            Console.WriteLine("7.  Syntax of Conditional Operator");
            Console.WriteLine("8.  While Loop Syntax");
            Console.WriteLine("9.  Do - While Loop Syntax");
            Console.WriteLine("10. For Loop -- Print first 10 multiples");
            Console.WriteLine("11. For Loop -- Show even and odd from String");
            Console.WriteLine("12. For Loop -- Print Array in reverse order");
            Console.WriteLine("13. Arrays -- Simple Array Sum");
            Console.WriteLine("14. Arrays -- Find MIN and MAX calculating summing 4 of the 5 elements");
            Console.WriteLine("15. Foreach -- Simple printing of array elements");
            Console.WriteLine("16. Foreach -- Printing array with LINQ and Foreach loop");
            Console.WriteLine("17. Foreach -- Compress String Exercise");
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
                    isEvenOrNot(Convert.ToInt32(Console.ReadLine().Trim()));
                    return true;
                case "6":
                    SwitchStatementSyntax(13);
                    return true;
                case "7":
                    ConditionalOperatorSyntax(18,18);
                    return true;
                case "8":
                    WhileLoopSyntax();
                    return true;
                case "9":
                    DoWhileLoopSyntax();
                    return true;
                case "10":
                    TenFirstMultiples(Convert.ToInt32(Console.ReadLine().Trim()));
                    return true;
                case "11":
                    ShowOddAndEven("Toronto");
                    return true;
                case "12":
                    ShowReverseArray();
                    return true;
                case "13":
                    ArraySimpleSum();
                    return true;
                case "14":
                    ArrayMinMaxSumFourOfFive();
                    return true;
                case "15":
                    PrintArraysForEach();
                    return true;
                case "16":
                    PrintArrayWithLINQ();
                    return true;
                case "17":
                    CompressString();
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

        private static void isEvenOrNot(int givenNumber)
        {
            Console.Title = "How to know if a number is even";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");

            bool isEven = givenNumber % 2 == 0;

            if (isEven)
            {
                Console.WriteLine("Not Weird");
            }
            else
            {
                Console.WriteLine("Weird");
            }

            Console.WriteLine("-----------Syntax to know if It is an even number------------------------------------------------\n");
            Console.WriteLine("-- bool isEven = givenNumber % 2 == 0;");
            Console.WriteLine("-- if (isEven)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine('Not Weird');");
            Console.WriteLine("-- }");
            Console.WriteLine("-- else");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine('Weird');");
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

        private static void TenFirstMultiples(int number)
        {
            Console.Title = "10 first multiples with For loop.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");
            
            
            for (int i = 1 ; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }


            Console.WriteLine("-----------How to show 10 first multiples of a number with a For loop.------------------------------------------------\n");
            Console.WriteLine("-- for (int i = 1 ; i <= 10; i++)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine($'{number} * {i} = {number * i}");
            Console.WriteLine("-- }");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void ShowOddAndEven(string T)
        {
            Console.Title = "Show Odd and Even with For loop.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");

            string evenChars = "";
            string oddChars = "";

            for (int i = 0; i < T.Length; i++)
            {
                string C = T[i].ToString();

                if (i % 2 == 0)
                {
                    evenChars = evenChars + C;
                }
                else
                {
                    oddChars = oddChars + C;
                }
            }

            Console.WriteLine($"{evenChars} {oddChars}");



            Console.WriteLine("-----------How to Show Odd and Even with For loop.------------------------------------------------\n");
            Console.WriteLine("-- string evenChars = '';");
            Console.WriteLine("-- string oddChars = '';");
            Console.WriteLine("-- for (int i = 0; i < T.Length; i++)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   string C = T[i].ToString();");
            Console.WriteLine("--   if (i % 2 == 0)");
            Console.WriteLine("--   {");
            Console.WriteLine("--       evenChars = evenChars + C;");
            Console.WriteLine("--   }");
            Console.WriteLine("--   else");
            Console.WriteLine("--   {");
            Console.WriteLine("--       oddChars = oddChars + C;");
            Console.WriteLine("--   }");
            Console.WriteLine("-- }");
            Console.WriteLine("-- Console.WriteLine($'{evenChars} {oddChars}');");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void ShowReverseArray()
        {
            Console.Title = "Show reverse array.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");

            int[] numbers = { 1, 2, 3, 4 };
            string output = "";

            for (int i = (numbers.Length - 1); i> -1; i--)
            {
                output = output + numbers[i] + " ";
            }
            Console.WriteLine(output);

            Console.WriteLine("-----------Show reverse array with For loop.------------------------------------------------\n");
            Console.WriteLine("-- int[] numbers = { 1, 2, 3, 4 };");
            Console.WriteLine("-- string output = '';");
            Console.WriteLine("-- for (int i = (numbers.Length - 1); i> -1; i--)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   output = output + numbers[i] + ' ';");
            Console.WriteLine("-- }");
            Console.WriteLine("-- Console.WriteLine(output);");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void ArraySimpleSum()
        {
            Console.Title = "Show Sum of an Array.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");

            int[] arr = { 1, 2, 3, 4 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine("-----------Show reverse array with For loop.------------------------------------------------\n");
            Console.WriteLine("-- int[] arr = { 1, 2, 3, 4 };");
            Console.WriteLine("-- int sum = 0;");
            Console.WriteLine("-- for (int i = 0; i < arr.Length; i++)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   sum += arr[i];");
            Console.WriteLine("-- }");
            Console.WriteLine("-- Console.WriteLine(sum);");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void ArrayMinMaxSumFourOfFive()
        {
            Console.Title = "Find MIN and MAX calculating summing 4 of the 5 elements.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");

            int[] arr = { 1,3,5,7,9 };
            Array.Sort(arr);

            long min = arr.Take(4).Sum(item => (long)item);
            long max = arr.Skip(1).Sum(item => (long)item);

            Console.WriteLine($"{min} {max}");

            Console.WriteLine("-----------Find MIN and MAX calculating summing 4 of the 5 elements.------------------------------------------------\n");
            Console.WriteLine("-- int[] arr = { 1,3,5,7,9 };");
            Console.WriteLine("-- Array.Sort(arr);");
            Console.WriteLine("-- long min = arr.Take(4).Sum();");
            Console.WriteLine("-- long max = arr.Skip(1).Sum();");
            Console.WriteLine("-- Console.WriteLine($'{min} {max}');");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }

        private static void PrintArraysForEach()
        {
            Console.Title = "Print a simple string and int array with Foreach loop.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");

            string[] carTypes = { "Ford", "BMW", "Mercedes Benz", "Lotus" };
            foreach (string carModel in carTypes)
            {
                Console.WriteLine(carModel);
            }

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------Print a simple string and int array with Foreach loop.------------------------------------------------\n");
            Console.WriteLine("-- string[] carTypes = { 'Ford', 'BMW', 'Mercedes Benz', 'Lotus' };");
            Console.WriteLine("-- foreach (string carModel in carTypes)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine(carModel);");
            Console.WriteLine("-- }");
            Console.WriteLine("-- ---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-- int[] myInts = { 10, 20, 30, 40 };");
            Console.WriteLine("-- foreach (int i in myInts)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine(i);");
            Console.WriteLine("-- }");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }


        private static void PrintArrayWithLINQ()
        {
            Console.Title = "Printing array with LINQ and Foreach loop.";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------\n");

            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            //LINQ query
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in Subset: ");

            foreach (var i in subset)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("-----------Printing array with LINQ and Foreach loop.------------------------------------------------\n");
            Console.WriteLine("-- int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };");
            Console.WriteLine("-- //LINQ query");
            Console.WriteLine("-- var subset = from i in numbers where i < 10 select i;");
            Console.WriteLine("-- Console.WriteLine('Values in Subset: ');");
            Console.WriteLine("-- foreach (var i in subset)");
            Console.WriteLine("-- {");
            Console.WriteLine("--   Console.WriteLine($'{i}');");
            Console.WriteLine("-- }");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
        }


        private static void CompressString()
        {
            string textToCompress = "kkkktttrrrrrrrrrr";
            int coincidences = 0;
            string finalCompressMessage = string.Empty;

            // Variable totalStringDigits extracts info for total digits from string
            int totalStringDigits = textToCompress.ToString().Length;

            // Convert string into an Array
            string[] arrayFromText = new string[textToCompress.Length];
            for (int i=0; i < totalStringDigits; i++)
            {
                arrayFromText[i] = textToCompress[i].ToString();
            }

            //Compare each position from string with each position from array
            //foreach (var e in textToCompress)
            foreach (string e in arrayFromText)
            {
                foreach (string arrayElement in arrayFromText)
                {  
                    if (e.ToString().Equals(arrayElement))
                    {
                        coincidences++;                        
                    }
                    finalCompressMessage = coincidences + e;
                    //Console.WriteLine(finalCompressMessage);
                }
            string keyToRemove = e.ToString();
            arrayFromText = arrayFromText.Where(val => val != keyToRemove).ToArray();
            Console.WriteLine(finalCompressMessage);
                coincidences = 0;
            }
            Console.ReadLine();
        }
    }
}
