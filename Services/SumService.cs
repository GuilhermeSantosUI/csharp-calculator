namespace CalculatorApp.Services;

public class SumService
{
    
    public static void handle()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        var valueOne = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo valor: ");
        var valueTwo = int.Parse(Console.ReadLine()!);
        
        var result = valueOne + valueTwo;
        Console.WriteLine(result);
    }
    
}