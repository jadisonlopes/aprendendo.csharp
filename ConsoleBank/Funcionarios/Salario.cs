using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Funcionarios
{
    class Salario
    {
        //readonly - A propriedade será usada apenas para leitura
        readonly IFuncionario funcionario;

        //Polimorfimos - Obriga que o parametro funcionário contenha os metodos no contrato IFuncionário
        //Injeção de dependência
        public Salario(IFuncionario funcionario) {
            this.funcionario = funcionario;
        }

        public void GerenciarAumento() {
            funcionario.AumentarSalario().MostreOhAumentoDeSalario();
        }

    }
}
