using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test
{
    [TestClass]
    public class ExponencialMinimosCuadradosTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new Input
            {
                Puntos = new List<Punto>
                {
                    new Punto {X = 1, Y = 5.10},
                    new Punto {X = 1.25, Y = 5.79},
                    new Punto {X = 1.50, Y = 6.53},
                    new Punto {X = 1.75, Y = 7.45},
                    new Punto {X = 2, Y = 8.46}
                },
                CantidadDecimales = 4
            };

            var exponencialMinimosCuadrados = new ExponencialMinimosCuadrados();

            var resultado = exponencialMinimosCuadrados.Calcular(input);


            Assert.AreEqual(0.51, resultado.Coheficientes[0]);
            Assert.AreEqual(3.0649, resultado.Coheficientes[1]);
            Debug.WriteLine($"a: {resultado.Coheficientes[0]}");
            Debug.WriteLine($"b: {resultado.Coheficientes[1]}");
        }
    }
}
