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
    public partial class subebaja : UserControl
    {
        public subebaja()
        {
            InitializeComponent();
        }
        int numeroValor = 0;
        int pica= 0;
        int creditos = 1000;
        int pozo = 0;
        int contador = 0;
        #region
        //e0igcihd
          //  gfeaebch
            //bbee0age
        #endregion
        private void btn_generar_Click(object sender, EventArgs e)
        {

            if (creditos > 0) {
                if (pb_carta1.Image == null)
                {
                    pozo = pozo + 100;
                    creditos = creditos - 100;
                    actualizarPozo();
                    actualizarCreditos();
                }
                else { 
            }
                
                actualizarPozo();
                actualizarCreditos();
                if (pb_carta1.Image == null)
                {
                    
                    generarCarta();
                    asignarCartas();
                    asignarImagenes();
                    cb_subebaja.Enabled = true;
                    cb_subebaja.SelectedIndex = 0;

                }
                else if (pb_carta2 != null)
                {
                    
                    pb_carta2.Image = pb_carta1.Image;
                    txt_pica2.Text = txt_pica.Text;
                    txt_valor2.Text = txt_valor.Text;
                    generarCarta();
                    asignarCartas();
                    asignarImagenes();
                    compararValores();
                    activarBoton(false);
                    activarBotonVolver(true);
                    activarRetirar(true);
                }
                
            } else
            {
                MessageBox.Show("Por favor recargue credtos","Casino Online", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
           
        }
        private void actualizarPozo()
        {
            txt_pozo.Text = pozo.ToString();
        }
        private void activarRetirar(bool estado)
        {
            btn_retirar.Enabled = estado;
        }
        private void activarBoton(bool estado)
        {
            btn_generar.Enabled = estado;
        }
        private void activarBotonVolver(bool estado)
        {
            btn_volver.Enabled = estado;
        }

        private void generarCarta()
        {
            Random random = new Random();
            numeroValor = random.Next(1, 14);
            txt_valor.Text = numeroValor.ToString();
            Random random2 = new Random();
            pica = random.Next(4);


        }
        private void multiplicador()
        {
            switch (contador)
            {
                case 2:
                    lbl_multiplicador.Text = "X2";
                    lbl_multiplicador.Visible = true;
                        break;
                case 5:
                    lbl_multiplicador.Text = "X3";
                    lbl_multiplicador.Visible = true;
                    break;
                case 10:
                    lbl_multiplicador.Text = "X10";
                    lbl_multiplicador.Visible = true;
                    break;
            }
        }
        private void compararValores()
        {
            if (cb_subebaja.SelectedIndex==0 && Convert.ToInt32(txt_valor2.Text) < Convert.ToInt32(txt_valor.Text)){
                lbl_estado.Text = "GANASTE";
                
                contador = contador + 1;
                
                actualizarCreditos();
                actualizarPozo();
              } else if (cb_subebaja.SelectedIndex == 0 && Convert.ToInt32(txt_valor2.Text) > Convert.ToInt32(txt_valor.Text) || (Convert.ToInt32(txt_valor2.Text) == Convert.ToInt32(txt_valor.Text))) {
                lbl_estado.Text = "PERDISTE";
                lbl_multiplicador.Visible = false;
                pozo = 0;
                contador = 0;
                actualizarCreditos();
                actualizarPozo();
            } else if (cb_subebaja.SelectedIndex == 1 && Convert.ToInt32(txt_valor2.Text) > Convert.ToInt32(txt_valor.Text)) {
                lbl_estado.Text = "GANASTE";
                
                
                contador = contador + 1;
                actualizarCreditos();
                actualizarPozo();
            } else if (cb_subebaja.SelectedIndex == 1 && Convert.ToInt32(txt_valor2.Text) < Convert.ToInt32(txt_valor.Text) || Convert.ToInt32(txt_valor2.Text) == Convert.ToInt32(txt_valor.Text))
            {
                lbl_estado.Text = "PERDISTE";
                pozo = 0;
                contador =0;
                lbl_multiplicador.Visible = false;
                actualizarPozo();
            } else if (cb_subebaja.SelectedIndex == 2 && Convert.ToInt32(txt_valor2.Text) == Convert.ToInt32(txt_valor.Text) || Convert.ToInt32(txt_valor2.Text) == Convert.ToInt32(txt_valor.Text))
            {
                lbl_estado.Text = "GANASTE";
                
                contador = contador + 1;
                actualizarCreditos();
                actualizarPozo();
            } else if (cb_subebaja.SelectedIndex == 2 && Convert.ToInt32(txt_valor2.Text) != Convert.ToInt32(txt_valor.Text))
            {
                lbl_estado.Text = "PERDISTE";
                pozo = 0;
                contador = 0;
                lbl_multiplicador.Visible = false;
                actualizarPozo();
            }
            multiplicador();
        }
        private void asignarImagenes()
        {
            if (pica == 0 && numeroValor == 1)
            {
                pb_carta1.Image = Properties.Resources.a_corazon;
            }
            else if (pica == 1 && numeroValor == 1)
            {
                pb_carta1.Image = Properties.Resources.a_diamante;
            }
            else if (pica == 2 && numeroValor == 1)
            {
                pb_carta1.Image = Properties.Resources.A_trebol;
            }
            else if (pica == 3 && numeroValor == 1)
            {           //AS
                pb_carta1.Image = Properties.Resources.a_pica;
            }
            else if (pica == 0 && numeroValor == 2)
            {
                pb_carta1.Image = Properties.Resources._2_corazon;
            }
            else if (pica == 1 && numeroValor == 2)
            {
                pb_carta1.Image = Properties.Resources._2_diamante;
            }
            else if (pica == 2 && numeroValor == 2)
            {                  //2
                pb_carta1.Image = Properties.Resources._2_trebol;
            }
            else if (pica == 3 && numeroValor == 2)
            {
                pb_carta1.Image = Properties.Resources.a_pica;
            }
            else if (pica == 0 && numeroValor == 3)
            {
                pb_carta1.Image = Properties.Resources._3_corazon;
            }
            else if (pica == 1 && numeroValor == 3)
            {
                pb_carta1.Image = Properties.Resources._3_diamante;
            }
            else if (pica == 2 && numeroValor == 3)                    //3
            {
                pb_carta1.Image = Properties.Resources._3_trebol;
            }
            else if (pica == 3 && numeroValor == 3)
            {
                pb_carta1.Image = Properties.Resources._3_pica;
            }
            else if (pica == 0 && numeroValor == 4)
            {
                pb_carta1.Image = Properties.Resources._4_corazon;
            }
            else if (pica == 1 && numeroValor == 4)
            {
                pb_carta1.Image = Properties.Resources._4_diamante;
            }
            else if (pica == 2 && numeroValor == 4)
            {                                                              //4
                pb_carta1.Image = Properties.Resources._4_trebol;
            }
            else if (pica == 3 && numeroValor == 4)
            {
                pb_carta1.Image = Properties.Resources._4_pica;
            }
            else if (pica == 0 && numeroValor == 5)
            {
                pb_carta1.Image = Properties.Resources._5_corazon;
            }
            else if (pica == 1 && numeroValor == 5)
            {
                pb_carta1.Image = Properties.Resources._5_diamante;
            }
            else if (pica == 2 && numeroValor == 5)
            {                                                                     //5
                pb_carta1.Image = Properties.Resources._5_trebol;
            }
            else if (pica == 3 && numeroValor == 5)
            {
                pb_carta1.Image = Properties.Resources._5_pica;
            }
            else if (pica == 0 && numeroValor == 6)
            {
                pb_carta1.Image = Properties.Resources._6_corazon;
            }
            else if (pica == 1 && numeroValor == 6)
            {
                pb_carta1.Image = Properties.Resources._6_diamante;
            }
            else if (pica == 2 && numeroValor == 6)
            {                                                                        //6
                pb_carta1.Image = Properties.Resources._6_trebol;
            }
            else if (pica == 3 && numeroValor == 6)
            {
                pb_carta1.Image = Properties.Resources._6_pica;
            }
            else if (pica == 0 && numeroValor == 7)
            {
                pb_carta1.Image = Properties.Resources._7_corazon;
            }
            else if (pica == 1 && numeroValor == 7)
            {
                pb_carta1.Image = Properties.Resources._7_diamante;
            }
            else if (pica == 2 && numeroValor == 7)
            {                                                                            //7
                pb_carta1.Image = Properties.Resources._7_trebol;
            }
            else if (pica == 3 && numeroValor == 7)
            {
                pb_carta1.Image = Properties.Resources._7_pica;
            }
            else if (pica == 0 && numeroValor == 8)
            {
                pb_carta1.Image = Properties.Resources._8_corazon;
            }
            else if (pica == 1 && numeroValor == 8)
            {
                pb_carta1.Image = Properties.Resources._8_diamante;
            }
            else if (pica == 2 && numeroValor == 8)
            {                                                                              //8
                pb_carta1.Image = Properties.Resources._8_trebol;
            }
            else if (pica == 3 && numeroValor == 8)
            {
                pb_carta1.Image = Properties.Resources._8_pica;
            }
            else if (pica == 0 && numeroValor == 9)
            {
                pb_carta1.Image = Properties.Resources._9_corazon;
            }
            else if (pica == 1 && numeroValor == 9)
            {
                pb_carta1.Image = Properties.Resources._9_diamante;
            }
            else if (pica == 2 && numeroValor == 9)
            {                                                                             //9
                pb_carta1.Image = Properties.Resources._9_trebol;
            }
            else if (pica == 3 && numeroValor == 9)
            {
                pb_carta1.Image = Properties.Resources._9_pica;
            }
            else if (pica == 0 && numeroValor == 10)
            {
                pb_carta1.Image = Properties.Resources._10_corazon;
            }
            else if (pica == 1 && numeroValor == 10)
            {
                pb_carta1.Image = Properties.Resources._10_diamante;
            }
            else if (pica == 2 && numeroValor == 10)
            {                                                                            //10
                pb_carta1.Image = Properties.Resources._10_trebol;
            }
            else if (pica == 3 && numeroValor == 2)
            {
                pb_carta1.Image = Properties.Resources.a_pica;
            }
            else if (pica == 0 && numeroValor == 11)
            {
                pb_carta1.Image = Properties.Resources.j_corazon;
            }
            else if (pica == 1 && numeroValor == 11)
            {
                pb_carta1.Image = Properties.Resources.j_diamante;
            }
            else if (pica == 2 && numeroValor == 11)
            {                                                                            //J
                pb_carta1.Image = Properties.Resources.J_trebol;
            }
            else if (pica == 3 && numeroValor == 11)
            {
                pb_carta1.Image = Properties.Resources.j_pica;
            }
            else if (pica == 0 && numeroValor == 12)
            {
                pb_carta1.Image = Properties.Resources.q_corazon;
            }
            else if (pica == 1 && numeroValor == 12)
            {
                pb_carta1.Image = Properties.Resources.q_diamante;
            }
            else if (pica == 2 && numeroValor == 12)
            {                                                                            //Q
                pb_carta1.Image = Properties.Resources.q_trebol;
            }
            else if (pica == 3 && numeroValor == 12)
            {
                pb_carta1.Image = Properties.Resources.q_pica;
            }
            else if (pica == 0 && numeroValor == 13)
            {
                pb_carta1.Image = Properties.Resources.k_corazon;
            }
            else if (pica == 1 && numeroValor == 13)
            {
                pb_carta1.Image = Properties.Resources.k_diamante;
            }
            else if (pica == 2 && numeroValor == 13)
            {                                                                            //K
                pb_carta1.Image = Properties.Resources.k_trebol;
            }
            else if (pica == 3 && numeroValor == 13)
            {
                pb_carta1.Image = Properties.Resources.k_pica;
            }
        }
        private void asignarCartas()
        {
            switch (pica)
            {
                case 0:
                    txt_pica.Text = "Corazon";
                    break;
                case 1:
                    txt_pica.Text = "Diamante";
                    break;
                case 2:
                    txt_pica.Text = "Trebol";
                    break;
                case 3:
                    txt_pica.Text = "Pica";
                    break;
            }
        }

        private void subebaja_Load(object sender, EventArgs e)
        {
            txt_creditos.Text = creditos.ToString();
            activarBotonVolver(false);
        }
       
        private void btn_recarga_Click(object sender, EventArgs e)
        {
            creditos = creditos +  100;
            actualizarCreditos();
        }
        private void actualizarCreditos()
        {
            txt_creditos.Text = creditos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activarBoton(true);
            activarBotonVolver(false);
            pb_carta2.Image = null;
            pb_carta1.Image = null;
            lbl_estado.Text = "";
            actualizarPozo();

        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Seguro que deseas retirar los creditos?", "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcion == DialogResult.Yes)
            {
                activarRetirar(false);

                if (contador >= 2 && contador < 5)
                {
                    creditos = creditos + (pozo * 2);
                    pozo = 0;
                    contador = 0;
                    lbl_multiplicador.Text = "";
                    actualizarCreditos();
                    actualizarPozo();
                }
                else if (contador >= 5 && contador < 10)
                {
                    creditos = creditos + (pozo * 3);
                    pozo = 0;
                    contador = 0;
                    lbl_multiplicador.Text = "";
                    actualizarCreditos();
                    actualizarPozo();
                }
                else if (contador >= 10)
                {
                    creditos = creditos + (pozo * 10);
                    pozo = 0;
                    contador = 0;
                    actualizarCreditos();
                    actualizarPozo();
                }
                else
                {
                    creditos = creditos + pozo;
                    pozo = 0;
                    contador = 0;
                    lbl_multiplicador.Text = "";
                    actualizarCreditos();
                    actualizarPozo();
                }
            } else {
            }
  
        }
    }  
    
       
}
