using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Core;

namespace Interface
{
    public partial class Main : Form
    {
        private Input _input;
        private BindingList<Punto> _puntosBindingList;
        private IDictionary<ModeloAproximacion, Output> _resultados;
        private IDictionary<ModeloAproximacion, Aproximacion> _modelosAproximaciones;
        private Output _mejorResultado;

        public Main()
        {
            InitializeComponent();

            this.InitializeInput();
            this.InitializeOutput();

            _input.AgregarPunto(1, 1);
            _input.AgregarPunto(2, 1.5);
            _input.AgregarPunto(4, 5.3);
            _input.AgregarPunto(5, 6.3);
            _input.AgregarPunto(8, 4.8);
            _input.AgregarPunto(9, 8.3);
            _input.AgregarPunto(11, 9.4);
            _input.CantidadDecimales = 4;
        }

        private void InitializeOutput()
        {
            _resultados = new Dictionary<ModeloAproximacion, Output>();
            _modelosAproximaciones = new Dictionary<ModeloAproximacion, Aproximacion>
            {
                {ModeloAproximacion.Recta, new RectaMinimosCuadrados()},
                {ModeloAproximacion.Parabola, new ParabolaMinimosCuadrados()},
                {ModeloAproximacion.Exponencial, new ExponencialMinimosCuadrados()},
                {ModeloAproximacion.Potencial, new PotencialMinimosCuadrados()},
                {ModeloAproximacion.Hiperbola, new HiperbolaMinimosCuadrados()}
            };
        }

        private void InitializeInput()
        {
            _input = new Input();
            _puntosBindingList = new BindingList<Punto>();
            this.dataGridView1.DataSource = _puntosBindingList;
        }

        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            var x = Convert.ToDouble(this.xValue.Value);
            var y = Convert.ToDouble(this.yValue.Value);

            var nuevoPunto = _input.AgregarPunto(x, y);

            this.xValue.Value = 0;
            this.yValue.Value = 0;

            _puntosBindingList.Add(nuevoPunto);
        }

        private void btnDecimales_Click(object sender, EventArgs e)
        {
            _input.CantidadDecimales = Convert.ToInt32(this.decimalesValue.Value);
        }

        private void btnRecta_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Recta))
                throw new ApplicationException("Calculo previo es requerido");
            
            var resultadoRecta = _resultados[ModeloAproximacion.Recta];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoRecta);
            vistaResultado.Text = "Recta";

            vistaResultado.Show();
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Parabola))
                throw new ApplicationException("Calculo previo es requerido");
            
            var resultadoParabola = _resultados[ModeloAproximacion.Parabola];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoParabola);
            vistaResultado.Text = "Parábola";
            vistaResultado.Show();
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Exponencial))
                throw new ApplicationException("Calculo previo es requerido");
            
            var resultadoExponencial = _resultados[ModeloAproximacion.Exponencial];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoExponencial);
            vistaResultado.Text = "Exponencial";
            vistaResultado.Show();
        }

        private void btnPotencial_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Potencial))
                throw new ApplicationException("Calculo previo es requerido");
            
            var resultadoPotencial = _resultados[ModeloAproximacion.Potencial];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoPotencial);
            vistaResultado.Text = "Potencial";
            vistaResultado.Show();
        }

        private void btnHiperbola_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Hiperbola))
                throw new ApplicationException("Calculo previo es requerido");

            var resultadoHiperbola = _resultados[ModeloAproximacion.Hiperbola];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoHiperbola);
            vistaResultado.Text = "Hipérbola";
            vistaResultado.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            foreach (var modeloAproximacion in _modelosAproximaciones)
            {
                var resultado = modeloAproximacion.Value.Calcular(_input);
                _resultados.Add(modeloAproximacion.Key, resultado);
            }

            _mejorResultado = _resultados.Values.Aggregate(
                (resultado, mejorResulrado) =>
                {
                    return resultado.ErrorTotal >= mejorResulrado.ErrorTotal ? resultado : mejorResulrado;
                });
        }

        private void btnMejorAproximacion_Click(object sender, EventArgs e)
        {
            var vistaResultado = new ResultadoAproximacion(_input, _mejorResultado);
            vistaResultado.Text = "Mejor Aproximación";
            vistaResultado.Show();
        }
    }
}
