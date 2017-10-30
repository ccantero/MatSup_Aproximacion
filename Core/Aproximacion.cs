using System;

namespace Core
{
    public abstract class Aproximacion
    {
        public abstract Output Calcular(Input input);
        public abstract string[] CabeceraResultados();
        public abstract string[] CabeceraComparacion();
        public abstract string Expresion(double[] coheficientes);

        protected Output Output(Input input, double[][] resultados, double[] totales, double[] coheficientes, Func<double, double> funcion)
        {
            var aproximaciones = new double[input.Puntos.Count];
            var errores = new double[input.Puntos.Count];
            var errorTotal = 0.0;

            for (int i = 0; i < input.Puntos.Count; i++)
            {
                var punto = input.Puntos[i];
                var valorAproximado = Math.Round(funcion.Invoke(punto.X), input.CantidadDecimales);
                var error = Math.Round(Math.Pow(valorAproximado - punto.Y, 2), input.CantidadDecimales);

                aproximaciones[i] = valorAproximado;
                errores[i] = error;
                errorTotal += error;
            }

            var output = new Output
            {
                CabeceraResultados = this.CabeceraResultados(),
                CabeceraComparacion = this.CabeceraComparacion(),
                Funcion = funcion,
                Expresion = this.Expresion(coheficientes),
                Resultados = resultados,
                Totales = totales,
                Coheficientes = coheficientes,
                Aproximaciones = aproximaciones,
                Errores = errores,
                ErrorTotal = errorTotal
            };

            return output;
        }

        protected Output Output(Input input, double[][] resultados, double[] totales, double[] coheficientes, Func<double, double> funcion, String sistemaEcuaciones)
        {
            var aproximaciones = new double[input.Puntos.Count];
            var errores = new double[input.Puntos.Count];
            var errorTotal = 0.0;

            for (int i = 0; i < input.Puntos.Count; i++)
            {
                var punto = input.Puntos[i];
                var valorAproximado = Math.Round(funcion.Invoke(punto.X), input.CantidadDecimales);
                var error = Math.Round(Math.Pow(valorAproximado - punto.Y, 2), input.CantidadDecimales);

                aproximaciones[i] = valorAproximado;
                errores[i] = error;
                errorTotal += error;
            }

            var output = new Output
            {
                CabeceraResultados = this.CabeceraResultados(),
                CabeceraComparacion = this.CabeceraComparacion(),
                Funcion = funcion,
                Expresion = this.Expresion(coheficientes),
                Resultados = resultados,
                Totales = totales,
                Coheficientes = coheficientes,
                Aproximaciones = aproximaciones,
                Errores = errores,
                ErrorTotal = errorTotal,
                SistemaEcuaciones = sistemaEcuaciones
            };

            

            return output;
        }
    }
}