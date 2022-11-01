namespace TestificadorDeString;

public class testificadorDeString
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome completo: ");
        string name = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine(name.Trim()); // Remove os espeços laterais.
        Console.WriteLine(name.Replace(" ", "")); // Troca todas as aparições de um pelo outro.
        
        Console.WriteLine(name.ToLower()); // Tudo minusculo.
        Console.WriteLine(name.ToUpper()); // Tudo maiusculo.
        
        Console.WriteLine(name.Insert(name.Length,"Brão")); // Adiciona uma palavra ao nome.
        Console.WriteLine(name.Replace("Abraão", "")); // Removendo uma palavra.

        Console.WriteLine(name.Contains("Oliveira")); // Pesquisa se há uma palavra dentro do nome.
        Console.WriteLine(name.Length); // Conta o total.
        Console.WriteLine(name.Replace(" ", "").Length); // Conta o total mas retirando os espaços.
    }
}