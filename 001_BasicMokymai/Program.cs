using System.Threading.Tasks;

namespace _001_BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Taks #4 Find, describe, and fix a bug in your app

            double weeklyPay = 600;
            double dailyEarnings = weeklyPay / 7;
            Console.WriteLine(dailyEarnings);

            //Task 3: Find and fix

            Console.WriteLine("Temp in degrees C:");
            string input = Console.ReadLine();
            double degreesC = Convert.ToDouble(input);
            Console.WriteLine("Degrees K: " + (degreesC + 273.15));

            //Task 2:

            string day = "Wednesday";
            Console.WriteLine($"{day}");



            //var a = 5;
            //var b = 6;

            //if ( ++a == b || b++ == a++ )
            //{
            //    b++;
            //}
            //Console.WriteLine(a + " " + b);

            //Console.WriteLine("Please type in a number");

            //var input = Console.ReadLine();
            //int number = Convert.ToInt32(input);
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //} else if (number % 2 != 0)
            //{
            //    Console.WriteLine("Number is odd");
            //} else
            //{
            //    Console.WriteLine($"You typed in {number}");
            //}

            //Console.WriteLine("Please type in number of band members.");

            //var input2 = Console.ReadLine();
            //int number2 = Convert.ToInt32(input2);

            //if (number2 == 1)
            //{
            //    Console.WriteLine("It's a solo act");
            //} else if (number2 == 2)
            //{
            //    Console.WriteLine("It's a duo");
            //} else if (number2 > 2 && number2 < 10)
            //{
            //    Console.WriteLine("It's a band");
            //} else if (number2 >= 10)
            //{
            //    Console.WriteLine("It's a chorus");
            //} else
            //{
            //    Console.WriteLine($"Error. You typed in an unsupported number probably ({number2}).");
            //}

            //Console.WriteLine("Please type in hours worked");
            //var input3 = Console.ReadLine();
            //int number3 = Convert.ToInt32(input3);

            //if (number3 < 160) 
            //{
            //    Console.WriteLine($"You need to work {160 - number3} more hours.");
            //} else if (number3 == 160)
            //{
            //    Console.WriteLine("You have worked full time");
            //} else if (number3 > 160)
            //{
            //    Console.WriteLine($"You have worked {number3 - 160} overtime hours.");
            //}

            //Console.WriteLine("Please write the grade for the exam");
            //var input4 = Console.ReadLine();
            //int number4 = Convert.ToInt32(input4);
            //switch (number4)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("Failed");
            //        break;
            //    case 5:
            //        Console.WriteLine("Weak");
            //        break;
            //    case 6:
            //        Console.WriteLine("Satisfactory");
            //        break;
            //    case 7:
            //        Console.WriteLine("Average");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ok");
            //        break;
            //    case 9:
            //        Console.WriteLine("Very good");
            //        break;
            //    case 10:
            //        Console.WriteLine("Excellent");
            //        break;
            //    default:
            //        Console.WriteLine($"Unknown grade ({number4})");
            //        break;
            //}
        }
    }
}