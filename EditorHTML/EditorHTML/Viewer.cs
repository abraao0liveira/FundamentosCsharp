using System.Text.RegularExpressions;

namespace EditorHTML;

public class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO VISUALIZADOR");
        Console.WriteLine("-----------------");
        Replace(text);
        Console.WriteLine("-----------------");
        Console.ReadKey();
        Menu.Show();
    }

    public static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>"); // substitu certas palavras.
        var words = text.Split(' '); // da um espaço.

        for (var i = 0; i < words.Length; i++)
        {
            if (strong.IsMatch(words[i])) // Se a palavra for em negrito.
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(words[i].Substring(words[i].IndexOf('>') + 1, (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')));
                Console.Write(" ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(words[i]);
                Console.Write(" ");
            }
        }
    }
}