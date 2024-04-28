using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Graficacion;
using GRAF_WPC;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Wpf;
using OxyPlot.Series;

namespace GRAF_WPE
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GraficaE.Model = new PlotModel();
        }
        private void textX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void btn_Calcular_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el valor de los radios desde los TextBoxes
            if (!double.TryParse(textRx.Text, out double radioX) || !double.TryParse(TexRy.Text, out double radioY))
            {
                MessageBox.Show("Ingrese un valor válido para los radios.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Obtener las coordenadas del centro de la elipse desde los TextBoxes
            if (!double.TryParse(Text_A.Text, out double xCentro))
            {
                MessageBox.Show("Ingrese un valor válido para la coordenada X del centro.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(TextB.Text, out double yCentro))
            {
                MessageBox.Show("Ingrese un valor válido para la coordenada Y del centro.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Calcular los puntos de la elipse y mostrarlos en las tablas
            CalcularYMostrarElipse(xCentro, yCentro, radioX, radioY);

            // Dibujar la elipse en el gráfico
            DibujarElipse(xCentro, yCentro, radioX, radioY);
        }

        private void CalcularYMostrarElipse(double xCentro, double yCentro, double radioX, double radioY)
        {
            // Calcular los puntos de la elipse utilizando el algoritmo proporcionado
            List<Tuple<int, double, double, double>> puntosElipse = CalcularPuntosElipse(xCentro, yCentro, radioX, radioY);

            // Mostrar las coordenadas de los puntos en las tablas
            MostrarCoordenadasEnTablas(puntosElipse);
        }

        private List<Tuple<int, double, double, double>> CalcularPuntosElipse(double xCentro, double yCentro, double radioX, double radioY)
        {
            List<Tuple<int, double, double, double>> puntos = new List<Tuple<int, double, double, double>>();

            double x = 0;
            double y = radioY;
            double p1 = Math.Pow(radioY, 2) - Math.Pow(radioX, 2) * radioY + 0.25 * Math.Pow(radioX, 2);
            double dx = 2 * Math.Pow(radioY, 2) * x;
            double dy = 2 * Math.Pow(radioX, 2) * y;

            // Región 1
            while (dx < dy)
            {
                puntos.Add(new Tuple<int, double, double, double>(1, Math.Round(y + yCentro, 4), Math.Round(x + xCentro, 4), Math.Round(y + yCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(2, Math.Round(-y + yCentro, 4), Math.Round(x + xCentro, 4), Math.Round(-y + yCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(3, Math.Round(-y + yCentro, 4), Math.Round(-x + xCentro, 4), Math.Round(-y + yCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(4, Math.Round(y + yCentro, 4), Math.Round(-x + xCentro, 4), Math.Round(y + yCentro, 4)));

                x++;

                if (p1 < 0)
                {
                    dx = 2 * Math.Pow(radioY, 2) * x;
                    p1 += dx + Math.Pow(radioY, 2);
                }
                else
                {
                    y--;
                    dx = 2 * Math.Pow(radioY, 2) * x;
                    dy = 2 * Math.Pow(radioX, 2) * y;
                    p1 += dx - dy + Math.Pow(radioY, 2);
                }
            }

            // Región 2
            double p2 = Math.Pow(radioY, 2) * Math.Pow((x + 0.5), 2) + Math.Pow(radioX, 2) * Math.Pow((y - 1), 2) - Math.Pow(radioX, 2) * Math.Pow(radioY, 2);
            while (y >= 0)
            {
                puntos.Add(new Tuple<int, double, double, double>(1, Math.Round(y + yCentro, 4), Math.Round(x + xCentro, 4), Math.Round(y + yCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(2, Math.Round(-y + yCentro, 4), Math.Round(x + xCentro, 4), Math.Round(-y + yCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(3, Math.Round(-y + yCentro, 4), Math.Round(-x + xCentro, 4), Math.Round(-y + yCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(4, Math.Round(y + yCentro, 4), Math.Round(-x + xCentro, 4), Math.Round(y + yCentro, 4)));

                y--;

                if (p2 > 0)
                {
                    dy = 2 * Math.Pow(radioX, 2) * y;
                    p2 += -dy + Math.Pow(radioX, 2);
                }
                else
                {
                    x++;
                    dy = 2 * Math.Pow(radioX, 2) * y;
                    dx = 2 * Math.Pow(radioY, 2) * x;
                    p2 += dx - dy + Math.Pow(radioX, 2);
                }
            }

            return puntos;
        }
        private void MostrarCoordenadasEnTablas(List<Tuple<int, double, double, double>> puntosElipse)
        {
            // Limpiar los DataGrids
            LimpiarDataGrid(Pk1);
            LimpiarDataGrid(Pk2);
            LimpiarDataGrid(Pk3);
            LimpiarDataGrid(Pk4);

            // Dividir los puntos en las cuatro tablas según las condiciones dadas
            List<Tuple<int, double, double, double>> pk1 = new List<Tuple<int, double, double, double>>();
            List<Tuple<int, double, double, double>> pk2 = new List<Tuple<int, double, double, double>>();
            List<Tuple<int, double, double, double>> pk3 = new List<Tuple<int, double, double, double>>();
            List<Tuple<int, double, double, double>> pk4 = new List<Tuple<int, double, double, double>>();

            foreach (var punto in puntosElipse)
            {
                int x = (int)punto.Item3;
                int y = (int)punto.Item4;

                if (x >= -8 && x <= -1 && y >= -6 && y <= 0)
                {
                    pk1.Add(punto);
                }
                else if (x >= 1 && x <= 8 && y >= -6 && y <= 0)
                {
                    pk2.Add(punto);
                }
                else if (x >= -8 && x <= -1 && y >= 1 && y <= 6)
                {
                    pk3.Add(punto);
                }
                else if (x >= 1 && x <= 8 && y >= 1 && y <= 6)
                {
                    pk4.Add(punto);
                }
            }

            // Mostrar los puntos en las tablas correspondientes
            MostrarEnTabla(Pk1, pk1);
            MostrarEnTabla(Pk2, pk2);
            MostrarEnTabla(Pk3, pk3);
            MostrarEnTabla(Pk4, pk4);

        }
        private void MostrarEnTabla(DataGrid dataGrid, List<Tuple<int, double, double, double>> puntos)
        {
            foreach (var punto in puntos)
            {
                int iteracion = punto.Item1;
                double x = punto.Item3;
                double y = punto.Item4;

                dataGrid.Items.Add(new { Iteración = iteracion, X = x, Y = y });
            }
        }
        private void LimpiarDataGrid(DataGrid dataGrid)
        {
            dataGrid.Items.Clear();
        }

        private void DibujarElipse(double xCentro, double yCentro, double radioX, double radioY)
        {
            // Calcular los puntos de la elipse utilizando el algoritmo proporcionado
            List<Tuple<int, double, double, double>> puntosElipse = CalcularPuntosElipse(xCentro, yCentro, radioX, radioY);

            // Convertir los puntos a DataPoint
            List<DataPoint> puntosElipseDataPoint = ConvertirATuplas(puntosElipse);

            // Crear un nuevo PlotModel para mostrar la elipse
            var plotModel = new PlotModel();

            // Agregar una serie de línea para dibujar la elipse
            var elipseSeries = new LineSeries
            {
                Color = OxyColors.Blue,
                StrokeThickness = 2
            };
            elipseSeries.Points.AddRange(puntosElipseDataPoint);
            plotModel.Series.Add(elipseSeries);

            // Asignar el PlotModel al PlotView
            GraficaE.Model = plotModel;
        }
        private List<DataPoint> ConvertirATuplas(List<Tuple<int, double, double, double>> puntosElipse)
        {
            List<DataPoint> puntos = new List<DataPoint>();
            foreach (var punto in puntosElipse)
            {
                double x = punto.Item3;
                double y = punto.Item4;
                puntos.Add(new DataPoint(x, y));
            }
            return puntos;
        }

        private void btn_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            // Limpiar TextBoxes
            textRx.Text = "";
            TexRy.Text = "";
            Text_A.Text = "";
            TextB.Text = "";

            // Limpiar DataGrids
            LimpiarDataGrid(Pk1);
            LimpiarDataGrid(Pk2);
            LimpiarDataGrid(Pk3);
            LimpiarDataGrid(Pk4);

            // Limpiar el gráfico
            GraficaE.Model = null;
        }
    }
}
