using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografickyKviz
{
    public partial class Form2 : Form
    {
        private Bitmap visualMap;
        private Bitmap mapMask;
        
        public Form2()
        {
            InitializeComponent();

            visualMap = Properties.Resources.Mapa_cz;
            mapMask = Properties.Resources.Mapa_cz_maska;

            pictureBox1.Image = visualMap;
        }
    }
}
