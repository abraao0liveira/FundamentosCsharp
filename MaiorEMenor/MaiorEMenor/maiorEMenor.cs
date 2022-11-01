namespace MaiorEMenor;

public class maiorEMenor
{
    static void Main()
    {
        int number = 0;
        var maxNumber = 0;
        var minNumber = 2147483647;

        Console.Clear();
        Console.WriteLine("MAIOR E MENOR");

        do
        {
            Console.WriteLine("Digite um número: (0 para finalizar)");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine($"O maior valor é {maxNumber}");
                Console.WriteLine($"O menor valor é {minNumber}");
            }
            else if (number < minNumber)
            {
                minNumber = number;
            }
            else if (number > maxNumber)
            {
                maxNumber = number;
            }
            
        } while (number != 0);
    }
}