// See https://aka.ms/new-console-template for more information
using _M1S02__Ex_3;

Console.WriteLine("Hello, World!");

using Exercicios03ao06;
using Exercicios03ao06.Classes.Enum;

ContaBancaria conta = new ContaBancaria();

conta.numero = 1234;
conta.agencia = 4321;
conta.nomeDoTitular = "Soraia Cunha";
conta.tipoConta = TipoContaEnum.POUPANCA;

// testando metodo depositar
// testando metodo sacar 
// testando método exibir saldo
conta.Depositar(100);

conta.Saque(40);

conta.ExibirSaldo();
