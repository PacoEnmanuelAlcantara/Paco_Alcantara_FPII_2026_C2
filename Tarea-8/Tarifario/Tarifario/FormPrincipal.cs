using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Tarifario
{
    public partial class FormPrincipal : Form
    {
        private readonly RepositorioVehiculos _repositorioVehiculos;

        private Vehiculo? _vehiculoEnEdicion;

        private Vehiculo? _ultimoVehiculoCalculado;
        private decimal _ultimoKmCarretera;
        private decimal _ultimoKmCiudad;
        private decimal _ultimoPrecioGalon;
        private decimal _ultimoPorcentajeGanancia;
        private ResultadoCalculo? _ultimoResultado;

        private const int AnchoEtiqueta = 46;

        public FormPrincipal()
        {
            InitializeComponent();
            _repositorioVehiculos = new RepositorioVehiculos(Path.Combine(AppContext.BaseDirectory, "tarifario.db"));
            RefrescarListaVehiculos();
            ActivarModoNuevo();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _repositorioVehiculos.Dispose();
            base.OnFormClosing(e);
        }

        private void tabControlPrincipal_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControlPrincipal.SelectedTab == tabCalcularViaje)
            {
                RefrescarListaVehiculos();
            }
        }

        private void btnGuardarVehiculo_Click(object? sender, EventArgs e)
        {
            if (!ValidarDatosVehiculo(out Vehiculo? vehiculo) || vehiculo is null)
            {
                return;
            }

            try
            {
                _repositorioVehiculos.Guardar(vehiculo);
                MessageBox.Show(
                    $"Vehículo guardado correctamente (ID: {vehiculo.Id}).",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ActivarModoNuevo();
                LimpiarFormularioVehiculo();
                RefrescarListaVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar el vehículo: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnActualizarVehiculo_Click(object? sender, EventArgs e)
        {
            if (_vehiculoEnEdicion is null)
            {
                return;
            }

            if (!ValidarDatosVehiculo(out Vehiculo? vehiculo) || vehiculo is null)
            {
                return;
            }

            try
            {
                vehiculo.Id = _vehiculoEnEdicion.Id;
                _repositorioVehiculos.Actualizar(vehiculo);
                MessageBox.Show(
                    "Vehículo actualizado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                ActivarModoNuevo();
                LimpiarFormularioVehiculo();
                RefrescarListaVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo actualizar el vehículo: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lstVehiculos_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstVehiculos.SelectedItems.Count == 0)
            {
                ActivarModoNuevo();
                return;
            }

            if (lstVehiculos.SelectedItems[0].Tag is Vehiculo vehiculo)
            {
                CargarVehiculoEnFormulario(vehiculo);
                ActivarModoEdicion(vehiculo);
            }
        }

        private void btnCancelarEdicion_Click(object? sender, EventArgs e)
        {
            ActivarModoNuevo();
            LimpiarFormularioVehiculo();
            lstVehiculos.SelectedItems.Clear();
        }

        private void btnEliminarVehiculo_Click(object? sender, EventArgs e)
        {
            if (_vehiculoEnEdicion is null)
            {
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar este vehículo? Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _repositorioVehiculos.Eliminar(_vehiculoEnEdicion.Id);
                ActivarModoNuevo();
                LimpiarFormularioVehiculo();
                RefrescarListaVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el vehículo: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ActivarModoEdicion(Vehiculo vehiculo)
        {
            _vehiculoEnEdicion = vehiculo;
            btnGuardarVehiculo.Enabled = false;
            btnActualizarVehiculo.Enabled = true;
            btnEliminarVehiculo.Enabled = true;
            btnCancelarEdicion.Enabled = true;
        }

        private void ActivarModoNuevo()
        {
            _vehiculoEnEdicion = null;
            btnGuardarVehiculo.Enabled = true;
            btnActualizarVehiculo.Enabled = false;
            btnEliminarVehiculo.Enabled = false;
            btnCancelarEdicion.Enabled = false;
        }

        private void CargarVehiculoEnFormulario(Vehiculo vehiculo)
        {
            txtMarca.Text = vehiculo.Marca;
            txtModelo.Text = vehiculo.Modelo;
            nudAnio.Value = Math.Clamp(vehiculo.Anio, (int)nudAnio.Minimum, (int)nudAnio.Maximum);
            nudValorComercial.Value = vehiculo.ValorComercialActual;
            nudValorHaceUnAnio.Value = vehiculo.ValorHaceUnAnio;
            nudKmUltimoAnio.Value = Math.Max(vehiculo.KmRecorridosUltimoAnio, nudKmUltimoAnio.Minimum);
            nudPrimaSeguro.Value = vehiculo.PrimaSeguroAnual;
            nudPorcentajeRiesgo.Value = Math.Min(vehiculo.PorcentajeRiesgo, nudPorcentajeRiesgo.Maximum);
            nudPrecioGomas.Value = vehiculo.PrecioJuegoGomas;
            nudKmDuracionGomas.Value = Math.Max(vehiculo.KmDuracionGomas, nudKmDuracionGomas.Minimum);
            nudCostoMantenimiento.Value = vehiculo.CostoMantenimiento;
            nudKmIntervaloMantenimiento.Value = Math.Max(vehiculo.KmIntervaloMantenimiento, nudKmIntervaloMantenimiento.Minimum);
            nudKmGalonCarretera.Value = Math.Max(vehiculo.KmPorGalonCarretera, nudKmGalonCarretera.Minimum);
            nudKmGalonCiudad.Value = Math.Max(vehiculo.KmPorGalonCiudad, nudKmGalonCiudad.Minimum);
            nudCostoLimpieza.Value = vehiculo.CostoLimpiezaPorEntrega;
            nudDepositoGarantia.Value = vehiculo.DepositoGarantia;
        }

        private void btnCalcular_Click(object? sender, EventArgs e)
        {
            if (cmbVehiculo.SelectedItem is not Vehiculo vehiculo)
            {
                MostrarError("Debe seleccionar un vehículo registrado para cotizar el viaje.");
                return;
            }

            decimal kmCarretera = nudKmCarretera.Value;
            decimal kmCiudad = nudKmCiudad.Value;
            decimal precioGalon = nudPrecioGalon.Value;
            decimal porcentajeGanancia = nudPorcentajeGanancia.Value;

            if (kmCarretera < 0 || kmCiudad < 0)
            {
                MostrarError("Los kilómetros del viaje no pueden ser negativos.");
                return;
            }

            if (kmCarretera + kmCiudad <= 0)
            {
                MostrarError("El viaje debe tener al menos 1 kilómetro (en carretera o en ciudad).");
                return;
            }

            if (precioGalon <= 0)
            {
                MostrarError("El precio del galón de gasolina debe ser mayor que cero.");
                return;
            }

            _ultimoVehiculoCalculado = vehiculo;
            _ultimoKmCarretera = kmCarretera;
            _ultimoKmCiudad = kmCiudad;
            _ultimoPrecioGalon = precioGalon;
            _ultimoPorcentajeGanancia = porcentajeGanancia;
            _ultimoResultado = CalculadoraCostos.Calcular(
                vehiculo, kmCarretera, kmCiudad, precioGalon, porcentajeGanancia);

            txtResultado.Text = ConstruirReporte(vehiculo, kmCarretera, kmCiudad, _ultimoResultado);
            btnFactura.Enabled = true;
        }

        private void btnFactura_Click(object? sender, EventArgs e)
        {
            if (_ultimoVehiculoCalculado is null || _ultimoResultado is null)
            {
                MostrarError("Primero debe calcular el viaje para poder generar la factura.");
                return;
            }

            using (SaveFileDialog dialogo = new SaveFileDialog())
            {
                dialogo.Title = "Guardar factura como PDF";
                dialogo.Filter = "Documentos PDF (*.pdf)|*.pdf";
                dialogo.FileName =
                    $"Factura_{_ultimoVehiculoCalculado.Marca}_{_ultimoVehiculoCalculado.Modelo}_" +
                    $"{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (dialogo.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    GeneradorFacturaPdf.Generar(
                        dialogo.FileName,
                        _ultimoVehiculoCalculado,
                        _ultimoKmCarretera,
                        _ultimoKmCiudad,
                        _ultimoPrecioGalon,
                        _ultimoResultado);

                    MessageBox.Show(
                        "Factura generada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo(dialogo.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "No se pudo generar la factura: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatosVehiculo(out Vehiculo? vehiculo)
        {
            vehiculo = null;

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MostrarError("Debe escribir la marca del vehículo.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MostrarError("Debe escribir el modelo del vehículo.");
                return false;
            }

            if (nudKmUltimoAnio.Value <= 0)
            {
                MostrarError("Los kilómetros recorridos en el último año deben ser mayores que cero.");
                return false;
            }

            if (nudKmDuracionGomas.Value <= 0)
            {
                MostrarError("La duración del juego de gomas debe ser mayor que cero.");
                return false;
            }

            if (nudKmIntervaloMantenimiento.Value <= 0)
            {
                MostrarError("El intervalo de mantenimiento debe ser mayor que cero.");
                return false;
            }

            if (nudKmGalonCarretera.Value <= 0 || nudKmGalonCiudad.Value <= 0)
            {
                MostrarError("Los rendimientos en carretera y en ciudad deben ser mayores que cero.");
                return false;
            }

            vehiculo = new Vehiculo
            {
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Anio = (int)nudAnio.Value,
                ValorComercialActual = nudValorComercial.Value,
                ValorHaceUnAnio = nudValorHaceUnAnio.Value,
                KmRecorridosUltimoAnio = nudKmUltimoAnio.Value,
                PrimaSeguroAnual = nudPrimaSeguro.Value,
                PorcentajeRiesgo = nudPorcentajeRiesgo.Value,
                PrecioJuegoGomas = nudPrecioGomas.Value,
                KmDuracionGomas = nudKmDuracionGomas.Value,
                CostoMantenimiento = nudCostoMantenimiento.Value,
                KmIntervaloMantenimiento = nudKmIntervaloMantenimiento.Value,
                KmPorGalonCarretera = nudKmGalonCarretera.Value,
                KmPorGalonCiudad = nudKmGalonCiudad.Value,
                CostoLimpiezaPorEntrega = nudCostoLimpieza.Value,
                DepositoGarantia = nudDepositoGarantia.Value
            };

            return true;
        }

        private void LimpiarFormularioVehiculo()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            nudAnio.Value = 2020;

            ReiniciarNumericUpDown(nudValorComercial, 0);
            ReiniciarNumericUpDown(nudValorHaceUnAnio, 0);
            ReiniciarNumericUpDown(nudPrimaSeguro, 0);
            ReiniciarNumericUpDown(nudPorcentajeRiesgo, 0);
            ReiniciarNumericUpDown(nudPrecioGomas, 0);
            ReiniciarNumericUpDown(nudKmUltimoAnio, 1);
            ReiniciarNumericUpDown(nudKmDuracionGomas, 1);
            ReiniciarNumericUpDown(nudCostoMantenimiento, 0);
            ReiniciarNumericUpDown(nudKmIntervaloMantenimiento, 1);
            ReiniciarNumericUpDown(nudKmGalonCarretera, 1);
            ReiniciarNumericUpDown(nudKmGalonCiudad, 1);
            ReiniciarNumericUpDown(nudCostoLimpieza, 0);
            ReiniciarNumericUpDown(nudDepositoGarantia, 0);

            txtMarca.Focus();
        }

        private void RefrescarListaVehiculos()
        {
            List<Vehiculo> vehiculos = _repositorioVehiculos.ObtenerTodos();

            lstVehiculos.Items.Clear();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                ListViewItem item = new ListViewItem(vehiculo.Marca);
                item.SubItems.Add(vehiculo.Modelo);
                item.SubItems.Add(vehiculo.Anio.ToString());
                item.SubItems.Add(vehiculo.Descripcion);
                item.Tag = vehiculo;
                lstVehiculos.Items.Add(item);
            }

            Vehiculo? seleccionado = cmbVehiculo.SelectedItem as Vehiculo;
            cmbVehiculo.Items.Clear();
            cmbVehiculo.Items.AddRange(vehiculos.ToArray());

            if (seleccionado is not null)
            {
                for (int i = 0; i < cmbVehiculo.Items.Count; i++)
                {
                    if (cmbVehiculo.Items[i] is Vehiculo vehiculoActual && vehiculoActual.Id == seleccionado.Id)
                    {
                        cmbVehiculo.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private static void ReiniciarNumericUpDown(NumericUpDown control, decimal valorPorDefecto)
        {
            control.Value = Math.Max(valorPorDefecto, control.Minimum);
        }

        private string ConstruirReporte(
            Vehiculo vehiculo,
            decimal kmCarretera,
            decimal kmCiudad,
            ResultadoCalculo r)
        {
            var sb = new StringBuilder();

            sb.AppendLine("Vehículo seleccionado: " + vehiculo.Descripcion);
            sb.AppendLine();
            sb.AppendLine("=== COSTOS POR KILÓMETRO (datos del último año) ===");
            sb.AppendLine(ConstruirLinea("Depreciación por km:", Moneda(r.DepreciacionPorKm)));
            sb.AppendLine(ConstruirLinea("Seguro por km:", Moneda(r.SeguroPorKm)));
            sb.AppendLine(ConstruirLinea("Imprevistos por km:", Moneda(r.ImprevistosPorKm)));
            sb.AppendLine(ConstruirLinea("Gomas por km:", Moneda(r.GomasPorKm)));
            sb.AppendLine(ConstruirLinea("Mantenimiento por km:", Moneda(r.MantenimientoPorKm)));
            sb.AppendLine(ConstruirLinea("Gasolina por km:", Moneda(r.GasolinaPorKm)));
            sb.AppendLine();
            sb.AppendLine(ConstruirLinea("COSTO FIJO POR KM (total):", Moneda(r.CostoFijoPorKm)));
            sb.AppendLine();
            sb.AppendLine("=== DESGLOSE DEL VIAJE ===");
            sb.AppendLine(ConstruirLinea("Km en carretera:", Numero(kmCarretera)));
            sb.AppendLine(ConstruirLinea("Km en ciudad:", Numero(kmCiudad)));
            sb.AppendLine(ConstruirLinea("Km totales del viaje:", Numero(r.KmTotalesViaje)));
            sb.AppendLine(ConstruirLinea("Gasolina del viaje:", Moneda(r.GasolinaViaje)));
            sb.AppendLine(ConstruirLinea("Costo de limpieza:", Moneda(r.CostoLimpieza)));
            sb.AppendLine(ConstruirLinea("Costo del viaje (sin ganancia):", Moneda(r.CostoViaje)));
            sb.AppendLine(ConstruirLinea(
                $"Precio final (con {Numero(r.PorcentajeGanancia)}% de ganancia):",
                Moneda(r.PrecioFinal)));
            sb.AppendLine();
            sb.AppendLine("=== GARANTÍA ===");
            sb.AppendLine(
                ConstruirLinea("Depósito de garantía:", Moneda(r.DepositoGarantia)) +
                " (es reembolsable; NO forma parte del costo del viaje)");

            return sb.ToString();
        }

        private static string ConstruirLinea(string etiqueta, string valor)
        {
            return etiqueta.PadRight(AnchoEtiqueta) + valor;
        }

        private static string Moneda(decimal monto)
        {
            return "RD$ " + monto.ToString("N2", CultureInfo.InvariantCulture);
        }

        private static string Numero(decimal valor)
        {
            return valor.ToString("N2", CultureInfo.InvariantCulture);
        }

        private static void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}