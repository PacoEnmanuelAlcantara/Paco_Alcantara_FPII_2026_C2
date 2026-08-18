namespace Tarifario
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabRegistrarVehiculo = new System.Windows.Forms.TabPage();
            this.lstVehiculos = new System.Windows.Forms.ListView();
            this.clhMarca = new System.Windows.Forms.ColumnHeader();
            this.clhModelo = new System.Windows.Forms.ColumnHeader();
            this.clhAnio = new System.Windows.Forms.ColumnHeader();
            this.clhDetalle = new System.Windows.Forms.ColumnHeader();
            this.btnGuardarVehiculo = new System.Windows.Forms.Button();
            this.btnActualizarVehiculo = new System.Windows.Forms.Button();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.nudValorComercial = new System.Windows.Forms.NumericUpDown();
            this.nudValorHaceUnAnio = new System.Windows.Forms.NumericUpDown();
            this.nudKmUltimoAnio = new System.Windows.Forms.NumericUpDown();
            this.nudPrimaSeguro = new System.Windows.Forms.NumericUpDown();
            this.nudPorcentajeRiesgo = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioGomas = new System.Windows.Forms.NumericUpDown();
            this.nudKmDuracionGomas = new System.Windows.Forms.NumericUpDown();
            this.nudCostoMantenimiento = new System.Windows.Forms.NumericUpDown();
            this.nudKmIntervaloMantenimiento = new System.Windows.Forms.NumericUpDown();
            this.nudKmGalonCarretera = new System.Windows.Forms.NumericUpDown();
            this.nudKmGalonCiudad = new System.Windows.Forms.NumericUpDown();
            this.nudCostoLimpieza = new System.Windows.Forms.NumericUpDown();
            this.nudDepositoGarantia = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblValorComercial = new System.Windows.Forms.Label();
            this.lblValorHaceUnAnio = new System.Windows.Forms.Label();
            this.lblKmUltimoAnio = new System.Windows.Forms.Label();
            this.lblPrimaSeguro = new System.Windows.Forms.Label();
            this.lblPorcentajeRiesgo = new System.Windows.Forms.Label();
            this.lblPrecioGomas = new System.Windows.Forms.Label();
            this.lblKmDuracionGomas = new System.Windows.Forms.Label();
            this.lblCostoMantenimiento = new System.Windows.Forms.Label();
            this.lblKmIntervaloMantenimiento = new System.Windows.Forms.Label();
            this.lblKmGalonCarretera = new System.Windows.Forms.Label();
            this.lblKmGalonCiudad = new System.Windows.Forms.Label();
            this.lblCostoLimpieza = new System.Windows.Forms.Label();
            this.lblDepositoGarantia = new System.Windows.Forms.Label();
            this.tabCalcularViaje = new System.Windows.Forms.TabPage();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.lblKmCarretera = new System.Windows.Forms.Label();
            this.nudKmCarretera = new System.Windows.Forms.NumericUpDown();
            this.lblKmCiudad = new System.Windows.Forms.Label();
            this.nudKmCiudad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioGalon = new System.Windows.Forms.Label();
            this.nudPrecioGalon = new System.Windows.Forms.NumericUpDown();
            this.lblPorcentajeGanancia = new System.Windows.Forms.Label();
            this.nudPorcentajeGanancia = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.tabControlPrincipal.SuspendLayout();
            this.tabRegistrarVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorHaceUnAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmUltimoAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimaSeguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeRiesgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioGomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmDuracionGomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmIntervaloMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmGalonCarretera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmGalonCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoLimpieza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositoGarantia)).BeginInit();
            this.tabCalcularViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmCarretera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioGalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeGanancia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabRegistrarVehiculo);
            this.tabControlPrincipal.Controls.Add(this.tabCalcularViaje);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1100, 860);
            this.tabControlPrincipal.TabIndex = 0;
            this.tabControlPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabControlPrincipal_SelectedIndexChanged);
            // 
            // tabRegistrarVehiculo
            // 
            this.tabRegistrarVehiculo.Controls.Add(this.lstVehiculos);
            this.tabRegistrarVehiculo.Controls.Add(this.btnCancelarEdicion);
            this.tabRegistrarVehiculo.Controls.Add(this.btnEliminarVehiculo);
            this.tabRegistrarVehiculo.Controls.Add(this.btnActualizarVehiculo);
            this.tabRegistrarVehiculo.Controls.Add(this.btnGuardarVehiculo);
            this.tabRegistrarVehiculo.Controls.Add(this.nudDepositoGarantia);
            this.tabRegistrarVehiculo.Controls.Add(this.lblDepositoGarantia);
            this.tabRegistrarVehiculo.Controls.Add(this.nudCostoLimpieza);
            this.tabRegistrarVehiculo.Controls.Add(this.lblCostoLimpieza);
            this.tabRegistrarVehiculo.Controls.Add(this.nudKmGalonCiudad);
            this.tabRegistrarVehiculo.Controls.Add(this.lblKmGalonCiudad);
            this.tabRegistrarVehiculo.Controls.Add(this.nudKmGalonCarretera);
            this.tabRegistrarVehiculo.Controls.Add(this.lblKmGalonCarretera);
            this.tabRegistrarVehiculo.Controls.Add(this.nudKmIntervaloMantenimiento);
            this.tabRegistrarVehiculo.Controls.Add(this.lblKmIntervaloMantenimiento);
            this.tabRegistrarVehiculo.Controls.Add(this.nudCostoMantenimiento);
            this.tabRegistrarVehiculo.Controls.Add(this.lblCostoMantenimiento);
            this.tabRegistrarVehiculo.Controls.Add(this.nudKmDuracionGomas);
            this.tabRegistrarVehiculo.Controls.Add(this.lblKmDuracionGomas);
            this.tabRegistrarVehiculo.Controls.Add(this.nudPrecioGomas);
            this.tabRegistrarVehiculo.Controls.Add(this.lblPrecioGomas);
            this.tabRegistrarVehiculo.Controls.Add(this.nudPorcentajeRiesgo);
            this.tabRegistrarVehiculo.Controls.Add(this.lblPorcentajeRiesgo);
            this.tabRegistrarVehiculo.Controls.Add(this.nudPrimaSeguro);
            this.tabRegistrarVehiculo.Controls.Add(this.lblPrimaSeguro);
            this.tabRegistrarVehiculo.Controls.Add(this.nudKmUltimoAnio);
            this.tabRegistrarVehiculo.Controls.Add(this.lblKmUltimoAnio);
            this.tabRegistrarVehiculo.Controls.Add(this.nudValorHaceUnAnio);
            this.tabRegistrarVehiculo.Controls.Add(this.lblValorHaceUnAnio);
            this.tabRegistrarVehiculo.Controls.Add(this.nudValorComercial);
            this.tabRegistrarVehiculo.Controls.Add(this.lblValorComercial);
            this.tabRegistrarVehiculo.Controls.Add(this.nudAnio);
            this.tabRegistrarVehiculo.Controls.Add(this.lblAnio);
            this.tabRegistrarVehiculo.Controls.Add(this.txtModelo);
            this.tabRegistrarVehiculo.Controls.Add(this.lblModelo);
            this.tabRegistrarVehiculo.Controls.Add(this.txtMarca);
            this.tabRegistrarVehiculo.Controls.Add(this.lblMarca);
            this.tabRegistrarVehiculo.Location = new System.Drawing.Point(4, 29);
            this.tabRegistrarVehiculo.Name = "tabRegistrarVehiculo";
            this.tabRegistrarVehiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrarVehiculo.Size = new System.Drawing.Size(1092, 827);
            this.tabRegistrarVehiculo.TabIndex = 0;
            this.tabRegistrarVehiculo.Text = "Registrar Vehículo";
            this.tabRegistrarVehiculo.UseVisualStyleBackColor = true;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVehiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.clhMarca, this.clhModelo, this.clhAnio, this.clhDetalle });
            this.lstVehiculos.FullRowSelect = true;
            this.lstVehiculos.GridLines = true;
            this.lstVehiculos.Location = new System.Drawing.Point(16, 606);
            this.lstVehiculos.MultiSelect = false;
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(1062, 200);
            this.lstVehiculos.TabIndex = 17;
            this.lstVehiculos.UseCompatibleStateImageBehavior = false;
            this.lstVehiculos.View = System.Windows.Forms.View.Details;
            this.lstVehiculos.SelectedIndexChanged += new System.EventHandler(this.lstVehiculos_SelectedIndexChanged);
            // 
            // clhMarca
            // 
            this.clhMarca.Text = "Marca";
            this.clhMarca.Width = 220;
            // 
            // clhModelo
            // 
            this.clhModelo.Text = "Modelo";
            this.clhModelo.Width = 300;
            // 
            // clhAnio
            // 
            this.clhAnio.Text = "Año";
            this.clhAnio.Width = 100;
            // 
            // clhDetalle
            // 
            this.clhDetalle.Text = "Detalles";
            this.clhDetalle.Width = 420;
            // 
            // btnGuardarVehiculo
            // 
            this.btnGuardarVehiculo.Location = new System.Drawing.Point(16, 556);
            this.btnGuardarVehiculo.Name = "btnGuardarVehiculo";
            this.btnGuardarVehiculo.Size = new System.Drawing.Size(230, 35);
            this.btnGuardarVehiculo.TabIndex = 16;
            this.btnGuardarVehiculo.Text = "Guardar vehículo";
            this.btnGuardarVehiculo.UseVisualStyleBackColor = true;
            this.btnGuardarVehiculo.Click += new System.EventHandler(this.btnGuardarVehiculo_Click);
            // 
            // btnActualizarVehiculo
            // 
            this.btnActualizarVehiculo.Enabled = false;
            this.btnActualizarVehiculo.Location = new System.Drawing.Point(262, 556);
            this.btnActualizarVehiculo.Name = "btnActualizarVehiculo";
            this.btnActualizarVehiculo.Size = new System.Drawing.Size(230, 35);
            this.btnActualizarVehiculo.TabIndex = 18;
            this.btnActualizarVehiculo.Text = "Actualizar vehículo";
            this.btnActualizarVehiculo.UseVisualStyleBackColor = true;
            this.btnActualizarVehiculo.Click += new System.EventHandler(this.btnActualizarVehiculo_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Enabled = false;
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(508, 556);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(230, 35);
            this.btnEliminarVehiculo.TabIndex = 19;
            this.btnEliminarVehiculo.Text = "Eliminar vehículo";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.Enabled = false;
            this.btnCancelarEdicion.Location = new System.Drawing.Point(754, 556);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(230, 35);
            this.btnCancelarEdicion.TabIndex = 20;
            this.btnCancelarEdicion.Text = "Cancelar edición";
            this.btnCancelarEdicion.UseVisualStyleBackColor = true;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(296, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(230, 23);
            this.txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(296, 54);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(230, 23);
            this.txtModelo.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 23);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(16, 57);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(16, 91);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 15);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "Año";
            // 
            // nudAnio
            // 
            this.nudAnio.DecimalPlaces = 0;
            this.nudAnio.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudAnio.Location = new System.Drawing.Point(296, 88);
            this.nudAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            this.nudAnio.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(230, 23);
            this.nudAnio.TabIndex = 5;
            this.nudAnio.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // lblValorComercial
            // 
            this.lblValorComercial.AutoSize = true;
            this.lblValorComercial.Location = new System.Drawing.Point(16, 125);
            this.lblValorComercial.Name = "lblValorComercial";
            this.lblValorComercial.Size = new System.Drawing.Size(142, 15);
            this.lblValorComercial.TabIndex = 6;
            this.lblValorComercial.Text = "Valor comercial actual (RD$)";
            // 
            // nudValorComercial
            // 
            this.nudValorComercial.DecimalPlaces = 2;
            this.nudValorComercial.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudValorComercial.Location = new System.Drawing.Point(296, 122);
            this.nudValorComercial.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudValorComercial.Name = "nudValorComercial";
            this.nudValorComercial.Size = new System.Drawing.Size(230, 23);
            this.nudValorComercial.TabIndex = 7;
            this.nudValorComercial.ThousandsSeparator = true;
            // 
            // lblValorHaceUnAnio
            // 
            this.lblValorHaceUnAnio.AutoSize = true;
            this.lblValorHaceUnAnio.Location = new System.Drawing.Point(16, 159);
            this.lblValorHaceUnAnio.Name = "lblValorHaceUnAnio";
            this.lblValorHaceUnAnio.Size = new System.Drawing.Size(142, 15);
            this.lblValorHaceUnAnio.TabIndex = 8;
            this.lblValorHaceUnAnio.Text = "Valor hace un año (RD$)";
            // 
            // nudValorHaceUnAnio
            // 
            this.nudValorHaceUnAnio.DecimalPlaces = 2;
            this.nudValorHaceUnAnio.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudValorHaceUnAnio.Location = new System.Drawing.Point(296, 156);
            this.nudValorHaceUnAnio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudValorHaceUnAnio.Name = "nudValorHaceUnAnio";
            this.nudValorHaceUnAnio.Size = new System.Drawing.Size(230, 23);
            this.nudValorHaceUnAnio.TabIndex = 9;
            this.nudValorHaceUnAnio.ThousandsSeparator = true;
            // 
            // lblKmUltimoAnio
            // 
            this.lblKmUltimoAnio.AutoSize = true;
            this.lblKmUltimoAnio.Location = new System.Drawing.Point(16, 193);
            this.lblKmUltimoAnio.Name = "lblKmUltimoAnio";
            this.lblKmUltimoAnio.Size = new System.Drawing.Size(157, 15);
            this.lblKmUltimoAnio.TabIndex = 10;
            this.lblKmUltimoAnio.Text = "Km recorridos el último año";
            // 
            // nudKmUltimoAnio
            // 
            this.nudKmUltimoAnio.DecimalPlaces = 1;
            this.nudKmUltimoAnio.Location = new System.Drawing.Point(296, 190);
            this.nudKmUltimoAnio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudKmUltimoAnio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudKmUltimoAnio.Name = "nudKmUltimoAnio";
            this.nudKmUltimoAnio.Size = new System.Drawing.Size(230, 23);
            this.nudKmUltimoAnio.TabIndex = 11;
            this.nudKmUltimoAnio.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblPrimaSeguro
            // 
            this.lblPrimaSeguro.AutoSize = true;
            this.lblPrimaSeguro.Location = new System.Drawing.Point(16, 227);
            this.lblPrimaSeguro.Name = "lblPrimaSeguro";
            this.lblPrimaSeguro.Size = new System.Drawing.Size(118, 15);
            this.lblPrimaSeguro.TabIndex = 12;
            this.lblPrimaSeguro.Text = "Costo del seguro al año (RD$)";
            // 
            // nudPrimaSeguro
            // 
            this.nudPrimaSeguro.DecimalPlaces = 2;
            this.nudPrimaSeguro.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudPrimaSeguro.Location = new System.Drawing.Point(296, 224);
            this.nudPrimaSeguro.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudPrimaSeguro.Name = "nudPrimaSeguro";
            this.nudPrimaSeguro.Size = new System.Drawing.Size(230, 23);
            this.nudPrimaSeguro.TabIndex = 13;
            this.nudPrimaSeguro.ThousandsSeparator = true;
            // 
            // lblPorcentajeRiesgo
            // 
            this.lblPorcentajeRiesgo.AutoSize = true;
            this.lblPorcentajeRiesgo.Location = new System.Drawing.Point(16, 261);
            this.lblPorcentajeRiesgo.Name = "lblPorcentajeRiesgo";
            this.lblPorcentajeRiesgo.Size = new System.Drawing.Size(184, 15);
            this.lblPorcentajeRiesgo.TabIndex = 14;
            this.lblPorcentajeRiesgo.Text = "% que se aparta por si el carro falla (ej. 2 = 2%)";
            // 
            // nudPorcentajeRiesgo
            // 
            this.nudPorcentajeRiesgo.DecimalPlaces = 2;
            this.nudPorcentajeRiesgo.Location = new System.Drawing.Point(296, 258);
            this.nudPorcentajeRiesgo.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudPorcentajeRiesgo.Name = "nudPorcentajeRiesgo";
            this.nudPorcentajeRiesgo.Size = new System.Drawing.Size(230, 23);
            this.nudPorcentajeRiesgo.TabIndex = 15;
            // 
            // lblPrecioGomas
            // 
            this.lblPrecioGomas.AutoSize = true;
            this.lblPrecioGomas.Location = new System.Drawing.Point(576, 23);
            this.lblPrecioGomas.Name = "lblPrecioGomas";
            this.lblPrecioGomas.Size = new System.Drawing.Size(129, 15);
            this.lblPrecioGomas.TabIndex = 0;
            this.lblPrecioGomas.Text = "Precio juego de gomas (RD$)";
            // 
            // nudPrecioGomas
            // 
            this.nudPrecioGomas.DecimalPlaces = 2;
            this.nudPrecioGomas.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudPrecioGomas.Location = new System.Drawing.Point(856, 20);
            this.nudPrecioGomas.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudPrecioGomas.Name = "nudPrecioGomas";
            this.nudPrecioGomas.Size = new System.Drawing.Size(220, 23);
            this.nudPrecioGomas.TabIndex = 1;
            this.nudPrecioGomas.ThousandsSeparator = true;
            // 
            // lblKmDuracionGomas
            // 
            this.lblKmDuracionGomas.AutoSize = true;
            this.lblKmDuracionGomas.Location = new System.Drawing.Point(576, 57);
            this.lblKmDuracionGomas.Name = "lblKmDuracionGomas";
            this.lblKmDuracionGomas.Size = new System.Drawing.Size(101, 15);
            this.lblKmDuracionGomas.TabIndex = 2;
            this.lblKmDuracionGomas.Text = "Duración gomas (km)";
            // 
            // nudKmDuracionGomas
            // 
            this.nudKmDuracionGomas.DecimalPlaces = 1;
            this.nudKmDuracionGomas.Location = new System.Drawing.Point(856, 54);
            this.nudKmDuracionGomas.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudKmDuracionGomas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudKmDuracionGomas.Name = "nudKmDuracionGomas";
            this.nudKmDuracionGomas.Size = new System.Drawing.Size(220, 23);
            this.nudKmDuracionGomas.TabIndex = 3;
            this.nudKmDuracionGomas.Value = new decimal(new int[] { 40000, 0, 0, 0 });
            // 
            // lblCostoMantenimiento
            // 
            this.lblCostoMantenimiento.AutoSize = true;
            this.lblCostoMantenimiento.Location = new System.Drawing.Point(576, 91);
            this.lblCostoMantenimiento.Name = "lblCostoMantenimiento";
            this.lblCostoMantenimiento.Size = new System.Drawing.Size(146, 15);
            this.lblCostoMantenimiento.TabIndex = 4;
            this.lblCostoMantenimiento.Text = "Costo mantenimiento (RD$)";
            // 
            // nudCostoMantenimiento
            // 
            this.nudCostoMantenimiento.DecimalPlaces = 2;
            this.nudCostoMantenimiento.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudCostoMantenimiento.Location = new System.Drawing.Point(856, 88);
            this.nudCostoMantenimiento.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudCostoMantenimiento.Name = "nudCostoMantenimiento";
            this.nudCostoMantenimiento.Size = new System.Drawing.Size(220, 23);
            this.nudCostoMantenimiento.TabIndex = 5;
            this.nudCostoMantenimiento.ThousandsSeparator = true;
            // 
            // lblKmIntervaloMantenimiento
            // 
            this.lblKmIntervaloMantenimiento.AutoSize = true;
            this.lblKmIntervaloMantenimiento.Location = new System.Drawing.Point(576, 125);
            this.lblKmIntervaloMantenimiento.Name = "lblKmIntervaloMantenimiento";
            this.lblKmIntervaloMantenimiento.Size = new System.Drawing.Size(151, 15);
            this.lblKmIntervaloMantenimiento.TabIndex = 6;
            this.lblKmIntervaloMantenimiento.Text = "Km entre mantenimientos";
            // 
            // nudKmIntervaloMantenimiento
            // 
            this.nudKmIntervaloMantenimiento.DecimalPlaces = 1;
            this.nudKmIntervaloMantenimiento.Location = new System.Drawing.Point(856, 122);
            this.nudKmIntervaloMantenimiento.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudKmIntervaloMantenimiento.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudKmIntervaloMantenimiento.Name = "nudKmIntervaloMantenimiento";
            this.nudKmIntervaloMantenimiento.Size = new System.Drawing.Size(220, 23);
            this.nudKmIntervaloMantenimiento.TabIndex = 7;
            this.nudKmIntervaloMantenimiento.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // lblKmGalonCarretera
            // 
            this.lblKmGalonCarretera.AutoSize = true;
            this.lblKmGalonCarretera.Location = new System.Drawing.Point(576, 159);
            this.lblKmGalonCarretera.Name = "lblKmGalonCarretera";
            this.lblKmGalonCarretera.Size = new System.Drawing.Size(155, 15);
            this.lblKmGalonCarretera.TabIndex = 8;
            this.lblKmGalonCarretera.Text = "Rendimiento carretera (km/gal)";
            // 
            // nudKmGalonCarretera
            // 
            this.nudKmGalonCarretera.DecimalPlaces = 1;
            this.nudKmGalonCarretera.Location = new System.Drawing.Point(856, 156);
            this.nudKmGalonCarretera.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.nudKmGalonCarretera.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudKmGalonCarretera.Name = "nudKmGalonCarretera";
            this.nudKmGalonCarretera.Size = new System.Drawing.Size(220, 23);
            this.nudKmGalonCarretera.TabIndex = 9;
            this.nudKmGalonCarretera.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // lblKmGalonCiudad
            // 
            this.lblKmGalonCiudad.AutoSize = true;
            this.lblKmGalonCiudad.Location = new System.Drawing.Point(576, 193);
            this.lblKmGalonCiudad.Name = "lblKmGalonCiudad";
            this.lblKmGalonCiudad.Size = new System.Drawing.Size(140, 15);
            this.lblKmGalonCiudad.TabIndex = 10;
            this.lblKmGalonCiudad.Text = "Rendimiento ciudad (km/gal)";
            // 
            // nudKmGalonCiudad
            // 
            this.nudKmGalonCiudad.DecimalPlaces = 1;
            this.nudKmGalonCiudad.Location = new System.Drawing.Point(856, 190);
            this.nudKmGalonCiudad.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.nudKmGalonCiudad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudKmGalonCiudad.Name = "nudKmGalonCiudad";
            this.nudKmGalonCiudad.Size = new System.Drawing.Size(220, 23);
            this.nudKmGalonCiudad.TabIndex = 11;
            this.nudKmGalonCiudad.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblCostoLimpieza
            // 
            this.lblCostoLimpieza.AutoSize = true;
            this.lblCostoLimpieza.Location = new System.Drawing.Point(576, 227);
            this.lblCostoLimpieza.Name = "lblCostoLimpieza";
            this.lblCostoLimpieza.Size = new System.Drawing.Size(158, 15);
            this.lblCostoLimpieza.TabIndex = 12;
            this.lblCostoLimpieza.Text = "Limpieza por entrega (RD$)";
            // 
            // nudCostoLimpieza
            // 
            this.nudCostoLimpieza.DecimalPlaces = 2;
            this.nudCostoLimpieza.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            this.nudCostoLimpieza.Location = new System.Drawing.Point(856, 224);
            this.nudCostoLimpieza.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudCostoLimpieza.Name = "nudCostoLimpieza";
            this.nudCostoLimpieza.Size = new System.Drawing.Size(220, 23);
            this.nudCostoLimpieza.TabIndex = 13;
            this.nudCostoLimpieza.ThousandsSeparator = true;
            // 
            // lblDepositoGarantia
            // 
            this.lblDepositoGarantia.AutoSize = true;
            this.lblDepositoGarantia.Location = new System.Drawing.Point(576, 261);
            this.lblDepositoGarantia.Name = "lblDepositoGarantia";
            this.lblDepositoGarantia.Size = new System.Drawing.Size(185, 15);
            this.lblDepositoGarantia.TabIndex = 14;
            this.lblDepositoGarantia.Text = "Depósito de garantía por daños (RD$)";
            // 
            // nudDepositoGarantia
            // 
            this.nudDepositoGarantia.DecimalPlaces = 2;
            this.nudDepositoGarantia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudDepositoGarantia.Location = new System.Drawing.Point(856, 258);
            this.nudDepositoGarantia.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudDepositoGarantia.Name = "nudDepositoGarantia";
            this.nudDepositoGarantia.Size = new System.Drawing.Size(220, 23);
            this.nudDepositoGarantia.TabIndex = 15;
            this.nudDepositoGarantia.ThousandsSeparator = true;
            // 
            // tabCalcularViaje
            // 
            this.tabCalcularViaje.Controls.Add(this.txtResultado);
            this.tabCalcularViaje.Controls.Add(this.btnFactura);
            this.tabCalcularViaje.Controls.Add(this.btnCalcular);
            this.tabCalcularViaje.Controls.Add(this.nudPorcentajeGanancia);
            this.tabCalcularViaje.Controls.Add(this.lblPorcentajeGanancia);
            this.tabCalcularViaje.Controls.Add(this.nudPrecioGalon);
            this.tabCalcularViaje.Controls.Add(this.lblPrecioGalon);
            this.tabCalcularViaje.Controls.Add(this.nudKmCiudad);
            this.tabCalcularViaje.Controls.Add(this.lblKmCiudad);
            this.tabCalcularViaje.Controls.Add(this.nudKmCarretera);
            this.tabCalcularViaje.Controls.Add(this.lblKmCarretera);
            this.tabCalcularViaje.Controls.Add(this.cmbVehiculo);
            this.tabCalcularViaje.Controls.Add(this.lblVehiculo);
            this.tabCalcularViaje.Location = new System.Drawing.Point(4, 29);
            this.tabCalcularViaje.Name = "tabCalcularViaje";
            this.tabCalcularViaje.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalcularViaje.Size = new System.Drawing.Size(1092, 827);
            this.tabCalcularViaje.TabIndex = 1;
            this.tabCalcularViaje.Text = "Calcular Viaje";
            this.tabCalcularViaje.UseVisualStyleBackColor = true;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(16, 23);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(54, 15);
            this.lblVehiculo.TabIndex = 0;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(300, 20);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(420, 23);
            this.cmbVehiculo.TabIndex = 1;
            // 
            // lblKmCarretera
            // 
            this.lblKmCarretera.AutoSize = true;
            this.lblKmCarretera.Location = new System.Drawing.Point(16, 57);
            this.lblKmCarretera.Name = "lblKmCarretera";
            this.lblKmCarretera.Size = new System.Drawing.Size(125, 15);
            this.lblKmCarretera.TabIndex = 2;
            this.lblKmCarretera.Text = "Km en carretera del viaje";
            // 
            // nudKmCarretera
            // 
            this.nudKmCarretera.DecimalPlaces = 1;
            this.nudKmCarretera.Location = new System.Drawing.Point(300, 54);
            this.nudKmCarretera.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudKmCarretera.Name = "nudKmCarretera";
            this.nudKmCarretera.Size = new System.Drawing.Size(420, 23);
            this.nudKmCarretera.TabIndex = 3;
            // 
            // lblKmCiudad
            // 
            this.lblKmCiudad.AutoSize = true;
            this.lblKmCiudad.Location = new System.Drawing.Point(16, 91);
            this.lblKmCiudad.Name = "lblKmCiudad";
            this.lblKmCiudad.Size = new System.Drawing.Size(109, 15);
            this.lblKmCiudad.TabIndex = 4;
            this.lblKmCiudad.Text = "Km en ciudad del viaje";
            // 
            // nudKmCiudad
            // 
            this.nudKmCiudad.DecimalPlaces = 1;
            this.nudKmCiudad.Location = new System.Drawing.Point(300, 88);
            this.nudKmCiudad.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudKmCiudad.Name = "nudKmCiudad";
            this.nudKmCiudad.Size = new System.Drawing.Size(420, 23);
            this.nudKmCiudad.TabIndex = 5;
            // 
            // lblPrecioGalon
            // 
            this.lblPrecioGalon.AutoSize = true;
            this.lblPrecioGalon.Location = new System.Drawing.Point(16, 125);
            this.lblPrecioGalon.Name = "lblPrecioGalon";
            this.lblPrecioGalon.Size = new System.Drawing.Size(147, 15);
            this.lblPrecioGalon.TabIndex = 6;
            this.lblPrecioGalon.Text = "Precio del galón de gasolina (RD$)";
            // 
            // nudPrecioGalon
            // 
            this.nudPrecioGalon.DecimalPlaces = 2;
            this.nudPrecioGalon.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudPrecioGalon.Location = new System.Drawing.Point(300, 122);
            this.nudPrecioGalon.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            this.nudPrecioGalon.Name = "nudPrecioGalon";
            this.nudPrecioGalon.Size = new System.Drawing.Size(420, 23);
            this.nudPrecioGalon.TabIndex = 7;
            this.nudPrecioGalon.ThousandsSeparator = true;
            // 
            // lblPorcentajeGanancia
            // 
            this.lblPorcentajeGanancia.AutoSize = true;
            this.lblPorcentajeGanancia.Location = new System.Drawing.Point(16, 159);
            this.lblPorcentajeGanancia.Name = "lblPorcentajeGanancia";
            this.lblPorcentajeGanancia.Size = new System.Drawing.Size(170, 15);
            this.lblPorcentajeGanancia.TabIndex = 8;
            this.lblPorcentajeGanancia.Text = "Porcentaje de ganancia (ej. 20)";
            // 
            // nudPorcentajeGanancia
            // 
            this.nudPorcentajeGanancia.DecimalPlaces = 2;
            this.nudPorcentajeGanancia.Location = new System.Drawing.Point(300, 156);
            this.nudPorcentajeGanancia.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudPorcentajeGanancia.Name = "nudPorcentajeGanancia";
            this.nudPorcentajeGanancia.Size = new System.Drawing.Size(420, 23);
            this.nudPorcentajeGanancia.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(300, 200);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(420, 35);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Enabled = false;
            this.btnFactura.Location = new System.Drawing.Point(740, 200);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(200, 35);
            this.btnFactura.TabIndex = 12;
            this.btnFactura.Text = "Generar factura (PDF)";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.txtResultado.Location = new System.Drawing.Point(16, 260);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(1060, 545);
            this.txtResultado.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 860);
            this.Controls.Add(this.tabControlPrincipal);
            this.MinimumSize = new System.Drawing.Size(1116, 899);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifario — Costos por Kilómetro";
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabRegistrarVehiculo.ResumeLayout(false);
            this.tabRegistrarVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorHaceUnAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmUltimoAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrimaSeguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeRiesgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioGomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmDuracionGomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmIntervaloMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmGalonCarretera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmGalonCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoLimpieza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositoGarantia)).EndInit();
            this.tabCalcularViaje.ResumeLayout(false);
            this.tabCalcularViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmCarretera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKmCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioGalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentajeGanancia)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabRegistrarVehiculo;
        private System.Windows.Forms.TabPage tabCalcularViaje;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label lblValorComercial;
        private System.Windows.Forms.NumericUpDown nudValorComercial;
        private System.Windows.Forms.Label lblValorHaceUnAnio;
        private System.Windows.Forms.NumericUpDown nudValorHaceUnAnio;
        private System.Windows.Forms.Label lblKmUltimoAnio;
        private System.Windows.Forms.NumericUpDown nudKmUltimoAnio;
        private System.Windows.Forms.Label lblPrimaSeguro;
        private System.Windows.Forms.NumericUpDown nudPrimaSeguro;
        private System.Windows.Forms.Label lblPorcentajeRiesgo;
        private System.Windows.Forms.NumericUpDown nudPorcentajeRiesgo;
        private System.Windows.Forms.Label lblPrecioGomas;
        private System.Windows.Forms.NumericUpDown nudPrecioGomas;
        private System.Windows.Forms.Label lblKmDuracionGomas;
        private System.Windows.Forms.NumericUpDown nudKmDuracionGomas;
        private System.Windows.Forms.Label lblCostoMantenimiento;
        private System.Windows.Forms.NumericUpDown nudCostoMantenimiento;
        private System.Windows.Forms.Label lblKmIntervaloMantenimiento;
        private System.Windows.Forms.NumericUpDown nudKmIntervaloMantenimiento;
        private System.Windows.Forms.Label lblKmGalonCarretera;
        private System.Windows.Forms.NumericUpDown nudKmGalonCarretera;
        private System.Windows.Forms.Label lblKmGalonCiudad;
        private System.Windows.Forms.NumericUpDown nudKmGalonCiudad;
        private System.Windows.Forms.Label lblCostoLimpieza;
        private System.Windows.Forms.NumericUpDown nudCostoLimpieza;
        private System.Windows.Forms.Label lblDepositoGarantia;
        private System.Windows.Forms.NumericUpDown nudDepositoGarantia;
        private System.Windows.Forms.Button btnGuardarVehiculo;
        private System.Windows.Forms.Button btnActualizarVehiculo;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.ListView lstVehiculos;
        private System.Windows.Forms.ColumnHeader clhMarca;
        private System.Windows.Forms.ColumnHeader clhModelo;
        private System.Windows.Forms.ColumnHeader clhAnio;
        private System.Windows.Forms.ColumnHeader clhDetalle;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label lblKmCarretera;
        private System.Windows.Forms.NumericUpDown nudKmCarretera;
        private System.Windows.Forms.Label lblKmCiudad;
        private System.Windows.Forms.NumericUpDown nudKmCiudad;
        private System.Windows.Forms.Label lblPrecioGalon;
        private System.Windows.Forms.NumericUpDown nudPrecioGalon;
        private System.Windows.Forms.Label lblPorcentajeGanancia;
        private System.Windows.Forms.NumericUpDown nudPorcentajeGanancia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.TextBox txtResultado;
    }
}