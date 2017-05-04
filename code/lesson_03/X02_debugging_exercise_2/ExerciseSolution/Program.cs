using System;

namespace ExerciseSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberNotFound = true;
            int number = 2520;

            while(numberNotFound)
            {
                number += 2;
                for(int devider = 2; devider <= 20; devider++)
                {
                    if(number % devider != 0)
                        break;
                    if(devider >= 20)
                        numberNotFound = false;
                }
            }

            // 232792560 ist das Ergebnis
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}