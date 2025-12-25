using System.ComponentModel.Design;

Console.WriteLine("Seja Bem vindo a nossa calculadora");



do
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    string? primeiroValorString = Console.ReadLine();
    double primeiroValor = Convert.ToDouble(primeiroValorString);

    Console.WriteLine("Digite o segundo valor:");
    string? segundoValorString = Console.ReadLine();
    double segundoValor = Convert.ToDouble(segundoValorString);

    Console.WriteLine($"Os valores digitados são : {primeiroValor} e {segundoValor}");

    

    Console.WriteLine("Selecione a operação desejada");
    Console.WriteLine("+" + " Soma");
    Console.WriteLine("-" + " Subtracao");
    Console.WriteLine("*" + " Multiplicacao");
    Console.WriteLine("/" + " Divisao");
    var operacaoSelecionada = Console.ReadLine();

    //Realizar calculo

    double resultadoOperacao;
    switch (operacaoSelecionada)
    {
        case "+":
            resultadoOperacao = primeiroValor + segundoValor;
            Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
            break;
        case "-":
            resultadoOperacao = primeiroValor - segundoValor;
            Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
            break;
        case "*":
            resultadoOperacao = primeiroValor * segundoValor;
            Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
            break;
        case "/":
            resultadoOperacao = primeiroValor / segundoValor;
            Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
    }
        Console.WriteLine();
    Console.WriteLine("Deseja realizar outra operação?");
    Console.WriteLine("(S) Sim (N) Não");
    Console.WriteLine();
} while (Console.ReadKey().Key == ConsoleKey.S);
Console.Clear();

Console.WriteLine("Até Logo!!");


    Console.ReadKey();
