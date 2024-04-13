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
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Wpf;
using OxyPlot.Series;

namespace GRAF_WPC
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            GraficaC.Model = new PlotModel();
        }

        private void textX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, RoutedEventArgs e)
        {// Obtener el valor del radio desde el TextBox
            if (!double.TryParse(Text_R.Text, out double radio))
            {
                MessageBox.Show("Ingrese un valor válido para el radio.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Obtener las coordenadas del centro de la circunferencia desde los TextBox
            if (!double.TryParse(textX.Text, out double xCentro))
            {
                MessageBox.Show("Ingrese un valor válido para la coordenada X del centro.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!double.TryParse(TexY.Text, out double yCentro))
            {
                MessageBox.Show("Ingrese un valor válido para la coordenada Y del centro.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Calcular las coordenadas de los puntos de la circunferencia utilizando el algoritmo DDA
            List<Tuple<int, double, double, double>> puntosCircunferencia = CalcularPuntosCircunferencia(xCentro, yCentro, radio);

            // Mostrar las coordenadas de los puntos en las tablas
            MostrarCoordenadasEnTablasYDibujarCircunferencia(puntosCircunferencia);
            Dibujar_HojaCuadriculada(xCentro - radio, yCentro - radio, 2 * radio, 2 * radio, 10); // Por ejemplo, con una separación de 10 unidades entre líneas
            Dibujar_RellenarC(xCentro, yCentro, radio);
        }

        private List<Tuple<int, double, double, double>> CalcularPuntosCircunferencia(double xCentro, double yCentro, double radio)
        {
            // Calcular las coordenadas de los puntos de la circunferencia utilizando el algoritmo DDA
            List<Tuple<int, double, double, double>> puntos = new List<Tuple<int, double, double, double>>();

            double x = 0;
            double y = radio;
            double p = 1 - radio; // Valor inicial del parámetro de decisión
            int iteracion = 0;

            while (x <= y)
            {
                // Agregar los puntos al resultado
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, x + xCentro, y + yCentro));
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, y + xCentro, x + yCentro));
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, -x + xCentro, y + yCentro));
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, -y + xCentro, x + yCentro));
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, x + xCentro, -y + yCentro));
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, y + xCentro, -x + yCentro));
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, -x + xCentro, -y + yCentro));
                puntos.Add(new Tuple<int, double, double, double>(iteracion, p, -y + xCentro, -x + yCentro));

                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                iteracion++;
            }

            return puntos;
        }

        private void MostrarCoordenadasEnTablasYDibujarCircunferencia(List<Tuple<int, double, double, double>> puntosCircunferencia)
        {
            // Limpiar los DataGrids
            for (int i = 1; i <= 9; i++)
            {
                DataGrid dataGrid = FindName($"Pk{i}") as DataGrid;
                if (dataGrid != null)
                {
                    dataGrid.Items.Clear();
                    if (i == 1)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Pk", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Xk+1", Binding = new Binding("Item3") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Yk-1", Binding = new Binding("Item4") });
                    }
                    else if (i == 2)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Y", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "X", Binding = new Binding("Item3") });
                    }
                    else if (i == 3)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-Y", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "X", Binding = new Binding("Item3") });
                    }
                    else if (i == 4)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "X", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-Y", Binding = new Binding("Item3") });
                    }
                    else if (i == 5)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-Y", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-X", Binding = new Binding("Item3") });
                    }
                    else if (i == 6)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-X", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-Y", Binding = new Binding("Item3") });
                    }
                    else if (i == 7)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-X", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Y", Binding = new Binding("Item3") });
                    }
                    else if (i == 8)
                    {
                        dataGrid.Columns.Clear();
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "Y", Binding = new Binding("Item2") });
                        dataGrid.Columns.Add(new DataGridTextColumn() { Header = "-X", Binding = new Binding("Item3") });
                    }
                }
            }

            // Agregar las coordenadas a las tablas
            foreach (var punto in puntosCircunferencia)
            {
                int iteracion = punto.Item1;
                double p = punto.Item2;
                double x = punto.Item3;
                double y = punto.Item4;

                int tablaIndex = iteracion % 9 + 1; // Asignar iteraciones a las tablas
                DataGrid dataGrid = FindName($"Pk{tablaIndex}") as DataGrid;
                if (dataGrid != null)
                {
                    dataGrid.Items.Add(new Tuple<int, double, double, double>(iteracion, p, x, y));
                }
            }
        }
        private void Dibujar_RellenarC(double xCentro, double yCentro, double radio)
        {
            List<DataPoint> puntosCircunferenciaPlot = new List<DataPoint>();

            // Definir el ángulo de inicio y final para dibujar solo la porción del círculo correspondiente al radio dado
            double anguloInicio = 0;
            double anguloFin = 2 * Math.PI;

            // Calcular los puntos de la circunferencia
            for (double theta = anguloInicio; theta <= anguloFin; theta += 0.1)
            {
                double x = xCentro + radio * Math.Cos(theta);
                double y = yCentro + radio * Math.Sin(theta);
                puntosCircunferenciaPlot.Add(new DataPoint(x, y));
            }

            // Crear un nuevo PlotModel para mostrar el círculo
            var plotModel = new PlotModel();

            // Agregar un AreaSeries para rellenar el círculo
            var circunferenciaRellenaSeries = new AreaSeries
            {
                Color = OxyColors.LightBlue
            };
            circunferenciaRellenaSeries.Points.AddRange(puntosCircunferenciaPlot);
            plotModel.Series.Add(circunferenciaRellenaSeries);

            // Configurar los ejes del gráfico para que tengan una escala de 300x300 y el círculo esté centrado
            plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = xCentro - 150, Maximum = xCentro + 150 });
            plotModel.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = yCentro - 150, Maximum = yCentro + 150 });

            // Agregar un círculo al gráfico
            var circleAnnotation = new OxyPlot.Annotations.EllipseAnnotation
            {
                X = xCentro,
                Y = yCentro,
                Width = radio * 2,
                Height = radio * 2
            };
            plotModel.Annotations.Add(circleAnnotation);

            // Asignar el PlotModel al PlotView
            GraficaC.Model = plotModel;
        }
        private void Dibujar_HojaCuadriculada(double xInicio, double yInicio, double ancho, double alto, double separacion)
        {
            // Crear un nuevo PlotModel para la hoja cuadriculada
            var plotModel = new PlotModel();

            // Agregar líneas verticales para representar las columnas de la cuadrícula
            for (double x = xInicio; x <= xInicio + ancho; x += separacion)
            {
                var verticalLineSeries = new LineSeries
                {
                    Color = OxyColors.LightGray,
                    StrokeThickness = 1
                };
                verticalLineSeries.Points.Add(new DataPoint(x, yInicio));
                verticalLineSeries.Points.Add(new DataPoint(x, yInicio + alto));
                plotModel.Series.Add(verticalLineSeries);
            }

            // Agregar líneas horizontales para representar las filas de la cuadrícula
            for (double y = yInicio; y <= yInicio + alto; y += separacion)
            {
                var horizontalLineSeries = new LineSeries
                {
                    Color = OxyColors.LightGray,
                    StrokeThickness = 1
                };
                horizontalLineSeries.Points.Add(new DataPoint(xInicio, y));
                horizontalLineSeries.Points.Add(new DataPoint(xInicio + ancho, y));
                plotModel.Series.Add(horizontalLineSeries);
            }

            // Asignar el PlotModel al PlotView
            GraficaC.Model = plotModel;
        }

       
        private void LimpiarDataGrid(DataGrid dataGrid)
        {
            dataGrid.Items.Clear();
        }

        private void btn_Limpiar_Click(object sender, RoutedEventArgs e)
        {
            // Limpiar TextBoxes
            textX.Text = "";
            TexY.Text = "";
            Text_R.Text = "";

            // Limpiar DataGrids
            LimpiarDataGrid(Pk1);
            LimpiarDataGrid(Pk2);
            LimpiarDataGrid(Pk3);
            LimpiarDataGrid(Pk4);
            LimpiarDataGrid(Pk5);
            LimpiarDataGrid(Pk6);
            LimpiarDataGrid(Pk7);
            LimpiarDataGrid(Pk8);
            GraficaC.Model = null;
        }
    }
}