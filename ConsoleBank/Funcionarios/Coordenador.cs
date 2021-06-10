using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Funcionarios
{
    class Coordenador : Funcionario
    {
        //Passando parâmetros para o construtor base.
        public Coordenador(string nome, double salario) : base(nome, salario) { }

        //Sobrescrevendo metodo setter da classe base - override
        public override double Salario { protected set => base.Salario = value * 1.1; }
    }
}
