
namespace AppCajero
{
    partial class FormLoginAdmin
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
            this.textUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.textClaveAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelarAdmin = new System.Windows.Forms.Button();
            this.BtnSiguienteAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUsuarioAdmin
            // 
            this.textUsuarioAdmin.BackColor = System.Drawing.SystemColors.Info;
            this.textUsuarioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioAdmin.Location = new System.Drawing.Point(164, 108);
            this.textUsuarioAdmin.Name = "textUsuarioAdmin";
            this.textUsuarioAdmin.Size = new System.Drawing.Size(218, 31);
            this.textUsuarioAdmin.TabIndex = 31;
            // 
            // textClaveAdmin
            // 
            this.textClaveAdmin.BackColor = System.Drawing.SystemColors.Info;
            this.textClaveAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClaveAdmin.Location = new System.Drawing.Point(164, 164);
            this.textClaveAdmin.Name = "textClaveAdmin";
            this.textClaveAdmin.Size = new System.Drawing.Size(218, 31);
            this.textClaveAdmin.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(140, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 46;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(34, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 47;
            this.label3.Text = "Clave";
            // 
            // BtnCancelarAdmin
            // 
            this.BtnCancelarAdmin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnCancelarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelarAdmin.Location = new System.Drawing.Point(314, 260);
            this.BtnCancelarAdmin.Name = "BtnCancelarAdmin";
            this.BtnCancelarAdmin.Size = new System.Drawing.Size(102, 46);
            this.BtnCancelarAdmin.TabIndex = 48;
            this.BtnCancelarAdmin.Text = "Cancelar";
            this.BtnCancelarAdmin.UseVisualStyleBackColor = false;
            this.BtnCancelarAdmin.Click += new System.EventHandler(this.BtnCancelarAdmin_Click);
            // 
            // BtnSiguienteAdmin
            // 
            this.BtnSiguienteAdmin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnSiguienteAdmin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSiguienteAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguienteAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSiguienteAdmin.Location = new System.Drawing.Point(40, 260);
            this.BtnSiguienteAdmin.Name = "BtnSiguienteAdmin";
            this.BtnSiguienteAdmin.Size = new System.Drawing.Size(96, 46);
            this.BtnSiguienteAdmin.TabIndex = 49;
            this.BtnSiguienteAdmin.Text = "Aceptar";
            this.BtnSiguienteAdmin.UseVisualStyleBackColor = false;
            this.BtnSiguienteAdmin.Click += new System.EventHandler(this.BtnSiguienteAdmin_Click);
            // 
            // FormLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(440, 334);
            this.Controls.Add(this.BtnSiguienteAdmin);
            this.Controls.Add(this.BtnCancelarAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textClaveAdmin);
            this.Controls.Add(this.textUsuarioAdmin);
            this.Name = "FormLoginAdmin";
            this.Text = "FormLoginAdmin";
            this.Load += new System.EventHandler(this.FormLoginAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUsuarioAdmin;
        private System.Windows.Forms.TextBox textClaveAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelarAdmin;
        private System.Windows.Forms.Button BtnSiguienteAdmin;
    }
}