//Напишете израз, който да проверява дали дадено цяло число е четно
//или нечетно.
using System.Threading.Channels;

namespace _01_Task
{
    internal class OddOrEven
    {
        static void Main(string[] args)
        {
            int number, remainder;
            Console.WriteLine("Please enter an integer value: ");
            number = Convert.ToInt32(Console.ReadLine());
            remainder = number % 2;
            if (remainder ==0)
            {
                Console.WriteLine("{0} is an even number", number );
            }
            else
            {
                Console.WriteLine("{0} is an odd number", number);
            }    
        }
    }
}