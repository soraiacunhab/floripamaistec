// See https://aka.ms/new-console-template for more information
Console.WriteLine("[M01S02] Ex 5 - Sequência de Fibonacci");

int n;
int x = 1, y = 0, z = 0;

Console.WriteLine("Vamos descobrir a sequência de fibonacci, informe um número:");

// lê a quantidade de número da sequência a ser exibidos
string number = Console.ReadLine();

n = int.Parse(number);

Console.Write("De acorde com wikipedia a sucessão de Fibonacci, é uma sequência de números inteiros, começando normalmente por 0 e 1, na qual cada termo subsequente corresponde à soma dos dois anteriores. Veja abaixo a sequencia de Fibonacci ");

// cria a sequência de Fibonacci
for (int i = 0; i < n; i++)
{

	// a sequência consiste em somar o anterior (y) com o número atual (x) e o resultado
	// será o próximo número (z)
	z = x + y;
	Console.WriteLine(z);
	y = x;
	x = z;
}


Console.ReadLine();

