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
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();

        }

        private void btn_regristros_Click(object sender, EventArgs e)
        {
            Ctl_Registros Control = new Ctl_Registros();
            pnl_principal.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            pnl_principal.Controls.Add(Control);

        }

        private void btn_numeroA_Click(object sender, EventArgs e)
        {
            UserControl1 Control = new UserControl1();
            pnl_principal.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            pnl_principal.Controls.Add(Control);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
           
            subebaja Control = new subebaja();
            pnl_principal.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            pnl_principal.Controls.Add(Control);

        }

        private void pnl_principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nicio_Click(object sender, EventArgs e)
        {
            Bienvenida Control = new Bienvenida();  
            pnl_principal.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            pnl_principal.Controls.Add(Control);
        }
    }
}
