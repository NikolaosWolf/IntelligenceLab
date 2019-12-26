using DataGenerator.Models;
using DataGenerator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DataGenerator.Services
{
    public class ExampleGenerator
    {
        private int progress = 0;
        public ExampleResult GenerateExamples()
        {
            Random rnd = new Random();

            ExampleResult examples = new ExampleResult
            {
                LearningSet = GenerateLearningSet(rnd),
                ControlSet = GenerateControlSet(rnd)
            };

            return examples;
        }

        private ISet<Example> GenerateLearningSet(Random rnd)
        {
            HashSet<Example> learningSet = new HashSet<Example>();

            for (int i = 0; i < 3000; i++)
            {
                if (i % 60 == 0)
                {
                    Console.Clear();

                    progress++;

                    Console.WriteLine("{0}%", progress);
                    Thread.Sleep(10);
                }

                Example newExample = new Example()
                {
                    X1 = (rnd.NextDouble() * 4) - 2,
                    X2 = (rnd.NextDouble() * 4) - 2
                };

                if (Math.Pow((newExample.X1 - 1), 2.0) + Math.Pow((newExample.X2 - 1), 2.0) <= 0.49)
                {
                    newExample.Category = CategoryType.Category2;
                }
                else if (Math.Pow((newExample.X1 + 1), 2.0) + Math.Pow((newExample.X2 + 1), 2.0) <= 0.49)
                {
                    newExample.Category = CategoryType.Category2;
                }
                else if (Math.Pow((newExample.X1 + 1), 2.0) + Math.Pow((newExample.X2 - 1), 2.0) <= 0.49)
                {
                    newExample.Category = CategoryType.Category3;
                }
                else if (Math.Pow((newExample.X1 - 1), 2.0) + Math.Pow((newExample.X2 + 1), 2.0) <= 0.49)
                {
                    newExample.Category = CategoryType.Category3;
                }
                else
                {
                    newExample.Category = CategoryType.Category1;
                }

                learningSet.Add(newExample);
            }

            return learningSet;
        }

        private ISet<Example> GenerateControlSet(Random rnd)
        {
            HashSet<Example> controlSet = new HashSet<Example>();

            for (int i = 0; i < 3000; i++)
            {
                if (i % 60 == 0)
                {
                    Console.Clear();

                    progress++;

                    Console.WriteLine("{0}%", progress);
                    Thread.Sleep(10);
                }

                Example newExample = new Example()
                {
                    X1 = (rnd.NextDouble() * 4) - 2,
                    X2 = (rnd.NextDouble() * 4) - 2
                };

                if (Math.Pow((newExample.X1 - 1), 2) + Math.Pow((newExample.X2 - 1), 2) <= 0.49)
                {
                    newExample.Category = CategoryType.Category2;
                }
                else if (Math.Pow((newExample.X1 + 1), 2) + Math.Pow((newExample.X2 + 1), 2) <= 0.49)
                {
                    newExample.Category = CategoryType.Category2;
                }
                else if (Math.Pow((newExample.X1 + 1), 2) + Math.Pow((newExample.X2 - 1), 2) <= 0.49)
                {
                    newExample.Category = CategoryType.Category3;
                }
                else if (Math.Pow((newExample.X1 - 1), 2) + Math.Pow((newExample.X2 + 1), 2) <= 0.49)
                {
                    newExample.Category = CategoryType.Category3;
                }
                else
                {
                    newExample.Category = CategoryType.Category1;
                }

                controlSet.Add(newExample);
            }

            return controlSet;
        }
    }
}
