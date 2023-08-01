// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("[M01S02] Ex 3 - Separador de números ímpares e pares");

List<int> numerosPares = new List<int>();
List<int> numerosImpares = new List<int>();

for (int i = 0; i < 10; i++)
{
	Console.Write($"Digite o {i + 1}º número: ");
	int num = int.Parse(Console.ReadLine());

	// verifica se o número é ímpar ou par
	if (num % 2 == 0)
	{
		numerosPares.Add(num);
	}
	else
	{
		numerosImpares.Add(num);
	}
}

// o método Sum() faz a soma dos números de uma lista
Console.WriteLine($"A lista de números ímpares possui {numerosImpares.Count()} números e a soma deles é igual a {numerosImpares.Sum()}");
Console.WriteLine($"A lista de números pares possui {numerosPares.Count()} números e a soma deles é igual a {numerosPares.Sum()}");

// coloca os números em ordem crescente

Console.WriteLine("Numeros pares em ordem crescente são:");
numerosPares.Sort();

foreach (int num in numerosPares)
{
	Console.WriteLine(num);
}

// coloca os números em ordem crescente

Console.WriteLine("Numeros Impares em ordem crescente são:");
numerosImpares.Sort();

foreach (int num in numerosImpares)
{
	Console.WriteLine(num);
}



