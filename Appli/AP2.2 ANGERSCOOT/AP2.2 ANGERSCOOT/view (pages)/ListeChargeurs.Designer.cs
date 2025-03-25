namespace AP2._2_ANGERSCOOT.view__pages_
{
    partial class ListeChargeurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_gestionchargeur = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.txt_siret = new System.Windows.Forms.TextBox();
            this.txt_nvmdp = new System.Windows.Forms.TextBox();
            this.txt_confmdp = new System.Windows.Forms.TextBox();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_carteIdentite = new System.Windows.Forms.Button();
            this.btn_justDomicile = new System.Windows.Forms.Button();
            this.btn_justEntreprise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gestionchargeur
            // 
            this.lbl_gestionchargeur.AutoSize = true;
            this.lbl_gestionchargeur.Location = new System.Drawing.Point(263, 9);
            this.lbl_gestionchargeur.Name = "lbl_gestionchargeur";
            this.lbl_gestionchargeur.Size = new System.Drawing.Size(112, 13);
            this.lbl_gestionchargeur.TabIndex = 0;
            this.lbl_gestionchargeur.Text = "Gestion du chargeur : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(391, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(266, 100);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 4;
            this.txt_nom.Text = "Nom";
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(391, 100);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 5;
            this.txt_prenom.Text = "Prenom";
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(286, 190);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(188, 20);
            this.txt_adresse.TabIndex = 7;
            this.txt_adresse.Text = "Adresse";
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(266, 239);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(100, 20);
            this.txt_ville.TabIndex = 8;
            this.txt_ville.Text = "Ville";
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(391, 239);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(100, 20);
            this.txt_cp.TabIndex = 9;
            this.txt_cp.Text = "CP";
            // 
            // txt_siret
            // 
            this.txt_siret.Location = new System.Drawing.Point(286, 143);
            this.txt_siret.Name = "txt_siret";
            this.txt_siret.Size = new System.Drawing.Size(188, 20);
            this.txt_siret.TabIndex = 6;
            this.txt_siret.Text = "N° Siret";
            // 
            // txt_nvmdp
            // 
            this.txt_nvmdp.Location = new System.Drawing.Point(286, 278);
            this.txt_nvmdp.Name = "txt_nvmdp";
            this.txt_nvmdp.Size = new System.Drawing.Size(188, 20);
            this.txt_nvmdp.TabIndex = 10;
            this.txt_nvmdp.Text = "Nouveau mot de passe";
            // 
            // txt_confmdp
            // 
            this.txt_confmdp.Location = new System.Drawing.Point(286, 304);
            this.txt_confmdp.Name = "txt_confmdp";
            this.txt_confmdp.Size = new System.Drawing.Size(188, 20);
            this.txt_confmdp.TabIndex = 11;
            this.txt_confmdp.Text = "Confirmation du mot de passe";
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.BackColor = System.Drawing.Color.Lime;
            this.btn_confirmer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_confirmer.Location = new System.Drawing.Point(333, 354);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmer.TabIndex = 12;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(573, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Supprimer définitivement";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(43, 236);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 14;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // btn_carteIdentite
            // 
            this.btn_carteIdentite.Location = new System.Drawing.Point(34, 276);
            this.btn_carteIdentite.Name = "btn_carteIdentite";
            this.btn_carteIdentite.Size = new System.Drawing.Size(106, 23);
            this.btn_carteIdentite.TabIndex = 15;
            this.btn_carteIdentite.Text = "Carte d\'identité";
            this.btn_carteIdentite.UseVisualStyleBackColor = true;
            // 
            // btn_justDomicile
            // 
            this.btn_justDomicile.Location = new System.Drawing.Point(12, 317);
            this.btn_justDomicile.Name = "btn_justDomicile";
            this.btn_justDomicile.Size = new System.Drawing.Size(158, 23);
            this.btn_justDomicile.TabIndex = 16;
            this.btn_justDomicile.Text = "Justificatif de domicile";
            this.btn_justDomicile.UseVisualStyleBackColor = true;
            // 
            // btn_justEntreprise
            // 
            this.btn_justEntreprise.Location = new System.Drawing.Point(12, 354);
            this.btn_justEntreprise.Name = "btn_justEntreprise";
            this.btn_justEntreprise.Size = new System.Drawing.Size(158, 23);
            this.btn_justEntreprise.TabIndex = 17;
            this.btn_justEntreprise.Text = "Justificatif entreprise";
            this.btn_justEntreprise.UseVisualStyleBackColor = true;
            // 
            // ListeChargeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_justEntreprise);
            this.Controls.Add(this.btn_justDomicile);
            this.Controls.Add(this.btn_carteIdentite);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.txt_confmdp);
            this.Controls.Add(this.txt_nvmdp);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.txt_siret);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_gestionchargeur);
            this.Name = "ListeChargeurs";
            this.Text = "ListeChargeurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gestionchargeur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_adresse;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.TextBox txt_siret;
        private System.Windows.Forms.TextBox txt_nvmdp;
        private System.Windows.Forms.TextBox txt_confmdp;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_carteIdentite;
        private System.Windows.Forms.Button btn_justDomicile;
        private System.Windows.Forms.Button btn_justEntreprise;
    }
}