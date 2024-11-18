using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Course.Program;

namespace Course
{
   public class Produto
    {

        // privatizando/protegendo para controlar o acesso aos atributos
        private string _nome;


        public double Preco;
        public int Qnt;
        public int qntFinal;

        public double ValorTotal()
        {
            return Preco * Qnt;
        }
        /*
        //metodo get
        //-metodo que consegue adentrar a privatizacao do atributo e manipula-lo
        public string GetNome()
        {
            return _nome;
        }

        //metodo set
        //-metodo que consegue adentrar a privatizacao do atributo e mudar seu valor
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = _nome;
            }
        }
        // gerando uma logica dentro da operacao de acessar o atributo
        */


        //properties
        public string Nome { 
            get { return _nome; }
            set
            {
                if ( value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }


        public override string ToString()
        {
            return Nome + ", $"
                + Preco 
                + ", qnt no Estoque: " 
                + Qnt
                + ", Valor total: "
                + ValorTotal();
        }



        public void AddProduto(int qnt)
        {
            Qnt = Qnt + qnt;
        }
        public void SubtProduto(int qnt)
        {
            Qnt = Qnt - qnt;
        }
    }
}
