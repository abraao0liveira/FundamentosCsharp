namespace ProjectTextEditor;

public class projectTextEditor
{
    static void Main()
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("EDITOR DE TEXTOS\n[1]Abrir arquivo\n[2]Criar novo arquivo\n[0]Sair");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0:
                System.Environment.Exit(0);
                break;
            case 1:
                Open();
                break;
            case 2:
                Edit();
                break;
        }
    }
    static void Open()
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho do arquivo? ");
        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd(); // LER O TEXTO ATE O FINAL.
            Console.WriteLine(text);
        }
        Console.WriteLine(""); // pula linha.
        Console.ReadLine();
        Menu();
    }
    static void Edit()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto (Space para sair)\n------------");
        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine; // Colocando uma nova linha a cada leitura.
        } while (Console.ReadKey().Key != ConsoleKey.Spacebar);

        {
            Console.Clear();
            Save(text);
        }
    }
    static void Save(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo? ");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path)) // Abre e fecha objetos (arquivos). blib(System.IO)
        {
            file.WriteLine(text);
        }
        Console.WriteLine($"Arquivo salvo em {path}");
        Console.ReadLine();
        Menu();
    }
}