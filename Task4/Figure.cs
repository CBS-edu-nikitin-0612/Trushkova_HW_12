using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Figure
    {
        Point[] points;
        string name;
        double perimetr;

        //public Figure(Point pointA, Point pointB, Point pointC)
        //{
        //    this.points = new Point[]{pointA, pointB, pointC};
        //}

        //public Figure(Point pointA, Point pointB, Point pointC, Point pointD)
        //{
        //    this.points = new Point[] { pointA, pointB, pointC, pointD };
        //}

        //public Figure(Point pointA, Point pointB, Point pointC, Point pointD, Point pointE)
        //{
        //    this.points = new Point[] { pointA, pointB, pointC, pointD, pointE };
        //}

        public Figure (params Point[] points)
        {
            this.points = points;
        }

        public double Perimetr
        {
            get 
            {
                PerimeterCalculator();
                return perimetr; 
            }
        }
        
        double LengthSide(Point A, Point B)
        {
            double dx = A.X - B.X;
            double dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        void PerimeterCalculator()
        {
            perimetr = 0;
            if (points != null)
            {
                for (int i = 0; i < points.Length - 1; i++)
                {
                    perimetr += LengthSide(points[i], points[i + 1]);
                }
                perimetr += LengthSide(points[0], points[points.Length - 1]);
            }
        }

        public string Name
        {
            get
            {
                CombineName();
                return name;
            }
            set { name = value; }
        }

        void CombineName()
        {
            name = "";
            if (points != null)
            {
                for (int i = 0; i < points.Length - 1; i++)
                {
                    name += points[i].Name + "+";
                }
                name += points[points.Length - 1].Name;
            }
        }
    }
}
