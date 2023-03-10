//Напишете израз
//който да проверява
//дали третият бит
//на дадено число
//е 1 или 0
using System.Threading.Tasks;
using System;

namespace _04_Task
{
    internal class ThirdBit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            
            int number = Convert.ToInt32(Console.ReadLine());
            bool bit3 = (number & 8) != 0;

            Console.WriteLine("The third bit of {0} is 1? {1}", number, bit3);

        }
    }
}