namespace Colmado;

public record Linea(string Producto, int Cantidad, decimal PrecioUnitario)
{
    public int Cantidad { get; init; } = Cantidad > 0 ? Cantidad : throw new ArgumentException("La cantidad debe ser mayor que cero.");
}
