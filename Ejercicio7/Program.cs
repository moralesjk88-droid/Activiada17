// See https://aka.ms/new-console-template for more information
double salario;
bool esNumero;

do
{
    Console.Clear();
    Console.WriteLine("Ingrese salario:");
    esNumero = double.TryParse(Console.ReadLine(), out salario);

    if (!esNumero)
    {
Console.WriteLine("Debe ingresar número");
        Console.ReadKey();
    }
        
    else if (salario < 0)
    {
Console.WriteLine("No puede ser negativo");
        Console.ReadKey();
    }
        
    else
    {
 Console.WriteLine("Salario válido");
        Console.ReadKey();
    }
       

} while (!esNumero || salario < 0);