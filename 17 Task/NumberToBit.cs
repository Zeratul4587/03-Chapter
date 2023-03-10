//Number to Bit 
//Display a given number
//into byte system
//of 0s and 1s 
namespace _17_Task
{
    internal class NumberToBit
    {
        static void Main(string[] args)
        {
            // Warm up with some simple equation
            int number1, number2, result;
            Console.WriteLine("Enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            number2= Convert.ToInt32(Console.ReadLine());
            
            result = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, result);
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();

            Console.Clear();
            //Напишете програма, която преобразува дадено число 
            //от десетична в
            //двоична бройна система.

            Console.WriteLine("Decimal : ");

            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result1 = string.Empty;
            while (decimalNumber > 0) 
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result1 = remainder.ToString() + result1;
            }
            Console.WriteLine("Binary : {0}", result1);
            Console.ReadLine();
        }

    }
}