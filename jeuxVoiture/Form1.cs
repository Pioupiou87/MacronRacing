using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;

namespace jeuxVoiture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Incremente = 0;
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Image img = voiture.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                voiture.Image = img;
            }
            if (e.KeyCode == Keys.Left)
            {
                voiture.Location = new Point(voiture.Location.X - 10, voiture.Location.Y);
                percute();
            }
            if (e.KeyCode == Keys.Right)
            {
                voiture.Location = new Point(voiture.Location.X + 10, voiture.Location.Y);
                percute();
            }

            if (e.KeyCode == Keys.Up)
            {
                voiture.Location = new Point(voiture.Location.X, voiture.Location.Y - 10);
                percute();
            }
            if (e.KeyCode == Keys.Down)
            {
                voiture.Location = new Point(voiture.Location.X, voiture.Location.Y + 10);
                percute();
            }
        }
        private void VoiturePolice()
        {
           while (voiture.Location.X +200 != macron.Location.X +200 || voiture.Location.Y + 200 != macron.Location.Y + 200)
            {
                PoliceVoiture.Location = new Point(PoliceVoiture.Location.X +1);
            }
        }
        private void playSimpleSound()
        {            
            System.Media.SoundPlayer son = new System.Media.SoundPlayer();
            son.SoundLocation = @"C:\\Users\F015189\source\repos\jeuxVoiture\son.wav";
            son.Play();
        }

        public bool percute ()
        {
            Random randx = new Random();
            Random randy = new Random();

            int Ax = randx.Next(180, 570);
            int Ay = randy.Next(0, 335);
            int Bx = Ax + 86;
            int By = Ay;
            int Cx = Ax;
            int Cy = Ay + 109;
            int Dx = Cx + 86;
            int Dy = Cy;
            
            if (voiture.Location.X > Ax && voiture.Location.X < Bx && voiture.Location.X > Cx && voiture.Location.X < Dx && voiture.Location.Y > Ay && voiture.Location.Y < Cy && voiture.Location.Y > By && voiture.Location.Y < Dy)
            {

                this.label1.Visible = true;
                this.label1.Location = new Point(0, 10);
                this.macron.Visible = false;

                this.macron.Location = new Point(randx.Next(180, 570), randy.Next(0, 335));

                this.macron.Visible = true;
                this.Score.Text = "Score : "+Compteur().ToString();

            }

            else { this.label1.Visible = false; }
            return this.label1.Visible;



        }
        public int Compteur()
        {
            
            if (this.macron.Visible == true)
            {
              Incremente++;
            }
           
           
            return Incremente ;
        }

        private void macron_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
 }

