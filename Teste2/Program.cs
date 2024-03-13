using Teste2;

Console.WriteLine(@"
========================================
               Calculadora               
========================================");

Console.WriteLine("Bem-vindo à Calculadora Simples!");
Console.WriteLine("Por favor, insira o primeiro valor:");
double valor1;
while (!double.TryParse(Console.ReadLine(), out valor1))
{
    Console.WriteLine("Valor inválido! Por favor, insira um número válido:");
}

Console.WriteLine("Por favor, insira o segundo valor:");
double valor2;
while (!double.TryParse(Console.ReadLine(), out valor2))
{
    Console.WriteLine("Valor inválido! Por favor, insira um número válido:");
}

Console.WriteLine("Por favor, insira o operador (+, -, *, /):");
char operador = Console.ReadLine()[0];

double resultado = 0;

IOperacaoBasicaEntreDoisNumeros operacaoBasicaEntreDoisNumeros = null;

switch (operador)
{
    case '+':
        operacaoBasicaEntreDoisNumeros = new OperacaoBasicaEntreDoisNumerosSoma();
        break;
    case '-':
        operacaoBasicaEntreDoisNumeros = new OperacaoBasicaEntreDoisNumerosSubstracao();
        break;
    case '*':
        operacaoBasicaEntreDoisNumeros = new OperacaoBasicaEntreDoisNumerosMultiplicacao();
        break;
    case '/':
        if (valor2 != 0)
            operacaoBasicaEntreDoisNumeros = new OperacaoBasicaEntreDoisNumerosDivisao();
        else
            Console.WriteLine("Não é possível dividir por zero!");
        break;
    default:
        Console.WriteLine("Operador inválido!");
        break;
}

resultado = operacaoBasicaEntreDoisNumeros.Executar(valor1, valor2);

Console.WriteLine($"O resultado é: {resultado}");

Console.WriteLine("Pressione qualquer tecla para sair.");
Console.ReadKey();