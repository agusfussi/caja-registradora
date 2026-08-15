//Etapa 6
int cantidadProducto = 0;
decimal total = 0;
string opcion;
string opcionPago;
const decimal descuentoDelDiez = 0.1m;
const decimal descuentoDelCinco = 0.05m;
decimal descuento = 0;
decimal recargo = 0;
do
{
    Console.WriteLine("¿Que desea hacer?");
    Console.WriteLine("1. Ingresar un producto");
    Console.WriteLine("2.Cerrar la ventana");
    Console.Write("Ingrese una opción: ");

    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese el nombre de un producto: ");
            string NombreProducto = Console.ReadLine();
            Console.Write("Escribe el precio del producto: ");
            string PrecioProducto = Console.ReadLine();
            Decimal precio = Convert.ToDecimal(PrecioProducto);

            Console.WriteLine($"El precio de {NombreProducto} es: {precio}");

            total += precio;
            cantidadProducto++;

            break;
        case "2":
            Console.WriteLine("Cerrando la ventana...");
            break;
        default:
            Console.WriteLine("No reconocido.");
            break;
    }
} while (opcion != "2");
Console.WriteLine($"Cantidad de productos: {cantidadProducto}");
if (total > 50000)
{
    descuento = total * descuentoDelDiez;
    total -= descuento;
}
else if (total > 20000)
{
    descuento = total * descuentoDelCinco;
    total -= descuento;
}
do
{
    Console.WriteLine("Medio de pago: ");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Debito");
    Console.WriteLine("3 - Credito");
    Console.Write("Ingrese una opción: ");

    opcionPago = Console.ReadLine();
    switch (opcionPago)
    {
        case "1":
            descuento = total * 0.1m;
            total -= descuento;
            break;
        case "2":
            break;
        case "3":
            recargo = total * 0.15m;
            total += recargo;
            break;
        default:
            Console.WriteLine("Opción no reconocida.");
            break;
    }
} while (opcionPago != "1" && opcionPago != "2" && opcionPago != "3");
for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}

Console.WriteLine();
Console.WriteLine("       KIOSCO EL RECREO");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}

Console.WriteLine();
Console.WriteLine($"Cajero: Juan Perez");
Console.WriteLine($"Productos: {cantidadProducto}");
Console.WriteLine($"Subtotal: {total}");
Console.WriteLine($"Descuento: {descuento}");
Console.WriteLine($"Recargo: {recargo}");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}

Console.WriteLine();
Console.WriteLine($"TOTAL: {total}");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}

Console.ReadKey();