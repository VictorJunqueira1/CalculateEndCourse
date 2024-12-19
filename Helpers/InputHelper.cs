namespace CalculateEndCourse.Helpers
{
    public static class InputHelper
    {
        public static int GetValidNumber(string message, int minValue, int maxValue = int.MaxValue)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int number) && number >= minValue && number <= maxValue)
                {
                    return number;
                }

                Console.WriteLine($"Por favor, insira um número válido entre {minValue} e {maxValue}.");
            }
        }

        public static string GetValidString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                Console.WriteLine("Por favor, insira um texto válido.");
            }
        }
    }
}