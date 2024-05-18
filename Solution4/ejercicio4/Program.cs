class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese el primer conjunto de números
        Console.WriteLine("Ingrese el primer conjunto de números separados por espacios:");
        string input1 = Console.ReadLine();
        HashSet<int> set1 = ConvertInputToSet(input1);

        // Solicitar al usuario que ingrese el segundo conjunto de números
        Console.WriteLine("Ingrese el segundo conjunto de números separados por espacios:");
        string input2 = Console.ReadLine();
        HashSet<int> set2 = ConvertInputToSet(input2);

        // Obtener los números que están en ambos conjuntos
        HashSet<int> intersection = GetIntersection(set1, set2);

        // Mostrar los números de la intersección
        Console.WriteLine("Números que están en ambos conjuntos:");
        foreach (int number in intersection)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static HashSet<int> ConvertInputToSet(string input)
    {
        HashSet<int> set = new HashSet<int>();
        string[] tokens = input.Split(' ');
        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                set.Add(number);
            }
        }
        return set;
    }

    static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        return intersection;
    }
}