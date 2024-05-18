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

        // Obtener los números primos del conjunto
        HashSet<int> primes = GetPrimes(numbers);

        // Mostrar los números primos
        Console.WriteLine("Números primos en el conjunto:");
        foreach (int prime in primes)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();
    }

    static HashSet<int> GetPrimes(HashSet<int> numbers)
    {
        HashSet<int> primes = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        return primes;
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}