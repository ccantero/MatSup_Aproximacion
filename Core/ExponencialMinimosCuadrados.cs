using System;
using System.Linq;

namespace Core
{
    public class ExponencialMinimosCuadrados : Aproximacion
    {
        public override Output Calcular(Input input)
        {
            var puntosRecta = input.Puntos
                .Select(p => new Punto {X = p.X, Y = Math.Round(Math.Log(p.Y), input.CantidadDecimales)})
                .ToList();

            var rectaInput = new Input
            {
                Puntos = puntosRecta,
                CantidadDecimales = input.CantidadDecimales
            };

            var recta = new RectaMinimosCuadrados();
            var resultadoRecta = recta.Calcular(rectaInput);

            var a = Math.Round(resultadoRecta.Coheficientes[0], input.CantidadDecimales);
            var b = Math.Round(Math.Pow(Math.E, resultadoRecta.Coheficientes[1]), input.CantidadDecimales);

            var resultados = new double[resultadoRecta.Resultados.Length][];

            for (int i = 0; i < resultadoRecta.Resultados.Length; i++)
            {
                resultados[i] = new[]
                {
                    input.Puntos[i].X,
                    input.Puntos[i].Y,
                    resultadoRecta.Resultados[i][1],
                    resultadoRecta.Resultados[i][2],
                    resultadoRecta.Resultados[i][3],
                };
            }

            var totales = new[]
            {
                resultadoRecta.Totales[0],
                input.Puntos.Sum(p => p.Y),
                resultadoRecta.Totales[1],
                resultadoRecta.Totales[2],
                resultadoRecta.Totales[3],
            };

            var coheficientes = new[] {a, b};
            var funcion = this.Funcion(a, b);

            return this.Output(input, resultados, totales, coheficientes, funcion);
        }

        private Func<double, double> Funcion(double a, double b)
        {
            return x => b * Math.Pow(Math.E, x * a);
        }

        public override string Expresion(double[] coheficientes)
        {
            var a = coheficientes[0];
            var b = coheficientes[1];

            return $"{b} e^({a} x)";
        }

        public override string[] CabeceraResultados()
        {
            return new[] { "x", "y", "ln y", "x^2", "x ln y" };
        }
    }
}
