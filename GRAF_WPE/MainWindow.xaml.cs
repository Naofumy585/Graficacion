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
using OxyPlot.Axes;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Wpf;
using OxyPlot.Series;
using System.Windows.Media.Media3D;

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
            var puntosElipse = CalcularPuntosElipse(xCentro, yCentro, radioX, radioY);
            CalcularPuntosElipseT(radioX, radioY, xCentro, yCentro);
            DibujarElipse(xCentro, yCentro, radioX, radioY);
            MostrarCoordenadasEnTablas(radioX, radioY, xCentro, yCentro);
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
                puntos.Add(new Tuple<int, double, double, double>(1, Math.Round(x + xCentro, 4), Math.Round(y + yCentro, 4), Math.Round(x + xCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(2, Math.Round(x + xCentro, 4), Math.Round(-y + yCentro, 4), Math.Round(x + xCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(3, Math.Round(-x + xCentro, 4), Math.Round(-y + yCentro, 4), Math.Round(-x + xCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(4, Math.Round(-x + xCentro, 4), Math.Round(y + yCentro, 4), Math.Round(-x + xCentro, 4)));

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
                puntos.Add(new Tuple<int, double, double, double>(1, Math.Round(x + xCentro, 4), Math.Round(y + yCentro, 4), Math.Round(x + xCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(2, Math.Round(x + xCentro, 4), Math.Round(-y + yCentro, 4), Math.Round(x + xCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(3, Math.Round(-x + xCentro, 4), Math.Round(-y + yCentro, 4), Math.Round(-x + xCentro, 4)));
                puntos.Add(new Tuple<int, double, double, double>(4, Math.Round(-x + xCentro, 4), Math.Round(y + yCentro, 4), Math.Round(-x + xCentro, 4)));

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
       
        private List<Tuple<int, double, double>> CalcularPuntosElipseT(double radioX, double radioY, double xCentro, double yCentro)
        {
            List<Tuple<int, double, double>> puntosElipse = new List<Tuple<int, double, double>>();

            // Inicialización de variables
            double x = 0;
            double y = radioY;
            double p1 = radioY * radioY - radioX * radioX * radioY + 0.25 * radioX * radioX;
            double dx = 2 * radioY * radioY * x;
            double dy = 2 * radioX * radioX * y;

            // Región I
            while (dx < dy)
            {
                // Agregar puntos
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro + x, yCentro + y));
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro + x, yCentro - y));
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro - x, yCentro + y));
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro - x, yCentro - y));

                // Calcular siguiente punto
                x++;
                dx += 2 * radioY * radioY;
                if (p1 < 0)
                {
                    p1 += dx + radioY * radioY;
                }
                else
                {
                    y--;
                    dy -= 2 * radioX * radioX;
                    p1 += dx - dy + radioY * radioY;
                }
            }

            // Región II
            double p2 = radioY * radioY * (x + 0.5) * (x + 0.5) + radioX * radioX * (y - 1) * (y - 1) - radioX * radioX * radioY * radioY;
            while (y > 0)
            {
                // Agregar puntos
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro + x, yCentro + y));
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro + x, yCentro - y));
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro - x, yCentro + y));
                puntosElipse.Add(new Tuple<int, double, double>((int)x, xCentro - x, yCentro - y));

                // Calcular siguiente punto
                y--;
                dy -= 2 * radioX * radioX;
                if (p2 > 0)
                {
                    p2 -= dy + radioX * radioX;
                }
                else
                {
                    x++;
                    dx += 2 * radioY * radioY;
                    p2 += dx - dy + radioX * radioX;
                }
            }

            return puntosElipse;
        }
        private void MostrarCoordenadasEnTablas(double radioX, double radioY, double xCentro, double yCentro)
        {
            // Calcular los puntos de la elipse
            var puntosElipse = CalcularPuntosElipse(radioX, radioY, xCentro, yCentro);

            // Limpiar los DataGrids
            for (int i = 1; i <= 4; i++)
            {
                DataGrid dataGrid = FindName($"Pk{i}") as DataGrid;
                if (dataGrid != null)
                {
                    dataGrid.Items.Clear();
                    dataGrid.Columns.Clear();
                    if (i == 1)
                    {
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Pk", Binding = new Binding("Item1") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "X", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Y", Binding = new Binding("Item3") });
                    }
                    else if (i == 2)
                    {
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "X", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-Y", Binding = new Binding("Item3") });
                    }
                    else if (i == 3)
                    {
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-X", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-Y", Binding = new Binding("Item3") });
                    }
                    else if (i == 4)
                    {
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-X", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Y", Binding = new Binding("Item3") });
                    }
                }
            }

            // Agregar las coordenadas a las tablas
            foreach (var punto in puntosElipse)
            {
                double x = punto.Item2;
                double y = punto.Item3;

                for (int i = 1; i <= 4; i++)
                {
                    DataGrid dataGrid = FindName($"Pk{i}") as DataGrid;
                    if (dataGrid != null)
                    {
                        double newX, newY;

                        // Ajustar coordenadas según el cuadrante
                        switch (i)
                        {
                            case 1:
                                newX = x;
                                newY = y;
                                break;
                            case 2:
                                newX = x;
                                newY = -y;
                                break;
                            case 3:
                                newX = -x;
                                newY = -y;
                                break;
                            case 4:
                                newX = -x;
                                newY = y;
                                break;
                            default:
                                newX = x;
                                newY = y;
                                break;
                        }

                        // Trasladar al centro
                        newX += xCentro;
                        newY += yCentro;

                        dataGrid.Items.Add(new Tuple<int, double, double>((int)punto.Item1, newX, newY));
                    }
                }
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

            // Crear un nuevo PlotModel para mostrar la elipse
            var plotModel = new PlotModel();

            // Crear una serie de áreas para colorear los cuadrantes
            var areaSeries = new AreaSeries();

            // Dividir los puntos de la elipse en grupos según el cuadrante al que pertenecen
            var cuadrantes = new List<List<DataPoint>>();
            for (int i = 0; i < 4; i++)
            {
                cuadrantes.Add(new List<DataPoint>());
            }

            foreach (var punto in puntosElipse)
            {
                int cuadrante = punto.Item1;
                double x = punto.Item3;
                double y = punto.Item4;
                cuadrantes[cuadrante - 1].Add(new DataPoint(x, y));
            }

            // Definir los colores para cada cuadrante
            var colores = new List<OxyColor> { OxyColors.LightBlue, OxyColors.LightGreen, OxyColors.Black, OxyColors.LightPink };

            // Agregar los cuadrantes al modelo de trazado y colorearlos
            for (int i = 0; i < 4; i++)
            {
                var serie = new AreaSeries();
                serie.Points.AddRange(cuadrantes[i]);
                serie.Color = colores[i];
                plotModel.Series.Add(serie);
            }

            // Agregar los puntos de la elipse como puntos individuales en color negro
            var puntosSeries = new ScatterSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 3,
                MarkerStroke = OxyColors.Black
            };

            foreach (var punto in puntosElipse)
            {
                double x = punto.Item3;
                double y = punto.Item4;
                puntosSeries.Points.Add(new ScatterPoint(x, y));
            }

            plotModel.Series.Add(puntosSeries);

            // Configurar los ejes del gráfico
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.All, Minimum = xCentro - 250, Maximum = xCentro + 250 });
            plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Right, Minimum = xCentro - 250, Maximum = yCentro + 250 });

            // Asignar el PlotModel al PlotView
            GraficaE.Model = plotModel;
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