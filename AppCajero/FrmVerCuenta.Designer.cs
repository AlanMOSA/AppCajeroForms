namespace AppCajero
{
    partial class FrmVerCuenta
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
            this.lstvVercuenta = new System.Windows.Forms.ListView();
            this.NumCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAgregarCuenta = new System.Windows.Forms.Button();
            this.BtnModificarCuenta = new System.Windows.Forms.Button();
            this.button3BtnEliminarCuenta = new System.Windows.Forms.Button();
            this.BtnSalirCuenta = new System.Windows.Forms.Button();
            this.txtBuscadorCuenta = new System.Windows.Forms.TextBox();
            this.BtnBuscadorCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvVercuenta
            // 
            this.lstvVercuenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumCliente,
            this.Clave});
            this.lstvVercuenta.GridLines = true;
            this.lstvVercuenta.HideSelection = false;
            this.lstvVercuenta.Location = new System.Drawing.Point(45, 48);
            this.lstvVercuenta.Name = "lstvVercuenta";
            this.lstvVercuenta.Size = new System.Drawing.Size(499, 232);
            this.lstvVercuenta.TabIndex = 0;
            this.lstvVercuenta.UseCompatibleStateImageBehavior = false;
            this.lstvVercuenta.View = System.Windows.Forms.View.Details;
            this.lstvVercuenta.SelectedIndexChanged += new System.EventHandler(this.lstvVercuenta_SelectedIndexChanged);
            // 
            // NumCliente
            // 
            this.NumCliente.Text = "Numero Cilente";
            this.NumCliente.Width = 167;
            // 
            // Clave
            // 
            this.Clave.Text = "Clave";
            this.Clave.Width = 291;
            // 
            // BtnAgregarCuenta
            // 
            this.BtnAgregarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCuenta.Location = new System.Drawing.Point(23, 314);
            this.BtnAgregarCuenta.Name = "BtnAgregarCuenta";
            this.BtnAgregarCuenta.Size = new System.Drawing.Size(96, 30);
            this.BtnAgregarCuenta.TabIndex = 1;
            this.BtnAgregarCuenta.Text = "Agergar";
            this.BtnAgregarCuenta.UseVisualStyleBackColor = true;
            this.BtnAgregarCuenta.Click += new System.EventHandler(this.BtnAgregarCuenta_Click);
            // 
            // BtnModificarCuenta
            // 
            this.BtnModificarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCuenta.Location = new System.Drawing.Point(170, 312);
            this.BtnModificarCuenta.Name = "BtnModificarCuenta";
            this.BtnModificarCuenta.Size = new System.Drawing.Size(98, 30);
            this.BtnModificarCuenta.TabIndex = 2;
            this.BtnModificarCuenta.Text = "Modificar";
            this.BtnModificarCuenta.UseVisualStyleBackColor = true;
            // 
            // button3BtnEliminarCuenta
            // 
            this.button3BtnEliminarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3BtnEliminarCuenta.Location = new System.Drawing.Point(338, 314);
            this.button3BtnEliminarCuenta.Name = "button3BtnEliminarCuenta";
            this.button3BtnEliminarCuenta.Size = new System.Drawing.Size(96, 33);
            this.button3BtnEliminarCuenta.TabIndex = 3;
            this.button3BtnEliminarCuenta.Text = "Eliminar";
            this.button3BtnEliminarCuenta.UseVisualStyleBackColor = true;
            this.button3BtnEliminarCuenta.Click += new System.EventHandler(this.button3BtnEliminarCuenta_Click);
            // 
            // BtnSalirCuenta
            // 
            this.BtnSalirCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirCuenta.Location = new System.Drawing.Point(489, 314);
            this.BtnSalirCuenta.Name = "BtnSalirCuenta";
            this.BtnSalirCuenta.Size = new System.Drawing.Size(98, 33);
            this.BtnSalirCuenta.TabIndex = 4;
            this.BtnSalirCuenta.Text = "Salir";
            this.BtnSalirCuenta.UseVisualStyleBackColor = true;
            this.BtnSalirCuenta.Click += new System.EventHandler(this.BtnSalirCuenta_Click);
            // 
            // txtBuscadorCuenta
            // 
            this.txtBuscadorCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorCuenta.Location = new System.Drawing.Point(143, 16);
            this.txtBuscadorCuenta.Name = "txtBuscadorCuenta";
            this.txtBuscadorCuenta.Size = new System.Drawing.Size(234, 22);
            this.txtBuscadorCuenta.TabIndex = 5;
            // 
            // BtnBuscadorCuenta
            // 
            this.BtnBuscadorCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscadorCuenta.Location = new System.Drawing.Point(12, 12);
            this.BtnBuscadorCuenta.Name = "BtnBuscadorCuenta";
            this.BtnBuscadorCuenta.Size = new System.Drawing.Size(95, 30);
            this.BtnBuscadorCuenta.TabIndex = 6;
            this.BtnBuscadorCuenta.Text = "Buscar";
            this.BtnBuscadorCuenta.UseVisualStyleBackColor = true;
            this.BtnBuscadorCuenta.Click += new System.EventHandler(this.BtnBuscadorCuenta_Click);
            // 
            // FrmVerCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 390);
            this.Controls.Add(this.BtnBuscadorCuenta);
            this.Controls.Add(this.txtBuscadorCuenta);
            this.Controls.Add(this.BtnSalirCuenta);
            this.Controls.Add(this.button3BtnEliminarCuenta);
            this.Controls.Add(this.BtnModificarCuenta);
            this.Controls.Add(this.BtnAgregarCuenta);
            this.Controls.Add(this.lstvVercuenta);
            this.Name = "FrmVerCuenta";
            this.Text = "FrmVerCuenta";
            this.Load += new System.EventHandler(this.FrmVerCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvVercuenta;
        private System.Windows.Forms.ColumnHeader NumCliente;
        private System.Windows.Forms.ColumnHeader Clave;
        private System.Windows.Forms.Button BtnAgregarCuenta;
        private System.Windows.Forms.Button BtnModificarCuenta;
        private System.Windows.Forms.Button button3BtnEliminarCuenta;
        private System.Windows.Forms.Button BtnSalirCuenta;
        private System.Windows.Forms.TextBox txtBuscadorCuenta;
        private System.Windows.Forms.Button BtnBuscadorCuenta;
    }
}