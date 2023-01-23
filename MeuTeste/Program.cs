// See https://aka.ms/new-console-template for more information
using MeuTeste;

Console.WriteLine("Hello, World!");


var meuNumero = 1;
Console.WriteLine($"Meu número: {meuNumero}");

string minhaVariavel = "10";
Console.WriteLine($"Aqui, minha variável é: {minhaVariavel}");

// o que são constantes em .NET C#? Como criá-las?
const int minhaConst = 2;
Console.WriteLine($"Minha constante: {minhaConst}");

// como criar criar uma classe? O que é uma classe? um objeto?

minhaVariavel = "Pamela";
Console.WriteLine($"Aqui, minha variável é: {minhaVariavel}");

var ramon = new Pessoa();
ramon.Andar();
ramon.ExibirAltura();


Console.ReadKey();

// testes unitários
// criar WEB APIS