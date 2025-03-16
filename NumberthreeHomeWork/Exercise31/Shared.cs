namespace Shared
{
    public static class ConsoleExtension
    {
        public static string GetValidOptions(string prompt, List<string> validOptions)
        {
            string answer;
            do
            {
                Console.Write(prompt);
                answer = Console.ReadLine();
            } while (!validOptions.Contains(answer!, StringComparer.CurrentCultureIgnoreCase));

            return answer!;
        }

        public static int GetInt(string message)
        {
            int numberInt = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(message);
                var numberString = Console.ReadLine();
                isValid = int.TryParse(numberString, out numberInt) && numberInt >= 0;

                if (!isValid)
                {
                    Console.WriteLine("Valor no válido. Por favor, ingresa un número entero mayor que cero.");
                }
            }

            return numberInt;
        }
    }
}
    
