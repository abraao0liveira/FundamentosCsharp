namespace MediaAritmetica;

public class mediaAritmetica
{
    static void Main()
    {
        Console.Clear();
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine("[1]Média com 2 valores \n[2]Média com n valores\n[0]Sair");
        int menu = int.Parse(Console.ReadLine());

        if (menu == 1)
        {
            Console.Clear();
            Media();
        }
        else if (menu == 2)
        {
            Console.Clear();
            MediaN();
        }
        else
        {
            System.Environment.Exit(0);
        }
    }
    static void Media()
    {
        double value01, value02;

        Console.WriteLine("Indique sua primeira nota: ");
        value01 = double.Parse(Console.ReadLine());
        Console.WriteLine("Indique sua segunda nota: ");
        value02 = double.Parse(Console.ReadLine());

        var solution = (value01 + value02) / 2;

        Console.WriteLine($"A sua média é {solution}.");
    }
    static void MediaN()
    {
        double total = 0;
        var contador = 0;
        double number = 0;

        do
        {
            Console.WriteLine("Digite o seu primeiro valor: (Para sair digite 0).");
            number = double.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine($"A média entre os dados oferecidos é {total/contador}.");
            }

            total += number;
            contador++;
        } while (number != 0);
    }
}