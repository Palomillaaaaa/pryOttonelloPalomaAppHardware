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
            dtpFecha = new DateTimePicker();
            btmRegistrar = new Button();
            nudCantidad = new NumericUpDown();
            btmCancelar = new Button();
            mtbPrecioUnitario = new MaskedTextBox();
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
            lblRegistrodeVenta.TextAlign = ContentAlignment.TopCenter;
            lblRegistrodeVenta.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(304, 119);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(304, 175);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(304, 230);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(304, 285);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(85, 15);
            lblPrecioUnitario.TabIndex = 4;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(428, 113);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 8;
            // 
            // btmRegistrar
            // 
            btmRegistrar.Location = new Point(594, 328);
            btmRegistrar.Name = "btmRegistrar";
            btmRegistrar.Size = new Size(92, 35);
            btmRegistrar.TabIndex = 9;
            btmRegistrar.Text = "Registrar";
            btmRegistrar.UseVisualStyleBackColor = true;
            btmRegistrar.Click += button1_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(428, 222);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(70, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // btmCancelar
            // 
            btmCancelar.Location = new Point(496, 328);
            btmCancelar.Name = "btmCancelar";
            btmCancelar.Size = new Size(92, 35);
            btmCancelar.TabIndex = 11;
            btmCancelar.Text = "Cancelar";
            btmCancelar.UseVisualStyleBackColor = true;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(428, 282);
            mtbPrecioUnitario.Mask = "99999";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(70, 23);
            mtbPrecioUnitario.TabIndex = 12;
            mtbPrecioUnitario.ValidatingType = typeof(int);
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(428, 175);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 13;
            cmbProducto.SelectedIndexChanged += cmbProducto_TextChanged;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 495);
            Controls.Add(cmbProducto);
            Controls.Add(mtbPrecioUnitario);
            Controls.Add(btmCancelar);
            Controls.Add(nudCantidad);
            Controls.Add(btmRegistrar);
            Controls.Add(dtpFecha);
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
        private DateTimePicker dtpFecha;
        private Button btmRegistrar;
        private NumericUpDown nudCantidad;
        private Button btmCancelar;
        private MaskedTextBox mtbPrecioUnitario;
        private ComboBox cmbProducto;
    }
}