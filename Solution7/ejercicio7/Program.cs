class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un conjunto de palabras
        Console.WriteLine("Ingrese un conjunto de palabras separadas por espacios:");
        string input = Console.ReadLine();
        HashSet<string> words = new HashSet<string>(input.Split(' '));

        // Obtener las palabras que son anagramas
        HashSet<string> anagrams = GetAnagrams(words);

        // Mostrar las palabras que son anagramas
        Console.WriteLine("Palabras que son anagramas:");
        foreach (string word in anagrams)
        {
            Console.WriteLine(word);
        }
    }

    static HashSet<string> GetAnagrams(HashSet<string> words)
    {
        // Crear un diccionario para agrupar las palabras por su versión ordenada
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        foreach (string word in words)
        {
            // Ordenar las letras de la palabra
            string sortedWord = new string(word.OrderBy(c => c).ToArray());

            // Agrupar las palabras en el diccionario
            if (!groups.ContainsKey(sortedWord))
            {
                groups[sortedWord] = new List<string>();
            }
            groups[sortedWord].Add(word);
        }

        // Filtrar los grupos que contienen más de una palabra
        HashSet<string> anagrams = new HashSet<string>();
        foreach (var group in groups.Values)
        {
            if (group.Count > 1)
            {
                foreach (string word in group)
                {
                    anagrams.Add(word);
                }
            }
        }

        return anagrams;
    }
}