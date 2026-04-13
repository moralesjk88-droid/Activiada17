// See https://aka.ms/new-console-template for more information
int cantidad;
bool esNumero;

do
{
    Console.Clear();
    Console.WriteLine("Cantidad de productos:");
    esNumero = int.TryParse(Console.ReadLine(), out cantidad);

    if (!esNumero)
    {
        Console.WriteLine("Debe ingresar número");
        Console.ReadKey();

    }
    else if (cantidad <= 0)
    {
        Console.WriteLine("Debe ser positivo");
        Console.ReadKey();
    }

} while (!esNumero || cantidad <= 0);

for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine("Producto " + i);
}


