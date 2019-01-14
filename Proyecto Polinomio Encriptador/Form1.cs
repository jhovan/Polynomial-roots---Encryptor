using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Polinomio_Encriptador
{
    public partial class frmPoliEnc : Form
    {
        public frmPoliEnc()
        {
            InitializeComponent();
        }

        private void pbPoli_Click(object sender, EventArgs e) //abre el polinomio y cierra esconde el menu principal
        {
            frmPoli poli = new frmPoli();
            poli.Show();
            this.Hide();
        }



        private void pbEnc_Click_1(object sender, EventArgs e)//abre el encriptador y cierra esconde el menu principal
        {
            frmEnc enc = new frmEnc();
            enc.Show();
            this.Hide();
        }

        private void informaciónToolStripMenuItem1_Click(object sender, EventArgs e) //muestra informacion al usuario
        {
            MessageBox.Show("Programa que deja seleccionar al usuario entre resolver, factorizar y graficar un polinomio o entre encriptar y desencriptar un texto.\nPrograma creado por:\nGallardo Valdez José Jhovan\n05-06-2014", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmPoliEnc_FormClosed(object sender, FormClosedEventArgs e) //cierra la aplicacion definitivamente
        {
            Application.Exit();
        }


    }
}
