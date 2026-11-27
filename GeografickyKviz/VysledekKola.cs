using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeografickyKviz
{
    internal class VysledekKola
    {
        public Mesto HledaneMesto { get; set; }
        public PointF KliknutiRelativni { get; set; }
        public bool Uspesne {  get; set; }
        public float Vzdalenost {  get; set; }
    }
}
