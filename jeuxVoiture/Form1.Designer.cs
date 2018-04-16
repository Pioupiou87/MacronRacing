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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.voiture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voiture
            // 
            this.voiture.Image = ((System.Drawing.Image)(resources.GetObject("voiture.Image")));
            this.voiture.Location = new System.Drawing.Point(135, 55);
            this.voiture.Name = "voiture";
            this.voiture.Size = new System.Drawing.Size(100, 50);
            this.voiture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voiture.TabIndex = 0;
            this.voiture.TabStop = false;
            // 
            // macron
            // 
            this.macron.Image = ((System.Drawing.Image)(resources.GetObject("macron.Image")));
            this.macron.Location = new System.Drawing.Point(397, 12);
            this.macron.Name = "macron";
            this.macron.Size = new System.Drawing.Size(70, 118);
            this.macron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.macron.TabIndex = 1;
            this.macron.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(520, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.voiture);
            this.Controls.Add(this.macron);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.voiture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox voiture;
        private System.Windows.Forms.PictureBox macron;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

