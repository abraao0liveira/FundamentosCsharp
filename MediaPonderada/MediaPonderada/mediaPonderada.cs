namespace MediaPonderada;

public class mediaPonderada
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Indique sua primeira nota: ");
        var note01 = double.Parse(Console.ReadLine());
        Console.WriteLine("Indique o peso da primeira nota: ");
        var weight01 = int.Parse(Console.ReadLine());

        Console.WriteLine("Indique sua segunda nota: ");
        var note02 = double.Parse(Console.ReadLine());
        Console.WriteLine("Indique o peso da segunda nota: ");
        var weight02 = int.Parse(Console.ReadLine());

        var result = (((note01 * weight01) + (note02 * weight02)) / (weight01 + weight02));

        Console.WriteLine($"A média ponderada é {result.ToString("N2")}.");
    }
}