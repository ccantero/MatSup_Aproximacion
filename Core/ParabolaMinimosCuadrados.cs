using System;
using System.Collections.Generic;

namespace Core
{
    public class ParabolaMinimosCuadrados : Aproximacion
    {
        public override Output Calcular(Input input)
        {
            double sumaX = 0;
            double sumaY = 0;
            double sumaX2 = 0;
            double sumaX3 = 0;
            double sumaX4 = 0;
            double sumaXY = 0;
            double sumaX2Y = 0;
            var resultados = new List<double[]>();

            foreach (var punto in input.Puntos)
            {
                var x = punto.X;
                var y = punto.Y;
                var x2 = Math.Round(Math.Pow(punto.X, 2), input.CantidadDecimales);
                var x3 = Math.Round(Math.Pow(punto.X, 3), input.CantidadDecimales);
                var x4 = Math.Round(Math.Pow(punto.X, 4), input.CantidadDecimales);
                var xy = Math.Round(punto.X * punto.Y, input.CantidadDecimales);
                var x2y = Math.Round(Math.Pow(punto.X, 2) * punto.Y, input.CantidadDecimales);

                resultados.Add(new[] { x, y, x2, x3, x4, xy, x2y});

                sumaX += x;
                sumaY += y;
                sumaX2 += x2;
                sumaX3 += x3;
                sumaX4 += x4;
                sumaXY += xy;
                sumaX2Y += x2y;
            }

            var totales = new[] {sumaX, sumaY, sumaX2, sumaX3, sumaX4, sumaXY, sumaX2Y};

            var matriz = new[]
            {
                new[] {sumaX4, sumaX3, sumaX2, sumaX2Y},
                new[] {sumaX3, sumaX2, sumaX, sumaXY},
                new[] {sumaX2, sumaX, input.Puntos.Count, sumaY}
            };

            var resultado = new GaussJordan().Resolve(matriz);
            var a = Math.Round(resultado[0], input.CantidadDecimales);
            var b = Math.Round(resultado[1], input.CantidadDecimales);
            var c = Math.Round(resultado[2], input.CantidadDecimales);

            var coheficientes = new[] {a, b, c};
            var funcion = this.Funcion(a, b, c);

            return this.Output(input, resultados.ToArray(), totales, coheficientes, funcion);
        }

        private Func<double, double> Funcion(double a, double b, double c)
        {
            return x => a * Math.Pow(x, 2) + b * x + c;
        }

        public override string Expresion(double[] coheficientes)
        {
            var a = coheficientes[0];
            var b = coheficientes[1];
            var c = coheficientes[2];

            return $"{a} x^2 + {b} x + {c}";
        }

        public override string[] CabeceraResultados()
        {
            return new[] {"x", "y", "x^2", "x^3", "x^4", "xy", "x^2y" };
        }

        public override string[] CabeceraComparacion()
        {
            return new[] { "x", "y" };
        }
    }
}
