namespace pryOttonelloPalomaAppHardware
{
    partial class frmPrincipal
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
            lblRegistrodeVenta = new Label();
            lblFecha = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            txtProducto = new TextBox();
            txtPrecioUnitario = new TextBox();
            dtpFecha = new DateTimePicker();
            btmRegistrar = new Button();
            nudCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblRegistrodeVenta
            // 
            lblRegistrodeVenta.AutoSize = true;
            lblRegistrodeVenta.Font = new Font("Bernard MT Condensed", 20F);
            lblRegistrodeVenta.Location = new Point(268, 27);
            lblRegistrodeVenta.Name = "lblRegistrodeVenta";
            lblRegistrodeVenta.Size = new Size(347, 31);
            lblRegistrodeVenta.TabIndex = 0;
            lblRegistrodeVenta.Text = "Registro de Ventas de Hardware";
            lblRegistrodeVenta.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(307, 103);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(307, 159);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(307, 214);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(307, 269);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 4;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(431, 151);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 5;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(431, 269);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 23);
            txtPrecioUnitario.TabIndex = 7;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(431, 97);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            // 
            // btmRegistrar
            // 
            btmRegistrar.Location = new Point(539, 332);
            btmRegistrar.Name = "btmRegistrar";
            btmRegistrar.Size = new Size(92, 35);
            btmRegistrar.TabIndex = 9;
            btmRegistrar.Text = "Registrar";
            btmRegistrar.UseVisualStyleBackColor = true;
            btmRegistrar.Click += button1_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(431, 206);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 23);
            nudCantidad.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 495);
            Controls.Add(nudCantidad);
            Controls.Add(btmRegistrar);
            Controls.Add(dtpFecha);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtProducto);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Controls.Add(lblRegistrodeVenta);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistrodeVenta;
        private Label lblFecha;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private TextBox txtProducto;
        private TextBox txtPrecioUnitario;
        private DateTimePicker dtpFecha;
        private Button btmRegistrar;
        private NumericUpDown nudCantidad;
    }
}