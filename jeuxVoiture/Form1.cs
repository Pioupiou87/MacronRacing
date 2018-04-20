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
using System.Timers;

namespace jeuxVoiture
{
    public partial class Form1 : Form
    {

        int Rotation = 0;
        public int Incremente = 0;
        public bool macronEcrase = false;
        static System.Windows.Forms.Timer bot = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

        // Constructeur

        // À ne mettre ici que si ce n'est pas déjà dans Form1.Designer.cs
        s_myTimer.Tick += new EventHandler(s_myTimer_Tick);

        // 1 seconde = 1000 millisecondes
        s_myTimer.Interval = 2000;

            // BOT Police
            bot.Tick += new EventHandler(Bot);
            bot.Start();

            void Bot(object sender, EventArgs e)

            {
                Random Horizontal = new Random();
                Random Vertical = new Random();
                int AxeX = Horizontal.Next(0, 1300);
                int AxeY = Vertical.Next(0, 700);
                //PoliceVoiture.Location = new Point(AxeX, AxeY);
                Limite();
                PoliceVoiture.Location = new Point(PoliceVoiture.Location.X + 10, PoliceVoiture.Location.Y);
                //s_myTimer.Stop();

            }




        }




        // Déclaration des champs
        static System.Windows.Forms.Timer s_myTimer = new System.Windows.Forms.Timer();
        static int s_myCounter = 0;


        // Méthode appelée pour l'évènement
         void s_myTimer_Tick(object sender, EventArgs e)
        {
            Random randx = new Random();
            Random randy = new Random();

            int Ax = randx.Next(0, 1300);
            int Ay = randy.Next(0, 700);
            int Bx = Ax + 70;
            int By = Ay;
            int Cx = Ax;
            int Cy = Ay + 118;
            int Dx = Cx + 70;
            int Dy = Cy;
            this.label1.Visible = true;
            s_myCounter++;
            s_myTimer.Stop();
            this.macron.Location = new Point(Ax, Ay);
            macron.ImageLocation = @"C:/Users/Guillaume/MacronRacing/macron.jpg";
            

        }        


        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Space)
            {
                
                Rot();
                          
               
            }
           

            if (e.KeyCode == Keys.Up)
            {
                voitureV.Location = voiture.Location;
                switch (Rotation)
                {
                    
                    case 0:
                        voiture.Location = new Point(voiture.Location.X, voiture.Location.Y - 10);



                        break;

                    case 1:
                        
                        voiture.Location = new Point(voiture.Location.X + 10, voiture.Location.Y);



                        break;

                    case 2:
                        
                        voiture.Location = new Point(voiture.Location.X, voiture.Location.Y + 10);



                        break;

                    case 3:
                        
                        voiture.Location = new Point(voiture.Location.X - 10, voiture.Location.Y);

                        break;

                }
               
                percute();
                Limite();
            }
            if (e.KeyCode == Keys.Down)
            {
                voitureV.Location = voiture.Location;
                switch (Rotation)
                {

                    case 0:

                        voiture.Location = new Point(voiture.Location.X, voiture.Location.Y + 10);


                        break;

                    case 1:
                        voiture.Location = new Point(voiture.Location.X - 10, voiture.Location.Y);




                        break;

                    case 2:

                        
                        voiture.Location = new Point(voiture.Location.X, voiture.Location.Y - 10);



                        break;

                    case 3:
                        voiture.Location = new Point(voiture.Location.X + 10, voiture.Location.Y);
                        

                        break;

                }
                percute();
                Limite();
            }
        }
      
        
        public bool percute ()
        {
           
            
            if (voiture.Location.X > macron.Location.X && voiture.Location.X < macron.Location.X + 70 &&  voiture.Location.Y > macron.Location.Y && voiture.Location.Y < macron.Location.Y + 118 ||
                voiture.Location.X + 131 > macron.Location.X && voiture.Location.X + 131 < macron.Location.X + 70 && voiture.Location.Y > macron.Location.Y && voiture.Location.Y < macron.Location.Y + 118 || 
                voiture.Location.X + 131 > macron.Location.X && voiture.Location.X + 131 < macron.Location.X + 70 && voiture.Location.Y + 83 > macron.Location.Y && voiture.Location.Y + 83 < macron.Location.Y + 118 ||
                voiture.Location.X > macron.Location.X && voiture.Location.X < macron.Location.X + 70 && voiture.Location.Y +83 > macron.Location.Y && voiture.Location.Y + 83 < macron.Location.Y ||

                voitureV.Location.X > macron.Location.X && voitureV.Location.X < macron.Location.X + 70 && voitureV.Location.Y > macron.Location.Y && voitureV.Location.Y < macron.Location.Y + 118 ||
                voitureV.Location.X + 83 > macron.Location.X && voitureV.Location.X + 83 < macron.Location.X + 70 && voitureV.Location.Y > macron.Location.Y && voitureV.Location.Y < macron.Location.Y + 118 ||
                voitureV.Location.X + 83 > macron.Location.X && voitureV.Location.X + 83 < macron.Location.X + 70 && voitureV.Location.Y + 131 > macron.Location.Y && voitureV.Location.Y + 131 < macron.Location.Y + 118 ||
                voitureV.Location.X > macron.Location.X && voitureV.Location.X < macron.Location.X + 70 && voitureV.Location.Y + 131 > macron.Location.Y && voitureV.Location.Y + 131 < macron.Location.Y

             )
            {


                macronEcrase = true;
                this.label1.Visible = true;
                this.label1.Location = new Point(0, 10);
                macron.ImageLocation = @"C:/Users/Guillaume/MacronRacing/macronDead.png";
                s_myTimer.Start();
                this.Score.Text = "Score : " + Compteur().ToString();
                this.Niveau.Text = "Level : " + Level().ToString();



            }

            else { this.label1.Visible = false; }
            return this.label1.Visible;



        }


        public int Compteur()
        {
            if (macronEcrase == true)
            {
                Incremente = Incremente + 1;
            }
            return Incremente;
        }
        public int Level()
        {
            int Niveau = 0;
            if (Compteur() < 1)
            {
                Niveau = 1;
                bot.Interval = 50;
            }
            if (Compteur() >= 500)
            {
                Niveau = 2;
                bot.Interval = 35;
            }
            if (Compteur() >= 900)
            {
                Niveau = 3;
                bot.Interval = 15;

            }

            return Niveau;
        }

        public void Limite()
        {
            int X = this.voiture.Location.X;
            int Y = this.voiture.Location.Y;
            int XPolice = this.PoliceVoiture.Location.X;
            int YPolice = this.PoliceVoiture.Location.Y;

            if (PoliceVoiture.Location.X > 1300)
            {
                this.PoliceVoiture.Location = new Point(0, YPolice);
            }
            if (voiture.Location.X > 1300)
            {
                this.voiture.Location = new Point(0, Y);
            }

            if (PoliceVoiture.Location.X < 0)
            {
                this.PoliceVoiture.Location = new Point(1300, YPolice);
            }
            if (voiture.Location.X < 0)
            {
                this.voiture.Location = new Point(1300, Y);
            }
            if (PoliceVoiture.Location.Y > 700)
            {
                this.PoliceVoiture.Location = new Point(XPolice, 0);
            }
            if (voiture.Location.Y > 700)
            {
                this.voiture.Location = new Point(X, 0);
            }
            if (PoliceVoiture.Location.Y < 0)
            {
                this.PoliceVoiture.Location = new Point(XPolice, 700);
            }
            if (voiture.Location.Y < 0)
            {
                this.voiture.Location = new Point(X, 700);
            }
        }

        public int Rot()
        {
                        
            switch (Rotation)

            {

                 case 0 :
                    voitureV.Visible = false;
                    voiture.ImageLocation = @"C:/Users/Guillaume/MacronRacing/Voiture/droite.gif";
                    voiture.Visible = true;
                    Rotation++;
                    
                    break;

                case 1:
                    voiture.Visible = false;
                    voitureV.ImageLocation = @"C:/Users/Guillaume/MacronRacing/Voiture/bas.gif";
                    voitureV.Visible = true;
                    Rotation++;

                    break;

                case 2:
                    
                    voitureV.Visible = false;
                    voiture.ImageLocation = @"C:/Users/Guillaume/MacronRacing/Voiture/gauche.gif";
                    voiture.Visible = true;
                    Rotation++;
                    
                    break;

                case 3:
                    voiture.Visible = false;
                    voitureV.ImageLocation = @"C:/Users/Guillaume/MacronRacing/Voiture/haut.gif";
                    voitureV.Visible = true;
                    { Rotation = 0; }

                    break;

                                    
            }

            return Rotation;
        }

        
    }
 }

