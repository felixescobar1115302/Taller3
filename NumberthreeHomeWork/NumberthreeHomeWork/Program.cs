
using Shared;

        var answer = string.Empty;
        var options = new List<string> { "s", "n" };

        do
        { 
        // 31 TRIANGULAR INFERIOR DE UNA MATRIZ 
        int n = ConsoleExtension.GetInt("Ingrese orden de la matriz : ");

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = i + j;
            }
        }

        Console.WriteLine("\nMatriz completa:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nTriangular inferior:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        do
            {
                answer = ConsoleExtension.GetValidOptions("\n¿Deseas continuar [S]í, [N]o?: ", options);
            } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

        } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;
