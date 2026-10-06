namespace Colmado;

public static class Pruebas
{
    private static readonly List<Linea> Compra = new()
    {
        new("Arroz 10 lb", 2, 425m),
        new("Aceite 1 gal", 1, 690m),
    };

    public static int Ejecutar()
    {
        var casos = new List<(string Nombre, bool Paso)>
        {
            ("El subtotal suma cantidad por precio", Precios.Subtotal(Compra) == 1540m),
            ("El ITBIS es el 18 % del subtotal", Precios.Impuesto(100m) == 18m),
            ("El resumen muestra el total", Reporte.Resumen(Compra).Contains("Total")),
            ("Descuento del 10 % en compras grandes", Precios.Descuento(Precios.MontoMinimoDescuento) == 150m),
            ("Sin descuento en compras pequeñas", Precios.Descuento(100m) == 0m),
            ("Envío de 150 por debajo de 3000", Precios.CargoEnvio(100m) == 150m),
            ("Envío gratis desde 3000", Precios.CargoEnvio(3000m) == 0m),
            ("El resumen con envío muestra el envío", Reporte.ResumenConEnvio(Compra).Contains("Envío")),
        };

        int fallas = 0;
        foreach (var (nombre, paso) in casos)
        {
            Console.WriteLine($"{(paso ? "OK   " : "FALLA")} {nombre}");
            if (!paso) fallas++;
        }
        Console.WriteLine(fallas == 0 ? "Todas las pruebas pasan." : $"{fallas} prueba(s) fallan.");
        return fallas == 0 ? 0 : 1;
    }
}
