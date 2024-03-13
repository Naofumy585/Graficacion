using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficacion
{
    class DDA
    {
        public double CalcularPendiente(double x1, double x2, double y1, double y2)
        {
            // Verificar si y1 es igual a y2
            if (y1 == y2)
            {
                throw new ArgumentException("Los valores de y1 y y2 son iguales. No se puede calcular la pendiente.");
            }

            // Verificar si x1 es igual a x2 para evitar una división por cero
            if (x1 == x2)
            {
                throw new ArgumentException("Los valores de x1 y x2 son iguales. No se puede calcular la pendiente.");
            }

            // Calcular la pendiente
            return (y2 - y1) / (x2 - x1);
        }
        public double CalcularTriangulo(double x1, double x2, double y1, double y2,double x3,double y3)
        {
            //// Crear un objeto Pen para dibujar las líneas del triángulo
            //Pen pen = new Pen(Color.Black);

            //// Dibujar las líneas que unen los vértices del triángulo
            //g.DrawLine(pen, (double)x1, (double)y1, (double)x2, (double)y2);
            //g.DrawLine(pen, (double)x2, (double)y2, (double)x3, (double)y3);
            //g.DrawLine(pen, (double)x3, (double)y3, (double)x1, (double)y1)   
            return 0;
        }
    }
}
