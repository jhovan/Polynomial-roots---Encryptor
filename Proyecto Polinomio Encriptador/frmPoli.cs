using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Drawing.Imaging;

namespace Proyecto_Polinomio_Encriptador
{
    public partial class frmPoli : Form
    {
        int grado;
        double[] Coeficientes;
        Complex[] Raices;
        Color ColGrafica = Color.Blue, ColRaices=Color.Red;

        public frmPoli()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e) //cuando se presiona el boton
        {

            Grafica.Series.Clear(); //primero se inicializa la grafica y el texto

            txtResultado.Clear();

            try //se obtienen los coeficientes
            {
                Coeficientes = new double[5] { Convert.ToDouble(C0.Text), Convert.ToDouble(C1.Text), Convert.ToDouble(C2.Text), Convert.ToDouble(C3.Text), Convert.ToDouble(C4.Text) };
            }
            catch
            {
                MessageBox.Show("Los coeficientes deben ser números","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            grado = 0;

            for (int i =0; i <= 4; i++) //se determina el grado del polinomio
            {
                if (Coeficientes[i] != 0)
                    grado = i;
            }

            switch (grado) //dependiendo del grado del polinomio se manda llamar a un metodo
            {
                case 0:
                    MessageBox.Show("El polinomio es de grado cero y por lo tanto no tiene raíces");
                    Raices= new Complex[0];
                    break;
                case 1:
                    Raices = PrimerGrado(Coeficientes);
                    break;
                case 2:
                    Raices = SegundoGrado(Coeficientes);
                    break;
                case 3:
                    Raices= TercerGrado(Coeficientes);
                    break;
                case 4:
                    Raices = CuartoGrado(Coeficientes);
                    break;
            }

            MostrarRaices(Raices); //se muestran los resultados;
            MostrarFactores(Raices);
            Graficar(Coeficientes);
        }

        private  Complex[] PrimerGrado(double[] Coeficientes) //despeje para primer grado
        {
            Complex[] Raices = { -Coeficientes[0]/Coeficientes[1] };
            return Raices;
        }

        private  Complex[] SegundoGrado(double[] Coeficientes) //formula general de segundo grado
        {
            Complex[] Raices = new Complex[2];
            Raices[0] = (-Coeficientes[1] + Complex.Sqrt(Complex.Pow(Coeficientes[1], 2) - 4 * Coeficientes[2] * Coeficientes[0])) / (2 * Coeficientes[2]);
            Raices[1] = (-Coeficientes[1] - Complex.Sqrt(Complex.Pow(Coeficientes[1], 2) - 4 * Coeficientes[2] * Coeficientes[0])) / (2 * Coeficientes[2]);
            return Raices;
        }

        private Complex[] TercerGrado(double[] Coeficientes)//formula general de tercer grado
        {
 
            Complex[] Raices = new Complex[3];

            double a = Coeficientes[3], b = Coeficientes[2], c = Coeficientes[1], d = Coeficientes[0];
            double delta = 18 * a * b * c * d - 4 * b * b * b * d + b * b * c * c - 4 * a * c * c * c - 27 * a * a * d * d;
            double delta0 = b * b - 3 * a * c;
            double delta1 = 2 * b * b * b - 9 * a * b * c + 27 * a * a * d;
            Complex delta2 = -27 * a * a * delta;

            Complex C = Complex.Pow((delta1 + Complex.Pow(delta2, 0.5)) / 2.0, 1 / 3.0);
            Complex[] U = { 1, new Complex(-0.5, Math.Sqrt(3) / 2.0), new Complex(-0.5, -Math.Sqrt(3) / 2.0) };



            if (delta == 0 || delta0 == 0) //se manejan casos particulares
            {
                if (delta == 0 && delta0 == 0)
                {
                    Raices[0] = (-b/ (3 * a));
                    Raices[1] = Raices[0];
                    Raices[2] = Raices[0];
                }
                else
                {
                    if (delta == 0 && delta0 != 0)
                    {
                        Raices[0]=(9*a*d-b*c)/(2*delta0);
                        Raices[1] = Raices[0];
                        Raices[2]=(4*a*b*c-9*Math.Pow(a,2)*d-Math.Pow(b,3))/(a*delta0);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Raices[i] = (-1.0 / (3 * a)) * (b + Complex.Multiply(U[i], C) + delta0 / (Complex.Multiply(U[i], C)));
                }
            }


            return Raices;
        }

        private Complex[] CuartoGrado(double[] Coeficientes) //metodo para resolver polinomios de cuarto grado
        {
            Complex[] Raices = new Complex[4];


            double[] CoeficientesAux = new double[5];

            for (int i = 0; i <= 4; i++)
            {
                CoeficientesAux[i] = Coeficientes[i] / Coeficientes[4];
            }


            double A = CoeficientesAux[4], B = CoeficientesAux[3], C = CoeficientesAux[2], D = CoeficientesAux[1], E = CoeficientesAux[0];


            if (B == 0 && D == 0) //si es bicuadratico se aplica la formula general de segundo grado
            {
                double[] CoeficientesAux2 = { Coeficientes[0], Coeficientes[2], Coeficientes[4] };
                Raices = SegundoGrado(CoeficientesAux2);
                Array.Resize(ref Raices, 4);
                Raices[2] = -Complex.Sqrt(Raices[1]);
                Raices[3] = Complex.Sqrt(Raices[1]);
                Raices[1] = -Complex.Sqrt(Raices[0]);
                Raices[0] = Complex.Sqrt(Raices[0]);
                

            }
            else //si no es bicuadratico se aplica la formula general de cuarto grado
            {

                double f = C - ((3 * Math.Pow(B, 2)) / 8.0);

                double g = D + (Math.Pow(B, 3) / 8) - (B * C / 2);

                double h = E - (3 * Math.Pow(B, 4) / 256.0) + (Math.Pow(B, 2) * C / 16.0) - (B * D / 4.0);

                double[] Coeficientes3 = { -Math.Pow(g, 2) / 64.0, (Math.Pow(f, 2) - 4 * h) / 16.0, f / 2.0, 1 };

                Complex[] Raices3 = TercerGrado(Coeficientes3);

                Complex[] pq = new Complex[3];
                int indice = 0;

                for (int i = 0; i < 3; i++)
                {
                    if (Math.Round(Raices3[i].Imaginary, 4) != 0 || Math.Round(Raices3[i].Real, 4) != 0)
                    {
                        pq[indice] = Complex.Sqrt(Raices3[i]);
                        indice += 1;
                    }
                }

                if (indice < 2)
                {
                    MessageBox.Show("El algoritmo no es aplicable");
                    Raices = new Complex[0];
                    return Raices;
                }

                Complex r = -g / (8 * pq[0] * pq[1]);

                Double s = Coeficientes[3] / (4 * Coeficientes[4]);

                Raices[0] = pq[0] + pq[1] + r - s;
                Raices[1] = pq[0] - pq[1] - r - s;
                Raices[2] = -pq[0] + pq[1] - r - s;
                Raices[3] = -pq[0] - pq[1] + r - s;

            }

            return Raices;
        }

        private  void MostrarRaices(Complex[] Raices) //metodo que escribe las raices en la caja de texto
        {
            string Raiz;

            txtResultado.Text = "Grado:" + grado + Environment.NewLine;

            for (int i = 0; i < Raices.Length; i++)
            {
                if (Math.Round(Raices[i].Imaginary, 2) == 0 && Math.Round(Raices[i].Real, 2) == 0)
                {
                    Raiz = "0";
                }
                else
                {
                    Raiz = "";
                    if (Math.Round(Raices[i].Real, 2) != 0)
                        Raiz = Raiz + Math.Round(Raices[i].Real, 2);

                    if (Math.Round(Raices[i].Real, 2) != 0 && Math.Round(Raices[i].Imaginary, 2) != 0)
                    {
                        if (Raices[i].Imaginary > 0)
                            Raiz = Raiz + "+";
                    }
                    if (Math.Round(Raices[i].Imaginary, 2) != 0)
                        Raiz = Raiz + Math.Round(Raices[i].Imaginary, 2) + "i";
                }

                txtResultado.Text = txtResultado.Text + Environment.NewLine + "X" + (i+1) + "=" + Raiz;
            }
            txtResultado.Text = txtResultado.Text + Environment.NewLine + Environment.NewLine;
        }

        private void MostrarFactores(Complex[] Raices) //metodo que escribe el polinomio factorizado en la caja de texto
        {
            string Factor;

            txtResultado.Text = txtResultado.Text + "Expresado en sus factores lineales:" + Environment.NewLine + Environment.NewLine;

            if (Coeficientes[grado] != 1 || grado==0)
                txtResultado.Text = txtResultado.Text + Coeficientes[grado];

            for (int i = 0; i < Raices.Length; i++)
            {
                Factor = "(X";
                if (Math.Round(Raices[i].Real, 2) != 0)
                {
                    if ( Raices[i].Real < 0)
                        Factor = Factor + "+";
                    Factor = Factor + Math.Round(-Raices[i].Real, 2);

                }

               if (-Math.Round( Raices[i].Imaginary,2) > 0)
                        Factor = Factor + "+";

                if (Math.Round(Raices[i].Imaginary, 2) != 0)
                    Factor = Factor + Math.Round(-Raices[i].Imaginary, 2) + "i";

                Factor = Factor + ")";
                txtResultado.Text = txtResultado.Text +  Factor;
            }
        }

        private void Graficar(double[] Coeficientes) //metodo que grafica el polinomio en un dominio dado y resalta las raices 
        {

            Grafica.Series.Clear();
            Grafica.Series.Add("Polinomio");
            Grafica.Series.Add("Raices");
            Grafica.Series["Polinomio"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Grafica.Series["Polinomio"].BorderWidth = 3;
            Grafica.Series["Polinomio"].Color = ColGrafica;
            Grafica.Series["Raices"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            Grafica.Series["Raices"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            Grafica.Series["Raices"].MarkerSize = 7;
            Grafica.Series["Raices"].Color = ColRaices;

            try
            {

                const double incremento = 0.01;
                double DiferenciaD, Min = Convert.ToDouble(txtbxDom1.Text), Max = Convert.ToDouble(txtbxDom2.Text);
                if (Max <= Min)
                    throw new Exception();
                DiferenciaD = Math.Round(Math.Abs(Max - Min), 2);
                int DiferenciaI = Convert.ToInt32(DiferenciaD / incremento);

                double[] y = new double[DiferenciaI], x = new double[DiferenciaI];

                for (int i = 0; i < DiferenciaI; i++)
                {
                    x[i] = Min + (i + 1) * incremento;
                    y[i] = 0;

                    for (int j = 0; j <= grado; j++)
                    {
                        y[i] += Coeficientes[j] * Math.Pow(x[i], j);
                    }

                    Grafica.Series["Polinomio"].Points.AddXY(x[i], y[i]);
                }

                for (int i = 0; i < grado; i++)
                {
                    if (Math.Round(Raices[i].Imaginary, 2) == 0)
                    {
                        if (Raices[i].Real >= Min && Raices[i].Real <= Max && Raices[i] != 0)
                        {
                            Grafica.Series["Raices"].Points.AddXY(Raices[i].Real, 0);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dominio no valido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

 

        private void colorDeLaGráficaToolStripMenuItem_Click(object sender, EventArgs e) //metodo que permite cambiar el color de la grafica
        {
            ColorDialog Colores = new ColorDialog();
            if (Colores.ShowDialog() == DialogResult.OK)
            {
                ColGrafica = Colores.Color;
                Grafica.Series["Polinomio"].Color = ColGrafica;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e) //vacia todas las cajas de texto y limpia la grafica
        {
            Grafica.Series.Clear();
            foreach ( TextBox Texto in this.Controls.OfType<TextBox>()) {
                Texto.Clear();
            }
        }


        private void EscribirA(string texto, string ruta) //escribe un archivo de texto en una ruta especificada
        {
            StreamWriter SW = new StreamWriter(ruta);
            SW.Write(texto);
            SW.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e) //guarda el contenido de la caja de texto en una ruta especificada
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivos de texto|*.txt";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                EscribirA(txtResultado.Text, guardar.FileName);
            }
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e) //muestra informacion al usuario
        {
            MessageBox.Show("Este programa puede calcular las raíces de un polinomio de grado 4 como máximo y lo gráfica.\nPrograma creado por:\nGallardo Valdez José Jhovan \nJiménez Cortés José Pablo\nRage Rojas Omar\n05-06-2014", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void colorDeLasRaicesToolStripMenuItem_Click(object sender, EventArgs e) //cambia el color de los puntos que resaltan las raices
        {
            ColorDialog Colores = new ColorDialog();
            if (Colores.ShowDialog() == DialogResult.OK)
            {
                ColRaices = Colores.Color;
                Grafica.Series["Raices"].Color = ColRaices;
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e) //cierra la aplicacion, lo cual regresa al menu raiz
        {
            this.Close();

        }

        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e) //guarda la grafica en una imagen
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "JPeg Imagen|*.jpg|Bitmap Imagen|*.bmp|PNG Imagen|*.png";
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream FS = new FileStream(guardar.FileName,FileMode.Create,FileAccess.Write);
                switch (guardar.FilterIndex)
                {
                    case 1:
                        this.Grafica.SaveImage(FS, ImageFormat.Jpeg);
                    break;
                    case 2:
                          this.Grafica.SaveImage(FS, ImageFormat.Bmp);
                    break;
                    case 3:
                          this.Grafica.SaveImage(FS, ImageFormat.Png);
                    break;
                }
                FS.Close();
            }
        }

        private void frmPoli_Load(object sender, EventArgs e)
        {

        }

        private void frmPoli_FormClosed(object sender, FormClosedEventArgs e) //abre el menu principal cuando se cierra el formulario
        {
            frmPoliEnc PoliEnc = new frmPoliEnc();
            PoliEnc.Show();
        }
       
    }
}