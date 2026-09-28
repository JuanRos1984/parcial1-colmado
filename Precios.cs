namespace Colmado;

public static class Precios
{
    public const decimal MontoMinimoDescuento = 1000m;

    public const decimal Itbis = 0.18m;

    // Suma cantidad por precio unitario de cada línea.
    public static decimal CalcularSubtotal(IEnumerable<Linea> lineas) =>
        lineas.Sum(l => l.Cantidad * l.PrecioUnitario);

    public static decimal Impuesto(decimal subtotal) =>
        Math.Round(subtotal * Itbis, 2);
}
