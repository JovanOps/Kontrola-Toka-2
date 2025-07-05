using System;

namespace KontrolaToka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };

          
            int[] positiveArray = new int[array.Length];
            int[] negativeArray = new int[array.Length];

            int posCounter = 0, negCounter = 0;

            
            foreach (int item in array)
            {
                if (item > 0)
                {
                    positiveArray[posCounter] = item;
                    posCounter++;
                }
                else if (item < 0)
                {
                    negativeArray[negCounter] = item;
                    negCounter++;
                }
            }

           
            Console.WriteLine("Pozitivni brojevi:");
            for (int i = 0; i < posCounter; i++)
            {
                Console.WriteLine(positiveArray[i]);
            }

           
            Console.WriteLine("Negativni brojevi:");
            for (int i = 0; i < negCounter; i++)
            {
                Console.WriteLine(negativeArray[i]);
            }
        }
    }
}
