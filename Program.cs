double a, b, resultado;
string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Console.WriteLine("---Soma A+B ---\n");
        Console.WriteLine("digite os valores:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        resultado = a + b;
        Console.WriteLine($"{a} mais {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
    case "-":
        Console.WriteLine("---Subtração A-B ---\n");

        Console.WriteLine("digite os valores:");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        resultado = a - b;
        Console.WriteLine($"{a} menos {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
        case "*":
        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
    case "/":
        Console.WriteLine("--- Divisão A/B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());
        
        resultado = a / b;

        if (b == 0)
        {
            Console.WriteLine("não é possivel realizar a divisão");
        }
        else
        {
           resultado = a / b;
        }

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
        default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");
