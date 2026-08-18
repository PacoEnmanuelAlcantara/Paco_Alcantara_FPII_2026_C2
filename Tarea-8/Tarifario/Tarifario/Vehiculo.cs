using LiteDB;

namespace Tarifario
{
    public class Vehiculo
    {
        [BsonId]
        public int Id { get; set; }

        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Anio { get; set; }

        public decimal ValorComercialActual { get; set; }
        public decimal ValorHaceUnAnio { get; set; }
        public decimal KmRecorridosUltimoAnio { get; set; }
        public decimal PrimaSeguroAnual { get; set; }

        public decimal PorcentajeRiesgo { get; set; }

        public decimal PrecioJuegoGomas { get; set; }
        public decimal KmDuracionGomas { get; set; }

        public decimal CostoMantenimiento { get; set; }
        public decimal KmIntervaloMantenimiento { get; set; }

        public decimal KmPorGalonCarretera { get; set; }
        public decimal KmPorGalonCiudad { get; set; }

        public decimal CostoLimpiezaPorEntrega { get; set; }
        public decimal DepositoGarantia { get; set; }

        public string Descripcion => $"{Marca} {Modelo} ({Anio})";

        public override string ToString() => Descripcion;
    }
}