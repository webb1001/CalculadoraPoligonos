using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Rectangulo : Poligono
    {
        public double Lado1
        {
            get;
            set;
        }
        public double Lado2
        {
            get;
            set;
        }
//private int lado2;
//        public int Lado2
//        {
//            get { return lado2; }
//            set
//            {
//                if(value > 0)
//                {
//lado2 = value;
//                }
//                else
//                {
//                    throw new Exception("El lado debe ser mayor que 0");
//                }
                
//            }
//        }
        public override double CalcularArea()
        {
            return Lado1 * Lado2;
        }

        public override double CalcularPerimetro()
        {
            return (Lado1 * 2) + (Lado2 * 2);
        }
    }
}