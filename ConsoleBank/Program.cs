using ConsoleBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank
{
    static class Program
    {
        static void Main(string[] args)
        {

            Funcionario jadison;

            jadison = new Funcionario("Jadison", 2000.0);

            Console.WriteLine("Funcionário " + jadison.Nome + " tem salário de R$" + jadison.Salario + " e sua bonificação eh " + jadison.GetBonificacao());

            jadison = new Coordenador("Jadison", 2500.0);

            Console.WriteLine("Coordenador " + jadison.Nome + " tem salário de R$" + jadison.Salario + " e sua bonificação eh " + jadison.GetBonificacao());

            jadison = new Diretor("Jadison", 3000.0);

            Console.WriteLine("Diretor.... " + jadison.Nome + " tem salário de R$" + jadison.Salario + " e sua bonificação eh " + jadison.GetBonificacao());

            Console.ReadLine();
        }
    }
}
