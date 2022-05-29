namespace AppCajero
{
    partial class FrmCajero
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumCuenta2 = new System.Windows.Forms.TextBox();
            this.txtNumBanco2 = new System.Windows.Forms.TextBox();
            this.txtCantidadEntregar = new System.Windows.Forms.TextBox();
            this.txtMontoMax = new System.Windows.Forms.TextBox();
            this.txtDenomMinima = new System.Windows.Forms.TextBox();
            this.BtnSiguienteCajero = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad del Billete a Entregar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Maximo a Entregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Denominacion minima a Entregar";
            // 
            // txtNumCuenta2
            // 
            this.txtNumCuenta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCuenta2.Location = new System.Drawing.Point(283, 32);
            this.txtNumCuenta2.Name = "txtNumCuenta2";
            this.txtNumCuenta2.Size = new System.Drawing.Size(289, 22);
            this.txtNumCuenta2.TabIndex = 5;
            // 
            // txtNumBanco2
            // 
            this.txtNumBanco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumBanco2.Location = new System.Drawing.Point(283, 78);
            this.txtNumBanco2.Name = "txtNumBanco2";
            this.txtNumBanco2.Size = new System.Drawing.Size(289, 22);
            this.txtNumBanco2.TabIndex = 6;
            // 
            // txtCantidadEntregar
            // 
            this.txtCantidadEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEntregar.Location = new System.Drawing.Point(283, 124);
            this.txtCantidadEntregar.Name = "txtCantidadEntregar";
            this.txtCantidadEntregar.Size = new System.Drawing.Size(289, 22);
            this.txtCantidadEntregar.TabIndex = 7;
            // 
            // txtMontoMax
            // 
            this.txtMontoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoMax.Location = new System.Drawing.Point(283, 185);
            this.txtMontoMax.Name = "txtMontoMax";
            this.txtMontoMax.Size = new System.Drawing.Size(289, 22);
            this.txtMontoMax.TabIndex = 8;
            // 
            // txtDenomMinima
            // 
            this.txtDenomMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenomMinima.Location = new System.Drawing.Point(283, 230);
            this.txtDenomMinima.Name = "txtDenomMinima";
            this.txtDenomMinima.Size = new System.Drawing.Size(289, 22);
            this.txtDenomMinima.TabIndex = 9;
            // 
            // BtnSiguienteCajero
            // 
            this.BtnSiguienteCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguienteCajero.Location = new System.Drawing.Point(473, 282);
            this.BtnSiguienteCajero.Name = "BtnSiguienteCajero";
            this.BtnSiguienteCajero.Size = new System.Drawing.Size(99, 33);
            this.BtnSiguienteCajero.TabIndex = 10;
            this.BtnSiguienteCajero.Text = "Siguiente";
            this.BtnSiguienteCajero.UseVisualStyleBackColor = true;
            this.BtnSiguienteCajero.Click += new System.EventHandler(this.BtnSiguienteCajero_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(122, 282);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 33);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 350);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSiguienteCajero);
            this.Controls.Add(this.txtDenomMinima);
            this.Controls.Add(this.txtMontoMax);
            this.Controls.Add(this.txtCantidadEntregar);
            this.Controls.Add(this.txtNumBanco2);
            this.Controls.Add(this.txtNumCuenta2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCajero";
            this.Text = "FrmCajero";
            this.Load += new System.EventHandler(this.FrmCajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumCuenta2;
        private System.Windows.Forms.TextBox txtNumBanco2;
        private System.Windows.Forms.TextBox txtCantidadEntregar;
        private System.Windows.Forms.TextBox txtMontoMax;
        private System.Windows.Forms.TextBox txtDenomMinima;
        private System.Windows.Forms.Button BtnSiguienteCajero;
        private System.Windows.Forms.Button BtnCancelar;
    }
}