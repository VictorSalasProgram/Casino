namespace WindowsFormsApp1
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_pica = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.pnl_acciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Aapuesta = new System.Windows.Forms.Button();
            this.btn_apuestaC = new System.Windows.Forms.Button();
            this.btn_allin = new System.Windows.Forms.Button();
            this.btn_pedirCarta = new System.Windows.Forms.Button();
            this.btn_quedarse = new System.Windows.Forms.Button();
            this.btn_irte = new System.Windows.Forms.Button();
            this.txt_creditos = new System.Windows.Forms.TextBox();
            this.lbl_creditos = new System.Windows.Forms.Label();
            this.txt_pozo = new System.Windows.Forms.TextBox();
            this.lbl_pica = new System.Windows.Forms.Label();
            this.txt_acumulado = new System.Windows.Forms.TextBox();
            this.lbl_acumulado = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pcb_carta1 = new System.Windows.Forms.PictureBox();
            this.pcb_carta2 = new System.Windows.Forms.PictureBox();
            this.pcb_carta3 = new System.Windows.Forms.PictureBox();
            this.pcb_carta4 = new System.Windows.Forms.PictureBox();
            this.label_pozo = new System.Windows.Forms.Label();
            this.btn_recarga = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.pnl_acciones.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(917, 678);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(64, 34);
            this.txt_numero.TabIndex = 0;
            this.txt_numero.Visible = false;
            // 
            // txt_pica
            // 
            this.txt_pica.Location = new System.Drawing.Point(1047, 678);
            this.txt_pica.Name = "txt_pica";
            this.txt_pica.ReadOnly = true;
            this.txt_pica.Size = new System.Drawing.Size(194, 34);
            this.txt_pica.TabIndex = 2;
            this.txt_pica.Visible = false;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(907, 640);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(77, 27);
            this.lbl_valor.TabIndex = 3;
            this.lbl_valor.Text = "Valor";
            this.lbl_valor.Visible = false;
            // 
            // pnl_acciones
            // 
            this.pnl_acciones.Controls.Add(this.btn_Aapuesta);
            this.pnl_acciones.Controls.Add(this.btn_apuestaC);
            this.pnl_acciones.Controls.Add(this.btn_allin);
            this.pnl_acciones.Controls.Add(this.btn_pedirCarta);
            this.pnl_acciones.Controls.Add(this.btn_quedarse);
            this.pnl_acciones.Controls.Add(this.btn_irte);
            this.pnl_acciones.Enabled = false;
            this.pnl_acciones.Location = new System.Drawing.Point(310, 496);
            this.pnl_acciones.Name = "pnl_acciones";
            this.pnl_acciones.Size = new System.Drawing.Size(801, 120);
            this.pnl_acciones.TabIndex = 5;
            // 
            // btn_Aapuesta
            // 
            this.btn_Aapuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_Aapuesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Aapuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aapuesta.FlatAppearance.BorderSize = 0;
            this.btn_Aapuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aapuesta.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Aapuesta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Aapuesta.Image")));
            this.btn_Aapuesta.Location = new System.Drawing.Point(3, 3);
            this.btn_Aapuesta.Name = "btn_Aapuesta";
            this.btn_Aapuesta.Size = new System.Drawing.Size(112, 110);
            this.btn_Aapuesta.TabIndex = 0;
            this.btn_Aapuesta.Text = "100";
            this.btn_Aapuesta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aapuesta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Aapuesta.UseVisualStyleBackColor = false;
            this.btn_Aapuesta.Click += new System.EventHandler(this.btn_Aapuesta_Click);
            // 
            // btn_apuestaC
            // 
            this.btn_apuestaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_apuestaC.FlatAppearance.BorderSize = 0;
            this.btn_apuestaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apuestaC.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_apuestaC.Image = global::WindowsFormsApp1.Properties.Resources.moneda1;
            this.btn_apuestaC.Location = new System.Drawing.Point(121, 3);
            this.btn_apuestaC.Name = "btn_apuestaC";
            this.btn_apuestaC.Size = new System.Drawing.Size(115, 110);
            this.btn_apuestaC.TabIndex = 4;
            this.btn_apuestaC.Text = "50";
            this.btn_apuestaC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_apuestaC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_apuestaC.UseVisualStyleBackColor = false;
            this.btn_apuestaC.Click += new System.EventHandler(this.btn_apuestaC_Click);
            // 
            // btn_allin
            // 
            this.btn_allin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_allin.FlatAppearance.BorderSize = 0;
            this.btn_allin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_allin.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_allin.Image = global::WindowsFormsApp1.Properties.Resources.all_in;
            this.btn_allin.Location = new System.Drawing.Point(242, 3);
            this.btn_allin.Name = "btn_allin";
            this.btn_allin.Size = new System.Drawing.Size(120, 110);
            this.btn_allin.TabIndex = 2;
            this.btn_allin.Text = "All In";
            this.btn_allin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_allin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_allin.UseVisualStyleBackColor = false;
            this.btn_allin.Click += new System.EventHandler(this.btn_allin_Click);
            // 
            // btn_pedirCarta
            // 
            this.btn_pedirCarta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_pedirCarta.FlatAppearance.BorderSize = 0;
            this.btn_pedirCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedirCarta.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_pedirCarta.Image = global::WindowsFormsApp1.Properties.Resources.otra_carta;
            this.btn_pedirCarta.Location = new System.Drawing.Point(368, 3);
            this.btn_pedirCarta.Name = "btn_pedirCarta";
            this.btn_pedirCarta.Size = new System.Drawing.Size(129, 110);
            this.btn_pedirCarta.TabIndex = 1;
            this.btn_pedirCarta.Text = "+Carta";
            this.btn_pedirCarta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pedirCarta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pedirCarta.UseVisualStyleBackColor = false;
            this.btn_pedirCarta.Click += new System.EventHandler(this.btn_pedirCarta_Click);
            // 
            // btn_quedarse
            // 
            this.btn_quedarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_quedarse.FlatAppearance.BorderSize = 0;
            this.btn_quedarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quedarse.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_quedarse.Image = global::WindowsFormsApp1.Properties.Resources.quedarse;
            this.btn_quedarse.Location = new System.Drawing.Point(503, 3);
            this.btn_quedarse.Name = "btn_quedarse";
            this.btn_quedarse.Size = new System.Drawing.Size(125, 110);
            this.btn_quedarse.TabIndex = 5;
            this.btn_quedarse.Text = "Quedarse";
            this.btn_quedarse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_quedarse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_quedarse.UseVisualStyleBackColor = false;
            // 
            // btn_irte
            // 
            this.btn_irte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_irte.FlatAppearance.BorderSize = 0;
            this.btn_irte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_irte.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_irte.Image = global::WindowsFormsApp1.Properties.Resources.irte;
            this.btn_irte.Location = new System.Drawing.Point(634, 3);
            this.btn_irte.Name = "btn_irte";
            this.btn_irte.Size = new System.Drawing.Size(125, 110);
            this.btn_irte.TabIndex = 3;
            this.btn_irte.Text = "Irte";
            this.btn_irte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_irte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_irte.UseVisualStyleBackColor = false;
            this.btn_irte.Click += new System.EventHandler(this.btn_irte_Click);
            // 
            // txt_creditos
            // 
            this.txt_creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.txt_creditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_creditos.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_creditos.ForeColor = System.Drawing.Color.Yellow;
            this.txt_creditos.Location = new System.Drawing.Point(577, 649);
            this.txt_creditos.Name = "txt_creditos";
            this.txt_creditos.ReadOnly = true;
            this.txt_creditos.Size = new System.Drawing.Size(246, 32);
            this.txt_creditos.TabIndex = 6;
            this.txt_creditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_creditos
            // 
            this.lbl_creditos.AutoSize = true;
            this.lbl_creditos.Location = new System.Drawing.Point(643, 619);
            this.lbl_creditos.Name = "lbl_creditos";
            this.lbl_creditos.Size = new System.Drawing.Size(116, 27);
            this.lbl_creditos.TabIndex = 7;
            this.lbl_creditos.Text = "Creditos";
            // 
            // txt_pozo
            // 
            this.txt_pozo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.txt_pozo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pozo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pozo.ForeColor = System.Drawing.Color.Yellow;
            this.txt_pozo.Location = new System.Drawing.Point(640, 53);
            this.txt_pozo.Name = "txt_pozo";
            this.txt_pozo.ReadOnly = true;
            this.txt_pozo.Size = new System.Drawing.Size(240, 36);
            this.txt_pozo.TabIndex = 8;
            this.txt_pozo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_pica
            // 
            this.lbl_pica.AutoSize = true;
            this.lbl_pica.Location = new System.Drawing.Point(1028, 640);
            this.lbl_pica.Name = "lbl_pica";
            this.lbl_pica.Size = new System.Drawing.Size(64, 27);
            this.lbl_pica.TabIndex = 4;
            this.lbl_pica.Text = "Pica";
            this.lbl_pica.Visible = false;
            // 
            // txt_acumulado
            // 
            this.txt_acumulado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.txt_acumulado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_acumulado.ForeColor = System.Drawing.Color.Yellow;
            this.txt_acumulado.Location = new System.Drawing.Point(1180, 454);
            this.txt_acumulado.Name = "txt_acumulado";
            this.txt_acumulado.Size = new System.Drawing.Size(61, 27);
            this.txt_acumulado.TabIndex = 12;
            // 
            // lbl_acumulado
            // 
            this.lbl_acumulado.AutoSize = true;
            this.lbl_acumulado.Location = new System.Drawing.Point(1175, 424);
            this.lbl_acumulado.Name = "lbl_acumulado";
            this.lbl_acumulado.Size = new System.Drawing.Size(64, 27);
            this.lbl_acumulado.TabIndex = 13;
            this.lbl_acumulado.Text = "Suma";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pcb_carta1);
            this.flowLayoutPanel1.Controls.Add(this.pcb_carta2);
            this.flowLayoutPanel1.Controls.Add(this.pcb_carta3);
            this.flowLayoutPanel1.Controls.Add(this.pcb_carta4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(431, 298);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(591, 192);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // pcb_carta1
            // 
            this.pcb_carta1.Location = new System.Drawing.Point(3, 3);
            this.pcb_carta1.Name = "pcb_carta1";
            this.pcb_carta1.Size = new System.Drawing.Size(130, 182);
            this.pcb_carta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_carta1.TabIndex = 10;
            this.pcb_carta1.TabStop = false;
            // 
            // pcb_carta2
            // 
            this.pcb_carta2.Location = new System.Drawing.Point(139, 3);
            this.pcb_carta2.Name = "pcb_carta2";
            this.pcb_carta2.Size = new System.Drawing.Size(130, 182);
            this.pcb_carta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_carta2.TabIndex = 11;
            this.pcb_carta2.TabStop = false;
            // 
            // pcb_carta3
            // 
            this.pcb_carta3.Location = new System.Drawing.Point(275, 3);
            this.pcb_carta3.Name = "pcb_carta3";
            this.pcb_carta3.Size = new System.Drawing.Size(130, 182);
            this.pcb_carta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_carta3.TabIndex = 12;
            this.pcb_carta3.TabStop = false;
            // 
            // pcb_carta4
            // 
            this.pcb_carta4.Location = new System.Drawing.Point(411, 3);
            this.pcb_carta4.Name = "pcb_carta4";
            this.pcb_carta4.Size = new System.Drawing.Size(130, 182);
            this.pcb_carta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_carta4.TabIndex = 13;
            this.pcb_carta4.TabStop = false;
            // 
            // label_pozo
            // 
            this.label_pozo.AutoSize = true;
            this.label_pozo.ForeColor = System.Drawing.Color.White;
            this.label_pozo.Location = new System.Drawing.Point(734, 2);
            this.label_pozo.Name = "label_pozo";
            this.label_pozo.Size = new System.Drawing.Size(64, 27);
            this.label_pozo.TabIndex = 15;
            this.label_pozo.Text = "Pozo";
            // 
            // btn_recarga
            // 
            this.btn_recarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_recarga.FlatAppearance.BorderSize = 0;
            this.btn_recarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recarga.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_recarga.Image = global::WindowsFormsApp1.Properties.Resources.recarga_express;
            this.btn_recarga.Location = new System.Drawing.Point(517, 640);
            this.btn_recarga.Name = "btn_recarga";
            this.btn_recarga.Size = new System.Drawing.Size(57, 51);
            this.btn_recarga.TabIndex = 7;
            this.btn_recarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recarga.UseVisualStyleBackColor = false;
            this.btn_recarga.Click += new System.EventHandler(this.btn_recarga_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_generar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pedir_carta;
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.ForeColor = System.Drawing.Color.Black;
            this.btn_generar.Location = new System.Drawing.Point(1142, 512);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(133, 97);
            this.btn_generar.TabIndex = 1;
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.label_pozo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_acumulado);
            this.Controls.Add(this.txt_acumulado);
            this.Controls.Add(this.txt_pozo);
            this.Controls.Add(this.lbl_creditos);
            this.Controls.Add(this.btn_recarga);
            this.Controls.Add(this.txt_creditos);
            this.Controls.Add(this.pnl_acciones);
            this.Controls.Add(this.lbl_pica);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_pica);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_numero);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1296, 757);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.pnl_acciones.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carta4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_pica;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.FlowLayoutPanel pnl_acciones;
        private System.Windows.Forms.Button btn_Aapuesta;
        private System.Windows.Forms.Button btn_pedirCarta;
        private System.Windows.Forms.Button btn_allin;
        private System.Windows.Forms.Button btn_irte;
        private System.Windows.Forms.TextBox txt_creditos;
        private System.Windows.Forms.Label lbl_creditos;
        private System.Windows.Forms.TextBox txt_pozo;
        private System.Windows.Forms.Button btn_apuestaC;
        private System.Windows.Forms.Button btn_quedarse;
        private System.Windows.Forms.Label lbl_pica;
        private System.Windows.Forms.PictureBox pcb_carta2;
        private System.Windows.Forms.TextBox txt_acumulado;
        private System.Windows.Forms.Label lbl_acumulado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_pozo;
        private System.Windows.Forms.Button btn_recarga;
        private System.Windows.Forms.PictureBox pcb_carta3;
        private System.Windows.Forms.PictureBox pcb_carta4;
        public System.Windows.Forms.PictureBox pcb_carta1;
    }
}
