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
    public partial class Form1 : Form
    {
        /***********************************************************************************
         * URL of public video: https://www.facebook.com/nzrnsrzd/videos/2071883003076170/ *
         ***********************************************************************************/

        public Form1()
        {
            InitializeComponent();
        }

        private void createHandler(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "3D Model (*.obj)|*.obj";
            saveFileDialog.DefaultExt = "obj";
            saveFileDialog.AddExtension = true;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DragonCurve.NumberOfSteps = Convert.ToInt32(Math.Round(numberOfSteps.Value, 0));
                DragonCurve.Length = Convert.ToDouble(length.Value);
                DragonCurve.Height = Convert.ToDouble(height.Value);
                DragonCurve.Angle = Convert.ToInt32(Math.Round(angle.Value, 0));
                DragonCurve.CreateObject();
                DragonCurve.SaveAsObject(saveFileDialog.FileName);
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }
        /* Bonus 2 
         * Draw the 3D model it has generated (without calling an external application) 
         * Let the user scale it up and down, and rotate it around
         */
        private void openHandler(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "3D Model (*.obj)|*.obj";
            openFileDialog.DefaultExt = "obj";
            openFileDialog.AddExtension = true;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenObject openObject = new OpenObject(openFileDialog.FileName);
                openObject.ShowDialog();
            }
        }
    }
}
