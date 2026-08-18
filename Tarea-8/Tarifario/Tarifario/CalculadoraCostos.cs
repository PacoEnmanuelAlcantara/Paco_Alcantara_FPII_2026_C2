namespace Tarifario
{
    public class ResultadoCalculo
    {
        public decimal DepreciacionPorKm { get; set; }
        public decimal SeguroPorKm { get; set; }
        public decimal ImprevistosPorKm { get; set; }
        public decimal GomasPorKm { get; set; }
        public decimal MantenimientoPorKm { get; set; }
        public decimal CostoFijoPorKm { get; set; }

        public decimal GasolinaPorKm { get; set; }
        public decimal GasolinaViaje { get; set; }

        public decimal KmTotalesViaje { get; set; }
        public decimal CostoLimpieza { get; set; }
        public decimal CostoViaje { get; set; }
        public decimal PrecioFinal { get; set; }
        public decimal PorcentajeGanancia { get; set; }
        public decimal DepositoGarantia { get; set; }
    }

    public static class CalculadoraCostos
    {
        public static ResultadoCalculo Calcular(
            Vehiculo vehiculo,
            decimal kmCarretera,
            decimal kmCiudad,
            decimal precioGalon,
            decimal porcentajeGanancia)
        {
            decimal depreciacionPorKm = (vehiculo.ValorHaceUnAnio - vehiculo.ValorComercialActual) / vehiculo.KmRecorridosUltimoAnio;
            decimal seguroPorKm = vehiculo.PrimaSeguroAnual / vehiculo.KmRecorridosUltimoAnio;
            decimal imprevistosPorKm = (vehiculo.ValorComercialActual * vehiculo.PorcentajeRiesgo / 100m) / vehiculo.KmRecorridosUltimoAnio;
            decimal gomasPorKm = vehiculo.PrecioJuegoGomas / vehiculo.KmDuracionGomas;
            decimal mantenimientoPorKm = vehiculo.CostoMantenimiento / vehiculo.KmIntervaloMantenimiento;

            decimal costoFijoPorKm = depreciacionPorKm + seguroPorKm + imprevistosPorKm + gomasPorKm + mantenimientoPorKm;

            decimal kmTotalesViaje = kmCarretera + kmCiudad;
            decimal gasolinaViaje = (kmCarretera / vehiculo.KmPorGalonCarretera + kmCiudad / vehiculo.KmPorGalonCiudad) * precioGalon;
            decimal gasolinaPorKm = kmTotalesViaje > 0 ? gasolinaViaje / kmTotalesViaje : 0m;

            decimal costoLimpieza = vehiculo.CostoLimpiezaPorEntrega;
            decimal costoViaje = (costoFijoPorKm * kmTotalesViaje) + gasolinaViaje + costoLimpieza;
            decimal precioFinal = costoViaje * (1m + porcentajeGanancia / 100m);

            return new ResultadoCalculo
            {
                DepreciacionPorKm = depreciacionPorKm,
                SeguroPorKm = seguroPorKm,
                ImprevistosPorKm = imprevistosPorKm,
                GomasPorKm = gomasPorKm,
                MantenimientoPorKm = mantenimientoPorKm,
                CostoFijoPorKm = costoFijoPorKm,
                GasolinaPorKm = gasolinaPorKm,
                GasolinaViaje = gasolinaViaje,
                KmTotalesViaje = kmTotalesViaje,
                CostoLimpieza = costoLimpieza,
                CostoViaje = costoViaje,
                PrecioFinal = precioFinal,
                PorcentajeGanancia = porcentajeGanancia,
                DepositoGarantia = vehiculo.DepositoGarantia
            };
        }
    }
}