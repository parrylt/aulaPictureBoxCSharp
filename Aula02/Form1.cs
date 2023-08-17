using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Tem certeza que deseja sair?", "Olá", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit ();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botaoIMG1_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.direitos_autorais;
        }

        private void imgPIN_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.pinguim;
        }

        private void botaoPSI_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.Image = Properties.Resources.image;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.None;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.Fixed3D;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pcbFoto.Visible = false;
            }
            else
            {
                pcbFoto.Visible = true;
            }
           
        }

    }
}
