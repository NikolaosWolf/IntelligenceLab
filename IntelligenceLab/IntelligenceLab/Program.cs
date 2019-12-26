namespace IntelligenceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuHandler handler = new MenuHandler();

            handler.Execute();




            //var counter1 = 0;
            //var counter2 = 0;
            //var counter3 = 0;

            //foreach (var learningExample in examples.LearningSet)
            //{
            //    if (learningExample.Category == DataSetGenerator.Models.Enums.CategoryType.Category1)
            //    {
            //        counter1++;
            //    }

            //    if (learningExample.Category == DataSetGenerator.Models.Enums.CategoryType.Category2)
            //    {
            //        counter2++;
            //    }

            //    if (learningExample.Category == DataSetGenerator.Models.Enums.CategoryType.Category3)
            //    {
            //        counter3++;
            //    }

            //    Console.WriteLine("{0} - {1} - {2}", learningExample.X1, learningExample.X2, learningExample.Category);
            //}

            //Console.WriteLine("{0} - {1} - {2}", counter1, counter2, counter3);

            //foreach (var point in points.Circle)
            //{
            //    Console.WriteLine("{0} - {1}", point.X1, point.X2);
            //}

        }
    }
}
