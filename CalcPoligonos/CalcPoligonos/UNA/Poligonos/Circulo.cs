
using System;

namespace UNA.Poligonos
{
    public class Circulo : Poligono
    {
        public double Radio
        {
            get;
            set;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}