using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test
{
    [TestClass]
    public class ParabolaMinimosCuadradosTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new Input
            {
                Puntos = new List<Punto>
                {
                    new Punto {X = 1.2, Y = 4.5},
                    new Punto {X = 1.8, Y = 5.9},
                    new Punto {X = 3.1, Y = 7},
                    new Punto {X = 4.9, Y = 7.8},
                    new Punto {X = 5.7, Y = 7.2},
                    new Punto {X = 7.1, Y = 6.8},
                    new Punto {X = 8.6, Y = 4.5},
                    new Punto {X = 9.8, Y = 2.7}
                }
            };

            var rectaMinimosCuadrados = new ParabolaMinimosCuadrados();

            var resultado = rectaMinimosCuadrados.Calcular(input);

            Debug.WriteLine($"A: {resultado.Coheficientes[0]}");
            Debug.WriteLine($"B: {resultado.Coheficientes[1]}");
            Debug.WriteLine($"C: {resultado.Coheficientes[2]}");
        }
    }
}
