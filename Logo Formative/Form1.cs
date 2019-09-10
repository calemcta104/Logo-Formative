using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo_Formative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Graphics objects
            Graphics g = this.CreateGraphics();
            Pen Redpen = new Pen(Color.Red, 10);
            Pen Bluepen = new Pen(Color.Blue, 10);
            SolidBrush BlueBrush = new SolidBrush(Color.Blue);
            SolidBrush RedBrush = new SolidBrush(Color.Red);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            SolidBrush OtherBrush = new SolidBrush(Color.MediumBlue);
            Font drawFont = new Font("Futura BdCn BT", 53, FontStyle.Bold);
            Font drawFont2 = new Font("Futura BdCn BT", 10, FontStyle.Bold);

            // Clear screen
            g.Clear(Color.LightGray);

            // Shapes
            //red square with dot
            g.TranslateTransform(200, 50);
            g.RotateTransform(310);
            g.FillRectangle(RedBrush, 100, 250, 120, 120);
            g.FillEllipse(WhiteBrush, 135, 285, 50, 50);
            g.ResetTransform();

            //blue square with 2 dots
            g.TranslateTransform(0, 0);
            g.RotateTransform(310);
            g.FillRectangle(RedBrush, 65, 435, 120, 120);
            g.ResetTransform();
            g.FillEllipse(WhiteBrush, 405, 195, 50, 50);
            g.FillEllipse(WhiteBrush, 465, 195, 50, 50);

            //blue square with text
            g.TranslateTransform(0, 0);
            g.RotateTransform(310);
            g.FillRectangle(OtherBrush, 60, 565, 250, 80);
            g.ResetTransform();

            // Text Code 
            g.TranslateTransform(460, 320);
            g.RotateTransform(310);
            g.DrawString("Domino's", drawFont, WhiteBrush, new Rectangle());
            g.ResetTransform();
          
            //Comment for Git
        }
    }
}
