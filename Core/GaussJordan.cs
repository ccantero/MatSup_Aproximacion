namespace Core
{
    public class GaussJordan
    {

        public double[] Resolve(double[][] matriz)
        {
            var iteraciones = matriz.Length;

            for (int indiceFila = 0; indiceFila < iteraciones; indiceFila++)
            {
                var nuevaFilaConUno = this.ObtenerFilaConUno(indiceFila, matriz[indiceFila]);
                matriz[indiceFila] = nuevaFilaConUno;

                for (int i = 0; i < iteraciones; i++)
                {
                    if (i == indiceFila)
                        continue;

                    var nuevaFilaConCero = this.ObtenerFilaConCero(indiceFila, i, matriz);
                    matriz[i] = nuevaFilaConCero;
                }
            }

            var resultado = new double[iteraciones];
            for (int indiceFila = 0; indiceFila < iteraciones; indiceFila++)
            {
                resultado[indiceFila] = matriz[indiceFila][matriz[indiceFila].Length - 1];
            }

            return resultado;
        }

        private double[] ObtenerFilaConUno(int columna, double[] fila)
        {
            var pivot = fila[columna];
            var nuevaFila = new double[fila.Length];

            for (int i = 0; i < fila.Length; i++)
            {
                nuevaFila[i] = fila[i] / pivot;
            }

            return nuevaFila;
        }

        private double[] ObtenerFilaConCero(int indiceFilaPivot, int indiceFilaAConvertir, double[][] matriz)
        {
            var valorAMultiplicar = matriz[indiceFilaAConvertir][indiceFilaPivot];

            var filaLength = matriz[0].Length;
            var nuevaFila = new double[filaLength];

            for (int i = 0; i < filaLength; i++)
            {
                nuevaFila[i] = -1 * valorAMultiplicar * matriz[indiceFilaPivot][i] + matriz[indiceFilaAConvertir][i];
            }

            return nuevaFila;
        }
    }
}
