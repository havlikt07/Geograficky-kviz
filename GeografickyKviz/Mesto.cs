using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografickyKviz
{
    internal class Mesto
    {
        public string Name { get; set; }

        public float RelativeX { get; set; }
        public float RelativeY { get; set; }

        public Mesto(string name, float relativeX, float relativeY)
        {
            Name = name;
            RelativeX = relativeX;
            RelativeY = relativeY;
        }
    }
}
