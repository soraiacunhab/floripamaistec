using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S04__Ex_1___Criação_de_Classe_Cliente.
{
	public class Cliente
	{
		public string Nome { get; private set; }
		public DateTime Nascimento { get; private set; }
		public string Profissao { get; private set; }
		public string EstadoCivil { get; private set; }
		public TipoPessoaEnum TipoPessoa { get; private set }


		public Cliente(string nome, DataTime nascimento, Profissao profissao, EstadoCivil estadoCivil,TipoPessoaEnum tipoPessoa
		{
			Nome = nome;
			Datatime = nascimento;
			Profissao = profissao;
			EstadoCivil = estadoCivil;
			TipoPessoa = tipoPessoa;
		}

		}

	}
}
