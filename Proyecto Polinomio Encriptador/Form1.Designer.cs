namespace Proyecto_Polinomio_Encriptador
{
    partial class frmPoliEnc
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoliEnc));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbEnc = new System.Windows.Forms.PictureBox();
            this.pbPoli = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoli)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(490, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem1});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // informaciónToolStripMenuItem1
            // 
            this.informaciónToolStripMenuItem1.Name = "informaciónToolStripMenuItem1";
            this.informaciónToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informaciónToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.informaciónToolStripMenuItem1.Text = "Información";
            this.informaciónToolStripMenuItem1.Click += new System.EventHandler(this.informaciónToolStripMenuItem1_Click);
            // 
            // pbEnc
            // 
            this.pbEnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEnc.Image = global::Proyecto_Polinomio_Encriptador.Properties.Resources.Enriptador;
            this.pbEnc.Location = new System.Drawing.Point(252, 63);
            this.pbEnc.Name = "pbEnc";
            this.pbEnc.Size = new System.Drawing.Size(226, 114);
            this.pbEnc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnc.TabIndex = 8;
            this.pbEnc.TabStop = false;
            this.pbEnc.Click += new System.EventHandler(this.pbEnc_Click_1);
            // 
            // pbPoli
            // 
            this.pbPoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPoli.Image = global::Proyecto_Polinomio_Encriptador.Properties.Resources.Polinomio;
            this.pbPoli.Location = new System.Drawing.Point(12, 63);
            this.pbPoli.Name = "pbPoli";
            this.pbPoli.Size = new System.Drawing.Size(224, 114);
            this.pbPoli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoli.TabIndex = 4;
            this.pbPoli.TabStop = false;
            this.pbPoli.Click += new System.EventHandler(this.pbPoli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Polinomios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Encriptador";
            // 
            // frmPoliEnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEnc);
            this.Controls.Add(this.pbPoli);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPoliEnc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polinmio y Encriptador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPoliEnc_FormClosed);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPoli;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbEnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

