Console.WriteLine("Reto 1: Fibonacci");
int Eleccion = 0;
int Nesimo = 0;
int Comprobar = 0;
int Cantidad = 0;
while (Eleccion != 4)
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("Menu");
        Console.WriteLine("");
        Console.WriteLine("1. Entregar n-ésimo número de Fibonacci");
        Console.WriteLine("2. Comprobar si un numero pertenece a la serie Fibonacci");
        Console.WriteLine("3. Mostrar determinada cantidad de numeros de la serie Fibonacci");
        Console.WriteLine("4. Salir");
        Console.WriteLine("");
        Console.Write("Ingrese opcion que desea revisar: ");
        Eleccion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (Eleccion)
        {   
            case 1:
                Console.WriteLine("1. Entregar n-ésimo número de Fibonacci");
                Console.Write("Ingrese n: ");
                Nesimo = int.Parse(Console.ReadLine());
                int[] Fibonacci = new int[Nesimo + 1];
                Fibonacci[0] = 0;
                Fibonacci[1] = 1;
                for (int i = 2; i <= Nesimo; i++)
                {
                    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
                }
                Console.WriteLine($"F{Nesimo} = {Fibonacci[Nesimo]}");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            case 2:
                Console.WriteLine("2. Comprobar si un numero pertenece a la serie Fibonacci");
                Console.Write("Ingrese el numero: ");
                Comprobar = int.Parse(Console.ReadLine());
                bool bander2=false;
                int[] Fibonacci2 = new int[3];
                Fibonacci2[0] = 0;
                Fibonacci2[1] = 1;
                int a = 2;
                while(bander2==false)
                {
                    Fibonacci2[2] = Fibonacci2[1] + Fibonacci2[0];
                    if (Comprobar == Fibonacci2[2])
                    {
                        bander2 = true;
                        Console.WriteLine($"El numero {Comprobar} pertenece a la serie Fibonacci");
                    } else if (Fibonacci2[2] > Comprobar)
                    {
                        bander2 = true;
                        Console.WriteLine($"El numero {Comprobar} no pertenece a la serie Fibonacci");
                    }
                    Fibonacci2[0] = Fibonacci2[1];
                    Fibonacci2[1] = Fibonacci2[2];
                    a++;
                }
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            case 3:
                Console.WriteLine("3. Mostrar determinada cantidad de numeros de la serie Fibonacci");
                Console.Write("Ingrese la cantidad de numeros de la serie Fibonacci que desea ver: ");
                Cantidad = int.Parse(Console.ReadLine());
                int[] Fibonacci3 = new int[Cantidad + 1];
                Fibonacci3[0] = 0;
                Fibonacci3[1] = 1;
                Console.WriteLine($"Los {Cantidad} primeros numeros de la serie Fibonacci son:");
                Console.Write($"{Fibonacci3[0]} ");
                Console.Write($"{Fibonacci3[1]} ");
                for (int i = 2; i <= Cantidad - 1; i++)
                {
                    Fibonacci3[i] = Fibonacci3[i - 1] + Fibonacci3[i - 2];
                    Console.Write($"{Fibonacci3[i]} ");
                }
                Console.WriteLine("");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            case 4:
                Console.WriteLine("Lo esperamos pronto");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            default:
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Valor incorrecto, ingrese un valor valido");
        Console.Write("Presione enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}