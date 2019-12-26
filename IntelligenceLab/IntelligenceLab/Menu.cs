using System;
using System.Threading;

namespace IntelligenceLab
{
    public class Menu
    {
        public void Initialize()
        {
            Console.WriteLine("Welcome to Intelligence Lab");
            Thread.Sleep(2000);
        }

        public void DataGenerationStart()
        {
            Console.Clear();
            Console.WriteLine("Proceeding to generate in-memory data.");
            Thread.Sleep(2000);
        }

        public void DataGenerationEnd()
        {
            Console.Clear();
            Console.WriteLine("The data generation is completed successfully");
            Thread.Sleep(2000);
        }

        public void ShowAvailablePrograms()
        {
            Console.Clear();

            Console.WriteLine("The available programs are:");
            Thread.Sleep(250);

            Console.WriteLine("1. Sorting based on multilevel perceptron");
            Thread.Sleep(50);

            Console.WriteLine("2. Grouping based on k-means algorithm");
            Thread.Sleep(50);

            Console.WriteLine("3. Grouping based on LVQ algorithm");
            Thread.Sleep(50);

            Console.WriteLine("Select the program you want to execute:");
        }
    }
}
