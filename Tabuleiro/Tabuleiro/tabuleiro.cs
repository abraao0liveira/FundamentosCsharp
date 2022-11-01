namespace Tabuleiro;

public class tabuleiro
{
    static void Main()
    {
        Console.Clear();
        Corpo();
    }
    static void Corpo()
    {
        Console.WriteLine("Digite o número de linhas do tabuleiro: ");
        int lines = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número de colunas do tabuleiro: ");
        int columns = int.Parse(Console.ReadLine());

        Console.Write("#");
        for (int i = 0; i < lines; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine("#");

        for (int i = 0; i < columns; i++)
        {
            Console.Write("#");
            for (int j = 0; j < columns; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }

        Console.Write("#");
        for (int i = 0; i < lines; i++)
        {
            Console.Write("#");
        } 
        Console.Write("#");
    }
}