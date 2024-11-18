using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec2
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;
        public double Porcentagem;
        public double salarioLiquido()
        {
            return Salario - Imposto;
        }
        public double AumentaSalario()
        {
            double SalarioAtualizado = Salario + (Salario * (Porcentagem / 100));
            return SalarioAtualizado;
        }

    }

}
