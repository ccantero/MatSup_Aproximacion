namespace Interface
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOutout = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnDecimales = new System.Windows.Forms.Button();
            this.decimalesValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.btnBorrarPuntos = new System.Windows.Forms.Button();
            this.yValue = new System.Windows.Forms.NumericUpDown();
            this.xValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOutput = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMejorAproximacion = new System.Windows.Forms.Button();
            this.btnHiperbola = new System.Windows.Forms.Button();
            this.btnPotencial = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.btnRecta = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.tabOutout.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decimalesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValue)).BeginInit();
            this.tabOutput.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOutout
            // 
            this.tabOutout.Controls.Add(this.tabInput);
            this.tabOutout.Controls.Add(this.tabOutput);
            this.tabOutout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOutout.Location = new System.Drawing.Point(0, 0);
            this.tabOutout.Margin = new System.Windows.Forms.Padding(1);
            this.tabOutout.Name = "tabOutout";
            this.tabOutout.SelectedIndex = 0;
            this.tabOutout.Size = new System.Drawing.Size(656, 442);
            this.tabOutout.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.tableLayoutPanel1);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Margin = new System.Windows.Forms.Padding(1);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(1);
            this.tabInput.Size = new System.Drawing.Size(648, 416);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Carga de Datos";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 414);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(324, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(321, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnDecimales);
            this.groupBox1.Controls.Add(this.decimalesValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAgregarPunto);
            this.groupBox1.Controls.Add(this.btnBorrarPuntos);
            this.groupBox1.Controls.Add(this.yValue);
            this.groupBox1.Controls.Add(this.xValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(321, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCalcular.Location = new System.Drawing.Point(1, 236);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(319, 36);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnDecimales
            // 
            this.btnDecimales.Location = new System.Drawing.Point(197, 150);
            this.btnDecimales.Margin = new System.Windows.Forms.Padding(1);
            this.btnDecimales.Name = "btnDecimales";
            this.btnDecimales.Size = new System.Drawing.Size(122, 30);
            this.btnDecimales.TabIndex = 6;
            this.btnDecimales.Text = "Configurar Decimales";
            this.btnDecimales.UseVisualStyleBackColor = true;
            this.btnDecimales.Click += new System.EventHandler(this.btnDecimales_Click);
            // 
            // decimalesValue
            // 
            this.decimalesValue.Location = new System.Drawing.Point(60, 157);
            this.decimalesValue.Margin = new System.Windows.Forms.Padding(1);
            this.decimalesValue.Name = "decimalesValue";
            this.decimalesValue.Size = new System.Drawing.Size(45, 20);
            this.decimalesValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decimales";
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.Location = new System.Drawing.Point(258, 75);
            this.btnAgregarPunto.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(61, 30);
            this.btnAgregarPunto.TabIndex = 4;
            this.btnAgregarPunto.Text = "Agregar";
            this.btnAgregarPunto.UseVisualStyleBackColor = true;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // btnBorrarPuntos
            // 
            this.btnBorrarPuntos.Location = new System.Drawing.Point(1, 199);
            this.btnBorrarPuntos.Margin = new System.Windows.Forms.Padding(1);
            this.btnBorrarPuntos.Name = "btnBorrarPuntos";
            this.btnBorrarPuntos.Size = new System.Drawing.Size(319, 36);
            this.btnBorrarPuntos.TabIndex = 7;
            this.btnBorrarPuntos.Text = "Borrar";
            this.btnBorrarPuntos.UseVisualStyleBackColor = true;
            this.btnBorrarPuntos.Click += new System.EventHandler(this.btnBorrarPuntos_Click);
            // 
            // yValue
            // 
            this.yValue.DecimalPlaces = 4;
            this.yValue.Location = new System.Drawing.Point(18, 50);
            this.yValue.Margin = new System.Windows.Forms.Padding(1);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(91, 20);
            this.yValue.TabIndex = 3;
            // 
            // xValue
            // 
            this.xValue.DecimalPlaces = 4;
            this.xValue.Location = new System.Drawing.Point(18, 22);
            this.xValue.Margin = new System.Windows.Forms.Padding(1);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(91, 20);
            this.xValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // tabOutput
            // 
            this.tabOutput.Controls.Add(this.tableLayoutPanel2);
            this.tabOutput.Location = new System.Drawing.Point(4, 22);
            this.tabOutput.Margin = new System.Windows.Forms.Padding(1);
            this.tabOutput.Name = "tabOutput";
            this.tabOutput.Padding = new System.Windows.Forms.Padding(1);
            this.tabOutput.Size = new System.Drawing.Size(648, 416);
            this.tabOutput.TabIndex = 1;
            this.tabOutput.Text = "Resultados";
            this.tabOutput.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnMejorAproximacion, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnHiperbola, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnPotencial, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnExponencial, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRecta, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnParabola, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(646, 414);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnMejorAproximacion
            // 
            this.btnMejorAproximacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMejorAproximacion.Location = new System.Drawing.Point(8, 317);
            this.btnMejorAproximacion.Margin = new System.Windows.Forms.Padding(8);
            this.btnMejorAproximacion.Name = "btnMejorAproximacion";
            this.btnMejorAproximacion.Size = new System.Drawing.Size(307, 89);
            this.btnMejorAproximacion.TabIndex = 5;
            this.btnMejorAproximacion.Text = "Mejor Aproximación";
            this.btnMejorAproximacion.UseVisualStyleBackColor = true;
            this.btnMejorAproximacion.Click += new System.EventHandler(this.btnMejorAproximacion_Click);
            // 
            // btnHiperbola
            // 
            this.btnHiperbola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHiperbola.Location = new System.Drawing.Point(8, 214);
            this.btnHiperbola.Margin = new System.Windows.Forms.Padding(8);
            this.btnHiperbola.Name = "btnHiperbola";
            this.btnHiperbola.Size = new System.Drawing.Size(307, 87);
            this.btnHiperbola.TabIndex = 4;
            this.btnHiperbola.Text = "Hipérbola";
            this.btnHiperbola.UseVisualStyleBackColor = true;
            this.btnHiperbola.Click += new System.EventHandler(this.btnHiperbola_Click);
            // 
            // btnPotencial
            // 
            this.btnPotencial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPotencial.Location = new System.Drawing.Point(331, 111);
            this.btnPotencial.Margin = new System.Windows.Forms.Padding(8);
            this.btnPotencial.Name = "btnPotencial";
            this.btnPotencial.Size = new System.Drawing.Size(307, 87);
            this.btnPotencial.TabIndex = 3;
            this.btnPotencial.Text = "Potencial";
            this.btnPotencial.UseVisualStyleBackColor = true;
            this.btnPotencial.Click += new System.EventHandler(this.btnPotencial_Click);
            // 
            // btnExponencial
            // 
            this.btnExponencial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExponencial.Location = new System.Drawing.Point(8, 111);
            this.btnExponencial.Margin = new System.Windows.Forms.Padding(8);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(307, 87);
            this.btnExponencial.TabIndex = 2;
            this.btnExponencial.Text = "Exponencial";
            this.btnExponencial.UseVisualStyleBackColor = true;
            this.btnExponencial.Click += new System.EventHandler(this.btnExponencial_Click);
            // 
            // btnRecta
            // 
            this.btnRecta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecta.Location = new System.Drawing.Point(8, 8);
            this.btnRecta.Margin = new System.Windows.Forms.Padding(8);
            this.btnRecta.Name = "btnRecta";
            this.btnRecta.Size = new System.Drawing.Size(307, 87);
            this.btnRecta.TabIndex = 1;
            this.btnRecta.Text = "Recta";
            this.btnRecta.UseVisualStyleBackColor = true;
            this.btnRecta.Click += new System.EventHandler(this.btnRecta_Click);
            // 
            // btnParabola
            // 
            this.btnParabola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnParabola.Location = new System.Drawing.Point(331, 8);
            this.btnParabola.Margin = new System.Windows.Forms.Padding(8);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Size = new System.Drawing.Size(307, 87);
            this.btnParabola.TabIndex = 0;
            this.btnParabola.Text = "Parábola";
            this.btnParabola.UseVisualStyleBackColor = true;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 442);
            this.Controls.Add(this.tabOutout);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabOutout.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decimalesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xValue)).EndInit();
            this.tabOutput.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOutout;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.Button btnBorrarPuntos;
        private System.Windows.Forms.NumericUpDown yValue;
        private System.Windows.Forms.NumericUpDown xValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecimales;
        private System.Windows.Forms.NumericUpDown decimalesValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnParabola;
        private System.Windows.Forms.Button btnHiperbola;
        private System.Windows.Forms.Button btnPotencial;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.Button btnRecta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMejorAproximacion;
    }
}