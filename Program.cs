using CalculatorApp.Services;

Console.WriteLine("Seja bem-vindo(a) a calculadora!");

int option;
do
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Multiplicação");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Subtração");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");

    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            SumService.handle();
            break;  
        
        case 2:
            MultService.handle();
            break;
        
        case 3:
            DiviService.handle();
            break; 
        
        case 4:
            SubtService.handle();
            break; 
        case 0:
            Console.WriteLine("Aplicação encerrada.");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
} while (option != 0);