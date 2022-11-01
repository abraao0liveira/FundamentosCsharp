using System.Runtime.InteropServices.ComTypes;

namespace EditorHTML;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen; // Muda a cor da letra.
        Console.BackgroundColor = ConsoleColor.Black; // Muda a cor de fundo.
        DrawScreen();
        WriteOptions();
        var option = short.Parse(Console.ReadLine()); // Escrever na tela.
        HandleMenuOption(option);
    }
    public static void DrawScreen()
    {
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");
        for (int lines = 0; lines <= 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(" ");
            }

            Console.Write("|\n");
        }
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");
    }
    public static void WriteOptions()
    {
        Console.SetCursorPosition(2,1);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("===========");
        Console.SetCursorPosition(2, 3);
        Console.WriteLine("Selecione uma opção:");
        Console.SetCursorPosition(2, 5);
        Console.WriteLine("[1]Novo arquivo");
        Console.SetCursorPosition(2, 6);
        Console.WriteLine("[2]Abrir arquivo");
        Console.SetCursorPosition(2, 7);
        Console.WriteLine("[0]Sair");
        Console.SetCursorPosition(2, 8);
        Console.Write("Opção: ");
    }
    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1:
                Editor.Show();
                break;
            case 2:
                
                break;
            case 0:
            {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
            default:
                Show();
                break;
        }
    }
}