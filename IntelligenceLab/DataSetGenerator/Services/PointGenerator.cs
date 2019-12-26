using DataGenerator.Models;
using System;
using System.Collections.Generic;

namespace DataGenerator.Services
{
    public class PointGenerator
    {
        public PointResult GeneratePoints()
        {
            Random rnd = new Random();

            PointResult points = new PointResult()
            {
                Circle = GenerateCirclePoints(rnd),
                Square1 = GenerateSquare1Points(rnd),
                Square2 = GenerateSquare2Points(rnd),
                Square3 = GenerateSquare3Points(rnd),
                Square4 = GenerateSquare4Points(rnd),
                Square5 = GenerateSquare5Points(rnd)
            };

            return points;
        }

        private ISet<Point> GenerateCirclePoints(Random rnd)
        {
            HashSet<Point> circlePoints = new HashSet<Point>();

            for (int i = 0; i < 100; i++)
            {
                double r = 0.3 * Math.Sqrt(rnd.NextDouble());
                double t = 2 * Math.PI * rnd.NextDouble();

                Point newPoint = new Point()
                {
                    X1 = r * Math.Cos(t),
                    X2 = r * Math.Sin(t)
                };

                circlePoints.Add(newPoint);
            }

            return circlePoints;
        }

        private ISet<Point> GenerateSquare1Points(Random rnd)
        {
            HashSet<Point> squarePoints = new HashSet<Point>();

            for (int i = 0; i < 100; i++)
            {
                Point newPoint = new Point()
                {
                    X1 = (rnd.NextDouble() * 0.6) - 1.1,
                    X2 = (rnd.NextDouble() * 0.6) + 0.5
                };

                squarePoints.Add(newPoint);
            }

            return squarePoints;
        }

        private ISet<Point> GenerateSquare2Points(Random rnd)
        {
            HashSet<Point> squarePoints = new HashSet<Point>();

            for (int i = 0; i < 100; i++)
            {
                Point newPoint = new Point()
                {
                    X1 = (rnd.NextDouble() * 0.6) - 1.1,
                    X2 = (rnd.NextDouble() * 0.6) - 1.1
                };

                squarePoints.Add(newPoint);
            }

            return squarePoints;
        }

        private ISet<Point> GenerateSquare3Points(Random rnd)
        {
            HashSet<Point> squarePoints = new HashSet<Point>();

            for (int i = 0; i < 100; i++)
            {
                Point newPoint = new Point()
                {
                    X1 = (rnd.NextDouble() * 0.6) + 0.5,
                    X2 = (rnd.NextDouble() * 0.6) - 1.1
                };

                squarePoints.Add(newPoint);
            }

            return squarePoints;
        }

        private ISet<Point> GenerateSquare4Points(Random rnd)
        {
            HashSet<Point> squarePoints = new HashSet<Point>();

            for (int i = 0; i < 100; i++)
            {
                Point newPoint = new Point()
                {
                    X1 = (rnd.NextDouble() * 0.6) + 0.5,
                    X2 = (rnd.NextDouble() * 0.6) + 0.5
                };

                squarePoints.Add(newPoint);
            }

            return squarePoints;
        }

        private ISet<Point> GenerateSquare5Points(Random rnd)
        {
            HashSet<Point> squarePoints = new HashSet<Point>();

            for (int i = 0; i < 100; i++)
            {
                Point newPoint = new Point()
                {
                    X1 = (rnd.NextDouble() * 2) - 1,
                    X2 = (rnd.NextDouble() * 2) - 1
                };

                squarePoints.Add(newPoint);
            }

            return squarePoints;
        }
    }
}
