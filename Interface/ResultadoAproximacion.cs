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
    public partial class ResultadoAproximacion : Form
    {
        public ResultadoAproximacion(Input input, Output resultado)
        {
            InitializeComponent();

            this.Size = new Size(1000, 600);
            this.plotView1.Size = new Size(580, 560);
            this.dataGridView1.Size = new Size(520, 450);

            var myModel = new PlotModel { Title = "Example 1" };

            var ancho = input.Puntos.Max(p => p.X) + 1;
            myModel.Series.Add(new FunctionSeries(resultado.Funcion, 0, ancho, 0.1, resultado.Expresion));

            var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle };
            foreach (var punto in input.Puntos)
            {
                scatterSeries.Points.Add(new ScatterPoint(punto.X, punto.Y));
            }

            myModel.Series.Add(scatterSeries);
            this.plotView1.Model = myModel;

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
            this.tableLayoutPanel2.Controls.Add(new Label() {
                Text = "Ecuaciones",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 24, FontStyle.Bold)
            },0,0);

            this.tableLayoutPanel2.Controls.Add(new Label()
            {
                Text = "Resultados",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 24, FontStyle.Bold)
            }, 0, 1);

            this.tableLayoutPanel2.Controls.Add(new Label() {
                Text = "Expresion",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 24, FontStyle.Bold)
            }, 0, 2);

            this.tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            this.tableLayoutPanel2.Controls.Add(new Label() {
                Text = resultado.SistemaEcuaciones,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Lucila Console", 16, FontStyle.Regular)
            }, 1, 0);


            string coheficientesText = "";
            char letra = 'a';

            foreach (var item in resultado.Coheficientes)
            {
                coheficientesText += letra + " = " + item.ToString() + "\n";
                letra = (char)((int) letra + 1);
            }

            this.tableLayoutPanel2.Controls.Add(new Label()
            {
                Text = coheficientesText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Lucila Console", 16, FontStyle.Regular)
            }, 1, 1);

            this.tableLayoutPanel2.Controls.Add(new Label() {
                Text = resultado.Expresion,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Lucila Console", 16, FontStyle.Regular)
            }, 1, 2);



            foreach (DataGridViewColumn column in this.dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.BorderStyle = BorderStyle.None;
        }

        private void ResultadoAproximacion_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Green;
        }
    }
}
