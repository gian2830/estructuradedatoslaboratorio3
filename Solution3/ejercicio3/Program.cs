class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese los números
        Console.WriteLine("Ingrese una lista de números separados por espacios:");
        string input = Console.ReadLine();

        // Convertir la entrada en un conjunto de números
        HashSet<int> numbers = new HashSet<int>();
        string[] tokens = input.Split(' ');
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                numbers.Add(number);
            }
        }

        // Solicitar al usuario que ingrese el divisor
        Console.WriteLine("Ingrese el número por el cual deben ser divisibles:");
        int divisor = int.Parse(Console.ReadLine());

        // Obtener los números que son divisibles por el divisor especificado
        HashSet<int> divisibleNumbers = GetNumbersDivisibleBy(numbers, divisor);

        // Mostrar los números divisibles
        Console.WriteLine($"Números que son divisibles por {divisor}:");
        foreach (int number in divisibleNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static HashSet<int> GetNumbersDivisibleBy(HashSet<int> numbers, int divisor)
    {
        HashSet<int> divisibleNumbers = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (number % divisor == 0)
            {
                divisibleNumbers.Add(number);
            }
        }

        return divisibleNumbers;
    }
}