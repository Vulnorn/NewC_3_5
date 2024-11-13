using System;

namespace NewC_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lengthArray = 30;
            int minRandomNumbers = 1;
            int maxRandomNumbers = 6;
            int quantitiesRepetitions = 1;
            int maxQuantitiesRepetitions = 1;
            int maxQuantitiesRepetitionsNumber = 0;
            int moreOneMaxRepetition = 0;

            int[] numbers = new int[lengthArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumbers, maxRandomNumbers);
                Console.Write($"{numbers[i]} ");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1])
                    quantitiesRepetitions++;
                else
                    quantitiesRepetitions = 1;

                if (quantitiesRepetitions > maxQuantitiesRepetitions)
                {
                    maxQuantitiesRepetitions = quantitiesRepetitions;
                    maxQuantitiesRepetitionsNumber = numbers[i];
                    moreOneMaxRepetition = 0;
                }
                else if (quantitiesRepetitions == maxQuantitiesRepetitions)
                {
                    moreOneMaxRepetition++;
                }
            }

            if (moreOneMaxRepetition == 0)
            {
                Console.WriteLine($"\nНаибольшее количество повторений подряд в массиве имет число {maxQuantitiesRepetitionsNumber} и оно повторяется {maxQuantitiesRepetitions} раз");
            }
            else
            {
                Console.WriteLine($"\nНет числа которое повторяется подрят больше всех раз.");
            }

            Console.ReadKey();
        }
    }
}