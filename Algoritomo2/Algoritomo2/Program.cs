int idade = 10;
string nomeCliente = "rafael Suarez";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Rafael Vieira Suarez";
var altura = 180;

Colsole.WriteLine("Digite seu nome");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine(""Bem vindo " + nomeCompleto);
Console.Write("Digite sua idade: ");
var linha - Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade informada " + idade);
if (idade < 18)
    Console.WriteLine("você não pode estar aqui!");
Console.ReadKey();
