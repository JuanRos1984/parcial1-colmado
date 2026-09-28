using System.Globalization;
using Colmado;

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

if (args.Contains("pruebas"))
    return Pruebas.Ejecutar();

var compra = new List<Linea> { new("Arroz 10 lb", 2, 425m), new("Aceite 1 gal", 1, 690m) };
Console.WriteLine(Reporte.Resumen(compra));
return 0;
