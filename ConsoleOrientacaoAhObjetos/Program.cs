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
            //Cliente cliente = new Cliente();
            //cliente.nome = "Jadison Lopes";
            //cliente.profissao = "Analista Programador";
            //cliente.cpf = "001.002.003.45";

            Cliente cliente = new Cliente {
            nome = "Jadison Lopes",
            profissao = "Analista Programador",
            cpf = "001.002.003.45"
            };

            //ContaCorrente contaCorrente = new ContaCorrente();
            //contaCorrente.titular = cliente;
            //contaCorrente.agencia = 8888;
            //contaCorrente.numero = 88102030;

            ContaCorrente contaCorrente = new ContaCorrente {
                Titular = cliente,
                agencia =  8888,
                numero = 88102030
            };
             
            ContaCorrente outraContaCorrente = new ContaCorrente
            {
                Titular = new Cliente
                {
                    nome = "Lopes Santos",
                    profissao = "Estudante",
                    cpf = "001.002.003.45"
                },
                agencia = 7777,
                numero = 77102030
            };

            outraContaCorrente.Saldo = 1;
            contaCorrente.Depositar(150);
            contaCorrente.Transferir(50, outraContaCorrente);
            contaCorrente.Sacar(200);

            Console.WriteLine("Saldo de " + contaCorrente.Titular.nome + " eh R$ " + contaCorrente.Saldo);
            Console.WriteLine("Saldo de " + outraContaCorrente.Titular.nome + " eh R$ " + outraContaCorrente.Saldo);


            Console.ReadLine();
        }
    }
}
