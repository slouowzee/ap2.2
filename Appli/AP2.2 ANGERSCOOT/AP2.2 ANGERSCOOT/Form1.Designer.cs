namespace AP2._2_ANGERSCOOT
{
    partial class FormulaireConnexion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_connexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(319, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(319, 232);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(152, 20);
            this.txt_login.TabIndex = 1;
            this.txt_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(319, 288);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(152, 20);
            this.txt_mdp.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(358, 272);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 13);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Mot de passe";
            this.lbl_password.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(375, 216);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(33, 13);
            this.lbl_login.TabIndex = 6;
            this.lbl_login.Text = "Login";
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(352, 349);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(88, 23);
            this.btn_connexion.TabIndex = 7;
            this.btn_connexion.Text = "Se connecter";
            this.btn_connexion.UseVisualStyleBackColor = true;
            // 
            // FormulaireConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormulaireConnexion";
            this.Text = "Formulaire de connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_connexion;
    }
}

