﻿using System;
using System.Linq;

namespace Core
{
    public class HiperbolaMinimosCuadrados : Aproximacion
    {
        public override Output Calcular(Input input)
        {
            var puntosRecta = input.Puntos
                .Select(p => new Punto
                {
                    X = p.X,
                    Y = Math.Round(1 / p.Y, input.CantidadDecimales)
                })
                .ToList();

            var rectaInput = new Input
            {
                Puntos = puntosRecta,
                CantidadDecimales = input.CantidadDecimales
            };

            var recta = new RectaMinimosCuadrados();
            var resultadoRecta = recta.Calcular(rectaInput);

            var a = Math.Round( 1 / resultadoRecta.Coheficientes[0], input.CantidadDecimales);
            var b = Math.Round( a * resultadoRecta.Coheficientes[1], input.CantidadDecimales);

            var resultados = new double[resultadoRecta.Resultados.Length][];

            for (int i = 0; i < resultadoRecta.Resultados.Length; i++)
            {
                resultados[i] = new[]
                {
                    input.Puntos[i].X,
                    input.Puntos[i].Y,
                    resultadoRecta.Resultados[i][1],
                    resultadoRecta.Resultados[i][2],
                    resultadoRecta.Resultados[i][3]
                };
            }

            var totales = new[]
            {
                input.Puntos.Sum(p => p.X),
                input.Puntos.Sum(p => p.Y),
                resultadoRecta.Totales[1],
                resultadoRecta.Totales[2],
                resultadoRecta.Totales[3]
            };

            var coheficientes = new[] {a, b};
            var funcion = this.Funcion(a, b);

            double sumaX = resultadoRecta.Totales[0];
            double cantPuntos = puntosRecta.Count;
            double sumaUnoSobreY = resultadoRecta.Totales[1];
            double sumaXxUnoSobreY = resultadoRecta.Totales[3];
            double sumaUnoSobreYCuadrado = resultadoRecta.Totales[2];

            String sistemaEcuaciones = "";
            sistemaEcuaciones += resultadoRecta.SistemaEcuaciones.ToUpper() + "\n";
            sistemaEcuaciones += "a = 1/A" + "\n";
            sistemaEcuaciones += "b = B/A" + "\n";

            return this.Output(input, resultados, totales, coheficientes, funcion, sistemaEcuaciones);
        }

        private Func<double, double> Funcion(double a, double b)
        {
            return x => a / (b + x);
        }

        public override string Expresion(double[] coheficientes)
        {
            var a = coheficientes[0];
            var b = coheficientes[1];

            return $"{a} / ({b} + x)";
        }

        public override string[] CabeceraResultados()
        {
            return new[] { "x", "y", "1 / y", "x^2", "x * (1 / y)" };
        }

        public override string[] CabeceraComparacion()
        {
            return new[] { "x", "y" };
        }
    }
}
