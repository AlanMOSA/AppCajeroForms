namespace AppCajero
{
    partial class FrmVerTarjeta
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
            this.lstvVertarjeta = new System.Windows.Forms.ListView();
            this.numCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumTarjeta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cvv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoTarjeta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAgregartarjeta = new System.Windows.Forms.Button();
            this.BtnModificarTarjeta = new System.Windows.Forms.Button();
            this.BtnEliminarTarjeta = new System.Windows.Forms.Button();
            this.BtnBuscarTarjeta = new System.Windows.Forms.Button();
            this.txtBuscadorTarjeta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstvVertarjeta
            // 
            this.lstvVertarjeta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numCliente,
            this.NumTarjeta,
            this.Nip,
            this.cvv,
            this.TipoTarjeta});
            this.lstvVertarjeta.HideSelection = false;
            this.lstvVertarjeta.Location = new System.Drawing.Point(39, 77);
            this.lstvVertarjeta.Name = "lstvVertarjeta";
            this.lstvVertarjeta.Size = new System.Drawing.Size(659, 254);
            this.lstvVertarjeta.TabIndex = 0;
            this.lstvVertarjeta.UseCompatibleStateImageBehavior = false;
            this.lstvVertarjeta.View = System.Windows.Forms.View.Details;
            this.lstvVertarjeta.SelectedIndexChanged += new System.EventHandler(this.lstvVertarjeta_SelectedIndexChanged);
            // 
            // numCliente
            // 
            this.numCliente.Text = "Numero Cliente";
            this.numCliente.Width = 127;
            // 
            // NumTarjeta
            // 
            this.NumTarjeta.Text = "Numero de Tarjeta";
            this.NumTarjeta.Width = 114;
            // 
            // Nip
            // 
            this.Nip.Text = "NIP";
            this.Nip.Width = 114;
            // 
            // cvv
            // 
            this.cvv.Text = "CVV";
            this.cvv.Width = 105;
            // 
            // TipoTarjeta
            // 
            this.TipoTarjeta.Text = "Tipo de Tarjeta";
            this.TipoTarjeta.Width = 139;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(581, 337);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(94, 32);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAgregartarjeta
            // 
            this.BtnAgregartarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregartarjeta.Location = new System.Drawing.Point(68, 339);
            this.BtnAgregartarjeta.Name = "BtnAgregartarjeta";
            this.BtnAgregartarjeta.Size = new System.Drawing.Size(94, 30);
            this.BtnAgregartarjeta.TabIndex = 2;
            this.BtnAgregartarjeta.Text = "Agregar";
            this.BtnAgregartarjeta.UseVisualStyleBackColor = true;
            this.BtnAgregartarjeta.Click += new System.EventHandler(this.BtnAgregartarjeta_Click);
            // 
            // BtnModificarTarjeta
            // 
            this.BtnModificarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarTarjeta.Location = new System.Drawing.Point(429, 338);
            this.BtnModificarTarjeta.Name = "BtnModificarTarjeta";
            this.BtnModificarTarjeta.Size = new System.Drawing.Size(99, 31);
            this.BtnModificarTarjeta.TabIndex = 3;
            this.BtnModificarTarjeta.Text = "Modificar";
            this.BtnModificarTarjeta.UseVisualStyleBackColor = true;
            this.BtnModificarTarjeta.Click += new System.EventHandler(this.BtnModificarTarjeta_Click);
            // 
            // BtnEliminarTarjeta
            // 
            this.BtnEliminarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarTarjeta.Location = new System.Drawing.Point(236, 337);
            this.BtnEliminarTarjeta.Name = "BtnEliminarTarjeta";
            this.BtnEliminarTarjeta.Size = new System.Drawing.Size(103, 30);
            this.BtnEliminarTarjeta.TabIndex = 4;
            this.BtnEliminarTarjeta.Text = "Eliminar";
            this.BtnEliminarTarjeta.UseVisualStyleBackColor = true;
            this.BtnEliminarTarjeta.Click += new System.EventHandler(this.BtnEliminarTarjeta_Click);
            // 
            // BtnBuscarTarjeta
            // 
            this.BtnBuscarTarjeta.Location = new System.Drawing.Point(54, 26);
            this.BtnBuscarTarjeta.Name = "BtnBuscarTarjeta";
            this.BtnBuscarTarjeta.Size = new System.Drawing.Size(108, 23);
            this.BtnBuscarTarjeta.TabIndex = 5;
            this.BtnBuscarTarjeta.Text = "Buscar";
            this.BtnBuscarTarjeta.UseVisualStyleBackColor = true;
            this.BtnBuscarTarjeta.Click += new System.EventHandler(this.BtnBuscarTarjeta_Click);
            // 
            // txtBuscadorTarjeta
            // 
            this.txtBuscadorTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscadorTarjeta.Location = new System.Drawing.Point(221, 26);
            this.txtBuscadorTarjeta.Name = "txtBuscadorTarjeta";
            this.txtBuscadorTarjeta.Size = new System.Drawing.Size(279, 22);
            this.txtBuscadorTarjeta.TabIndex = 6;
            // 
            // FrmVerTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 422);
            this.Controls.Add(this.txtBuscadorTarjeta);
            this.Controls.Add(this.BtnBuscarTarjeta);
            this.Controls.Add(this.BtnEliminarTarjeta);
            this.Controls.Add(this.BtnModificarTarjeta);
            this.Controls.Add(this.BtnAgregartarjeta);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.lstvVertarjeta);
            this.Name = "FrmVerTarjeta";
            this.Text = "FrmVerTarjeta";
            this.Load += new System.EventHandler(this.FrmVerTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvVertarjeta;
        private System.Windows.Forms.ColumnHeader numCliente;
        private System.Windows.Forms.ColumnHeader NumTarjeta;
        private System.Windows.Forms.ColumnHeader Nip;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAgregartarjeta;
        private System.Windows.Forms.Button BtnModificarTarjeta;
        private System.Windows.Forms.Button BtnEliminarTarjeta;
        private System.Windows.Forms.ColumnHeader cvv;
        private System.Windows.Forms.ColumnHeader TipoTarjeta;
        private System.Windows.Forms.Button BtnBuscarTarjeta;
        private System.Windows.Forms.TextBox txtBuscadorTarjeta;
    }
}