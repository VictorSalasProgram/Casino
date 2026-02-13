using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Ruleta : UserControl
    {
        public Ruleta()
        {
            InitializeComponent();
        }
        int creditos = 1000;
        int ganador = 0;
        int color = 0;

        private void Ruleta_Load(object sender, EventArgs e)
        {
            txt_creditos.Text = creditos.ToString();
        }

        private void btn_recarga_Click(object sender, EventArgs e)
        {

            aumentar_creditos();
        }

        private void aumentar_creditos()
        {
            creditos += 100;

            txt_creditos.Text = creditos.ToString();

        }

        private void btn_girar_Click(object sender, EventArgs e)
        {
            girar();
        }



        private void girar()
        {
            Random random = new Random();
            ganador = random.Next(0, 36);
            lbl_resultado.Text = ganador.ToString();
            asignar_color();
            


        }

        private void asignar_color()
        {
            if (ganador == 0)
            {
                lbl_resultado.BackColor = Color.FromArgb(41, 99, 24);
            }
            else if (ganador % 2 == 0)
            {
                lbl_resultado.BackColor = Color.Red;

            }
            else if (ganador % 1 == 0) 
            {
                lbl_resultado.BackColor= Color.Black;
            }


        }

        private void cmb_numero_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_numero.SelectedIndex == 0 & cmb_color.SelectedIndex == 0 & cmb_par.SelectedIndex ==0)
            {
                cmb_color.Enabled = true;
                cmb_par.Enabled = true;
            }
            else if (cmb_numero.SelectedIndex != 0)
            {
                cmb_par.Enabled = false;
                cmb_color.Enabled = false;

                cmb_color.SelectedIndex = 0;
                cmb_par.SelectedIndex = 0;
            }

        }

        private void btn_apostar_Click(object sender, EventArgs e)
        {
            if (cmb_numero.SelectedIndex != 0)
            {
                int index_numero = cmb_numero.SelectedIndex - 1;
                lbl_apostado.Text = index_numero.ToString();
                lbl_apostado.Visible = true;
                lbl_apuesta.Visible = true;
            }
            if (cmb_color.SelectedIndex != 0)
            {

                lbl_apostado.Text = cmb_color.Text;
                lbl_apostado.Visible = true;
                lbl_apuesta.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_color.SelectedIndex == 0 & cmb_numero.SelectedIndex == 0 & cmb_par.SelectedIndex ==0)
            {
                cmb_numero.Enabled = true;
                cmb_par.Enabled = true;
            }
            else if (cmb_color.SelectedIndex != 0)
            {
                cmb_numero.Enabled = false;
                cmb_par.Enabled = false;
                cmb_numero.SelectedIndex = 0;
                cmb_par.SelectedIndex = 0;
            }

        }

        private void btn_retirarse_Click(object sender, EventArgs e)
        {

        }

        private void cmb_par_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_par.SelectedIndex != 0)
            {
                cmb_color.Enabled = false;
                cmb_numero.Enabled = false;
                cmb_color.SelectedIndex = 0;
                cmb_numero.SelectedIndex = 0;


            }
            else if (cmb_par.SelectedIndex == 0 & cmb_color.SelectedIndex == 0 & cmb_numero.SelectedIndex == 0)
            {
                cmb_color.Enabled = true;
                cmb_numero.Enabled = true;
                cmb_par.Enabled = true;
            }
        }
    }
}
