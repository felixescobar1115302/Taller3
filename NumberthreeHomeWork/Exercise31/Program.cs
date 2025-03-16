using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    // 34 RELOJ DE ARENA
    int n = ConsoleExtension.GetInt("Ingrese orden de la matriz (N, debe ser impar): ");

    while (n % 2 == 0)
    {
        Console.WriteLine("El tamaño debe ser un número impar. Por favor, intente nuevamente.");
        n = ConsoleExtension.GetInt("Ingrese orden de la matriz (N, debe ser impar): ");
    }

    int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
           for (int j = 0; j < n; j++)
             {
              matrix[i, j] = (i * 2) + j;  
             }
        }

        Console.WriteLine("\nMATRIZ COMPLETA:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nRELOJ DE ARENA:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i <= j && i + j < n || i >= j && i + j >= n - 1)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                else
                {
                    Console.Write("   "); 
                }
            }
            Console.WriteLine();
        }
    do
    {
        answer = ConsoleExtension.GetValidOptions("\n¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));