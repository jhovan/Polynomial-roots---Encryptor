namespace Proyecto_Polinomio_Encriptador
{
    partial class frmPoli
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoli));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeLaGráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeLasRaicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtbxDom1 = new System.Windows.Forms.TextBox();
            this.txtbxDom2 = new System.Windows.Forms.TextBox();
            this.lblDom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.TextBox();
            this.C0 = new System.Windows.Forms.TextBox();
            this.C2 = new System.Windows.Forms.TextBox();
            this.C3 = new System.Windows.Forms.TextBox();
            this.C4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarImagenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.regresarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.guardarToolStripMenuItem.Text = "Guardar Reporte";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarImagenToolStripMenuItem
            // 
            this.guardarImagenToolStripMenuItem.Name = "guardarImagenToolStripMenuItem";
            this.guardarImagenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.guardarImagenToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.guardarImagenToolStripMenuItem.Text = "Guardar Imagen";
            this.guardarImagenToolStripMenuItem.Click += new System.EventHandler(this.guardarImagenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDeLaGráficaToolStripMenuItem,
            this.colorDeLasRaicesToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // colorDeLaGráficaToolStripMenuItem
            // 
            this.colorDeLaGráficaToolStripMenuItem.Name = "colorDeLaGráficaToolStripMenuItem";
            this.colorDeLaGráficaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.colorDeLaGráficaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.colorDeLaGráficaToolStripMenuItem.Text = "Color de la gráfica";
            this.colorDeLaGráficaToolStripMenuItem.Click += new System.EventHandler(this.colorDeLaGráficaToolStripMenuItem_Click);
            // 
            // colorDeLasRaicesToolStripMenuItem
            // 
            this.colorDeLasRaicesToolStripMenuItem.Name = "colorDeLasRaicesToolStripMenuItem";
            this.colorDeLasRaicesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.colorDeLasRaicesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.colorDeLasRaicesToolStripMenuItem.Text = "Color de las raices";
            this.colorDeLasRaicesToolStripMenuItem.Click += new System.EventHandler(this.colorDeLasRaicesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // Grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Grafica.Legends.Add(legend1);
            this.Grafica.Location = new System.Drawing.Point(293, 42);
            this.Grafica.Name = "Grafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grafica.Series.Add(series1);
            this.Grafica.Size = new System.Drawing.Size(363, 268);
            this.Grafica.TabIndex = 3;
            this.Grafica.Text = "chart1";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(16, 97);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(271, 213);
            this.txtResultado.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(221, 72);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(66, 22);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtbxDom1
            // 
            this.txtbxDom1.Location = new System.Drawing.Point(101, 71);
            this.txtbxDom1.Name = "txtbxDom1";
            this.txtbxDom1.Size = new System.Drawing.Size(38, 20);
            this.txtbxDom1.TabIndex = 8;
            this.txtbxDom1.Text = "-8";
            // 
            // txtbxDom2
            // 
            this.txtbxDom2.Location = new System.Drawing.Point(161, 71);
            this.txtbxDom2.Name = "txtbxDom2";
            this.txtbxDom2.Size = new System.Drawing.Size(38, 20);
            this.txtbxDom2.TabIndex = 9;
            this.txtbxDom2.Text = "8";
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDom.Location = new System.Drawing.Point(12, 69);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(84, 20);
            this.lblDom.TabIndex = 10;
            this.lblDom.Text = "Dominio:  (";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = ")";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "+";
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(200, 46);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(29, 20);
            this.C1.TabIndex = 18;
            this.C1.Text = "-126";
            // 
            // C0
            // 
            this.C0.Location = new System.Drawing.Point(258, 46);
            this.C0.Name = "C0";
            this.C0.Size = new System.Drawing.Size(29, 20);
            this.C0.TabIndex = 19;
            this.C0.Text = "1080";
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(135, 46);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(29, 20);
            this.C2.TabIndex = 20;
            this.C2.Text = "-123";
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(71, 46);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(29, 20);
            this.C3.TabIndex = 21;
            this.C3.Text = "6";
            // 
            // C4
            // 
            this.C4.Location = new System.Drawing.Point(6, 46);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(29, 20);
            this.C4.TabIndex = 22;
            this.C4.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "+";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Proyecto_Polinomio_Encriptador.Properties.Resources._1;
            this.pictureBox4.Location = new System.Drawing.Point(235, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 14);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto_Polinomio_Encriptador.Properties.Resources._2;
            this.pictureBox3.Location = new System.Drawing.Point(170, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Polinomio_Encriptador.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(105, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Proyecto_Polinomio_Encriptador.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(41, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmPoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 322);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C0);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.txtbxDom2);
            this.Controls.Add(this.txtbxDom1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.Grafica);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polinomio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPoli_FormClosed);
            this.Load += new System.EventHandler(this.frmPoli_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtbxDom1;
        private System.Windows.Forms.TextBox txtbxDom2;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox C1;
        private System.Windows.Forms.TextBox C0;
        private System.Windows.Forms.TextBox C2;
        private System.Windows.Forms.TextBox C3;
        private System.Windows.Forms.TextBox C4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeLaGráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeLasRaicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarImagenToolStripMenuItem;
    }
}