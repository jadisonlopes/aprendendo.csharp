using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        //Passando parâmetros para o construtor base.
        public Desenvolvedor(string nome) : base(nome, 2500.0) { }

        //Implementando metodo abstrato da classe base.
        public override Funcionario AumentarSalario()
        {
            Salario *= 1.6;
            return this;
        }

        public override Funcionario Info()
        {
            base.Info("Desenvolvedor");
            return this;
        }
    }
}
