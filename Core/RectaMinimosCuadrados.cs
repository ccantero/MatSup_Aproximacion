﻿using System;
using System.Collections.Generic;

namespace Core
{
    public class RectaMinimosCuadrados : Aproximacion
    {
        public override Output Calcular(Input input)
        {
            double sumaX = 0;
            double sumaY = 0;
            double sumaX2 = 0;
            double sumaXY = 0;
            var decimales = input.CantidadDecimales;
            var resultados = new List<double[]>();

            foreach (var punto in input.Puntos)
            {
                var x = punto.X;
                var y = punto.Y;
                var x2 = Math.Round(Math.Pow(punto.X, 2), decimales);
                var xy = Math.Round(punto.X * punto.Y, decimales);

                resultados.Add(new[] { x, y, x2, xy });
                
                sumaX += x;
                sumaY += y;
                sumaX2 += x2;
                sumaXY += xy;
            }

            sumaX = Math.Round(sumaX, decimales);
            sumaY = Math.Round(sumaY, decimales);
            sumaX2 = Math.Round(sumaX2, decimales);
            sumaXY = Math.Round(sumaXY, decimales);

            var totales = new[] { sumaX, sumaY, sumaX2, sumaXY };

            var matriz = new[]
            {
                new[] {sumaX2, sumaX, sumaXY},
                new[] {sumaX, input.Puntos.Count, sumaY}
            };

            var resultado = new GaussJordan().Resolve(matriz);
            var a = Math.Round(resultado[0], 2);
            var b = Math.Round(resultado[1], 2);
            var coheficientes = new[] {a, b};

            var funcion = this.Funcion(a, b);

            return this.Output(input, resultados.ToArray(), totales, coheficientes, funcion);
        }

        private Func<double, double> Funcion(double a, double b)
        {
            return x => a * x + b;
        }

        public override string Expresion(double[] coheficientes)
        {
            var a = coheficientes[0];
            var b = coheficientes[1];

            return $"{a} x + {b}";
        }

        public override string[] CabeceraResultados()
        {
            return new[] { "x", "y", "x^2", "xy" };
        }
    }
}