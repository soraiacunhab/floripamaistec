﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ex 2 - Organizador de lista de frutas\r\n");

List<string> listaDeFrutas = new List<string>();

bool continuar = true;
while (continuar)
{
	if (listaDeFrutas.Count() == 15)
	{
		continuar = false;
	}
	Console.Write("Digite o nome de uma fruta: ");
	listaDeFrutas.Add(Console.ReadLine());
	Console.Write("Deseja continuar? Responda [s] para sim ou [n] para não: ");

	string resposta = Console.ReadLine();
	if (resposta == "n" || resposta == "nao")
	{
		continuar = false;
	}
}

// coloca a lista em ordem alfabética

Console.WriteLine("Lista em ordem alfabética");
listaDeFrutas.Sort();

foreach (string fruta in listaDeFrutas)
{
	Console.WriteLine(fruta);
}

