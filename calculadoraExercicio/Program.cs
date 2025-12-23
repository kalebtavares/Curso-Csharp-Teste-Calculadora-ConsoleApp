using System.ComponentModel.Design;

Console.WriteLine("Seja Bem vindo a nossa calculadora");

// Receber 2 valores
// Solicitar que o usuario digite os valores

Console.WriteLine("Digite o primeiro valor:");
string? primeiroValorString = Console.ReadLine();
double primeiroValor = Convert.ToDouble(primeiroValorString); 

Console.WriteLine("Digite o segundo valor:");
string? segundoValorString = Console.ReadLine();
double segundoValor = Convert.ToDouble(segundoValorString);

Console.WriteLine($"Os valores digitados são : {primeiroValor} e {segundoValor}"); 

// Dar opcoes de calculo

Console.WriteLine("Selecione a operação desejada");
Console.WriteLine("+"+" Soma");
Console.WriteLine("-"+" Subtracao");
Console.WriteLine("*"+" Multiplicacao");
Console.WriteLine("/"+" Divisao");
var operacaoSelecionada = Console.ReadLine();

//Realizar calculo
if (operacaoSelecionada == "+" )
{
    var resultadoOperacao = primeiroValor + segundoValor;
    Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
}
else if (operacaoSelecionada == "-")
{
    var resultadoOperacao = primeiroValor - segundoValor;
    Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
}
else if (operacaoSelecionada == "*")
{
    var resultadoOperacao = primeiroValor * segundoValor;
    Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
}
else if (operacaoSelecionada == "/")
{
    var resultadoOperacao = primeiroValor / segundoValor;
    Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");
}

// Exibir o resultado do calculo
// Finalizar a aplicacao

Console.ReadKey();
