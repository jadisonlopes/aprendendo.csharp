using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Por padrão o namespace respeita a estrutura de pastas.
namespace ConsoleBank.Funcionarios
{
    //classe abstrata não podem ser instanciadas.
    abstract class Funcionario : IFuncionario
    {
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public virtual double Salario { get; protected set; }

        //Declarando construtor.
        protected Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        //Declarando metodo que pode ser subscrito - virtual.
        public virtual double GetBonificacao() {
            return Salario * 0.1;

        }

        public abstract Funcionario Info();

        //Metodo será chamado na implementação do metodo Info();
        protected void Info(string cargo)
        {
            Console.WriteLine(cargo + " " + this.Nome + " tem salário de R$" + this.Salario + " e sua bonificação eh " + this.GetBonificacao());
        }

        //Metodos abstratos não podem ser implementados e só podem existir em classes abstratas.
        public abstract Funcionario AumentarSalario();

        public Funcionario MostreOhAumentoDeSalario()
        {
            Console.WriteLine("Seu novo salário eh R$" + this.Salario);
            return this;
        }
    }
}
