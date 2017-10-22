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
        public ResultadoComparacion(Input input, Output resultado)
        {
            InitializeComponent();

            this.Size = new Size(1000, 600);
            this.dataGridView1.Size = new Size(520, 450);

            var ancho = input.Puntos.Max(p => p.X) + 1;

            var dataTable = new DataTable();

           
            foreach (var cabecera in resultado.CabeceraResultados)
            {
                dataTable.Columns.Add(cabecera, typeof(double));
            }

            foreach (var coheficientes in resultado.Resultados)
            {
                var row = dataTable.NewRow();
                for (int i = 0; i < coheficientes.Length; i++)
                    row[i] = coheficientes[i];

                dataTable.Rows.Add(row);
            }

            var rowTotales = dataTable.NewRow();
            for (int i = 0; i < resultado.Totales.Length; i++)
            {
                rowTotales[i] = resultado.Totales[i];
            }
            dataTable.Rows.Add(rowTotales);

            this.dataGridView1.DataSource = dataTable;
        }
    }
}
