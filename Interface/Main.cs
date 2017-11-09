using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
        int calculado = 0;

        public Main()
        {
            InitializeComponent();

            this.InitializeInput();
            this.InitializeOutput();

            // Test

            //AgregarPunto(1, 1);
            //AgregarPunto(2, 1.5);
            //AgregarPunto(4, 5.3);
            //AgregarPunto(5, 6.3);
            //AgregarPunto(8, 4.8);
            //AgregarPunto(9, 8.3);
            //AgregarPunto(11, 9.4);

            AgregarPunto(1, 5.1);
            AgregarPunto(1.25, 5.79);
            AgregarPunto(1.5, 6.53);
            AgregarPunto(1.75, 7.45);
            AgregarPunto(2, 8.46);

            // Test http://www.monografias.com/trabajos89/regresion-potencial-metodo-minimos-cuadrados/regresion-potencial-metodo-minimos-cuadrados.shtml
            //AgregarPunto(1, 7);
            //AgregarPunto(2, 30);
            //AgregarPunto(3, 90);
            //AgregarPunto(4, 170);
            //AgregarPunto(5, 290);
            //AgregarPunto(6, 450);
            //AgregarPunto(7, 650);

            _input.CantidadDecimales = 4;

            this.decimalesValue.Value = _input.CantidadDecimales;
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

        private void AgregarPunto(double x, double y)
        {
            Punto nuevoPunto = _input.AgregarPunto(x, y);
            _puntosBindingList.Add(nuevoPunto);
        }

        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            var x = Convert.ToDouble(this.xValue.Value);
            var y = Convert.ToDouble(this.yValue.Value);


            this.xValue.Value = 0;
            this.yValue.Value = 0;

            AgregarPunto(x, y);
        }

        private void btnBorrarPuntos_Click(object sender, EventArgs e)
        {
            _input.QuitarPuntos();
            _puntosBindingList.Clear();
            calculado = 0;
            _resultados.Clear();
        }

        private void btnDecimales_Click(object sender, EventArgs e)
        {
            _input.CantidadDecimales = Convert.ToInt32(this.decimalesValue.Value);
            calculado = 0;
            _resultados.Clear();
        }

        private void btnRecta_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Recta))
            {
                //throw new ApplicationException("Calculo previo es requerido");
                MensajeError("Debe presionar el boton calcular antes de proceder.", "Aproximación no calculada");
                this.tabInput.Select();
                this.tabOutout.SelectedTab = this.tabInput;
                this.btnCalcular.Font = new Font(this.btnCalcular.Font.Name, this.btnCalcular.Font.Size, FontStyle.Bold);
                return;
            }


            var resultadoRecta = _resultados[ModeloAproximacion.Recta];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoRecta);
            vistaResultado.Text = "Recta";

            vistaResultado.Show();
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            if (_puntosBindingList == null)
            {
                //throw new ApplicationException("Calculo previo es requerido");
                MensajeError("Debe ingresar datos y presionar el boton calcular antes de proceder.", "Aproximación no calculada");
                if ((!_resultados.ContainsKey(ModeloAproximacion.Parabola)))
                {
                    //throw new ApplicationException("Calculo previo es requerido");
                    MensajeError("Debe presionar el boton calcular antes de proceder.", "Aproximación no calculada");
                    this.tabInput.Select();
                    this.tabOutout.SelectedTab = this.tabInput;
                    this.btnCalcular.Font = new Font(this.btnCalcular.Font.Name, this.btnCalcular.Font.Size, FontStyle.Bold);

                    return;
                }
            }
            var resultadoParabola = _resultados[ModeloAproximacion.Parabola];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoParabola);
            vistaResultado.Text = "Parábola";
            vistaResultado.Show();
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Exponencial))
            {
                //throw new ApplicationException("Calculo previo es requerido");
                MensajeError("Debe presionar el boton calcular antes de proceder.", "Aproximación no calculada");
                this.tabInput.Select();
                this.tabOutout.SelectedTab = this.tabInput;
                this.btnCalcular.Font = new Font(this.btnCalcular.Font.Name, this.btnCalcular.Font.Size, FontStyle.Bold);
                return;
            }

            var resultadoExponencial = _resultados[ModeloAproximacion.Exponencial];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoExponencial);
            vistaResultado.Text = "Exponencial";
            vistaResultado.Show();
        }

        private void btnPotencial_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Potencial))
            {
                //throw new ApplicationException("Calculo previo es requerido");
                MensajeError("Debe presionar el boton calcular antes de proceder.", "Aproximación no calculada");
                this.tabInput.Select();
                this.tabOutout.SelectedTab = this.tabInput;
                this.btnCalcular.Font = new Font(this.btnCalcular.Font.Name, this.btnCalcular.Font.Size, FontStyle.Bold);
                return;
            }

            var resultadoPotencial = _resultados[ModeloAproximacion.Potencial];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoPotencial);
            vistaResultado.Text = "Potencial";
            vistaResultado.Show();
        }

        private void btnHiperbola_Click(object sender, EventArgs e)
        {
            if (!_resultados.ContainsKey(ModeloAproximacion.Hiperbola))
            {
                //throw new ApplicationException("Calculo previo es requerido");
                MensajeError("Debe presionar el boton calcular antes de proceder.", "Aproximación no calculada");
                this.tabInput.Select();
                this.tabOutout.SelectedTab = this.tabInput;
                this.btnCalcular.Font = new Font(this.btnCalcular.Font.Name, this.btnCalcular.Font.Size, FontStyle.Bold);
                return;
            }

            var resultadoHiperbola = _resultados[ModeloAproximacion.Hiperbola];

            var vistaResultado = new ResultadoAproximacion(_input, resultadoHiperbola);
            vistaResultado.Text = "Hipérbola";
            vistaResultado.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (calculado == 0 && _input.Puntos.Count > 0)
            {
                calculado = 1;
                //throw new ApplicationException("Calculo realizado");
                MensajeError("El calculo se realizo con exito.", "Calculo procesado");
                foreach (var modeloAproximacion in _modelosAproximaciones)
                {
                    var resultado = modeloAproximacion.Value.Calcular(_input);
                    _resultados.Add(modeloAproximacion.Key, resultado);
                }

                _mejorResultado = _resultados.Values.Aggregate(
                    (resultado, mejorResulrado) =>
                    {
                        return resultado.ErrorTotal <= mejorResulrado.ErrorTotal ? resultado : mejorResulrado;
                    });
            }
            else
            {
                //throw new ApplicationException("Ya se calculo");
                if(_input.Puntos.Count == 0)
                    MensajeError("Lista de puntos vacia", "Imposible calcular");
                else
                    MensajeError("Estos datos ya han sido calculados.", "Aproximación calculada");
            }
        }

        private void btnMejorAproximacion_Click(object sender, EventArgs e)
        {
            if (_resultados.Count == 0)
            {
                MensajeError("Debe presionar el boton calcular antes de proceder.", "Aproximación no calculada");
                this.tabInput.Select();
                this.tabOutout.SelectedTab = this.tabInput;
                this.btnCalcular.Font = new Font(this.btnCalcular.Font.Name, this.btnCalcular.Font.Size, FontStyle.Bold);
                return;
            }

            var vistaResultado = new ResultadoAproximacion(_input, _mejorResultado);
            vistaResultado.Text = "Mejor Aproximación";
            vistaResultado.Show();

            var vistaComparacion = new ResultadoComparacion(_input, _mejorResultado, _resultados);
            vistaComparacion.Text = "Mejor Aproximación - Comparacion";
            vistaComparacion.Show();

        }

        private void MensajeError(String message, String caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
                
        }
    }
}
