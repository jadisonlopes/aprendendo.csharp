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

            jadison = new Desenvolvedor("Jadison");
            Console.WriteLine("Funcionário " + jadison.Nome + " tem salário de R$" + jadison.Salario + " e sua bonificação eh " + jadison.GetBonificacao());
            jadison.AumentarSalario();
            MostreOhAumentoDeSalario(jadison.Salario);

            jadison = new Coordenador("Jadison");
            Console.WriteLine("Coordenador " + jadison.Nome + " tem salário de R$" + jadison.Salario + " e sua bonificação eh " + jadison.GetBonificacao());
            jadison.AumentarSalario();
            MostreOhAumentoDeSalario(jadison.Salario);

            jadison = new Diretor("Jadison");
            Console.WriteLine("Diretor.... " + jadison.Nome + " tem salário de R$" + jadison.Salario + " e sua bonificação eh " + jadison.GetBonificacao());
            jadison.AumentarSalario();
            MostreOhAumentoDeSalario(jadison.Salario);

            Console.ReadLine();
        }

        public static void MostreOhAumentoDeSalario(double salario) {
            Console.WriteLine("Seu novo salário eh R$" + salario);
        }
    }
}
