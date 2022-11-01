namespace ProjectStopWatch;

public class projectStopWatch
{
    static void Main()
    {
        Menu();
    }

    static void Start(int time)
    {
        int currentTime = 0;
        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000); // Pausa por 1seg.
        }
        Console.Clear();
        Console.WriteLine("StopWatch finalizado!");
        Thread.Sleep(3000);
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("[S]SEGUNDOS (10s = 10seg)\n[M]MINUTOS (10m = 10min)\n[0]SAIR");
        Console.WriteLine("Quanto tempo deseja contar: ");
        string data = Console.ReadLine().ToLower(); // armazena e transforma tudo em minusculo.
        char type = char.Parse(data.Substring(data.Length - 1, 1)); // Pega um pedaço da string, no caso o ultimo.
        int time = int.Parse(data.Substring(0, data.Length - 1)); // Pegando todos menos o ultimo.

        int min = 1;
        if (type == 'm')
        {
            min = 60;
        }
        if(time == 0)
        {
            System.Environment.Exit(0);
        }
        PreStart(time * min);
    }
    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(3000);

        Start(time);
    }
}