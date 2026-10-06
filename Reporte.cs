namespace Colmado;

public static class Reporte
{
    public static string Resumen(List<Linea> lineas)
    {
        var subtotal = Precios.Subtotal(lineas);
        var impuesto = Precios.Impuesto(subtotal);
        return $"Subtotal: {subtotal:N2} | ITBIS: {impuesto:N2} | Total: {subtotal + impuesto:N2}";
    }
}
