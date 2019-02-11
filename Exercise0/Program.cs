using System;

namespace Exercise0
{
    class Program
    {

        public static string firstName;
        public static string lastName;


        /*
        public static DateTime todaysDate = DateTime.Now;
        public static DateTime yesterdaysDate = todaysDate.AddDays(-1);
        public static DateTime tomorrowsDate = todaysDate.AddDays(1);
        
        this is a change     
        */

        private static void RunExerciseOne()
        {
            string firstName1 = "Henrik";
            string lastName1 = "Granmyr";
            Console.WriteLine("Hello " + firstName1 + " " + lastName1 + " I'm glad to inform you that you are the test subject of my very first assignment");
        }
        private static void RunExerciseTwo()
        {
            DateTime todaysDate = DateTime.Now;
            DateTime yesterdaysDate = todaysDate.AddDays(-1);
            DateTime tomorrowsDate = todaysDate.AddDays(1);

            Console.WriteLine("Today is " + todaysDate);
            Console.WriteLine("Tomorrow is " + tomorrowsDate);
            Console.WriteLine("Yesterday was " + yesterdaysDate);
        }
        public static void RunExerciseThree()                                           //Jag gjorde den här metoden offentlig bara för att testa
        {
            Console.WriteLine(
                "Success! Your name is: \n" +
                firstName + " " + lastName + "\n" +
                "This is a public method."                                              //Jag la till den här raden för skoj skull
                );
        }
        static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";
            string subStr = str.Substring(0);
            subStr = subStr.Replace("Jumped Over the DOG", "jumped over the dog");
            subStr = subStr.Remove(subStr.IndexOf("q"), 6);
            subStr = subStr.Insert(subStr.IndexOf(" "), " brown");
            subStr = subStr.Insert(subStr.LastIndexOf(" "), " lazy");
            Console.WriteLine(subStr);
        }
        static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like:[1,2,3,4,5]";
            string subStr = str.Substring(str.IndexOf("["));
            subStr = subStr.Remove(3, 4);
            subStr = subStr.Insert(subStr.IndexOf("]"), ",6,7,8,9,10");
            Console.WriteLine(subStr);
            Console.ReadLine();
        }
        static void RunExerciseSix()
        {
            int a;
            int b;
            Console.WriteLine("Insert first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number");
            b = int.Parse(Console.ReadLine());
            if (a > b) {
                Console.WriteLine(a + " is the bigger number");
                Console.WriteLine(b + " is the smaller number");
            }
            if (b > a) {
                Console.WriteLine(b + " is the bigger number");
                Console.WriteLine(a + " is the smaller number");
            }
            Console.WriteLine("The difference of " + a + " and " + b + " is:");
            Console.WriteLine(a - b);
            Console.WriteLine("The sum of " + a + " and " + b + " is:");
            Console.WriteLine(a + b);
            Console.WriteLine("The product of " + a + " and " + b + " is:");
            Console.WriteLine(a * b);
            if (a > b)
            {
                int rest = a % b;
                Console.WriteLine("The ratio of " + a + " and " + b + " is:");
                Console.WriteLine(a / b);
                Console.WriteLine("With a rest of " + rest);
            }
            if (b > a)
            {
                int rest = b % a;
                Console.WriteLine("The ratio of " + b + " and " + a + " is:");
                Console.WriteLine(b / a);
                Console.WriteLine("With a rest of " + rest);
            }
        }
        static void RunExerciseSeven()
        {
            double radius;
            double area;
            double vx;
            double volume;

            Console.WriteLine("Please insert a radius here:");
            radius = double.Parse(Console.ReadLine());
            area = 2 * System.Math.PI * radius * radius;
            Console.WriteLine("The area of a circle with the radius of " + radius + " is equal to: " + area);
            vx = 4 * System.Math.PI * radius * radius * radius;
            volume = vx / 3;
            Console.WriteLine("The volume of a sphere with the radius of " + radius + " is equal to: " + volume);

        }
        static void RunExerciseEight()
        {
            decimal decN;
            double sqrt;
            double pow2;
            double pow10;


            Console.WriteLine("Input a decimal number: ");
            decN = decimal.Parse(Console.ReadLine());

            double n = decimal.ToDouble(decN);
            sqrt = Math.Sqrt(n);
            pow2 = Math.Pow(n, 2);
            pow10 = Math.Pow(n, 10);





            Console.WriteLine("The square root of " + n + " equals " + sqrt);
            Console.WriteLine(n + " to the power of 2 equals " + pow2);
            Console.WriteLine(n + " to the power of 10 equals " + pow10);
            
        }
        static void RunExerciseNine()
        {
            string name;
            int birthYear;
            int thisYear;
            int age;

            Console.WriteLine("Please insert your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + ". Nice to meet you!");
            Console.WriteLine("Please enter your birth year:");
            birthYear = int.Parse(Console.ReadLine());
            thisYear = DateTime.Now.Year;
            age = thisYear - birthYear;

            Console.WriteLine("I calculate that you are " + age + " years old.");

            if (age >= 18)
            {
                int answ;
                Console.WriteLine(
                    "Do you want to order a beer?\n"+
                    "1: Yes         2: No"
                    );
                answ = int.Parse(Console.ReadLine());
                if (answ == 1) { Console.WriteLine("The order has been carried out, enjoy your beer!"); }
                else if (answ == 2)
                {
                    Console.WriteLine(
                        "Do you want to order a coke instead?\n" +
                        "1: Yes         2:No
                        );
                    answ = int.Parse(Console.ReadLine());
                    if (answ == 1)
                    {
                        Console.WriteLine("The coke has been served!");
                    }
                    else if (answ == 2) { Console.WriteLine("No more order options available."); }

                else { Console.WriteLine("Syntax Error: Unknown Request"); }
            }
            else
            {
                 Console.WriteLine(
                                    "Do you want to order a coke instead?\n" +
                                    "1: Yes         2:No
                                  );
                 answ = int.Parse(Console.ReadLine());
                 if (answ == 1)
                 {
                    Console.WriteLine("The coke has been served!");
                 }
            }


        }
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {

                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            Console.WriteLine("Please enter your first name: ");
                            firstName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Thank you, now enter your last name:");
                            lastName = Convert.ToString(Console.ReadLine());
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case -1:
                            keepAlive = false;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Exiting Program");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not an assignment number!");
                            break;

                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();

                }
            }
        }
    }
}
