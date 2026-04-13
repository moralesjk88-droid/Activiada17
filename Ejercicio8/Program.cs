// See https://aka.ms/new-console-template for more information
double num;
bool esNumero;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese número:");
    esNumero = double.TryParse(Console.ReadLine(), out num);

    if (!esNumero)
    {
        Console.WriteLine("Debe ingresar número");
        Console.ReadKey();
    }
    else if (num < 0)
    {
        Console.WriteLine("No puede ser negativo");
Console.ReadKey();
    }

} while (!esNumero || num < 0);

Console.WriteLine("Raíz: " + Math.Sqrt(num));