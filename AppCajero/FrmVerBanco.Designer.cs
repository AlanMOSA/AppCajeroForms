namespace AppCajero
{
    partial class FrmVerBanco
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
            this.BtnSalirVerBancos = new System.Windows.Forms.Button();
            this.ltsvBanco = new System.Windows.Forms.ListView();
            this.NumCliente1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumBanco1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarjeta1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnEliminarBanco = new System.Windows.Forms.Button();
            this.BtnaAgregarBanco = new System.Windows.Forms.Button();
            this.BtnModificarbanco = new System.Windows.Forms.Button();
            this.BtnBuscarBanco = new System.Windows.Forms.Button();
            this.txtBuscadorBanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalirVerBancos
            // 
            this.BtnSalirVerBancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirVerBancos.Location = new System.Drawing.Point(519, 325);
            this.BtnSalirVerBancos.Name = "BtnSalirVerBancos";
            this.BtnSalirVerBancos.Size = new System.Drawing.Size(89, 35);
            this.BtnSalirVerBancos.TabIndex = 1;
            this.BtnSalirVerBancos.Text = "Salir";
            this.BtnSalirVerBancos.UseVisualStyleBackColor = true;
            this.BtnSalirVerBancos.Click += new System.EventHandler(this.BtnSalirVerBancos_Click);
            // 
            // ltsvBanco
            // 
            this.ltsvBanco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumCliente1,
            this.Nombre1,
            this.NumBanco1,
            this.Tarjeta1});
            this.ltsvBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltsvBanco.GridLines = true;
            this.ltsvBanco.HideSelection = false;
            this.ltsvBanco.Location = new System.Drawing.Point(35, 79);
            this.ltsvBanco.Name = "ltsvBanco";
            this.ltsvBanco.Size = new System.Drawing.Size(588, 227);
            this.ltsvBanco.TabIndex = 2;
            this.ltsvBanco.UseCompatibleStateImageBehavior = false;
            this.ltsvBanco.View = System.Windows.Forms.View.Details;
            // 
            // NumCliente1
            // 
            this.NumCliente1.Text = "Numero Cliente";
            this.NumCliente1.Width = 133;
            // 
            // Nombre1
            // 
            this.Nombre1.Text = "Nombre";
            this.Nombre1.Width = 89;
            // 
            // NumBanco1
            // 
            this.NumBanco1.Text = "Numero de Banco";
            this.NumBanco1.Width = 239;
            // 
            // Tarjeta1
            // 
            this.Tarjeta1.Text = "Tarjeta";
            this.Tarjeta1.Width = 305;
            // 
            // BtnEliminarBanco
            // 
            this.BtnEliminarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarBanco.Location = new System.Drawing.Point(345, 329);
            this.BtnEliminarBanco.Name = "BtnEliminarBanco";
            this.BtnEliminarBanco.Size = new System.Drawing.Size(89, 27);
            this.BtnEliminarBanco.TabIndex = 3;
            this.BtnEliminarBanco.Text = "Eliminar";
            this.BtnEliminarBanco.UseVisualStyleBackColor = true;
            this.BtnEliminarBanco.Click += new System.EventHandler(this.BtnEliminarBanco_Click);
            // 
            // BtnaAgregarBanco
            // 
            this.BtnaAgregarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnaAgregarBanco.Location = new System.Drawing.Point(35, 323);
            this.BtnaAgregarBanco.Name = "BtnaAgregarBanco";
            this.BtnaAgregarBanco.Size = new System.Drawing.Size(89, 39);
            this.BtnaAgregarBanco.TabIndex = 4;
            this.BtnaAgregarBanco.Text = "Agregar";
            this.BtnaAgregarBanco.UseVisualStyleBackColor = true;
            this.BtnaAgregarBanco.Click += new System.EventHandler(this.BtnaAgregarBanco_Click);
            // 
            // BtnModificarbanco
            // 
            this.BtnModificarbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarbanco.Location = new System.Drawing.Point(196, 327);
            this.BtnModificarbanco.Name = "BtnModificarbanco";
            this.BtnModificarbanco.Size = new System.Drawing.Size(89, 35);
            this.BtnModificarbanco.TabIndex = 5;
            this.BtnModificarbanco.Text = "Modificar";
            this.BtnModificarbanco.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarBanco
            // 
            this.BtnBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarBanco.Location = new System.Drawing.Point(12, 18);
            this.BtnBuscarBanco.Name = "BtnBuscarBanco";
            this.BtnBuscarBanco.Size = new System.Drawing.Size(89, 27);
            this.BtnBuscarBanco.TabIndex = 6;
            this.BtnBuscarBanco.Text = "Buscar";
            this.BtnBuscarBanco.UseVisualStyleBackColor = true;
            this.BtnBuscarBanco.Click += new System.EventHandler(this.BtnBuscarBanco_Click);
            // 
            // txtBuscadorBanco
            // 
            this.txtBuscadorBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorBanco.Location = new System.Drawing.Point(222, 23);
            this.txtBuscadorBanco.Name = "txtBuscadorBanco";
            this.txtBuscadorBanco.Size = new System.Drawing.Size(315, 22);
            this.txtBuscadorBanco.TabIndex = 7;
            // 
            // FrmVerBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 412);
            this.Controls.Add(this.txtBuscadorBanco);
            this.Controls.Add(this.BtnBuscarBanco);
            this.Controls.Add(this.BtnModificarbanco);
            this.Controls.Add(this.BtnaAgregarBanco);
            this.Controls.Add(this.BtnEliminarBanco);
            this.Controls.Add(this.ltsvBanco);
            this.Controls.Add(this.BtnSalirVerBancos);
            this.Name = "FrmVerBanco";
            this.Text = "FrmVerBanco";
            this.Load += new System.EventHandler(this.FrmVerBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalirVerBancos;
        private System.Windows.Forms.ListView ltsvBanco;
        private System.Windows.Forms.ColumnHeader NumCliente1;
        private System.Windows.Forms.ColumnHeader Nombre1;
        private System.Windows.Forms.ColumnHeader NumBanco1;
        private System.Windows.Forms.ColumnHeader Tarjeta1;
        private System.Windows.Forms.Button BtnEliminarBanco;
        private System.Windows.Forms.Button BtnaAgregarBanco;
        private System.Windows.Forms.Button BtnModificarbanco;
        private System.Windows.Forms.Button BtnBuscarBanco;
        private System.Windows.Forms.TextBox txtBuscadorBanco;
    }
}