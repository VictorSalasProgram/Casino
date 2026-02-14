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
        string numero_apuesta = "";
        int pozo = 0;
         

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
            if (lbl_resultado.Text == txt_prueba.Text | txt_texto_par.Text == txt_prueba.Text | txt_color_apostado.Text == txt_prueba.Text) 
            {
                MessageBox.Show("GANASTE");
                cmb_color.SelectedIndex = -1;
                cmb_numero.SelectedIndex = -1;
                cmb_par.SelectedIndex = -1;
                
                cmb_color.Enabled = true;
                cmb_par.Enabled = true;
                cmb_numero.Enabled = true;

                btn_cambiar_apuesta.Enabled = false;
                btn_girar.Enabled = false;

                lbl_apuesta.Visible = false;
                lbl_apostado.Visible = false;

                txt_prueba.Text = "";
                lbl_resultado.Text = "";

                pozo = pozo * 2;
            }
            else
            {
                MessageBox.Show("PERDISTE");
                cmb_color.SelectedIndex = -1;
                cmb_numero.SelectedIndex = -1;
                cmb_par.SelectedIndex = -1;

                cmb_numero.Enabled = true;
                cmb_color.Enabled = true;
                cmb_par.Enabled = true;

                btn_cambiar_apuesta.Enabled = false;
                btn_girar.Enabled = false;

                lbl_apuesta.Visible = false;
                lbl_apostado.Visible = false;

                txt_prueba.Text = "";
                lbl_resultado.Text = "";

                pozo = 0;
            }
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
                txt_texto_par.Text = "";
            }
            else if (ganador % 2 == 0)
            {
                lbl_resultado.BackColor = Color.Red;
                txt_texto_par.Text = "PAR";
                txt_color_apostado.Text = "ROJO";
            }
            else if (ganador % 1 == 0) 
            {
                lbl_resultado.BackColor= Color.Black;
                txt_texto_par.Text = "IMPAR";
                txt_color_apostado.Text = "NEGRO";
            }


        }

        private void cmb_numero_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_numero.SelectedIndex == 0 & cmb_color.SelectedIndex == 0 & cmb_par.SelectedIndex ==0)
            {
                cmb_color.Enabled = true;
                cmb_par.Enabled = true;
                txt_prueba.Text = "";
            }
            else if (cmb_numero.SelectedIndex != 0)
            {
                cmb_par.Enabled = false;
                cmb_color.Enabled = false;
                int index_numero_apuesta = cmb_numero.SelectedIndex -1;
                numero_apuesta = index_numero_apuesta.ToString();
                txt_prueba.Text = numero_apuesta;

                cmb_color.SelectedIndex = 0;
                cmb_par.SelectedIndex = 0;
            }

        }

        private void btn_apostar_Click(object sender, EventArgs e)
        {


            if (cmb_numero.SelectedIndex != 0 )
            {
                int index_numero = cmb_numero.SelectedIndex - 1;
                lbl_apostado.Text = index_numero.ToString();
                lbl_apostado.Visible = true;
                lbl_apuesta.Visible = true;
                cmb_color.Enabled = false;
                cmb_numero.Enabled = false;
                cmb_par.Enabled = false;

                btn_girar.Enabled = true;
                btn_cambiar_apuesta.Enabled = true;

                
            }
            if (cmb_color.SelectedIndex != 0 )
            {

                lbl_apostado.Text = cmb_color.Text;
                lbl_apostado.Visible = true;
                lbl_apuesta.Visible = true;
                cmb_color.Enabled = false;
                cmb_numero.Enabled = false;
                cmb_par.Enabled = false;

                btn_girar.Enabled = true;
                btn_cambiar_apuesta.Enabled = true;

                
            }
            if (cmb_par.SelectedIndex != 0 )
            {
                lbl_apostado.Text = cmb_par.Text;
                lbl_apostado.Visible = true;
                lbl_apuesta.Visible = true;
                cmb_color.Enabled = false;
                cmb_numero.Enabled= false;
                cmb_par.Enabled= false;

                btn_girar.Enabled = true;
                btn_cambiar_apuesta.Enabled = true;
                ;
            }
            if (cmb_color.SelectedIndex == -1 & cmb_numero.SelectedIndex == -1 & cmb_par.SelectedIndex == -1 | txt_prueba.Text == "")
            {
                MessageBox.Show("Por favor apuestale a algo ", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lbl_apuesta.Visible = false;
                cmb_color.Enabled = true;
                cmb_numero.Enabled = true;
                cmb_par.Enabled = true;

                btn_cambiar_apuesta.Enabled = false;
                btn_girar.Enabled = false;
            }


        }

        private void apostar_creditos()
        {
            creditos -= 100;
            pozo += 100;
            txt_pozo.Text = pozo.ToString();
            txt_creditos.Text = creditos.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_color.Enabled = true;
            cmb_numero.Enabled = true;
            cmb_par.Enabled = true;

            btn_girar.Enabled = false;
            btn_cambiar_apuesta.Enabled = false;
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
                txt_prueba.Text = cmb_color.Text;   
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
                txt_prueba.Text= cmb_par.Text;



            }
            else if (cmb_par.SelectedIndex == -1 & cmb_color.SelectedIndex == -1 & cmb_numero.SelectedIndex == -1)
            {
                cmb_color.Enabled = true;
                cmb_numero.Enabled = true;
                cmb_par.Enabled = true;
            }
        }
    }
}
