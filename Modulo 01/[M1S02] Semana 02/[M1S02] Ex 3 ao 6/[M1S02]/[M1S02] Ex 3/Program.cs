// See https://aka.ms/new-console-template for more information
using _M1S02__Ex_3;

Console.WriteLine("Hello, World!");

using Exercicios03ao06;
using Exercicios03ao06.Classes.Enum;

ContaBancaria conta = new ContaBancaria();

conta.numero = 1542;
conta.agencia = 1234;
conta.nomeDoTitular = "Bruno Costa";
conta.tipoConta = TipoContaEnum.POUPANCA;

// testando metodo depositar
conta.Depositar(200);

// testando metodo sacar 
conta.Saque(50);

// testando método exibir saldo
conta.ExibirSaldo();