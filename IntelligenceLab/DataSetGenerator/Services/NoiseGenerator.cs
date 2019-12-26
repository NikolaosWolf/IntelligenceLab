using DataGenerator.Models;
using DataGenerator.Models.Enums;
using System;
using System.Collections.Generic;

namespace DataGenerator.Services
{
    public class NoiseGenerator
    {
        public ISet<Example> GenerateNoise(ISet<Example> learningSet)
        {
            Random rnd = new Random();

            foreach (Example example in learningSet)
            {
                if (example.Category == CategoryType.Category2 || example.Category == CategoryType.Category3)
                {
                    double probability = rnd.NextDouble();

                    if (probability < 0.1)
                    {
                        example.Category = CategoryType.Category1;
                    }
                }
            }

            return learningSet;
        }
    }
}
