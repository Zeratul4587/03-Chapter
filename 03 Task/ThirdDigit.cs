// Напишете израз,
// който да проверява
// дали третата цифра
// (от дясно на ляво)
//на дадено цяло число е 7.
namespace _03_Task
{
    using System;
    using System.Threading;
    using System.Globalization;
    using System.Data;

    internal class ThirdDigit
    {
        static void Main(string[] args)
        {
            //Ask the user to enter a whole number (this step can be seen as a console input)
            Console.WriteLine("Please write a whole number: ");
            //Save that whole number in computer's memory of what the user entered (this is a user Input)
            int wholenumber = Convert.ToInt32(Console.ReadLine());
            //Devide the whole number by 100 and then the resoult will be devide again by module (%) 10, to find the reminder
            int thirdDigit = (wholenumber / 100) % 10;
            //Check if the remeinder is equal to 7
            if (thirdDigit == 7)
            {
                Console.WriteLine("The third digit is 7. ");
            }
            else 
            {
                Console.WriteLine("The third digit is not 7. ");
            }
        }
    }
}