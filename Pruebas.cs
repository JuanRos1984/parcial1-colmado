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
            ("Descuento del 10 % en compras grandes", Precios.Descuento(20000m) == 2000m),
            ("Sin descuento en compras pequeñas", Precios.Descuento(100m) == 0m),
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
