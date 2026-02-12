namespace WindowsFormsApp1
{
    partial class subebaja
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
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_pica = new System.Windows.Forms.TextBox();
            this.cb_subebaja = new System.Windows.Forms.ComboBox();
            this.label_pozo = new System.Windows.Forms.Label();
            this.txt_pozo = new System.Windows.Forms.TextBox();
            this.lbl_creditos = new System.Windows.Forms.Label();
            this.txt_creditos = new System.Windows.Forms.TextBox();
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.txt_pica2 = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_multiplicador = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_recarga = new System.Windows.Forms.Button();
            this.pb_carta1 = new System.Windows.Forms.PictureBox();
            this.pb_carta2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_carta2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(557, 656);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(155, 29);
            this.txt_valor.TabIndex = 13;
            this.txt_valor.Visible = false;
            // 
            // txt_pica
            // 
            this.txt_pica.Location = new System.Drawing.Point(756, 656);
            this.txt_pica.Name = "txt_pica";
            this.txt_pica.Size = new System.Drawing.Size(188, 29);
            this.txt_pica.TabIndex = 14;
            this.txt_pica.Visible = false;
            // 
            // cb_subebaja
            // 
            this.cb_subebaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.cb_subebaja.Enabled = false;
            this.cb_subebaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_subebaja.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_subebaja.ForeColor = System.Drawing.Color.White;
            this.cb_subebaja.FormattingEnabled = true;
            this.cb_subebaja.Items.AddRange(new object[] {
            "Sube",
            "Baja",
            "Iguala"});
            this.cb_subebaja.Location = new System.Drawing.Point(565, 427);
            this.cb_subebaja.Name = "cb_subebaja";
            this.cb_subebaja.Size = new System.Drawing.Size(162, 35);
            this.cb_subebaja.TabIndex = 15;
            // 
            // label_pozo
            // 
            this.label_pozo.AutoSize = true;
            this.label_pozo.ForeColor = System.Drawing.Color.White;
            this.label_pozo.Location = new System.Drawing.Point(616, 13);
            this.label_pozo.Name = "label_pozo";
            this.label_pozo.Size = new System.Drawing.Size(50, 22);
            this.label_pozo.TabIndex = 18;
            this.label_pozo.Text = "Pozo";
            // 
            // txt_pozo
            // 
            this.txt_pozo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.txt_pozo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pozo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pozo.ForeColor = System.Drawing.Color.Yellow;
            this.txt_pozo.Location = new System.Drawing.Point(524, 43);
            this.txt_pozo.Name = "txt_pozo";
            this.txt_pozo.ReadOnly = true;
            this.txt_pozo.Size = new System.Drawing.Size(237, 36);
            this.txt_pozo.TabIndex = 17;
            this.txt_pozo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_creditos
            // 
            this.lbl_creditos.AutoSize = true;
            this.lbl_creditos.ForeColor = System.Drawing.Color.White;
            this.lbl_creditos.Location = new System.Drawing.Point(584, 518);
            this.lbl_creditos.Name = "lbl_creditos";
            this.lbl_creditos.Size = new System.Drawing.Size(90, 22);
            this.lbl_creditos.TabIndex = 21;
            this.lbl_creditos.Text = "Creditos";
            // 
            // txt_creditos
            // 
            this.txt_creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.txt_creditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_creditos.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_creditos.ForeColor = System.Drawing.Color.Yellow;
            this.txt_creditos.Location = new System.Drawing.Point(518, 548);
            this.txt_creditos.Name = "txt_creditos";
            this.txt_creditos.ReadOnly = true;
            this.txt_creditos.Size = new System.Drawing.Size(243, 32);
            this.txt_creditos.TabIndex = 19;
            this.txt_creditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_valor2
            // 
            this.txt_valor2.Location = new System.Drawing.Point(212, 320);
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(126, 29);
            this.txt_valor2.TabIndex = 23;
            this.txt_valor2.Visible = false;
            // 
            // txt_pica2
            // 
            this.txt_pica2.Location = new System.Drawing.Point(212, 385);
            this.txt_pica2.Name = "txt_pica2";
            this.txt_pica2.Size = new System.Drawing.Size(126, 29);
            this.txt_pica2.TabIndex = 24;
            this.txt_pica2.Visible = false;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_estado.Location = new System.Drawing.Point(571, 365);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(0, 43);
            this.lbl_estado.TabIndex = 25;
            // 
            // lbl_multiplicador
            // 
            this.lbl_multiplicador.AutoSize = true;
            this.lbl_multiplicador.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multiplicador.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_multiplicador.Location = new System.Drawing.Point(767, 39);
            this.lbl_multiplicador.Name = "lbl_multiplicador";
            this.lbl_multiplicador.Size = new System.Drawing.Size(35, 38);
            this.lbl_multiplicador.TabIndex = 27;
            this.lbl_multiplicador.Text = "x";
            this.lbl_multiplicador.Visible = false;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_generar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generar.FlatAppearance.BorderSize = 0;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.ForeColor = System.Drawing.Color.White;
            this.btn_generar.Image = global::WindowsFormsApp1.Properties.Resources.carta_nueva;
            this.btn_generar.Location = new System.Drawing.Point(1112, 497);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(97, 115);
            this.btn_generar.TabIndex = 12;
            this.btn_generar.Text = "$100";
            this.btn_generar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_retirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_retirar.Enabled = false;
            this.btn_retirar.FlatAppearance.BorderSize = 0;
            this.btn_retirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retirar.Image = global::WindowsFormsApp1.Properties.Resources.retirar;
            this.btn_retirar.Location = new System.Drawing.Point(823, 23);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(93, 80);
            this.btn_retirar.TabIndex = 28;
            this.btn_retirar.UseVisualStyleBackColor = false;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.ForeColor = System.Drawing.Color.Black;
            this.btn_volver.Image = global::WindowsFormsApp1.Properties.Resources.volver;
            this.btn_volver.Location = new System.Drawing.Point(1217, 539);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(65, 73);
            this.btn_volver.TabIndex = 26;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_recarga
            // 
            this.btn_recarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_recarga.FlatAppearance.BorderSize = 0;
            this.btn_recarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recarga.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_recarga.Image = global::WindowsFormsApp1.Properties.Resources.recarga_express;
            this.btn_recarga.Location = new System.Drawing.Point(458, 539);
            this.btn_recarga.Name = "btn_recarga";
            this.btn_recarga.Size = new System.Drawing.Size(54, 51);
            this.btn_recarga.TabIndex = 20;
            this.btn_recarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recarga.UseVisualStyleBackColor = false;
            this.btn_recarga.Click += new System.EventHandler(this.btn_recarga_Click);
            // 
            // pb_carta1
            // 
            this.pb_carta1.Location = new System.Drawing.Point(564, 134);
            this.pb_carta1.Margin = new System.Windows.Forms.Padding(4);
            this.pb_carta1.Name = "pb_carta1";
            this.pb_carta1.Size = new System.Drawing.Size(163, 251);
            this.pb_carta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_carta1.TabIndex = 11;
            this.pb_carta1.TabStop = false;
            // 
            // pb_carta2
            // 
            this.pb_carta2.Location = new System.Drawing.Point(310, 40);
            this.pb_carta2.Margin = new System.Windows.Forms.Padding(4);
            this.pb_carta2.Name = "pb_carta2";
            this.pb_carta2.Size = new System.Drawing.Size(163, 251);
            this.pb_carta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_carta2.TabIndex = 16;
            this.pb_carta2.TabStop = false;
            // 
            // subebaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.lbl_multiplicador);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_pica2);
            this.Controls.Add(this.txt_valor2);
            this.Controls.Add(this.lbl_creditos);
            this.Controls.Add(this.btn_recarga);
            this.Controls.Add(this.txt_creditos);
            this.Controls.Add(this.label_pozo);
            this.Controls.Add(this.txt_pozo);
            this.Controls.Add(this.pb_carta1);
            this.Controls.Add(this.pb_carta2);
            this.Controls.Add(this.cb_subebaja);
            this.Controls.Add(this.txt_pica);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.btn_generar);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "subebaja";
            this.Size = new System.Drawing.Size(1394, 702);
            this.Load += new System.EventHandler(this.subebaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_carta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_carta1;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_pica;
        private System.Windows.Forms.ComboBox cb_subebaja;
        private System.Windows.Forms.PictureBox pb_carta2;
        private System.Windows.Forms.Label label_pozo;
        private System.Windows.Forms.TextBox txt_pozo;
        private System.Windows.Forms.Label lbl_creditos;
        private System.Windows.Forms.Button btn_recarga;
        private System.Windows.Forms.TextBox txt_creditos;
        private System.Windows.Forms.TextBox txt_valor2;
        private System.Windows.Forms.TextBox txt_pica2;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_multiplicador;
        private System.Windows.Forms.Button btn_retirar;
    }
}
