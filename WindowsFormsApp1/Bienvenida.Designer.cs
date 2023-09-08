namespace WindowsFormsApp1
{
    partial class Bienvenida
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
            this.lbl_bienvenidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_bienvenidos
            // 
            this.lbl_bienvenidos.AutoSize = true;
            this.lbl_bienvenidos.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenidos.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_bienvenidos.Location = new System.Drawing.Point(459, 269);
            this.lbl_bienvenidos.Name = "lbl_bienvenidos";
            this.lbl_bienvenidos.Size = new System.Drawing.Size(544, 55);
            this.lbl_bienvenidos.TabIndex = 0;
            this.lbl_bienvenidos.Text = "BIENVENIDO AL CASINO";
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.lbl_bienvenidos);
            this.Name = "Bienvenida";
            this.Size = new System.Drawing.Size(1525, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_bienvenidos;
    }
}
