namespace AppCajero
{
    partial class FrmBanco
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
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.txtNumeroBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSiguienteBanco = new System.Windows.Forms.Button();
            this.BtnSalirBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBanco.Location = new System.Drawing.Point(157, 64);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(198, 22);
            this.txtNombreBanco.TabIndex = 0;
            // 
            // txtNumeroBanco
            // 
            this.txtNumeroBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroBanco.Location = new System.Drawing.Point(157, 117);
            this.txtNumeroBanco.Name = "txtNumeroBanco";
            this.txtNumeroBanco.Size = new System.Drawing.Size(198, 22);
            this.txtNumeroBanco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero del Banco";
            // 
            // BtnSiguienteBanco
            // 
            this.BtnSiguienteBanco.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSiguienteBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguienteBanco.Location = new System.Drawing.Point(46, 172);
            this.BtnSiguienteBanco.Name = "BtnSiguienteBanco";
            this.BtnSiguienteBanco.Size = new System.Drawing.Size(78, 31);
            this.BtnSiguienteBanco.TabIndex = 5;
            this.BtnSiguienteBanco.Text = "Aceptar";
            this.BtnSiguienteBanco.UseVisualStyleBackColor = true;
            this.BtnSiguienteBanco.Click += new System.EventHandler(this.BtnSiguienteBanco_Click);
            // 
            // BtnSalirBanco
            // 
            this.BtnSalirBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirBanco.Location = new System.Drawing.Point(243, 172);
            this.BtnSalirBanco.Name = "BtnSalirBanco";
            this.BtnSalirBanco.Size = new System.Drawing.Size(78, 31);
            this.BtnSalirBanco.TabIndex = 6;
            this.BtnSalirBanco.Text = "Cancelar";
            this.BtnSalirBanco.UseVisualStyleBackColor = true;
            this.BtnSalirBanco.Click += new System.EventHandler(this.BtnSalirBanco_Click);
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 232);
            this.Controls.Add(this.BtnSalirBanco);
            this.Controls.Add(this.BtnSiguienteBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroBanco);
            this.Controls.Add(this.txtNombreBanco);
            this.Name = "FrmBanco";
            this.Text = "FrmBanco";
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.TextBox txtNumeroBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSiguienteBanco;
        private System.Windows.Forms.Button BtnSalirBanco;
    }
}