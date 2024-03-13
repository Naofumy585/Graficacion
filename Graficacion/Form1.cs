using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficacion
{
    public partial class Form1 : Form
    {
        private List<double> listaX = new List<double>();
        private List<double> listaY = new List<double>();
        public Form1()
        {
            InitializeComponent();
            chartResultados.MouseMove += ChartResultados_MouseMove;
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBox
                double x1 = double.Parse(txtvalorXa.Text);
                double y1 = double.Parse(txtvalorYa.Text);
                double x2 = double.Parse(txtvalorXb.Text);
                double y2 = double.Parse(txtvalorYb.Text);
                double x3 = double.Parse(txtvalorXc.Text);
                double y3 = double.Parse(txtvalorYc.Text);

                // Llamamos al método CalcularPendiente de la instancia de DDA
                DDA dda = new DDA();

                // Calcular la pendiente para los lados del triángulo
                double pendienteAB = dda.CalcularPendiente(x1, x2, y1, y2);
                double pendienteBC = dda.CalcularPendiente(x2, x3, y2, y3);
                double pendienteCA = dda.CalcularPendiente(x3, x1, y3, y1);

                // Crear listas para almacenar los puntos del triángulo
                listaX.Clear();
                listaY.Clear();

                // Calcular nuevos valores utilizando la pendiente para el lado AB
                for (int i = 0; i <= 10; i++)
                {
                    double x = x1 + i * (x2 - x1) / 10;
                    double y = y1 + pendienteAB * (x - x1);
                    listaX.Add(x);
                    listaY.Add(y);
                }

                // Calcular nuevos valores utilizando la pendiente para el lado BC
                for (int i = 0; i <= 10; i++)
                {
                    double x = x2 + i * (x3 - x2) / 10;
                    double y = y2 + pendienteBC * (x - x2);
                    listaX.Add(x);
                    listaY.Add(y);
                }

                // Calcular nuevos valores utilizando la pendiente para el lado CA
                for (int i = 0; i <= 10; i++)
                {
                    double x = x3 + i * (x1 - x3) / 10;
                    double y = y3 + pendienteCA * (x - x3);
                    listaX.Add(x);
                    listaY.Add(y);
                }

                // Mostrar en el DataGridView
                MostrarEnDataGridView();

                // Mostrar en el Chart
                MostrarEnChart();

                // Mostrar valores de los puntos en los TextBox
                txta1.Text = $"A: ({Convert.ToInt32(x1)}, {Convert.ToInt32(y1)})";
                txtb1.Text = $"B: ({Convert.ToInt32(x2)}, {Convert.ToInt32(y2)})";
                txtc1.Text = $"C: ({Convert.ToInt32(x3)}, {Convert.ToInt32(y3)})";
            }
            catch (FormatException)
            {
                MessageBox.Show("Uno o más valores ingresados no son números válidos.", "Error: Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Uno o más valores ingresados son demasiado grandes o demasiado pequeños para ser procesados.", "Error: Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnDataGridView()
        {
            dataGridViewResultados.Rows.Clear();
            for (int i = 0; i < listaX.Count; i++)
            {
                double x = listaX[i];
                double y = listaY[i];

                // Formatear el valor de X como entero
                string xFormateado = x.ToString("F0");

                // Formatear el valor de Y según si tiene decimales o no
                string yFormateado = y % 1 == 0 ? y.ToString("F0") : y.ToString("F2");

                // Agregar una nueva fila con los valores formateados
                dataGridViewResultados.Rows.Add(xFormateado, yFormateado);
            }
        }

        private void MostrarEnChart()
        {
            chartResultados.Series.Clear();

            // Crear una nueva serie para la gráfica
            Series serie = new Series("Triángulo");
            serie.ChartType = SeriesChartType.Line;
            serie.BorderWidth = 2; // Ajusta el ancho de la línea según tus preferencias

            // Agregar puntos a la serie para el triángulo
            for (int i = 0; i < listaX.Count; i++)
            {
                double scaledX = Escalar(listaX[i]);
                double scaledY = Escalar(listaY[i]);
                serie.Points.AddXY(scaledX, scaledY);

                // Marcar los vértices del triángulo con un marcador diferente
                if (i == 0 || i == 11 || i == 22)
                {
                    DataPoint vertex = serie.Points[serie.Points.Count - 1];
                    vertex.MarkerStyle = MarkerStyle.Diamond;
                    vertex.MarkerColor = Color.Green;
                }
            }

            // Agregar la serie al chart
            chartResultados.Series.Add(serie);

            // Establecer límites manuales para los ejes X e Y
            chartResultados.ChartAreas[0].AxisX.Minimum = 0;
            chartResultados.ChartAreas[0].AxisX.Maximum = 150;
            chartResultados.ChartAreas[0].AxisY.Minimum = 0;
            chartResultados.ChartAreas[0].AxisY.Maximum = 150;
        }

        private double Escalar(double value)
        {
            return (value / 100) * 150;
        }

        private void ChartResultados_MouseMove(object sender, MouseEventArgs e)
        {
            Chart chart = (Chart)sender;

            try
            {
                Point mousePoint = new Point(e.X, e.Y);
                HitTestResult result = chart.HitTest(mousePoint.X, mousePoint.Y);

                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    DataPoint dataPoint = chart.Series[0].Points[result.PointIndex];
                    string coordenadas = $"X: {dataPoint.XValue:F2}, Y: {dataPoint.YValues[0]:F2}";

                    toolTip1.SetToolTip(chart, coordenadas);
                }
                else
                {
                    toolTip1.SetToolTip(chart, "");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error de desbordamiento: {ex.Message}");
            }
        }

        private string DeterminarTipoCaso(double pendiente)
        {
            if (pendiente < 1)
            {
                return "-M<1";
            }
            else if (pendiente > 1)
            {
                return "-M>1";
            }
            else if (pendiente == 1)
            {
                double angulo = Math.Atan(pendiente) * (180 / Math.PI);
                return $"-M=1 ({angulo:F2} grados)";
            }
            else if (pendiente == 0)
            {
                return "-M=0 (No se puede graficar)";
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos. Asegúrese de que y2 sea mayor que y1 o y1 sea menor que y2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
                Environment.Exit(0);
                return "-Error";
            }
        }

        private double ObtenerMinimo(List<double> valores)
        {
            return valores.Min();
        }

        private double ObtenerMaximo(List<double> valores)
        {
            return valores.Max();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvalorXb.Clear();
            txtvalorXa.Clear();
            txtvalorYb.Clear();
            txtvalorYa.Clear();
            txtvalorXc.Clear();
            txtvalorYc.Clear();
            txtpendiente.Clear();
            txtcaso.Clear();
            txta1.Clear();
            txtb1.Clear();
            txtc1.Clear();
            txta2.Clear();
            txtb2.Clear();

            dataGridViewResultados.Rows.Clear();
            toolTip1.SetToolTip(chartResultados, "");

            while (chartResultados.Series.Count > 1)
            {
                chartResultados.Series.RemoveAt(1);
            }
            chartResultados.Series[0].Points.Clear();
        }

        private void chartResultados_Click(object sender, EventArgs e)
        {

        }

        private void txtvalorYb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
