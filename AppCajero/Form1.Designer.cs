namespace AppCajero
{
    partial class Form1
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
            this.txtFechaNacimiento1 = new System.Windows.Forms.DateTimePicker();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblCurp = new System.Windows.Forms.Label();
            this.LblRFC = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.btnCacnelar1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFechaNacimiento1
            // 
            this.txtFechaNacimiento1.CustomFormat = "dd/MM/yyyy";
            this.txtFechaNacimiento1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaNacimiento1.Location = new System.Drawing.Point(159, 121);
            this.txtFechaNacimiento1.Name = "txtFechaNacimiento1";
            this.txtFechaNacimiento1.Size = new System.Drawing.Size(213, 22);
            this.txtFechaNacimiento1.TabIndex = 9;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(159, 158);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(213, 22);
            this.txtEmailCliente.TabIndex = 8;
            // 
            // txtNombreCliente1
            // 
            this.txtNombreCliente1.Location = new System.Drawing.Point(159, 83);
            this.txtNombreCliente1.Name = "txtNombreCliente1";
            this.txtNombreCliente1.Size = new System.Drawing.Size(213, 22);
            this.txtNombreCliente1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Location = new System.Drawing.Point(79, 324);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(89, 33);
            this.BtnAceptar.TabIndex = 16;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click_1);
            // 
            // LblCurp
            // 
            this.LblCurp.AutoSize = true;
            this.LblCurp.Location = new System.Drawing.Point(92, 206);
            this.LblCurp.Name = "LblCurp";
            this.LblCurp.Size = new System.Drawing.Size(36, 16);
            this.LblCurp.TabIndex = 17;
            this.LblCurp.Text = "Curp";
            // 
            // LblRFC
            // 
            this.LblRFC.AutoSize = true;
            this.LblRFC.Location = new System.Drawing.Point(93, 240);
            this.LblRFC.Name = "LblRFC";
            this.LblRFC.Size = new System.Drawing.Size(35, 16);
            this.LblRFC.TabIndex = 18;
            this.LblRFC.Text = "RFC";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(159, 197);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(213, 22);
            this.txtCurp.TabIndex = 19;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(159, 234);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(213, 22);
            this.txtRFC.TabIndex = 20;
            // 
            // btnCacnelar1
            // 
            this.btnCacnelar1.Location = new System.Drawing.Point(284, 323);
            this.btnCacnelar1.Name = "btnCacnelar1";
            this.btnCacnelar1.Size = new System.Drawing.Size(88, 34);
            this.btnCacnelar1.TabIndex = 22;
            this.btnCacnelar1.Text = "Cancelar";
            this.btnCacnelar1.UseVisualStyleBackColor = true;
            this.btnCacnelar1.Click += new System.EventHandler(this.btnCacnelar1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Registro de Datos";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCacnelar1);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.LblRFC);
            this.Controls.Add(this.LblCurp);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaNacimiento1);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtNombreCliente1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtEmail1;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento1;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNombreCliente1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblCurp;
        private System.Windows.Forms.Label LblRFC;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Button btnCacnelar1;
        private System.Windows.Forms.Label label5;
    }
}

