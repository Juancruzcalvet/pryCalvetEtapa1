namespace pryCalvetEtapa1
{
    partial class frmFirma
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctDibujo = new System.Windows.Forms.PictureBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDibujo
            // 
            this.pctDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctDibujo.Location = new System.Drawing.Point(12, 12);
            this.pctDibujo.Name = "pctDibujo";
            this.pctDibujo.Size = new System.Drawing.Size(237, 195);
            this.pctDibujo.TabIndex = 0;
            this.pctDibujo.TabStop = false;
            this.pctDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctDibujo_MouseDown);
            this.pctDibujo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctDibujo_MouseMove);
            this.pctDibujo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctDibujo_MouseUp);
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(12, 213);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(75, 23);
            this.btnDibujar.TabIndex = 1;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(174, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.pctDibujo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de firmas";
            ((System.ComponentModel.ISupportInitialize)(this.pctDibujo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDibujo;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

