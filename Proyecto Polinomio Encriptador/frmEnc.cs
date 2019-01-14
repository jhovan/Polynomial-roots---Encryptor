using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Polinomio_Encriptador
{
    public partial class frmEnc : Form
    {
        int[,] A = { { 2, 1 }, { 7, 4 } };
        int[,] Ainv = { { 4, -1 }, { -7, 2 } };
        bool Enc = true;
        bool salir = false;
        
        public frmEnc()
        {
            InitializeComponent();
        }

        private void frmEnc_Load(object sender, EventArgs e)
        {
            Enc = true;
            txtbx2.ReadOnly = true;
            txtbx1.ReadOnly = false;
        }

        private void txtbx1_TextChanged(object sender, EventArgs e) //encripta cuando cambia el texto
        {
            if (Enc == true)
            {
                Encriptar();
            }
        }

        private void txtbx2_TextChanged(object sender, EventArgs e) //desencripta cuando cambia el texto
        {
            if (Enc == false)
            {
                Desencriptar();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //cambia el sentido de la encriptacion
        {
            if (Enc == true)
            {
                Enc = false;
                pictureBox1.BackgroundImage = Image.FromFile(@"..\..\Resources\fechaizq.jpg");
                txtbx1.ReadOnly = true;
                txtbx2.ReadOnly = false;
                Desencriptar();
            }
            else
            {
                Enc = true;
                pictureBox1.BackgroundImage = Image.FromFile(@"..\..\Resources\flechader.jpg");
                txtbx1.ReadOnly = false;
                txtbx2.ReadOnly = true;
                Encriptar();
            }
        }

        private void matrizToolStripMenuItem_Click(object sender, EventArgs e)//Nuevo
        {
            if (MessageBox.Show("¿Deseas guardar tu mensaje?", "Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                guardar();
            txtbx1.Text = "";
            txtbx2.Text = "";
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)//Borrar
        {
            txtbx1.Text = "";
            txtbx2.Text = "";
        }

        private void informaciónToolStripMenuItem1_Click(object sender, EventArgs e)//Información
        {
            MessageBox.Show("Programa que encripta y desencripta texto por medio de una matriz.\n\nPrograma creado por:\nGallardo Valdez José Jhovan \nJiménez Cortés José Pablo\nRage Rojas Omar\n05-06-2014", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)//Guardar
        {
            guardar();
        }

        private void regresarToolStripMenuItem1_Click(object sender, EventArgs e)//Regresar
        {
            if (salir == true)
                this.Close();
            else
            {
                if (MessageBox.Show("¿Deseas guardar los cambios?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    this.Close();
                else
                    guardar();
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)//Borrar
        {
            txtbx1.Text = "";
            txtbx2.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)//Regresar
        {
            if (salir == true)
                Hide();
            else
            {
                if (MessageBox.Show("¿Deseas guardar los cambios?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    Hide();
                else
                    guardar();
            }
        }

        private void guardar() //guarda en un archivo de texto el texto encriptado o desencriptado segun sea el caso
        {
            SaveFileDialog Guardar = new SaveFileDialog();

            Guardar.Title = "Guardar...";
            Guardar.Filter = "Archivos de texto | *.txt";

            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(Guardar.FileName);
                if(Enc==true)
                    SW.Write(txtbx2.Text);
                else
                    SW.Write(txtbx1.Text);
                SW.Close();
            }
            salir = true;
        }

        private void archivoAEncriptarToolStripMenuItem_Click(object sender, EventArgs e)//Abrir archivo a encriptar
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = Image.FromFile(@"..\..\Resources\flechader.jpg");
                txtbx1.Text = "";
                txtbx2.Text = "";
                txtbx1.ReadOnly = false;
                txtbx2.ReadOnly = true;
                txtbx1.Text = SR.ReadToEnd();
                Enc = true;
                Encriptar();
                SR.Close();
            }
        }

        private void archivoADesencriptarToolStripMenuItem_Click(object sender, EventArgs e)//Abrir archivo a desencriptar
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = Image.FromFile(@"..\..\Resources\fechaizq.jpg");
                txtbx1.Text = "";
                txtbx2.Text = "";
                txtbx1.ReadOnly = true;
                txtbx2.ReadOnly = false;
                txtbx2.Text = SR.ReadToEnd();
                Enc = false;
                Desencriptar();
                SR.Close();
            }
        }

 

        public int[] Cross(int[,] mat, int[] T)
        {
            int[] Resultado = { 0, 0 };
            Resultado[0] = mat[0, 0] * T[0] + mat[0, 1] * T[1];
            Resultado[1] = mat[1, 0] * T[0] + mat[1, 1] * T[1];
            return Resultado;
        }
        public void Encriptar() //encripta el contenido de la caja de texto
        {
            var T = new List<int[]>();
            txtbx2.Text = "";
            bool d = true;
            int i = -1;
            for (int x = 0; x < txtbx1.Text.Length; x++)
            {
                int[] temp = new int[2];

                if (d == true)
                {
                    T.Add(temp);
                    i = i + 1;
                    T[i][0] = 0;
                    T[i][1] = 0;
                    T[i][0] = Encoding.ASCII.GetBytes(txtbx1.Text.Substring(x, 1))[0];
                    d = false;
                }
                else
                {
                    T[i][1] = 0;
                    T[i][1] = Encoding.ASCII.GetBytes(txtbx1.Text.Substring(x, 1))[0];
                    d = true;
                }

            }
            try
            {
                for (int a = 0; a < T.Count; a++)
                {
                    int[] ResTemp = Cross(A, T[a]);
                    txtbx2.Text = txtbx2.Text + ResTemp[0] + " " + ResTemp[1] + " ";

                }
            }
            catch
            {
                txtbx2.Text = "";
            }

        }
        public void Desencriptar() //desencripta el contenido de la caja de texto
        {
            char[] current = new char[txtbx2.Text.Length];
            var T = new List<string[]>();
            bool d = true, f = true, s = true;
            int i = -1;
            txtbx1.Text = "";
            for (int x = 0; x < txtbx2.Text.Length; x++)
            {
                string[] temp = new string[2];
                current[x] = (Convert.ToChar((txtbx2.Text.Substring(x, 1))));
                if (IsNumeric(current[x]))
                {
                    if (d == true)
                    {
                        if (f == true)
                        {
                            i = i + 1;
                            T.Add(temp);
                            T[i][0] = "";
                            T[i][1] = "";

                            f = false;
                        }
                        T[i][0] = T[i][0] + current[x];
                    }
                    else
                    {
                        if (f == true)
                        {
                            T[i][1] = T[i][1] + current[x];
                        }
                    }
                    s = false;
                }
                else
                {
                    if (s == false)
                    {
                        f = true;
                        if (d == true)
                        {
                            d = false;
                        }
                        else
                        {
                            d = true;
                        }
                        s = true;
                    }
                }
            }
            try
            {
                var Taux = new List<int[]>();

                for (int x = 0; x < T.Count; x++)
                {
                    int[] aux = new int[2];
                    aux[0] = Convert.ToInt32(T[x][0]);
                    aux[1] = Convert.ToInt32(T[x][1]);
                    Taux.Add(aux);
                    int[] temp = Cross(Ainv, Taux[x]);
                    txtbx1.Text = txtbx1.Text + Convert.ToChar(temp[0]) + Convert.ToChar(temp[1]);
                }
            }
            catch
            {
                txtbx1.Text = "Error";
            }
            if (string.IsNullOrEmpty(txtbx2.Text) && txtbx1.Text != "")
            {
                txtbx1.Text = "Datos erróneos";
            }

            return;
        }

        public static bool IsNumeric(object expression)
        {
            if (expression == null)
                return false;

            double testDouble;
            if (double.TryParse(expression.ToString(), out testDouble))
                return true;

            //VB's 'IsNumeric' returns true for any boolean value:
            bool testBool;
            if (bool.TryParse(expression.ToString(), out testBool))
                return true;

            return false;
        }

        private void frmEnc_FormClosed(object sender, FormClosedEventArgs e) //muestra el menu principal
        {
            frmPoliEnc PoliEnc = new frmPoliEnc();
            PoliEnc.Show();
        }
    }
}
