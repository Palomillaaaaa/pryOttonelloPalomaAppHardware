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
            txtPrecioUnitario = new TextBox();
            dtpFecha = new DateTimePicker();
            btmRegistrar = new Button();
            nudCantidad = new NumericUpDown();
            cmbProducto = new ComboBox();
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
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.Location = new Point(250, 116);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 28);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 15F);
            lblProducto.Location = new Point(250, 172);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(93, 28);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 15F);
            lblCantidad.Location = new Point(250, 227);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(91, 28);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 15F);
            lblPrecioUnitario.Location = new Point(250, 282);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(142, 28);
            lblPrecioUnitario.TabIndex = 4;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Segoe UI", 15F);
            txtPrecioUnitario.Location = new Point(421, 279);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(100, 34);
            txtPrecioUnitario.TabIndex = 7;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 15F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(421, 107);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(341, 34);
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
            nudCantidad.Font = new Font("Segoe UI", 15F);
            nudCantidad.Location = new Point(421, 216);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 34);
            nudCantidad.TabIndex = 10;
            // 
            // cmbProducto
            // 
            cmbProducto.Font = new Font("Segoe UI", 15F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(421, 166);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 36);
            cmbProducto.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 495);
            Controls.Add(cmbProducto);
            Controls.Add(nudCantidad);
            Controls.Add(btmRegistrar);
            Controls.Add(dtpFecha);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblFecha);
            Controls.Add(lblRegistrodeVenta);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
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
        private ComboBox cmbProducto;
    }
}