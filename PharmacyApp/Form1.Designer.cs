namespace PharmacyApp
{
    partial class Form1
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientųSąrašasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atnaujintiPaštoIndeksusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importuotiKlientusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klientųSąrašasToolStripMenuItem,
            this.atnaujintiPaštoIndeksusToolStripMenuItem,
            this.importuotiKlientusToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // klientųSąrašasToolStripMenuItem
            // 
            this.klientųSąrašasToolStripMenuItem.Name = "klientųSąrašasToolStripMenuItem";
            this.klientųSąrašasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.klientųSąrašasToolStripMenuItem.Text = "Klientų sąrašas";
            this.klientųSąrašasToolStripMenuItem.Click += new System.EventHandler(this.klientuSarasasToolStripMenuItem_Click);
            // 
            // atnaujintiPaštoIndeksusToolStripMenuItem
            // 
            this.atnaujintiPaštoIndeksusToolStripMenuItem.Name = "atnaujintiPaštoIndeksusToolStripMenuItem";
            this.atnaujintiPaštoIndeksusToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.atnaujintiPaštoIndeksusToolStripMenuItem.Text = "Atnaujinti pašto indeksus";
            this.atnaujintiPaštoIndeksusToolStripMenuItem.Click += new System.EventHandler(this.atnaujintiPastoIndeksusToolStripMenuItem_Click);
            // 
            // importuotiKlientusToolStripMenuItem
            // 
            this.importuotiKlientusToolStripMenuItem.Name = "importuotiKlientusToolStripMenuItem";
            this.importuotiKlientusToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.importuotiKlientusToolStripMenuItem.Text = "Importuoti klientus";
            this.importuotiKlientusToolStripMenuItem.Click += new System.EventHandler(this.importuotiKlientusToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientųSąrašasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importuotiKlientusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atnaujintiPaštoIndeksusToolStripMenuItem;
    }
}

