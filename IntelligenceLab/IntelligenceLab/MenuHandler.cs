using DataGenerator.Models;
using DataGenerator.Services;

namespace IntelligenceLab
{
    public class MenuHandler
    {
        private ExampleResult Examples { get; set; }
        private PointResult Points { get; set; }

        public void Execute()
        {
            Menu menu = new Menu();

            menu.Initialize();

            menu.DataGenerationStart();
            GenerateData();
            menu.DataGenerationEnd();

            menu.ShowAvailablePrograms();
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
    }
}
