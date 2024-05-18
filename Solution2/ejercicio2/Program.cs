class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese las palabras
        Console.WriteLine("Ingrese una lista de palabras separadas por espacios:");
        string input = Console.ReadLine();

        // Convertir la entrada en un conjunto de palabras
        HashSet<string> words = new HashSet<string>(input.Split(' '));

        // Solicitar al usuario que ingrese la letra
        Console.WriteLine("Ingrese la letra por la que deben comenzar las palabras:");
        char letter = Console.ReadLine()[0];

        // Obtener las palabras que comienzan con la letra especificada
        HashSet<string> filteredWords = GetWordsStartingWith(words, letter);

        // Mostrar las palabras filtradas
        Console.WriteLine($"Palabras que comienzan con '{letter}':");
        foreach (string word in filteredWords)
        {
            Console.WriteLine(word);
        }
    }

    static HashSet<string> GetWordsStartingWith(HashSet<string> words, char letter)
    {
        HashSet<string> filteredWords = new HashSet<string>();

        foreach (string word in words)
        {
            if (word.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                filteredWords.Add(word);
            }
        }

        return filteredWords;
    }
}