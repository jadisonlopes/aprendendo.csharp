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
            jadison.Info();

            Salario salario = new Salario(jadison);
            salario.GerenciarAumento();

            jadison = new Coordenador("Jadison");
            jadison.Info().AumentarSalario().MostreOhAumentoDeSalario();

            jadison = new Diretor("Jadison");
            jadison.Info().AumentarSalario().MostreOhAumentoDeSalario();

            Console.ReadLine();
        }
    }
}
