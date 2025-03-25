namespace AP2._2_ANGERSCOOT
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeDesVéhiculesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFichesDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesVéhiculesToolStripMenuItem,
            this.listeDesToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.gestionDesFichesDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeDesVéhiculesToolStripMenuItem
            // 
            this.listeDesVéhiculesToolStripMenuItem.Name = "listeDesVéhiculesToolStripMenuItem";
            this.listeDesVéhiculesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.listeDesVéhiculesToolStripMenuItem.Text = "Liste des véhicules";
            // 
            // listeDesToolStripMenuItem
            // 
            this.listeDesToolStripMenuItem.Name = "listeDesToolStripMenuItem";
            this.listeDesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.listeDesToolStripMenuItem.Text = "Liste des chargeurs";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.listeToolStripMenuItem.Text = "Liste des forfaits";
            // 
            // gestionDesFichesDeToolStripMenuItem
            // 
            this.gestionDesFichesDeToolStripMenuItem.Name = "gestionDesFichesDeToolStripMenuItem";
            this.gestionDesFichesDeToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.gestionDesFichesDeToolStripMenuItem.Text = "Gestion des fiches de paie";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDesVéhiculesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFichesDeToolStripMenuItem;
    }
}