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
            int number;
            int maxQuantitiesRepetitions = 1;
            int maxQuantitiesRepetitionsNumber = 0;
            int moreOneMaxRepetition = 0;

            int[] numbers = new int[lengthArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumbers, maxRandomNumbers);
                Console.Write($"{numbers[i]} ");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == number)
                    {
                        quantitiesRepetitions++;
                    }
                    else
                    {
                        if (quantitiesRepetitions > maxQuantitiesRepetitions)
                        {
                            maxQuantitiesRepetitions = quantitiesRepetitions;
                            maxQuantitiesRepetitionsNumber = number;
                            moreOneMaxRepetition = 0;
                        }
                        else if (quantitiesRepetitions == maxQuantitiesRepetitions)
                        {
                            moreOneMaxRepetition++;
                        }

                        quantitiesRepetitions = 1;
                        break;
                    }
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