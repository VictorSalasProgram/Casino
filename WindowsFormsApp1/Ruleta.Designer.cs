namespace WindowsFormsApp1
{
    partial class Ruleta
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_creditos = new System.Windows.Forms.Label();
            this.txt_creditos = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_recarga = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_girar = new System.Windows.Forms.Button();
            this.cmb_numero = new System.Windows.Forms.ComboBox();
            this.btn_apostar = new System.Windows.Forms.Button();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.btn_cambiar_apuesta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Gold;
            this.lbl_titulo.Location = new System.Drawing.Point(989, 19);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(147, 38);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "RULETA";
            // 
            // lbl_creditos
            // 
            this.lbl_creditos.AutoSize = true;
            this.lbl_creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_creditos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_creditos.Location = new System.Drawing.Point(994, 767);
            this.lbl_creditos.Name = "lbl_creditos";
            this.lbl_creditos.Size = new System.Drawing.Size(120, 32);
            this.lbl_creditos.TabIndex = 10;
            this.lbl_creditos.Text = "Creditos";
            // 
            // txt_creditos
            // 
            this.txt_creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.txt_creditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_creditos.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_creditos.ForeColor = System.Drawing.Color.Yellow;
            this.txt_creditos.Location = new System.Drawing.Point(928, 797);
            this.txt_creditos.Name = "txt_creditos";
            this.txt_creditos.ReadOnly = true;
            this.txt_creditos.Size = new System.Drawing.Size(246, 32);
            this.txt_creditos.TabIndex = 8;
            this.txt_creditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Captura_de_pantalla_2026_02_11_214604;
            this.pictureBox2.Location = new System.Drawing.Point(873, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 297);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btn_recarga
            // 
            this.btn_recarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(60)))));
            this.btn_recarga.FlatAppearance.BorderSize = 0;
            this.btn_recarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recarga.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_recarga.Image = global::WindowsFormsApp1.Properties.Resources.recarga_express;
            this.btn_recarga.Location = new System.Drawing.Point(868, 788);
            this.btn_recarga.Name = "btn_recarga";
            this.btn_recarga.Size = new System.Drawing.Size(57, 51);
            this.btn_recarga.TabIndex = 9;
            this.btn_recarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recarga.UseVisualStyleBackColor = false;
            this.btn_recarga.Click += new System.EventHandler(this.btn_recarga_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Captura_de_pantalla_2026_02_11_212316;
            this.pictureBox1.Location = new System.Drawing.Point(615, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_resultado.Location = new System.Drawing.Point(1723, 118);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 43);
            this.lbl_resultado.TabIndex = 12;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(1642, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "GANADOR";
            // 
            // btn_girar
            // 
            this.btn_girar.BackColor = System.Drawing.Color.Black;
            this.btn_girar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_girar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_girar.Location = new System.Drawing.Point(1666, 797);
            this.btn_girar.Name = "btn_girar";
            this.btn_girar.Size = new System.Drawing.Size(217, 54);
            this.btn_girar.TabIndex = 14;
            this.btn_girar.Text = "GIRAR";
            this.btn_girar.UseVisualStyleBackColor = false;
            this.btn_girar.Click += new System.EventHandler(this.btn_girar_Click);
            // 
            // cmb_numero
            // 
            this.cmb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_numero.FormattingEnabled = true;
            this.cmb_numero.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.cmb_numero.Location = new System.Drawing.Point(1731, 605);
            this.cmb_numero.Name = "cmb_numero";
            this.cmb_numero.Size = new System.Drawing.Size(121, 37);
            this.cmb_numero.TabIndex = 15;
            this.cmb_numero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_apostar
            // 
            this.btn_apostar.BackColor = System.Drawing.Color.Black;
            this.btn_apostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apostar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_apostar.Location = new System.Drawing.Point(1598, 726);
            this.btn_apostar.Name = "btn_apostar";
            this.btn_apostar.Size = new System.Drawing.Size(171, 54);
            this.btn_apostar.TabIndex = 16;
            this.btn_apostar.Text = "APOSTAR";
            this.btn_apostar.UseVisualStyleBackColor = false;
            this.btn_apostar.Click += new System.EventHandler(this.btn_apostar_Click);
            // 
            // cmb_color
            // 
            this.cmb_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.cmb_color.Location = new System.Drawing.Point(1731, 662);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(121, 37);
            this.cmb_color.TabIndex = 17;
            // 
            // btn_cambiar_apuesta
            // 
            this.btn_cambiar_apuesta.BackColor = System.Drawing.Color.Black;
            this.btn_cambiar_apuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiar_apuesta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cambiar_apuesta.Location = new System.Drawing.Point(1785, 726);
            this.btn_cambiar_apuesta.Name = "btn_cambiar_apuesta";
            this.btn_cambiar_apuesta.Size = new System.Drawing.Size(172, 54);
            this.btn_cambiar_apuesta.TabIndex = 18;
            this.btn_cambiar_apuesta.Text = "CAMBIAR APUESTA";
            this.btn_cambiar_apuesta.UseVisualStyleBackColor = false;
            this.btn_cambiar_apuesta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ruleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.btn_cambiar_apuesta);
            this.Controls.Add(this.cmb_color);
            this.Controls.Add(this.btn_apostar);
            this.Controls.Add(this.cmb_numero);
            this.Controls.Add(this.btn_girar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_creditos);
            this.Controls.Add(this.btn_recarga);
            this.Controls.Add(this.txt_creditos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Ruleta";
            this.Size = new System.Drawing.Size(1972, 879);
            this.Load += new System.EventHandler(this.Ruleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_creditos;
        private System.Windows.Forms.Button btn_recarga;
        private System.Windows.Forms.TextBox txt_creditos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_girar;
        private System.Windows.Forms.ComboBox cmb_numero;
        private System.Windows.Forms.Button btn_apostar;
        private System.Windows.Forms.ComboBox cmb_color;
        private System.Windows.Forms.Button btn_cambiar_apuesta;
    }
}
