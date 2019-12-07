using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNA.Poligonos
{
    public class Pentagono : Poligono
    {
      public double Lado
        {
            get;
            set; 
        }
        public double Apotema
        {
            get;
            set;
        }
        public override double CalcularArea()
        {
            //TODO: implementar esta funcion 
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }
}