using Exercicios01ao06.Classes;
using Exercicios01ao06.Classes.enums;

Cliente pessoaJuridica = new Cliente("Soraia Cunha", DateTime.Parse("1992-06-09"), "Desenvolvedor", "Solteira", TipoPessoaEnum.JURIDICA);

ContaEmpresarial contaJuridica = new ContaEmpresarial(1542, 1234, pessoaJuridica, 5000, 9, "01265498712");

contaJuridica.FazerEmprestimo(1200);
contaJuridica.Depositar(200);
contaJuridica.ExibirSaldo();
contaJuridica.PagarEmprestimo();
contaJuridica.ExibirSaldo();

Cliente pessoaFisica = new Cliente("Soraia Cunha", DateTime.Parse("1992-06-09"), "Desenvolvedor", "Solteira", TipoPessoaEnum.FISICA);

ContaCorrente contaCorrente = new ContaCorrente(1542, 1234, pessoaFisica);

contaCorrente.Depositar(200);
contaCorrente.Sacar(50);
contaCorrente.ExibirSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(1542, 1234, pessoaFisica);

contaPoupanca.Depositar(200);
contaPoupanca.Transferir(contaCorrente, 50);
contaPoupanca.ExibirSaldo();