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
        public Diretor(string nome) : base(nome, 5000.0) { }


        //Sobrescrevendo o metodo da classe base - override.
        public override double GetBonificacao()
        {
            return Salario * 1.0;
        }

        //Implementando metodo abstrato da classe base.
        public override Funcionario AumentarSalario()
        {
            Salario *= 1.8;
            return this;
        }
    }
}
