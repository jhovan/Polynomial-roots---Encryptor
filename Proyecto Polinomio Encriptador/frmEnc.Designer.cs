namespace Proyecto_Polinomio_Encriptador
{
    partial class frmEnc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnc));
            this.txtbx1 = new System.Windows.Forms.TextBox();
            this.txtbx2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoAEncriptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoADesencriptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.regresarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx1
            // 
            this.txtbx1.Location = new System.Drawing.Point(12, 27);
            this.txtbx1.Multiline = true;
            this.txtbx1.Name = "txtbx1";
            this.txtbx1.Size = new System.Drawing.Size(244, 240);
            this.txtbx1.TabIndex = 0;
            this.txtbx1.TextChanged += new System.EventHandler(this.txtbx1_TextChanged);
            // 
            // txtbx2
            // 
            this.txtbx2.Location = new System.Drawing.Point(407, 27);
            this.txtbx2.Multiline = true;
            this.txtbx2.Name = "txtbx2";
            this.txtbx2.ReadOnly = true;
            this.txtbx2.Size = new System.Drawing.Size(244, 240);
            this.txtbx2.TabIndex = 1;
            this.txtbx2.TextChanged += new System.EventHandler(this.txtbx2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.verToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrizToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.regresarToolStripMenuItem,
            this.regresarToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.editarToolStripMenuItem.Text = "Archivo";
            // 
            // matrizToolStripMenuItem
            // 
            this.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem";
            this.matrizToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.matrizToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.matrizToolStripMenuItem.Text = "Nuevo";
            this.matrizToolStripMenuItem.Click += new System.EventHandler(this.matrizToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoAEncriptarToolStripMenuItem,
            this.archivoADesencriptarToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";

            // 
            // archivoAEncriptarToolStripMenuItem
            // 
            this.archivoAEncriptarToolStripMenuItem.Name = "archivoAEncriptarToolStripMenuItem";
            this.archivoAEncriptarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.archivoAEncriptarToolStripMenuItem.Text = "Archivo a encriptar";
            this.archivoAEncriptarToolStripMenuItem.Click += new System.EventHandler(this.archivoAEncriptarToolStripMenuItem_Click);
            // 
            // archivoADesencriptarToolStripMenuItem
            // 
            this.archivoADesencriptarToolStripMenuItem.Name = "archivoADesencriptarToolStripMenuItem";
            this.archivoADesencriptarToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.archivoADesencriptarToolStripMenuItem.Text = "Archivo a desencriptar";
            this.archivoADesencriptarToolStripMenuItem.Click += new System.EventHandler(this.archivoADesencriptarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(157, 6);
            // 
            // regresarToolStripMenuItem1
            // 
            this.regresarToolStripMenuItem1.Name = "regresarToolStripMenuItem1";
            this.regresarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.regresarToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.regresarToolStripMenuItem1.Text = "Regresar";
            this.regresarToolStripMenuItem1.Click += new System.EventHandler(this.regresarToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem1});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.verToolStripMenuItem.Text = "Editar";

            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.borrarToolStripMenuItem1.Text = "Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // verToolStripMenuItem1
            // 
            this.verToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem1});
            this.verToolStripMenuItem1.Name = "verToolStripMenuItem1";
            this.verToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.verToolStripMenuItem1.Text = "Ayuda";
            // 
            // informaciónToolStripMenuItem1
            // 
            this.informaciónToolStripMenuItem1.Name = "informaciónToolStripMenuItem1";
            this.informaciónToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informaciónToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.informaciónToolStripMenuItem1.Text = "Información";
            this.informaciónToolStripMenuItem1.Click += new System.EventHandler(this.informaciónToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Proyecto_Polinomio_Encriptador.Properties.Resources.flechader;
            this.pictureBox1.Location = new System.Drawing.Point(295, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 31);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbx2);
            this.Controls.Add(this.txtbx1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmEnc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encriptador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEnc_FormClosed);
            this.Load += new System.EventHandler(this.frmEnc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx1;
        private System.Windows.Forms.TextBox txtbx2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem archivoAEncriptarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoADesencriptarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}