namespace Fibonacci;

public class fibonacci
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Digite a quantidade de números a serem imprimidos: ");
        int total = int.Parse(Console.ReadLine());
        Console.Clear();
        Fibonacci(1, total, 0, 1);
    }
    static int Fibonacci(int number, int total, int aux, int i)
    {
        if (i > total)
        {
            return number;
        }
        Console.WriteLine(number);

        var result = number + aux;
        aux = number;
        number = result;
        i++;
        return Fibonacci(result, total, aux, i);
    }
}