using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test
{
    [TestClass]
    public class RectaMinimosCuadradosTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new Input
            {
                Puntos = new List<Punto>
                {
                    new Punto {X = 1, Y = 1},
                    new Punto {X = 3, Y = 2},
                    new Punto {X = 4, Y = 4},
                    new Punto {X = 6, Y = 4},
                    new Punto {X = 8, Y = 5},
                    new Punto {X = 9, Y = 7},
                    new Punto {X = 11, Y = 8},
                    new Punto {X = 14, Y = 9}
                },
                CantidadDecimales = 2
            };

            var rectaMinimosCuadrados = new RectaMinimosCuadrados();

            var resultado = rectaMinimosCuadrados.Calcular(input);


            Assert.AreEqual(0.64, resultado.Coheficientes[0]);
            Assert.AreEqual(0.55, resultado.Coheficientes[1]);
            Debug.WriteLine($"A: {resultado.Coheficientes[0]}");
            Debug.WriteLine($"B: {resultado.Coheficientes[1]}");
        }
    }
}
