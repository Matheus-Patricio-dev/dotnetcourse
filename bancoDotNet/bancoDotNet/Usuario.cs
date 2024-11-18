using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoDotNet
{
    public class Usuario
    {
        private string _tittle;
        public int NumAcc { get;  set; }
        public double Balance { get; set; }
 
        
        
        public string Tittle 
        {
            get { return _tittle; }
            set 
            { 
                if (value != null && value.Length > 4)
                {
                    _tittle = value;
                }
            }
        }


        //construtor com 2 parametros
        public Usuario(string tittle, int numAcc)
        {
            NumAcc = numAcc;
            _tittle = tittle;
        }

        //construtor com 3 parametros caso o usuario informe o deposito inicial
        public Usuario(string tittle, int numAcc, double initialBalance) : this(tittle, numAcc)
        {
            AddBalance(initialBalance);
        }


        public override string ToString()
        {
            return "CONTA: "
                + NumAcc
                + ", titular: "
                + Tittle
                + ", Saldo: $"
                + Balance.ToString("F2");
        }


        public void AddBalance(double balanceValue)
        {
            Balance += balanceValue;
        }

        public void MinusBalance(double balanceValue)
        {
            Balance -= balanceValue + 5;
        }
    }
}
