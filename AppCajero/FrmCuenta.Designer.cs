namespace AppCajero
{
    partial class FrmCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNumCuenta = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.BtnSiguienteCuenta = new System.Windows.Forms.Button();
            this.BtnCancelarCuenta = new System.Windows.Forms.Button();
            this.LblNumeroCuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNumCuenta
            // 
            this.LblNumCuenta.AutoSize = true;
            this.LblNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumCuenta.Location = new System.Drawing.Point(26, 104);
            this.LblNumCuenta.Name = "LblNumCuenta";
            this.LblNumCuenta.Size = new System.Drawing.Size(120, 16);
            this.LblNumCuenta.TabIndex = 0;
            this.LblNumCuenta.Text = "Numero de Cuenta";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(26, 149);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(43, 16);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(179, 145);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(285, 22);
            this.txtClave.TabIndex = 6;
            // 
            // BtnSiguienteCuenta
            // 
            this.BtnSiguienteCuenta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSiguienteCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguienteCuenta.Location = new System.Drawing.Point(75, 274);
            this.BtnSiguienteCuenta.Name = "BtnSiguienteCuenta";
            this.BtnSiguienteCuenta.Size = new System.Drawing.Size(95, 40);
            this.BtnSiguienteCuenta.TabIndex = 10;
            this.BtnSiguienteCuenta.Text = "Aceptar";
            this.BtnSiguienteCuenta.UseVisualStyleBackColor = true;
            this.BtnSiguienteCuenta.Click += new System.EventHandler(this.BtnSiguienteCuenta_Click);
            // 
            // BtnCancelarCuenta
            // 
            this.BtnCancelarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCuenta.Location = new System.Drawing.Point(369, 274);
            this.BtnCancelarCuenta.Name = "BtnCancelarCuenta";
            this.BtnCancelarCuenta.Size = new System.Drawing.Size(95, 40);
            this.BtnCancelarCuenta.TabIndex = 11;
            this.BtnCancelarCuenta.Text = "Cancelar";
            this.BtnCancelarCuenta.UseVisualStyleBackColor = true;
            this.BtnCancelarCuenta.Click += new System.EventHandler(this.BtnCancelarCuenta_Click);
            // 
            // LblNumeroCuenta
            // 
            this.LblNumeroCuenta.AutoSize = true;
            this.LblNumeroCuenta.BackColor = System.Drawing.Color.Black;
            this.LblNumeroCuenta.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroCuenta.ForeColor = System.Drawing.Color.White;
            this.LblNumeroCuenta.Location = new System.Drawing.Point(224, 101);
            this.LblNumeroCuenta.Name = "LblNumeroCuenta";
            this.LblNumeroCuenta.Size = new System.Drawing.Size(17, 24);
            this.LblNumeroCuenta.TabIndex = 14;
            this.LblNumeroCuenta.Text = "0";
            // 
            // FrmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 367);
            this.Controls.Add(this.LblNumeroCuenta);
            this.Controls.Add(this.BtnCancelarCuenta);
            this.Controls.Add(this.BtnSiguienteCuenta);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblNumCuenta);
            this.Name = "FrmCuenta";
            this.Text = "FrmCuenta";
            this.Load += new System.EventHandler(this.FrmCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumCuenta;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button BtnSiguienteCuenta;
        private System.Windows.Forms.Button BtnCancelarCuenta;
        private System.Windows.Forms.Label LblNumeroCuenta;
    }
}