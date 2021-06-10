using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrientacaoAhObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(
                new Cliente
                {
                    Nome = "Jadison Lopes",
                    Profissao = "Analista Programador",
                    Cpf = "001.002.003.45"
                },
                8888,
                88102030
            );
             
            ContaCorrente outraContaCorrente = new ContaCorrente(
                new Cliente
                {
                    Nome = "Lopes Santos",
                    Profissao = "Estudante",
                    Cpf = "001.002.003.45"
                },
                7777,
                77102030
            )
            { Saldo = 1};

            contaCorrente.Depositar(150);
            contaCorrente.Transferir(50, outraContaCorrente);
            contaCorrente.Sacar(200);

            Console.WriteLine("Saldo de " + contaCorrente.Titular.Nome + " eh R$ " + contaCorrente.Saldo);
            Console.WriteLine("Saldo de " + outraContaCorrente.Titular.Nome + " eh R$ " + outraContaCorrente.Saldo);
            Console.WriteLine("Total de contas criadas " + ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();
        }
    }
}
