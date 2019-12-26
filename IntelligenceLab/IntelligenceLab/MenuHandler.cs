using DataGenerator.Models;
using DataGenerator.Services;
using System;
using System.Threading;

namespace IntelligenceLab
{
    public class MenuHandler
    {
        private ExampleResult Examples { get; set; }
        private PointResult Points { get; set; }

        private bool runLab;

        public void Execute()
        {
            Menu menu = new Menu();

            menu.Initialize();

            //menu.DataGenerationStart();
            //GenerateData();
            //menu.DataGenerationEnd();


            do
            {
                menu.ShowAvailablePrograms();
                runLab = SelectProgram();
            } while (runLab);
        }

        private void GenerateData()
        {
            ExampleGenerator exampleGenerator = new ExampleGenerator();
            NoiseGenerator noise = new NoiseGenerator();
            Examples = exampleGenerator.GenerateExamples();
            Examples.LearningSet = noise.GenerateNoise(Examples.LearningSet);


            PointGenerator pointGenerator = new PointGenerator();
            Points = pointGenerator.GeneratePoints();
        }

        private bool SelectProgram()
        {
            string userInput = Console.ReadLine();
            short choice = Int16.Parse(userInput);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You selected 'Sorting based on multilevel perceptron'");
                    Console.WriteLine("Proceeding to execute the selected program");
                    Thread.Sleep(2000);
                    return true;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You selected 'Grouping based on k-means algorithm'");
                    Console.WriteLine("Proceeding to execute the selected program");
                    Thread.Sleep(2000);
                    return true;
                case 3:
                    Console.Clear();
                    Console.WriteLine("You selected 'Grouping based on LVQ algorithm'");
                    Console.WriteLine("Proceeding to execute the selected program");
                    Thread.Sleep(2000);
                    return true;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Exiting Intelligence Lab...");
                    Thread.Sleep(2000);
                    return false;
                default:
                    Console.Clear();
                    Console.WriteLine("Your choice was invalid. Please choose again");
                    Thread.Sleep(2000);
                    return true;
            }
        }
    }
}
