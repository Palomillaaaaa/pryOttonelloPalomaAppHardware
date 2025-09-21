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
            lblRegistrodeVenta.Location = new Point(383, 45);
            lblRegistrodeVenta.Margin = new Padding(4, 0, 4, 0);
            lblRegistrodeVenta.Name = "lblRegistrodeVenta";
            lblRegistrodeVenta.Size = new Size(514, 47);
            lblRegistrodeVenta.TabIndex = 0;
            lblRegistrodeVenta.Text = "Registro de Ventas de Hardware";
            lblRegistrodeVenta.TextAlign = ContentAlignment.TopCenter;
            lblRegistrodeVenta.Click += label1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(434, 198);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(434, 292);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(85, 25);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(434, 383);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 25);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(434, 475);
            lblPrecioUnitario.Margin = new Padding(4, 0, 4, 0);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(127, 25);
            lblPrecioUnitario.TabIndex = 4;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(611, 188);
            dtpFecha.Margin = new Padding(4, 5, 4, 5);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(284, 31);
            dtpFecha.TabIndex = 8;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // btmRegistrar
            // 
            btmRegistrar.Location = new Point(849, 547);
            btmRegistrar.Margin = new Padding(4, 5, 4, 5);
            btmRegistrar.Name = "btmRegistrar";
            btmRegistrar.Size = new Size(131, 58);
            btmRegistrar.TabIndex = 9;
            btmRegistrar.Text = "Registrar";
            btmRegistrar.UseVisualStyleBackColor = true;
            btmRegistrar.Click += button1_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(611, 370);
            nudCantidad.Margin = new Padding(4, 5, 4, 5);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(100, 31);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // btmCancelar
            // 
            btmCancelar.Location = new Point(709, 547);
            btmCancelar.Margin = new Padding(4, 5, 4, 5);
            btmCancelar.Name = "btmCancelar";
            btmCancelar.Size = new Size(131, 58);
            btmCancelar.TabIndex = 11;
            btmCancelar.Text = "Cancelar";
            btmCancelar.UseVisualStyleBackColor = true;
            btmCancelar.Click += btmCancelar_Click;
            // 
            // mtbPrecioUnitario
            // 
            mtbPrecioUnitario.Enabled = false;
            mtbPrecioUnitario.Location = new Point(611, 470);
            mtbPrecioUnitario.Margin = new Padding(4, 5, 4, 5);
            mtbPrecioUnitario.Mask = "99999";
            mtbPrecioUnitario.Name = "mtbPrecioUnitario";
            mtbPrecioUnitario.Size = new Size(98, 31);
            mtbPrecioUnitario.TabIndex = 12;
            mtbPrecioUnitario.ValidatingType = typeof(int);
            mtbPrecioUnitario.MaskInputRejected += mtbPrecioUnitario_MaskInputRejected;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(611, 284);
            cmbProducto.Margin = new Padding(4, 5, 4, 5);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(171, 33);
            cmbProducto.TabIndex = 13;
            cmbProducto.SelectedIndexChanged += cmbProducto_TextChanged;
            cmbProducto.TextChanged += cmbProducto_TextChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 825);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private DateTimePicker dtpFecha;
        private Button btmRegistrar;
        private NumericUpDown nudCantidad;
        private Button btmCancelar;
        private MaskedTextBox mtbPrecioUnitario;
        private ComboBox cmbProducto;
    }
}