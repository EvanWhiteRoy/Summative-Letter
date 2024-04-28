using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Summative_Letter
{
    public partial class GreetingsCard : Form
    {
        SoundPlayer walk = new SoundPlayer(Properties.Resources.footsteps);
        SoundPlayer cheer = new SoundPlayer(Properties.Resources.cheering);
        public GreetingsCard()
        {
            InitializeComponent();
            this.BackColor = Color.Goldenrod;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 10);
            Pen greyPen = new Pen(Color.DarkGray, 20);
            SolidBrush blackBrush = new SolidBrush(Color.Black);


            g.DrawLine(blackPen, 0, 0, 400, 100);
            g.DrawLine(blackPen, 800,0 , 400, 100);

            g.DrawLine(blackPen, 0, 0, 0, 489);
            g.DrawLine(blackPen, 800, 480, 0, 480);
            g.DrawLine(blackPen, 800, 480, 800, 0);
            g.DrawLine(blackPen, 0, 0, 800, 0);

            Font drawFont = new Font("Times New Roman", 40, FontStyle.Bold);
            g.DrawString("To My Sweet Tri\nClick For Surprise *Kisses*", drawFont, blackBrush, 100, 250);

        }

        

        private void Form1_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 10);
            Pen greyPen = new Pen(Color.DarkGray, 20);
            Pen bluePen = new Pen(Color.LightBlue, 10);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            Font drawFont = new Font("Times New Roman", 40, FontStyle.Bold);
            int i = 815;
            while (i > 0)
            {
                g.Clear(Color.Goldenrod);
                g.DrawString("Have Fun In London Tri!!", drawFont, blackBrush, i, 200);
                Thread.Sleep(1);
                i = i - 4;
                walk.Play();
            }
            g.Clear(Color.Goldenrod);
            g.DrawString("Stratford", drawFont, blackBrush, 50, 100);
            g.DrawString("London", drawFont, blackBrush, 550, 100);
            int y = 0;
            while (y < 300)
            {
                g.Clear(Color.Goldenrod);
                g.DrawEllipse(blackPen, 315, 200 + y, 200, 200);
                g.DrawEllipse(bluePen, 340, 250 + y, 25, 25);
                g.DrawEllipse(bluePen, 460, 250 + y, 25, 25);
                g.DrawArc(blackPen, 365, 300 + y, 100, 100, 200, 140);
                y = y + 100;
                cheer.Play();

            }
            












        }
    }
}
