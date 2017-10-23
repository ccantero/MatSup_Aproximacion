using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using OxyPlot;
using OxyPlot.Series;

namespace Interface
{
    public partial class ResultadoComparacion : Form
    {
        public ResultadoComparacion(Input input, Output resultado, IDictionary<ModeloAproximacion, Output> resultados)
        {
            InitializeComponent();

            this.Size = new Size(1000, 600);
            this.dataGridView1.Size = new Size(520, 450);

            var ancho = input.Puntos.Max(p => p.X) + 1;

            var dataTable = new DataTable();

           
            foreach (var cabecera in resultado.CabeceraComparacion)
            {
                dataTable.Columns.Add(cabecera, typeof(double));
            }

            foreach (var modeloAproximacion in resultados)
            {
                dataTable.Columns.Add(modeloAproximacion.Key.ToString(), typeof(double));
            }

            foreach (var modeloAproximacion in resultados)
            {
                dataTable.Columns.Add(modeloAproximacion.Key.ToString() + "_ERROR", typeof(double));
            }

            foreach (var coheficientes in resultado.Resultados)
            {
                var row = dataTable.NewRow();
                for (int i = 0; i < resultado.CabeceraComparacion.Length; i++)
                    row[i] = coheficientes[i];

                dataTable.Rows.Add(row);
            }

            int column = resultado.CabeceraComparacion.Length;

            foreach (var modeloAproximacion in resultados)
            {
                Output output = modeloAproximacion.Value;
                int rowNumber = 0;
                foreach (var aproximacion in output.Aproximaciones)
                {
                    var row = dataTable.Rows[rowNumber];
                    row[column] = aproximacion;
                    rowNumber++;
                }

                rowNumber = 0;
                foreach (var error in output.Errores)
                {
                    var row = dataTable.Rows[rowNumber];
                    row[column + resultados.Count] = error;
                    rowNumber++;
                }

                column++;
            }








            this.dataGridView1.DataSource = dataTable;
            
        }
    }
}
