using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonCurve
{
    public partial class OpenObject : Form
    {
        Object3D object3d;
        
        public OpenObject(string fileName)
        {
            InitializeComponent();
            object3d = new Object3D();
            object3d.LoadFromFile(fileName);
        }

        private void OpenObject_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    object3d.Scale *= 1.1F;
                    break;
                case '-':
                    object3d.Scale *= 0.9F;
                    break;
                case '5':
                    object3d.AngleX -= 0.1F;
                    break;
                case '2':
                    object3d.AngleX += 0.1F;
                    break;
                case '1':
                    object3d.AngleZ -= 0.1F;
                    break;
                case '3':
                    object3d.AngleZ += 0.1F;
                    break;
                case '4':
                    object3d.AngleY -= 0.1F;
                    break;
                case '6':
                    object3d.AngleY += 0.1F;
                    break;
            }
            DrawObject();
        }

        private void DrawObject()
        {
            Graphics g = this.CreateGraphics();
            // We implement double buffering i.e. drawing in background
            Bitmap bmp = new Bitmap(Width, Height);
            Graphics gdraw = Graphics.FromImage(bmp);
            gdraw.SetClip(new Rectangle(0, 0, Width, Height));
            if (object3d != null) object3d.Draw(gdraw, true);
            g.DrawImage(bmp, 0, 0);
            gdraw.Dispose();
            g.Dispose();
        }

        private void OpenObject_SizeChanged(object sender, EventArgs e)
        {
            DrawObject();
        }

        private void OpenObject_Shown(object sender, EventArgs e)
        {
            DrawObject();
        }
    }
}
