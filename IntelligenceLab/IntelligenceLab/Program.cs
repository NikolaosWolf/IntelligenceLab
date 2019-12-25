using DataSetGenerator.Models;
using DataSetGenerator.Services;
using System;

namespace IntelligenceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ExampleGenerator generator = new ExampleGenerator();
            NoiseGenerator noise = new NoiseGenerator();

            ExampleResult result = generator.GenerateExamples();

            result.LearningSet = noise.GenerateNoise(result.LearningSet);

            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;

            foreach (var learningExample in result.LearningSet)
            {
                if (learningExample.Category == DataSetGenerator.Models.Enums.CategoryType.Category1)
                {
                    counter1++;
                }

                if (learningExample.Category == DataSetGenerator.Models.Enums.CategoryType.Category2)
                {
                    counter2++;
                }

                if (learningExample.Category == DataSetGenerator.Models.Enums.CategoryType.Category3)
                {
                    counter3++;
                }

                Console.WriteLine("{0} - {1} - {2}", learningExample.X1, learningExample.X2, learningExample.Category);
            }

            Console.WriteLine("{0} - {1} - {2}", counter1, counter2, counter3);

        }
    }
}
