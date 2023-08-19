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
    public partial class Nombres : Form
    {
        public Nombres()
        {
            InitializeComponent();
        }

        int contador = 0;


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            lst_lista.Items.Add(txt_patente.Text + " "  + txt_nombre.Text + " " + txt_apellido.Text);   
            txt_apellido.Clear();
            txt_nombre.Clear(); 
            txt_patente.Clear();
            contador = contador + 1;
            txt_registros.Text = contador.ToString();
            MessageBox.Show("Registro Guardado");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_patente.Clear();    
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            Resultado = MessageBox.Show("Estas seguro de eliminar?", "Aviso importante!", MessageBoxButtons.YesNo);

        if (Resultado == DialogResult.Yes) {
                lst_lista.Items.Remove(lst_lista.SelectedItem);
                contador = contador - 1;
                txt_registros.Text = contador.ToString();
                MessageBox.Show("Registro Eliminado");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
