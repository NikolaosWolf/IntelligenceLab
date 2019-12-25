using DataSetGenerator.Models;
using DataSetGenerator.Models.Enums;
using System;

namespace DataSetGenerator.Services
{
    public class ExampleGenerator
    {
        public ExampleResult GenerateExamples()
        {
            Random rnd = new Random();

            ExampleResult result = new ExampleResult();

            #region Learning Set Examples

            for (int i = 0; i < 3000; i++)
            {
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

                result.LearningSet.Add(newExample);
            }

            #endregion

            #region Control Set Examples

            for (int i = 0; i < 3000; i++)
            {
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

                result.ControlSet.Add(newExample);
            }

            #endregion


            return result;
        }
    }
}
