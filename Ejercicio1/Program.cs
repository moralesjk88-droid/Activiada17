// See https://aka.ms/new-console-template for more information


int edad;
do
{
 Console.Clear();
Console.WriteLine("ingrese su edad");

    if (int.TryParse(Console.ReadLine(), out edad))
    {
        if (edad < 0|| edad>100)
        { 
            Console.WriteLine("Edad no valida");
          Console.ReadKey();
        }
        else
        {
             Console.WriteLine("Edad aguardada");
        Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("EDAD NO PERMITIDA");
    }

} while (edad<0||edad>100);




