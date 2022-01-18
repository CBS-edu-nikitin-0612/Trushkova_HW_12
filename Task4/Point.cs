using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Point
    {
        int x;
        int y;
        string name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int X
        { get => x; }

        public int Y
        { get => y; }

        public string Name
        {
            get
            {
                if (name != null)
                    return name;
                else
                    return "Имя отсутствует";
            }
        }

    }
}
