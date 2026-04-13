// See https://aka.ms/new-console-template for more information
double nota;
bool esNumero;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese nota:");
    esNumero = double.TryParse(Console.ReadLine(), out nota);

    if (!esNumero)
    {
        Console.WriteLine("Debe ingresar número");
        Console.ReadKey();
    }
    else if (nota < 0 || nota > 100)
    {
        Console.WriteLine("Fuera de rango");
        Console.ReadKey();

    }

} while (!esNumero || nota < 0 || nota > 100);

if (nota >= 60)
{
    Console.WriteLine("Aprobado");

}
else
{
    Console.WriteLine("Reprobado");
}
