using System.Collections.Generic;

namespace DataGenerator.Models
{
    public class PointResult
    {
        public PointResult()
        {
            Circle = new HashSet<Point>();
            Square1 = new HashSet<Point>();
            Square2 = new HashSet<Point>();
            Square3 = new HashSet<Point>();
            Square4 = new HashSet<Point>();
            Square5 = new HashSet<Point>();
        }

        public ISet<Point> Circle { get; set; }

        public ISet<Point> Square1 { get; set; }

        public ISet<Point> Square2 { get; set; }
        
        public ISet<Point> Square3 { get; set; }
        
        public ISet<Point> Square4 { get; set; }

        public ISet<Point> Square5 { get; set; }
    }
}
