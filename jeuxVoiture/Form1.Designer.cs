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
            this.voitureV = new System.Windows.Forms.PictureBox();
            this.Niveau = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voiture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoliceVoiture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureV)).BeginInit();
            this.SuspendLayout();
            // 
            // voiture
            // 
            this.voiture.Image = ((System.Drawing.Image)(resources.GetObject("voiture.Image")));
            this.voiture.Location = new System.Drawing.Point(45, 160);
            this.voiture.Name = "voiture";
            this.voiture.Size = new System.Drawing.Size(131, 83);
            this.voiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voiture.TabIndex = 0;
            this.voiture.TabStop = false;
            // 
            // macron
            // 
            this.macron.Image = ((System.Drawing.Image)(resources.GetObject("macron.Image")));
            this.macron.Location = new System.Drawing.Point(537, 148);
            this.macron.Name = "macron";
            this.macron.Size = new System.Drawing.Size(70, 118);
            this.macron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.macron.TabIndex = 1;
            this.macron.TabStop = false;
            // 
            // PoliceVoiture
            // 
            this.PoliceVoiture.Image = ((System.Drawing.Image)(resources.GetObject("PoliceVoiture.Image")));
            this.PoliceVoiture.Location = new System.Drawing.Point(328, 307);
            this.PoliceVoiture.Name = "PoliceVoiture";
            this.PoliceVoiture.Size = new System.Drawing.Size(197, 90);
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
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "MACRON MORT !!! ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(771, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(111, 46);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score";
            // 
            // voitureV
            // 
            this.voitureV.Image = ((System.Drawing.Image)(resources.GetObject("voitureV.Image")));
            this.voitureV.Location = new System.Drawing.Point(68, 135);
            this.voitureV.Name = "voitureV";
            this.voitureV.Size = new System.Drawing.Size(83, 131);
            this.voitureV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voitureV.TabIndex = 6;
            this.voitureV.TabStop = false;
            this.voitureV.Visible = false;
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Niveau.Location = new System.Drawing.Point(291, 9);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(88, 29);
            this.Niveau.TabIndex = 7;
            this.Niveau.Text = "Niveau";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 441);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.voitureV);
            this.Controls.Add(this.voiture);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PoliceVoiture);
            this.Controls.Add(this.macron);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.voiture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoliceVoiture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox voiture;
        private System.Windows.Forms.PictureBox macron;
        private System.Windows.Forms.PictureBox PoliceVoiture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox voitureV;
        private System.Windows.Forms.Label Niveau;
    }
}

