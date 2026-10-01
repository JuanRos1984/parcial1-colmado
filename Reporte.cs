namespace Colmado;

public static class Reporte
{
    public static string Resumen(List<Linea> lineas)
    {
        var subtotal = Precios.Subtotal(lineas);
        var impuesto = Precios.Impuesto(subtotal);
        return $"Subtotal: {subtotal:N2} | ITBIS: {impuesto:N2} | Total: {subtotal + impuesto:N2}";
    }

    public static string ResumenConEnvio(List<Linea> lineas)
    {
        var subtotal = Precios.Subtotal(lineas);
        return $"{Resumen(lineas)} | Envío: {Precios.CargoEnvio(subtotal):N2}";
    }
}