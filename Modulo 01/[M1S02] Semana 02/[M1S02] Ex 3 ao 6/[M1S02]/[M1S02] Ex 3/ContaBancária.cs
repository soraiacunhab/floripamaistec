using Exercicios03ao06.Classes.Enum;

//Ex 3 - Defina uma classe chamada ContaBancaria com os seguintes atributos: número, agência, nome do titular, saldo, tipo de conta.


namespace Exercicios03ao06
{
public class ContaBancaria
{ 	
	public int numero;
	public int agencia;
	public string nomeDoTitular;
	public decimal saldo = 0;
	public TipoContaEnum tipoConta;
	
	// Ex 04 - Crie um método para depositar valores na conta bancária.
	public void Depositar(decimal valor)
	{
		if (valor <= 0)
		{
			Console.WriteLine("O valor precisa ser maior do que 0");
		}
		else
		{
			saldo = saldo + valor;
		}
	}

// Ex 05 - Crie um método para possibilitar o saque de valores da conta bancária.
	public void Sacar (decimal valor)
	{
		if (valor >= saldo)
					{
			Console.WriteLine("O valor precisa ser maior que o saldo atual");
		}
		else if (valor <= 0)

			Console.WriteLine("O valor precisa superior a 0 reais");

		else 
		saldo = saldo - valor;
			Console.WriteLine("Você ficará com saldo de", saldo);
	}
		// Ex 05 - Crie um método para possibilitar o saque de valores da conta bancária.
		public void ExibirSaldo()
		{
			Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
		}

	}
}
