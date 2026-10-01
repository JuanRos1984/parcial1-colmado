namespace Colmado;

public static class Precios
{
    public const decimal MontoMinimoDescuento = 500m;

    public const decimal Itbis = 0.18m;

    // Suma cantidad por precio unitario de cada línea.
    public static decimal CalcularSubtotal(IEnumerable<Linea> lineas) =>
        lineas.Sum(l => l.Cantidad * l.PrecioUnitario);

    public static decimal Impuesto(decimal subtotal) =>
        Math.Round(subtotal * Itbis, 2);

    public static decimal CargoEnvio(decimal subtotal) =>
        subtotal >= 3000m ? 0m : 150m;
}
