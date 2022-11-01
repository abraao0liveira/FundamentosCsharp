using System.Runtime.CompilerServices;
using System.Text;

namespace EditorHTML;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-----------");
        Start();
    }
    public static void Start()
    {
        var file = new StringBuilder();
        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Spacebar);
        
        Console.WriteLine("-----------");
        Console.WriteLine(" Deseja salvar? ");
        Viewer.Show(file.ToString());
    }
}