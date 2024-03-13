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
                double x1 = double.Parse(txtvalorXb.Text);
                double x2 = double.Parse(txtvalorXa.Text);
                double y1 = double.Parse(txtvalorYb.Text);
                double y2 = double.Parse(txtvalorYa.Text);
                // Llamamos al método CalcularPendiente de la instancia de DDA

                DDA dda = new DDA();

                // Calcular la pendiente utilizando la instancia de DDA
                double pendiente = dda.CalcularPendiente(x1, x2, y1, y2);


                string tipoCaso = DeterminarTipoCaso(pendiente);
                txtcaso.Text = tipoCaso;

                // Calcular la dirección para x
                string direccionX = x2 > x1 ? "Izq>Der" : "Der>Izq";
                txta2.Text = direccionX;

                // Calcular la dirección para y
                string direccionY = y2 > y1 ? "Abj>Arrb" : "Arrb<Abj";
                txtb2.Text = direccionY;

                // Limpiar listas
                listaX.Clear();
                listaY.Clear();

                // Calcular nuevos valores utilizando la pendiente
                for (int i = 0; i < 10; i++)
                {
                    double x = x1 + i; // Puedes ajustar la variación de x según tus necesidades
                    double y = y1 + pendiente * (x - x1);

                    // Agregar valores a las listas
                    listaX.Add(x);
                    listaY.Add(y);
                }

                // Mostrar en el DataGridView
                MostrarEnDataGridView();

                // Mostrar en el Chart
                MostrarEnChart();

                // Mostrar valores de x1, y1 en txta1 y x2, y2 en txtb1
                txta1.Text = $"X1: {Convert.ToInt32(x1)}, Y1: {Convert.ToInt32(y1)}";
                txtb1.Text = $"X2: {Convert.ToInt32(x2)}, Y2: {Convert.ToInt32(y2)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Uno o más valores ingresados no son números válidos.", "Error: Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart(); // Reiniciar la aplicación
                Environment.Exit(0);   // Salir completamente para asegurar el reinicio
            }
            catch (OverflowException)
            {
                MessageBox.Show("Uno o más valores ingresados son demasiado grandes o demasiado pequeños para ser procesados.", "Error: Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart(); // Reiniciar la aplicación
                Environment.Exit(0);   // Salir completamente para asegurar el reinicio
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart(); // Reiniciar la aplicación
                Environment.Exit(0);   // Salir completamente para asegurar el reinicio
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
            Series serie = new Series("Línea");
            serie.ChartType = SeriesChartType.Line;
            serie.BorderWidth = 4; // Ajusta el ancho de la línea según tus preferencias

            // Agregar puntos a la serie
            for (int i = 0; i < listaX.Count; i++)
            {
                // Escalar los puntos para que estén dentro del rango 0-150
                double scaledX = Escalar(listaX[i]);
                double scaledY = Escalar(listaY[i]);
                serie.Points.AddXY(scaledX, scaledY);
            }

            // Marcar el punto inicial con un marcador diferente
            serie.Points[0].MarkerStyle = MarkerStyle.Circle;
            serie.Points[0].MarkerColor = System.Drawing.Color.Red;

            // Marcar el punto final con un marcador diferente
            serie.Points[listaX.Count - 1].MarkerStyle = MarkerStyle.Square;
            serie.Points[listaX.Count - 1].MarkerColor = System.Drawing.Color.Blue;

            // Agregar la serie al chart
            chartResultados.Series.Add(serie);

            // Establecer límites manuales para los ejes X e Y
            chartResultados.ChartAreas[0].AxisX.Minimum = 0;
            chartResultados.ChartAreas[0].AxisX.Maximum = 150;
            chartResultados.ChartAreas[0].AxisY.Minimum = 0;
            chartResultados.ChartAreas[0].AxisY.Maximum = 150;
        }

        // Método para escalar un valor dentro del rango 0-150
        private double Escalar(double value)
        {
            // Se asume que el rango original está entre 0 y 100
            // Se utiliza una regla de tres simple para escalar el valor al rango 0-150
            return (value / 100) * 150;
        }

        private void ChartResultados_MouseMove(object sender, MouseEventArgs e)
        {
            Chart chart = (Chart)sender;

            try
            {
                // Obtener las coordenadas del mouse en relación con el gráfico
                Point mousePoint = new Point(e.X, e.Y);
                HitTestResult result = chart.HitTest(mousePoint.X, mousePoint.Y);

                // Verificar si el puntero está sobre un punto de la serie
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    DataPoint dataPoint = chart.Series[0].Points[result.PointIndex];
                    string coordenadas = $"X: {dataPoint.XValue:F2}, Y: {dataPoint.YValues[0]:F2}";

                    // Mostrar las coordenadas en algún lugar, como un ToolTip
                    toolTip1.SetToolTip(chart, coordenadas);
                }
                else
                {
                    // Si no está sobre un punto, borrar el ToolTip
                    toolTip1.SetToolTip(chart, "");
                }
            }
            catch (OverflowException ex)
            {
                // Manejar la excepción de desbordamiento
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
                double angulo = Math.Atan(pendiente) * (180 / Math.PI); // Convertir a grados
                return $"-M=1 ({angulo:F2} grados)";
            }
            else if (pendiente == 0)
            {
                return "-M=0 (No se puede graficar)";
            }
            else
            {
                MessageBox.Show("Ingrese datos válidos. Asegúrese de que y2 sea mayor que y1 o y1 sea menor que y2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart(); // Reiniciar la aplicación
                Environment.Exit(0);   // Salir completamente para asegurar el reinicio
                return "-Error"; // Este return es solo para cumplir con la firma del método, pero en realidad no se ejecutará.
            }
        }

        private double ObtenerMinimo(List<double> valores)
        {
            return valores.Min();
        }

        // Método para obtener el valor máximo de una lista de doubles
        private double ObtenerMaximo(List<double> valores)
        {
            return valores.Max();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox
            txtvalorXb.Clear();
            txtvalorXa.Clear();
            txtvalorYb.Clear();
            txtvalorYa.Clear();
            txtpendiente.Clear();
            txtcaso.Clear();
            txta1.Clear();
            txtb1.Clear();
            txta2.Clear();
            txtb2.Clear();


            // Limpiar el DataGridView
            dataGridViewResultados.Rows.Clear();
            toolTip1.SetToolTip(chartResultados, "");

            // Limpiar las series y los puntos del gráfico (excepto la primera serie)
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
