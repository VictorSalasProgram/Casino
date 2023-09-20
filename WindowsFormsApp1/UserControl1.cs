using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        private object random;

        public UserControl1()
        {
            InitializeComponent();
        }
        int creditos = 1000;
        int pozo = 0;
        int numeroPica = 0;
        int numeroValor = 0;
        int numeroPica2 = 0;
        int numeroValor2 = 0;
        int numeroValor3 = 0;
        int numeroPica3 = 0;
        int numeroPica4 =0;
        int numeroValor4 = 0;
        int[] arraySuma = new int[4];
        int suma = 0;

        // VARIABLES
        #region "NUMEROS"
        int[] num = { 11, 56, 34, 63, 51 };
        #endregion
        private void btn_generar_Click(object sender, EventArgs e)
        {
           
            if (Convert.ToInt32(txt_creditos.Text)>50)
            {
                generarCarta();
                generarCarta2();
                pozo = pozo + 50;
                actualizarPozo();
                asignarImagenes();
                asignarImagenes2();
                calculaAcumulado();
            } else
            {
                MessageBox.Show("Por favor recargue creditos", "Casino Online", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
            
        }
        private void generarCarta()
        {
            
            Random random = new Random();
            numeroValor = random.Next(1,14);

            txt_numero.Text = Convert.ToString(numeroValor);

            
            Random random2 = new Random();
            numeroPica = random.Next(3);
            asignarCartas();
            
            pnl_acciones.Enabled = true;
            btn_generar.Enabled = false;
            creditos = creditos - 50;
            actualizarCreditos();
        }
        private void generarCarta2()
        {

            Random random3 = new Random();
            numeroValor2 = random3.Next(1, 14);

            Random random4 = new Random();
            numeroPica2 = random4.Next(4);
            asignarCartas();

            pnl_acciones.Enabled = true;
            btn_generar.Enabled = false;
            
            actualizarCreditos();
        }
        private void asignarCartas()
        {
            switch (numeroPica)
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
        private void asignarImagenes()
        {
            if (numeroPica == 0 && numeroValor == 1)
            {
                pcb_carta1.Image = Properties.Resources.a_corazon;
            } else if (numeroPica == 1 && numeroValor == 1) {
                pcb_carta1.Image = Properties.Resources.a_diamante;
            } else if (numeroPica == 2 && numeroValor == 1){
                pcb_carta1.Image = Properties.Resources.A_trebol;
            } else if (numeroPica == 3 && numeroValor == 1){           //AS
                pcb_carta1.Image = Properties.Resources.a_pica;
            } else if (numeroPica == 0 && numeroValor== 2)
            {
                pcb_carta1.Image = Properties.Resources._2_corazon;
            } else if(numeroPica == 1 && numeroValor == 2) {
                pcb_carta1.Image = Properties.Resources._2_diamante;
            } else if (numeroPica == 2 && numeroValor == 2) {                  //2
                pcb_carta1.Image = Properties.Resources._2_trebol;
            } else if (numeroPica == 3 && numeroValor == 2){
                pcb_carta1.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica == 0 && numeroValor == 3)
            {
                pcb_carta1.Image = Properties.Resources._3_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 3)
            {
                pcb_carta1.Image = Properties.Resources._3_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 3)                    //3
            {                 
                pcb_carta1.Image = Properties.Resources._3_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 3)
            {
                pcb_carta1.Image = Properties.Resources._3_pica;
            }
            else if (numeroPica == 0 && numeroValor == 4)
            {
                pcb_carta1.Image = Properties.Resources._4_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 4)
            {
                pcb_carta1.Image = Properties.Resources._4_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 4)
            {                                                              //4
                pcb_carta1.Image = Properties.Resources._4_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 4)
            {
                pcb_carta1.Image = Properties.Resources._4_pica;
            }
            else if (numeroPica == 0 && numeroValor == 5)
            {
                pcb_carta1.Image = Properties.Resources._5_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 5)
            {
                pcb_carta1.Image = Properties.Resources._5_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 5)
            {                                                                     //5
                pcb_carta1.Image = Properties.Resources._5_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 5)
            {
                pcb_carta1.Image = Properties.Resources._5_pica;
            }
            else if (numeroPica == 0 && numeroValor == 6)
            {
                pcb_carta1.Image = Properties.Resources._6_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 6)
            {
                pcb_carta1.Image = Properties.Resources._6_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 6)
            {                                                                        //6
                pcb_carta1.Image = Properties.Resources._6_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 6)
            {
                pcb_carta1.Image = Properties.Resources._6_pica;
            }
            else if (numeroPica == 0 && numeroValor == 7)
            {
                pcb_carta1.Image = Properties.Resources._7_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 7)
            {
                pcb_carta1.Image = Properties.Resources._7_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 7)
            {                                                                            //7
                pcb_carta1.Image = Properties.Resources._7_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 7)
            {
                pcb_carta1.Image = Properties.Resources._7_pica;
            }
            else if (numeroPica == 0 && numeroValor == 8)
            {
                pcb_carta1.Image = Properties.Resources._8_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 8)
            {
                pcb_carta1.Image = Properties.Resources._8_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 8)
            {                                                                              //8
                pcb_carta1.Image = Properties.Resources._8_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 8)
            {
                pcb_carta1.Image = Properties.Resources._8_pica;
            }
            else if (numeroPica == 0 && numeroValor == 9)
            {
                pcb_carta1.Image = Properties.Resources._9_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 9)
            {
                pcb_carta1.Image = Properties.Resources._9_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 9)
            {                                                                             //9
                pcb_carta1.Image = Properties.Resources._9_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 9)
            {
                pcb_carta1.Image = Properties.Resources._9_pica;
            }
            else if (numeroPica == 0 && numeroValor == 10)
            {
                pcb_carta1.Image = Properties.Resources._10_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 10)
            {
                pcb_carta1.Image = Properties.Resources._10_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 10)
            {                                                                            //10
                pcb_carta1.Image = Properties.Resources._10_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 2)
            {
                pcb_carta1.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica == 0 && numeroValor == 11)
            {
                pcb_carta1.Image = Properties.Resources.j_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 11)
            {
                pcb_carta1.Image = Properties.Resources.j_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 11)
            {                                                                            //J
                pcb_carta1.Image = Properties.Resources.J_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 11)
            {
                pcb_carta1.Image = Properties.Resources.j_pica;
            }
            else if (numeroPica == 0 && numeroValor == 12)
            {
                pcb_carta1.Image = Properties.Resources.q_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 12)
            {
                pcb_carta1.Image = Properties.Resources.q_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 12)
            {                                                                            //Q
                pcb_carta1.Image = Properties.Resources.q_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 12)
            {
                pcb_carta1.Image = Properties.Resources.q_pica;
            }
            else if (numeroPica == 0 && numeroValor == 13)
            {
                pcb_carta1.Image = Properties.Resources.k_corazon;
            }
            else if (numeroPica == 1 && numeroValor == 13)
            {
                pcb_carta1.Image = Properties.Resources.k_diamante;
            }
            else if (numeroPica == 2 && numeroValor == 13)
            {                                                                            //K
                pcb_carta1.Image = Properties.Resources.k_trebol;
            }
            else if (numeroPica == 3 && numeroValor == 13)
            {
                pcb_carta1.Image = Properties.Resources.k_pica;
            }
        }
        private void asignarImagenes2()
        {
            if (numeroPica2 == 0 && numeroValor2 == 1)
            {
                pcb_carta2.Image = Properties.Resources.a_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 1)
            {
                pcb_carta2.Image = Properties.Resources.a_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 1)
            {
                pcb_carta2.Image = Properties.Resources.A_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 1)
            {           //AS
                pcb_carta2.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 2)
            {
                pcb_carta2.Image = Properties.Resources._2_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 2)
            {
                pcb_carta2.Image = Properties.Resources._2_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 2)
            {                  //2
                pcb_carta2.Image = Properties.Resources._2_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 2)
            {
                pcb_carta2.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 3)
            {
                pcb_carta2.Image = Properties.Resources._3_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 3)
            {
                pcb_carta2.Image = Properties.Resources._3_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 3)                    //3
            {
                pcb_carta2.Image = Properties.Resources._3_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 3)
            {
                pcb_carta2.Image = Properties.Resources._3_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 4)
            {
                pcb_carta2.Image = Properties.Resources._4_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 4)
            {
                pcb_carta2.Image = Properties.Resources._4_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 4)
            {                                                              //4
                pcb_carta2.Image = Properties.Resources._4_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 4)
            {
                pcb_carta2.Image = Properties.Resources._4_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 5)
            {
                pcb_carta2.Image = Properties.Resources._5_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 5)
            {
                pcb_carta2.Image = Properties.Resources._5_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 5)
            {                                                                     //5
                pcb_carta2.Image = Properties.Resources._5_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 5)
            {
                pcb_carta2.Image = Properties.Resources._5_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 6)
            {
                pcb_carta2.Image = Properties.Resources._6_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 6)
            {
                pcb_carta2.Image = Properties.Resources._6_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 6)
            {                                                                        //6
                pcb_carta2.Image = Properties.Resources._6_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 6)
            {
                pcb_carta2.Image = Properties.Resources._6_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 7)
            {
                pcb_carta2.Image = Properties.Resources._7_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 7)
            {
                pcb_carta2.Image = Properties.Resources._7_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 7)
            {                                                                            //7
                pcb_carta2.Image = Properties.Resources._7_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 7)
            {
                pcb_carta2.Image = Properties.Resources._7_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 8)
            {
                pcb_carta2.Image = Properties.Resources._8_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 8)
            {
                pcb_carta2.Image = Properties.Resources._8_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 8)
            {                                                                              //8
                pcb_carta2.Image = Properties.Resources._8_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 8)
            {
                pcb_carta2.Image = Properties.Resources._8_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 9)
            {
                pcb_carta2.Image = Properties.Resources._9_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 9)
            {
                pcb_carta2.Image = Properties.Resources._9_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 9)
            {                                                                             //9
                pcb_carta2.Image = Properties.Resources._9_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 9)
            {
                pcb_carta2.Image = Properties.Resources._9_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 10)
            {
                pcb_carta2.Image = Properties.Resources._10_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 10)
            {
                pcb_carta2.Image = Properties.Resources._10_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 10)
            {                                                                            //10
                pcb_carta2.Image = Properties.Resources._10_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 2)
            {
                pcb_carta2.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 11)
            {
                pcb_carta2.Image = Properties.Resources.j_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 11)
            {
                pcb_carta2.Image = Properties.Resources.j_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 11)
            {                                                                            //J
                pcb_carta2.Image = Properties.Resources.J_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 11)
            {
                pcb_carta2.Image = Properties.Resources.j_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 12)
            {
                pcb_carta2.Image = Properties.Resources.q_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 12)
            {
                pcb_carta2.Image = Properties.Resources.q_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 12)
            {                                                                            //Q
                pcb_carta2.Image = Properties.Resources.q_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 12)
            {
                pcb_carta2.Image = Properties.Resources.q_pica;
            }
            else if (numeroPica2 == 0 && numeroValor2 == 13)
            {
                pcb_carta2.Image = Properties.Resources.k_corazon;
            }
            else if (numeroPica2 == 1 && numeroValor2 == 13)
            {
                pcb_carta2.Image = Properties.Resources.k_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2 == 13)
            {                                                                            //K
                pcb_carta2.Image = Properties.Resources.k_trebol;
            }
            else if (numeroPica2 == 3 && numeroValor2 == 13)
            {
                pcb_carta2.Image = Properties.Resources.k_pica;
            }
        }

        private void calculaAcumulado()
        {
            arraySuma[0] = numeroValor;
            arraySuma[1] = numeroValor2;
            arraySuma[2] = numeroValor3;
            arraySuma[3] = numeroValor4;
            for (int i = 0; i < arraySuma.Length; i++)
            {
                if (arraySuma[i] >= 10)
                {
                    suma += arraySuma[i] - (arraySuma[i] -10);
                }
                else
                {
                    suma += arraySuma[i];
                }
            }
            txt_acumulado.Text = suma.ToString();


            //// if (pcb_carta3.Image == null) {
            //if (numeroValor > 10 && numeroValor2 < 10)
            //    {
            //        txt_acumulado.Text = Convert.ToString(numeroValor - (numeroValor - 10) + numeroValor2);
            //    }
            //    else if (numeroValor < 10 && numeroValor2 > 10)
            //    {

            //        txt_acumulado.Text = Convert.ToString(numeroValor + numeroValor2 - (numeroValor2 - 10) +numeroValor3 + numeroValor4);
            //    }
            //    else if (numeroValor > 10 && numeroValor2 > 10)
            //    {
            //        txt_acumulado.Text = Convert.ToString(numeroValor - (numeroValor - 10) + numeroValor2 - (numeroValor2 - 10) +numeroValor3 + numeroValor4);
            //    }
            //    else if (numeroValor <= 10 && numeroValor2 <= 10)
            //    {
            //        txt_acumulado.Text = Convert.ToString(numeroValor + numeroValor2 +numeroValor4 + numeroValor3);
            //    }
            //    else
            //    {
            //        txt_acumulado.Text = Convert.ToString(numeroValor + numeroValor2 + numeroValor4+ numeroValor3);
            //    }

        }
        
        private void allIn()
        {
            pozo = pozo + creditos;
            txt_pozo.Text = pozo.ToString();
            creditos = 0;
            actualizarCreditos();
        }
        private void btn_irte_Click(object sender, EventArgs e)
        {


            DialogResult Rpt = MessageBox.Show("Seguro que desea irse? \n Perdera todos los creditos", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            if (Rpt == DialogResult.Yes)
            {
                txt_numero.Clear();
                txt_pica.Clear();
                txt_pozo.Clear();
                btn_generar.Enabled = true;
                pnl_acciones.Enabled = false;
                actualizarCreditos();
                pozo = 0;
                pcb_carta1.Image = null;
                pcb_carta2.Image = null;
                pcb_carta3.Image = null;
                pcb_carta4.Image = null;
                txt_acumulado.Clear();
                numeroValor2 = 0;
                numeroValor3 = 0;
                numeroValor4 = 0;
                suma = 0;
            } 
            
        
                
                }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            txt_creditos.Text = creditos.ToString();
            txt_pozo.Text = pozo.ToString();

        }

        private void actualizarCreditos()
        {
            txt_creditos.Text = creditos.ToString();
        }

        private void btn_Aapuesta_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32( txt_creditos.Text) >= 100)
            {
                pozo = pozo + 100;
                creditos = creditos - 100;
                actualizarPozo();
                actualizarCreditos();

            } else
            {
                MessageBox.Show("Por favor recargue creditos", "Casino Online", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }
        private void actualizarPozo()
        {
            txt_pozo.Text= pozo.ToString();
        }
        private void calcularBj()
        {
            if (Convert.ToInt32( txt_acumulado.Text) > 21)
            {
                MessageBox.Show("PERDISTE!", "Casino Online", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_numero.Clear();
                txt_pica.Clear();
                txt_pozo.Clear();
                btn_generar.Enabled = true;
                pnl_acciones.Enabled = false;
                actualizarCreditos();
                pozo = 0;
                pcb_carta1.Image = null;
                pcb_carta2.Image = null;
                pcb_carta3.Image = null;
                pcb_carta4.Image = null;
                txt_acumulado.Clear();
                numeroValor2 = 0;
                numeroValor3 = 0;
                numeroValor4 = 0;
                suma = 0;

            }
        }

        private void btn_apuestaC_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_creditos.Text) > 0)
            {
                pozo = pozo + 50;
                creditos = creditos - 50;
                actualizarPozo();
                actualizarCreditos();

            }
            else
            {
                MessageBox.Show("Por favor recargue creditos", "Casino Online", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_allin_Click(object sender, EventArgs e)
        {
            if (creditos > 0)
            {
                actualizarCreditos();
                allIn();
            }  else
            {
                MessageBox.Show("Por favor regargue creditos", "Casino Online", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btn_recarga_Click(object sender, EventArgs e)
        {
            creditos = creditos + 100;
            actualizarCreditos();
        }
        private void generarCarta3()
        {

            Random random5 = new Random();
            numeroValor3 = random5.Next(1, 14);

            Random random6 = new Random();
            numeroPica3 = random6.Next(4);
            asignarCartas();
            actualizarCreditos();
        }
        private void generarCarta4()
        {

            Random random7 = new Random();
            numeroValor4 = random7.Next(1, 14);

            Random random8 = new Random();
            numeroPica4 = random8.Next(4);
            asignarCartas();
            actualizarCreditos();
        }
        private void asignarImagenes3()
        {
            
            if (numeroPica3 == 0 && numeroValor3 == 1)
            {
                pcb_carta3.Image = Properties.Resources.a_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 1)
            {
                pcb_carta3.Image = Properties.Resources.a_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 1)
            {
                pcb_carta3.Image = Properties.Resources.A_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 1)
            {           //AS
                pcb_carta3.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 2)
            {
                pcb_carta3.Image = Properties.Resources._2_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 2)
            {
                pcb_carta3.Image = Properties.Resources._2_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 2)
            {                  //2
                pcb_carta3.Image = Properties.Resources._2_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 2)
            {
                pcb_carta3.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 3)
            {
                pcb_carta3.Image = Properties.Resources._3_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 3)
            {
                pcb_carta3.Image = Properties.Resources._3_diamante;
            }
            else if (numeroPica2 == 2 && numeroValor2    == 3)                    //3
            {
                pcb_carta3.Image = Properties.Resources._3_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 3)
            {
                pcb_carta3.Image = Properties.Resources._3_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 4)
            {
                pcb_carta3.Image = Properties.Resources._4_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 4)
            {
                pcb_carta3.Image = Properties.Resources._4_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 4)
            {                                                              //4
                pcb_carta3.Image = Properties.Resources._4_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 4)
            {
                pcb_carta3.Image = Properties.Resources._4_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 5)
            {
                pcb_carta3.Image = Properties.Resources._5_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 5)
            {
                pcb_carta3.Image = Properties.Resources._5_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 5)
            {                                                                     //5
                pcb_carta3.Image = Properties.Resources._5_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 5)
            {
                pcb_carta3.Image = Properties.Resources._5_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 6)
            {
                pcb_carta3.Image = Properties.Resources._6_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 6)
            {
                pcb_carta3.Image = Properties.Resources._6_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 6)
            {                                                                        //6
                pcb_carta3.Image = Properties.Resources._6_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 6)
            {
                pcb_carta3.Image = Properties.Resources._6_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 7)
            {
                pcb_carta3.Image = Properties.Resources._7_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 7)
            {
                pcb_carta3.Image = Properties.Resources._7_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 7)
            {                                                                            //7
                pcb_carta3.Image = Properties.Resources._7_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 7)
            {
                pcb_carta3.Image = Properties.Resources._7_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 8)
            {
                pcb_carta3.Image = Properties.Resources._8_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 8)
            {
                pcb_carta3.Image = Properties.Resources._8_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 8)
            {                                                                              //8
                pcb_carta3.Image = Properties.Resources._8_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 8)
            {
                pcb_carta3.Image = Properties.Resources._8_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 9)
            {
                pcb_carta3.Image = Properties.Resources._9_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 9)
            {
                pcb_carta3.Image = Properties.Resources._9_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 9)
            {                                                                             //9
                pcb_carta3.Image = Properties.Resources._9_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 9)
            {
                pcb_carta3.Image = Properties.Resources._9_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 10)
            {
                pcb_carta3.Image = Properties.Resources._10_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 10)
            {
                pcb_carta3.Image = Properties.Resources._10_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 10)
            {                                                                            //10
                pcb_carta3.Image = Properties.Resources._10_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 10)
            {
                pcb_carta3.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 11)
            {
                pcb_carta3.Image = Properties.Resources.j_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 11)
            {
                pcb_carta3.Image = Properties.Resources.j_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 11)
            {                                                                            //J
                pcb_carta3.Image = Properties.Resources.J_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 11)
            {
                pcb_carta3.Image = Properties.Resources.j_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 12)
            {
                pcb_carta3.Image = Properties.Resources.q_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 12)
            {
                pcb_carta3.Image = Properties.Resources.q_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 12)
            {                                                                            //Q
                pcb_carta3.Image = Properties.Resources.q_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 12)
            {
                pcb_carta3.Image = Properties.Resources.q_pica;
            }
            else if (numeroPica3 == 0 && numeroValor3 == 13)
            {
                pcb_carta3.Image = Properties.Resources.k_corazon;
            }
            else if (numeroPica3 == 1 && numeroValor3 == 13)
            {
                pcb_carta3.Image = Properties.Resources.k_diamante;
            }
            else if (numeroPica3 == 2 && numeroValor3 == 13)
            {                                                                            //K
                pcb_carta3.Image = Properties.Resources.k_trebol;
            }
            else if (numeroPica3 == 3 && numeroValor3 == 13)
            {
                pcb_carta3.Image = Properties.Resources.k_pica;
            }
        }
        private void asignarImagenes4()
        {

            if (numeroPica4 == 0 && numeroValor4 == 1)
            {
                pcb_carta4.Image = Properties.Resources.a_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 1)
            {
                pcb_carta4.Image = Properties.Resources.a_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 1)
            {
                pcb_carta4.Image = Properties.Resources.A_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 1)
            {           //AS
                pcb_carta4.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 2)
            {
                pcb_carta4.Image = Properties.Resources._2_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 2)
            {
                pcb_carta4.Image = Properties.Resources._2_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 2)
            {                  //2
                pcb_carta4.Image = Properties.Resources._2_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 2)
            {
                pcb_carta4.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 3)
            {
                pcb_carta4.Image = Properties.Resources._3_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 3)
            {
                pcb_carta4.Image = Properties.Resources._3_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 3)                    //3
            {
                pcb_carta4.Image = Properties.Resources._3_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 3)
            {
                pcb_carta4.Image = Properties.Resources._3_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 4)
            {
                pcb_carta4.Image = Properties.Resources._4_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 4)
            {
                pcb_carta4.Image = Properties.Resources._4_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 4)
            {                                                              //4
                pcb_carta4.Image = Properties.Resources._4_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 4)
            {
                pcb_carta4.Image = Properties.Resources._4_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 5)
            {
                pcb_carta4.Image = Properties.Resources._5_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 5)
            {
                pcb_carta4.Image = Properties.Resources._5_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 5)
            {                                                                     //5
                pcb_carta4.Image = Properties.Resources._5_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 5)
            {
                pcb_carta4.Image = Properties.Resources._5_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 6)
            {
                pcb_carta4.Image = Properties.Resources._6_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 6)
            {
                pcb_carta4.Image = Properties.Resources._6_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 6)
            {                                                                        //6
                pcb_carta4.Image = Properties.Resources._6_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 6)
            {
                pcb_carta4.Image = Properties.Resources._6_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 7)
            {
                pcb_carta4.Image = Properties.Resources._7_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 7)
            {
                pcb_carta4.Image = Properties.Resources._7_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 7)
            {                                                                            //7
                pcb_carta4.Image = Properties.Resources._7_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 7)
            {
                pcb_carta4.Image = Properties.Resources._7_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 8)
            {
                pcb_carta4.Image = Properties.Resources._8_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 8)
            {
                pcb_carta4.Image = Properties.Resources._8_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 8)
            {                                                                              //8
                pcb_carta4.Image = Properties.Resources._8_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 8)
            {
                pcb_carta4.Image = Properties.Resources._8_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 9)
            {
                pcb_carta4.Image = Properties.Resources._9_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 9)
            {
                pcb_carta4.Image = Properties.Resources._9_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 9)
            {                                                                             //9
                pcb_carta4.Image = Properties.Resources._9_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 9)
            {
                pcb_carta4.Image = Properties.Resources._9_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 10)
            {
                pcb_carta4.Image = Properties.Resources._10_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 10)
            {
                pcb_carta4.Image = Properties.Resources._10_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 10)
            {                                                                            //10
                pcb_carta4.Image = Properties.Resources._10_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 2)
            {
                pcb_carta4.Image = Properties.Resources.a_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 11)
            {
                pcb_carta4.Image = Properties.Resources.j_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 11)
            {
                pcb_carta4.Image = Properties.Resources.j_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 11)
            {                                                                            //J
                pcb_carta4.Image = Properties.Resources.J_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 11)
            {
                pcb_carta4.Image = Properties.Resources.j_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 12)
            {
                pcb_carta4.Image = Properties.Resources.q_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 12)
            {
                pcb_carta4.Image = Properties.Resources.q_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 12)
            {                                                                            //Q
                pcb_carta4.Image = Properties.Resources.q_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 12)
            {
                pcb_carta4.Image = Properties.Resources.q_pica;
            }
            else if (numeroPica4 == 0 && numeroValor4 == 13)
            {
                pcb_carta4.Image = Properties.Resources.k_corazon;
            }
            else if (numeroPica4 == 1 && numeroValor4 == 13)
            {
                pcb_carta4.Image = Properties.Resources.k_diamante;
            }
            else if (numeroPica4 == 2 && numeroValor4 == 13)
            {                                                                            //K
                pcb_carta4.Image = Properties.Resources.k_trebol;
            }
            else if (numeroPica4 == 3 && numeroValor4 == 13)
            {
                pcb_carta4.Image = Properties.Resources.k_pica;
            }
        }
        private void btn_pedirCarta_Click(object sender, EventArgs e)
        {   if (pcb_carta3.Image==null) {
                suma = 0;
                generarCarta3();
                asignarImagenes3();
                calculaAcumulado();
                calcularBj();
            } else if (pcb_carta3.Image!=null)
            {
                suma = 0;
                generarCarta4();
                asignarImagenes4();
                calculaAcumulado();
                calcularBj();
            }
            
            

            

        }
    }



    
}
