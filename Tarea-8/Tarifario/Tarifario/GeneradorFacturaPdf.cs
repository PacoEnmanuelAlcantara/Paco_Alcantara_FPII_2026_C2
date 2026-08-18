using System.Globalization;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Tarifario
{
    public static class GeneradorFacturaPdf
    {
        public static void Generar(
            string rutaArchivo,
            Vehiculo vehiculo,
            decimal kmCarretera,
            decimal kmCiudad,
            decimal precioGalon,
            ResultadoCalculo r)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(contenedor =>
            {
                contenedor.Page(pagina =>
                {
                    pagina.Size(PageSizes.A4);
                    pagina.Margin(40);
                    pagina.DefaultTextStyle(estilo => estilo.FontSize(11));

                    pagina.Header().Column(cabecera =>
                    {
                        cabecera.Spacing(2);
                        cabecera.Item().Text("TARIFARIO")
                            .FontSize(22).Bold().FontColor(Colors.Blue.Darken3);
                        cabecera.Item().Text("Factura — Cotización de viaje")
                            .FontSize(13).FontColor(Colors.Grey.Darken1);
                        cabecera.Item().Text("Fecha de emisión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                            .FontSize(10).FontColor(Colors.Grey.Darken1);
                    });

                    pagina.Content().PaddingVertical(16).Column(contenido =>
                    {
                        contenido.Spacing(10);

                        contenido.Item().Text("Vehículo: " + vehiculo.Descripcion)
                            .FontSize(14).Bold();

                        contenido.Item().Text("DATOS DEL VIAJE")
                            .FontSize(11).Bold().FontColor(Colors.Blue.Darken2);
                        contenido.Item().Table(tabla => TablaDatosDelViaje(tabla, kmCarretera, kmCiudad, precioGalon, r));

                        contenido.Item().Text("COSTOS POR KILÓMETRO (datos del último año)")
                            .FontSize(11).Bold().FontColor(Colors.Blue.Darken2);
                        contenido.Item().Table(tabla => TablaCostosPorKm(tabla, r));

                        contenido.Item().Text("DESGLOSE DEL VIAJE")
                            .FontSize(11).Bold().FontColor(Colors.Blue.Darken2);
                        contenido.Item().Table(tabla => TablaDesglose(tabla, r));
                    });

                    pagina.Footer().AlignCenter()
                        .Text("Documento generado por Tarifario")
                        .FontSize(9).FontColor(Colors.Grey.Darken2);
                });
            }).GeneratePdf(rutaArchivo);
        }

        private static void TablaDatosDelViaje(
            TableDescriptor tabla,
            decimal kmCarretera,
            decimal kmCiudad,
            decimal precioGalon,
            ResultadoCalculo r)
        {
            ConfigurarTabla(tabla);
            Fila(tabla, "Km en carretera", Numero(kmCarretera) + " km");
            Fila(tabla, "Km en ciudad", Numero(kmCiudad) + " km");
            Fila(tabla, "Km totales del viaje", Numero(r.KmTotalesViaje) + " km");
            Fila(tabla, "Precio del galón de gasolina", Moneda(precioGalon));
        }

        private static void TablaCostosPorKm(TableDescriptor tabla, ResultadoCalculo r)
        {
            ConfigurarTabla(tabla);
            Fila(tabla, "Depreciación por km", Moneda(r.DepreciacionPorKm));
            Fila(tabla, "Seguro por km", Moneda(r.SeguroPorKm));
            Fila(tabla, "Imprevistos por km", Moneda(r.ImprevistosPorKm));
            Fila(tabla, "Gomas por km", Moneda(r.GomasPorKm));
            Fila(tabla, "Mantenimiento por km", Moneda(r.MantenimientoPorKm));
            Fila(tabla, "Gasolina por km", Moneda(r.GasolinaPorKm));
            FilaTotal(tabla, "COSTO FIJO POR KM (total)", Moneda(r.CostoFijoPorKm));
        }

        private static void TablaDesglose(TableDescriptor tabla, ResultadoCalculo r)
        {
            ConfigurarTabla(tabla);
            Fila(tabla, "Gasolina del viaje", Moneda(r.GasolinaViaje));
            Fila(tabla, "Costo de limpieza", Moneda(r.CostoLimpieza));
            Fila(tabla, "Costo del viaje (sin ganancia)", Moneda(r.CostoViaje));
            FilaPrecioFinal(tabla, "PRECIO FINAL", Moneda(r.PrecioFinal));
            Fila(tabla,
                "Depósito de garantía (reembolsable, no forma parte del costo del viaje)",
                Moneda(r.DepositoGarantia));
        }

        private static void ConfigurarTabla(TableDescriptor tabla)
        {
            tabla.ColumnsDefinition(columnas =>
            {
                columnas.RelativeColumn(3);
                columnas.RelativeColumn(2);
            });
            tabla.Header(cabecera =>
            {
                cabecera.Cell().Element(CeldaCabecera).Text("Concepto")
                    .FontSize(10).Bold().FontColor(Colors.White);
                cabecera.Cell().Element(CeldaCabecera).Text("Valor")
                    .FontSize(10).Bold().FontColor(Colors.White).AlignRight();
            });
        }

        private static void Fila(TableDescriptor tabla, string concepto, string valor)
        {
            tabla.Cell().Element(CeldaBase).Text(concepto).FontSize(10);
            tabla.Cell().Element(CeldaBase).AlignRight().Text(valor).FontSize(10);
        }

        private static void FilaTotal(TableDescriptor tabla, string concepto, string valor)
        {
            tabla.Cell().Element(CeldaTotal).Text(concepto).FontSize(11).Bold();
            tabla.Cell().Element(CeldaTotal).AlignRight().Text(valor).FontSize(11).Bold();
        }

        private static void FilaPrecioFinal(TableDescriptor tabla, string concepto, string valor)
        {
            tabla.Cell().Element(CeldaPrecioFinal).Text(concepto)
                .FontSize(13).Bold().FontColor(Colors.Blue.Darken3);
            tabla.Cell().Element(CeldaPrecioFinal).AlignRight().Text(valor)
                .FontSize(13).Bold().FontColor(Colors.Blue.Darken3);
        }

        private static IContainer CeldaCabecera(IContainer contenedor)
        {
            return contenedor
                .Background(Colors.Blue.Darken3)
                .PaddingVertical(6)
                .PaddingHorizontal(4);
        }

        private static IContainer CeldaBase(IContainer contenedor)
        {
            return contenedor
                .BorderBottom(0.5f)
                .BorderColor(Colors.Grey.Lighten2)
                .PaddingVertical(5)
                .PaddingHorizontal(4);
        }

        private static IContainer CeldaTotal(IContainer contenedor)
        {
            return contenedor
                .Background(Colors.Blue.Lighten4)
                .BorderTop(1f)
                .BorderColor(Colors.Blue.Lighten2)
                .PaddingVertical(5)
                .PaddingHorizontal(4);
        }

        private static IContainer CeldaPrecioFinal(IContainer contenedor)
        {
            return contenedor
                .Background(Colors.Blue.Lighten3)
                .BorderTop(1.5f)
                .BorderColor(Colors.Blue.Darken2)
                .PaddingVertical(7)
                .PaddingHorizontal(4);
        }

        private static string Moneda(decimal monto)
        {
            return "RD$ " + monto.ToString("N2", CultureInfo.InvariantCulture);
        }

        private static string Numero(decimal valor)
        {
            return valor.ToString("N2", CultureInfo.InvariantCulture);
        }
    }
}