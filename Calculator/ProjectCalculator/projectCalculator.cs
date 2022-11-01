namespace ProjectCalculator;

public class projectCalculator
{
    static void Main()
    {
        int repeat = 0;
        Menu();
    }
    #region operations
    static void Soma()
    {
        Console.Clear();
        
        Console.WriteLine("Qual o primeiro valor: ");
        float value01 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Qual o segundo valor: ");
        float value02 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        
        #region Soma
        
        float result = (value01 + value02);
        Console.WriteLine($"SOMA: {result}.");
        
        #endregion
        
        Console.WriteLine("Deseja fazer outra operação? Se sim aperte [1], caso não, aperte [0].");
        int repeat = int.Parse(Console.ReadLine());
        
        while (repeat == 1)
        {
            Menu();
        }
    }
    static void Sub()
    {
        Console.Clear();
        
        Console.WriteLine("Qual o primeiro valor: ");
        float value01 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Qual o segundo valor: ");
        float value02 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        
        #region Subtração
        
        float result = (value01 - value02);
        Console.WriteLine($"SUBTRAÇÃO: {result}");

        #endregion
        
        Console.WriteLine("Deseja fazer outra operação? Se sim aperte [1], caso não, aperte [0].");
        int repeat = int.Parse(Console.ReadLine());
        
        while (repeat == 1)
        {
            Menu();
        }
    }

    static void Mult()
    {
        Console.Clear();

        Console.WriteLine("Qual o primeiro valor: ");
        float value01 = float.Parse(Console.ReadLine());

        Console.WriteLine("Qual o segundo valor: ");
        float value02 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        
        #region Multiplicação

        float result = (value01 * value02);
        Console.WriteLine($"MUTIPLICAÇÃO: {result}");
        
        #endregion
        
        Console.WriteLine("Deseja fazer outra operação? Se sim aperte [1], caso não, aperte [0].");
        int repeat = int.Parse(Console.ReadLine());
        
        while (repeat == 1)
        {
            Menu();
        }
    }
    static void Division()
    {
        Console.Clear();
        
        Console.WriteLine("Qual o primeiro valor: ");
        float value01 = float.Parse(Console.ReadLine());

        Console.WriteLine("Qual o segundo valor: ");
        float value02 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
        
        #region Divisão

        float result = (value01 / value02);
        Console.WriteLine($"DIVISÃO: {result}");
        
        #endregion
        
        Console.WriteLine("Deseja fazer outra operação? Se sim aperte [1], caso não, aperte [0].");
        int repeat = int.Parse(Console.ReadLine());
        
        while (repeat == 1)
        {
            Menu();
        }
    }
    #endregion
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("[1]SOMA\n[2]SUBTRAÇÃO\n[3]MUTIPLICAÇÃO\n[4]DIVISÃO");
        int operation = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Soma();
                break;
            case 2:
                Sub();
                break;
            case 3:
                Mult();
                break;
            case 4:
                Division();
                break;
            default:
                Menu();
                break;
        }
    }
}