using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Funcionarios
{
    interface IFuncionario
    {
        //Interface é a criação de um contrato que obriga a implementação do seus métodos para quem o herdar.
        double GetBonificacao();
        Funcionario AumentarSalario();
        Funcionario MostreOhAumentoDeSalario();
    }
}
