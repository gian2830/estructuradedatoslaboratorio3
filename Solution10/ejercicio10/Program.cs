class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de palabras
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        HashSet<string> words = new HashSet<string>(input.Split(' '));

        // Solicitar al usuario que ingrese la letra deseada
        Console.WriteLine("Ingrese la letra que desea buscar en las palabras:");
        char letter = Console.ReadLine()[0]; // Tomar solo el primer carácter

        // Obtener las palabras que contienen la letra especificada
        HashSet<string> wordsWithLetter = GetWordsWithLetter(words, letter);

        // Mostrar las palabras que contienen la letra especificada
        Console.WriteLine($"Palabras que contienen la letra '{letter}':");
        foreach (string word in wordsWithLetter)
        {
            Console.WriteLine(word);
        }
    }

    static HashSet<string> GetWordsWithLetter(HashSet<string> words, char letter)
    {
        HashSet<string> wordsWithLetter = new HashSet<string>();

        foreach (string word in words)
        {
            if (word.Contains(letter))
            {
                wordsWithLetter.Add(word);
            }
        }

        return wordsWithLetter;
    }
}