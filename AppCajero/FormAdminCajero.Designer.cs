
namespace AppCajero
{
    partial class FormAdminCajero
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
            this.BtnTarjetaAdmin = new System.Windows.Forms.Button();
            this.BtnClientesAdmin = new System.Windows.Forms.Button();
            this.BtnBancosAdmin = new System.Windows.Forms.Button();
            this.btnSalirAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTarjetaAdmin
            // 
            this.BtnTarjetaAdmin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnTarjetaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarjetaAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTarjetaAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarjetaAdmin.Location = new System.Drawing.Point(455, 140);
            this.BtnTarjetaAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTarjetaAdmin.Name = "BtnTarjetaAdmin";
            this.BtnTarjetaAdmin.Size = new System.Drawing.Size(332, 65);
            this.BtnTarjetaAdmin.TabIndex = 41;
            this.BtnTarjetaAdmin.Text = "Tarjeta";
            this.BtnTarjetaAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarjetaAdmin.UseVisualStyleBackColor = false;
            this.BtnTarjetaAdmin.Click += new System.EventHandler(this.BtnTarjetaAdmin_Click);
            // 
            // BtnClientesAdmin
            // 
            this.BtnClientesAdmin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnClientesAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientesAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientesAdmin.Location = new System.Drawing.Point(13, 140);
            this.BtnClientesAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClientesAdmin.Name = "BtnClientesAdmin";
            this.BtnClientesAdmin.Size = new System.Drawing.Size(327, 65);
            this.BtnClientesAdmin.TabIndex = 42;
            this.BtnClientesAdmin.Text = "Clientes";
            this.BtnClientesAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClientesAdmin.UseVisualStyleBackColor = false;
            this.BtnClientesAdmin.Click += new System.EventHandler(this.BtnClientesAdmin_Click);
            // 
            // BtnBancosAdmin
            // 
            this.BtnBancosAdmin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnBancosAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBancosAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBancosAdmin.Location = new System.Drawing.Point(13, 242);
            this.BtnBancosAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBancosAdmin.Name = "BtnBancosAdmin";
            this.BtnBancosAdmin.Size = new System.Drawing.Size(326, 65);
            this.BtnBancosAdmin.TabIndex = 43;
            this.BtnBancosAdmin.Text = "Banco";
            this.BtnBancosAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBancosAdmin.UseVisualStyleBackColor = false;
            this.BtnBancosAdmin.Click += new System.EventHandler(this.BtnBancosAdmin_Click);
            // 
            // btnSalirAdmin
            // 
            this.btnSalirAdmin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalirAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalirAdmin.Location = new System.Drawing.Point(455, 242);
            this.btnSalirAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirAdmin.Name = "btnSalirAdmin";
            this.btnSalirAdmin.Size = new System.Drawing.Size(332, 65);
            this.btnSalirAdmin.TabIndex = 44;
            this.btnSalirAdmin.Text = "Cancelar";
            this.btnSalirAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirAdmin.UseVisualStyleBackColor = false;
            this.btnSalirAdmin.Click += new System.EventHandler(this.btnSalirAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(138, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 40);
            this.label1.TabIndex = 45;
            this.label1.Text = "Seleccione el Tipo de Operacion";
            // 
            // FormAdminCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirAdmin);
            this.Controls.Add(this.BtnBancosAdmin);
            this.Controls.Add(this.BtnClientesAdmin);
            this.Controls.Add(this.BtnTarjetaAdmin);
            this.Name = "FormAdminCajero";
            this.Text = "FormAdminCajero";
            this.Load += new System.EventHandler(this.FormAdminCajero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTarjetaAdmin;
        private System.Windows.Forms.Button BtnClientesAdmin;
        private System.Windows.Forms.Button BtnBancosAdmin;
        private System.Windows.Forms.Button btnSalirAdmin;
        private System.Windows.Forms.Label label1;
    }
}