namespace jeuxVoiture
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.voiture = new System.Windows.Forms.PictureBox();
            this.macron = new System.Windows.Forms.PictureBox();
            this.PoliceVoiture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voiture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoliceVoiture)).BeginInit();
            this.SuspendLayout();
            // 
            // voiture
            // 
            this.voiture.Image = ((System.Drawing.Image)(resources.GetObject("voiture.Image")));
            this.voiture.Location = new System.Drawing.Point(74, 55);
            this.voiture.Name = "voiture";
            this.voiture.Size = new System.Drawing.Size(131, 83);
            this.voiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voiture.TabIndex = 0;
            this.voiture.TabStop = false;
            // 
            // macron
            // 
            this.macron.Image = ((System.Drawing.Image)(resources.GetObject("macron.Image")));
            this.macron.Location = new System.Drawing.Point(345, 78);
            this.macron.Name = "macron";
            this.macron.Size = new System.Drawing.Size(70, 118);
            this.macron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.macron.TabIndex = 1;
            this.macron.TabStop = false;
            this.macron.Click += new System.EventHandler(this.macron_Click);
            // 
            // PoliceVoiture
            // 
            this.PoliceVoiture.Image = ((System.Drawing.Image)(resources.GetObject("PoliceVoiture.Image")));
            this.PoliceVoiture.Location = new System.Drawing.Point(12, 144);
            this.PoliceVoiture.Name = "PoliceVoiture";
            this.PoliceVoiture.Size = new System.Drawing.Size(99, 61);
            this.PoliceVoiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PoliceVoiture.TabIndex = 2;
            this.PoliceVoiture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MACRON MORT !!! ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(771, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(129, 37);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score : 0";
            this.Score.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(900, 430);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voiture);
            this.Controls.Add(this.macron);
            this.Controls.Add(this.PoliceVoiture);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.voiture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoliceVoiture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox voiture;
        private System.Windows.Forms.PictureBox macron;
        private System.Windows.Forms.PictureBox PoliceVoiture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
    }
}

