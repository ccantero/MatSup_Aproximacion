using System;

namespace Core
{
    public class Output
    {
        public string[] CabeceraResultados { get; set; }
        public string[] CabeceraComparacion { get; set; }
        public double[][] Resultados { get; set; }
        public double[] Totales { get; set; }
        public double[] Coheficientes { get; set; }
        public double[] Aproximaciones { get; set; } 
        public double[] Errores { get; set; }

        public string SistemaEcuaciones { get; set; }

        public Func<double, double> Funcion { get; set; }
        public string Expresion { get; set; }
        public double ErrorTotal { get; set; }
    }
}
