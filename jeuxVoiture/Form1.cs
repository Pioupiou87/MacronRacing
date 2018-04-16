using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeuxVoiture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                voiture.Location = new Point(voiture.Location.X - 10, voiture.Location.Y);
            }
            if (e.KeyCode == Keys.Right)
            {
                voiture.Location = new Point(voiture.Location.X + 10, voiture.Location.Y);
            }
            if (e.KeyCode == Keys.Up)
            {
                voiture.Location = new Point(voiture.Location.X, voiture.Location.Y - 10);
            }
            if (e.KeyCode == Keys.Down)
            {
                voiture.Location = new Point(voiture.Location.X, voiture.Location.Y + 10);
            }
            if (e.KeyCode == Keys.Up && e.KeyCode == Keys.Right)
            {
                voiture.Location = new Point(voiture.Location.X + 10, voiture.Location.Y - 10);
            }


        }
        private void percute ()
        {
            if (voiture.Location == macron.Location)
            {
                this.Text += "Hello World!"; 
            }

        }
    }
 }

