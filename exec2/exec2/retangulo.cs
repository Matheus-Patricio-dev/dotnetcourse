using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec2
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;



        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }
        public double Diagonal()
        {
            double c = (Altura * Altura) + (Largura * Largura);
            return Math.Sqrt(c);
            
        }
    }
}
