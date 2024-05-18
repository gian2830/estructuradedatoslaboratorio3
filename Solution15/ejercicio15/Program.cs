class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de números separados por espacios
        Console.WriteLine("Ingrese un conjunto de números separados por espacios:");
        string input = Console.ReadLine();
        HashSet<int> numbers = new HashSet<int>(input.Split(' ').Select(int.Parse));

        // Obtener el conjunto de números primos ordenados de menor a mayor
        HashSet<int> primeNumbers = GetPrimeNumbers(numbers);

        // Mostrar el conjunto de números primos ordenados de menor a mayor
        Console.WriteLine("Conjunto de números primos ordenados de menor a mayor:");
        foreach (int number in primeNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static HashSet<int> GetPrimeNumbers(HashSet<int> numbers)
    {
        HashSet<int> primeNumbers = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (IsPrime(number))
            {
                primeNumbers.Add(number);
            }
        }

        // Ordenar los números primos de menor a mayor
        List<int> sortedPrimes = primeNumbers.ToList();
        sortedPrimes.Sort();
        primeNumbers = new HashSet<int>(sortedPrimes);

        return primeNumbers;
    }
}