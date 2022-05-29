
namespace AppCajero
{
    partial class FormInterfazCajero
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
            this.BtnSalirBase = new System.Windows.Forms.Button();
            this.BtnCajero = new System.Windows.Forms.Button();
            this.BtnCuenta = new System.Windows.Forms.Button();
            this.BtnBanco = new System.Windows.Forms.Button();
            this.BtnVerCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInterfazOtros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalirBase
            // 
            this.BtnSalirBase.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSalirBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalirBase.Location = new System.Drawing.Point(621, 375);
            this.BtnSalirBase.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalirBase.Name = "BtnSalirBase";
            this.BtnSalirBase.Size = new System.Drawing.Size(166, 62);
            this.BtnSalirBase.TabIndex = 43;
            this.BtnSalirBase.Text = "Salir";
            this.BtnSalirBase.UseVisualStyleBackColor = false;
            this.BtnSalirBase.Click += new System.EventHandler(this.BtnSalirBase_Click);
            // 
            // BtnCajero
            // 
            this.BtnCajero.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCajero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCajero.Location = new System.Drawing.Point(4, 185);
            this.BtnCajero.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCajero.Name = "BtnCajero";
            this.BtnCajero.Size = new System.Drawing.Size(379, 65);
            this.BtnCajero.TabIndex = 41;
            this.BtnCajero.Text = "Cajero";
            this.BtnCajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCajero.UseVisualStyleBackColor = false;
            // 
            // BtnCuenta
            // 
            this.BtnCuenta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCuenta.Location = new System.Drawing.Point(429, 185);
            this.BtnCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCuenta.Name = "BtnCuenta";
            this.BtnCuenta.Size = new System.Drawing.Size(367, 65);
            this.BtnCuenta.TabIndex = 40;
            this.BtnCuenta.Text = "Cuenta";
            this.BtnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCuenta.UseVisualStyleBackColor = false;
            this.BtnCuenta.Click += new System.EventHandler(this.BtnCuenta_Click);
            // 
            // BtnBanco
            // 
            this.BtnBanco.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBanco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBanco.Location = new System.Drawing.Point(4, 91);
            this.BtnBanco.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBanco.Name = "BtnBanco";
            this.BtnBanco.Size = new System.Drawing.Size(379, 64);
            this.BtnBanco.TabIndex = 39;
            this.BtnBanco.Text = "Consultar Saldo $";
            this.BtnBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBanco.UseVisualStyleBackColor = false;
            // 
            // BtnVerCliente
            // 
            this.BtnVerCliente.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnVerCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVerCliente.Location = new System.Drawing.Point(429, 91);
            this.BtnVerCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVerCliente.Name = "BtnVerCliente";
            this.BtnVerCliente.Size = new System.Drawing.Size(367, 64);
            this.BtnVerCliente.TabIndex = 38;
            this.BtnVerCliente.Text = "Retirar Efectivo";
            this.BtnVerCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerCliente.UseVisualStyleBackColor = false;
            this.BtnVerCliente.Click += new System.EventHandler(this.BtnVerCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 37);
            this.label1.TabIndex = 44;
            this.label1.Text = "Seleccione el Tipo de Operacion";
            // 
            // BtnInterfazOtros
            // 
            this.BtnInterfazOtros.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnInterfazOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInterfazOtros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInterfazOtros.Location = new System.Drawing.Point(13, 285);
            this.BtnInterfazOtros.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInterfazOtros.Name = "BtnInterfazOtros";
            this.BtnInterfazOtros.Size = new System.Drawing.Size(164, 65);
            this.BtnInterfazOtros.TabIndex = 45;
            this.BtnInterfazOtros.Text = "Otros";
            this.BtnInterfazOtros.UseVisualStyleBackColor = false;
            this.BtnInterfazOtros.Click += new System.EventHandler(this.BtnInterfazOtros_Click);
            // 
            // FormInterfazCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInterfazOtros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalirBase);
            this.Controls.Add(this.BtnCajero);
            this.Controls.Add(this.BtnCuenta);
            this.Controls.Add(this.BtnBanco);
            this.Controls.Add(this.BtnVerCliente);
            this.Name = "FormInterfazCajero";
            this.Text = "FormInterfazCajero";
            this.Load += new System.EventHandler(this.FormInterfazCajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalirBase;
        private System.Windows.Forms.Button BtnCajero;
        private System.Windows.Forms.Button BtnCuenta;
        private System.Windows.Forms.Button BtnBanco;
        private System.Windows.Forms.Button BtnVerCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInterfazOtros;
    }
}