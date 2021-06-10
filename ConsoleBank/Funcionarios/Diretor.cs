using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Funcionarios
{
    class Diretor : Funcionario
    {
        //Passando parâmetros para o construtor base.
        public Diretor(string nome, double salario) : base(nome, salario) { }


        //Sobrescrevendo o metodo da classe base - override.
        public override double GetBonificacao()
        {
            return Salario * 1.0;
        }
    }
}
