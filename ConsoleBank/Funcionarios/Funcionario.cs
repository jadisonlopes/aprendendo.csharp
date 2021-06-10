using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Por padrão o namespace respeita a estrutura de pastas.
namespace ConsoleBank.Funcionarios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public virtual double Salario { get; protected set; }

        //Declarando construtor
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        //Declarando metodo que pode ser subscrito - virtual
        public virtual double GetBonificacao() {
            return Salario * 0.1;

        }

    }
}
