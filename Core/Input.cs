using System.Collections.Generic;

namespace Core
{
    public class Input
    {
        public IList<Punto> Puntos { get; set; }
        public int CantidadDecimales { get; set; }

        public Input()
        {
            this.Puntos = new List<Punto>();
        }

        public Punto AgregarPunto(double x, double y)
        {
            var punto = new Punto {X = x, Y = y};
            this.Puntos.Add(punto);

            return punto;
        }
    }

    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
