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
        //Panel1 obsahuje pictureBox a Panel2 je hlavička a Panel3 je patička
        
        private Bitmap visualMap;
        private Bitmap mapMask;
        
        public Form2()
        {
            InitializeComponent();

            this.MinimumSize = new Size(1024, 665);

            visualMap = Properties.Resources.Mapa_cz;
            mapMask = Properties.Resources.Mapa_cz_maska;

            pictureBox1.Image = visualMap;

            this.Shown += (s, e) => UpdateMapBounds();
        }

        private void UpdateMapBounds()
        {
            if(visualMap == null || panel1.Width == 0 || panel1.Height == 0) return;

            float imageAspect = (float)visualMap.Width / visualMap.Height;
            float panelAspect = (float)panel1.Width / panel1.Height;

            int targetWidth;
            int targetHeight;

            if(panelAspect > imageAspect)
            {
                targetHeight = panel1.Height;
                targetWidth = (int)(targetHeight * imageAspect);
            }
            else
            {
                targetWidth = panel1.Width;
                targetHeight = (int)(targetWidth / imageAspect);
            }

            pictureBox1.Size = new Size(targetWidth, targetHeight);
            pictureBox1.Location = new Point((panel1.Width - targetWidth) / 2, (panel1.Height - targetHeight) / 2);  
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            UpdateMapBounds();
        }
    }
}
