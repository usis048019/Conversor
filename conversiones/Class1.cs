using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    class Class1
    {
        double[][] Val = new double[5][] { 
        new double[]{1, 1.33, 796.500, 3404.97, 0.92, 7.63550},
         
        new double[]{33.8, 1, 274.15},
        
        new double[]{1, 8, 8000, 8e+6, 8e+9, 8e+12},

         new double[]{100, 1, 1000, 160934, 1.43},
            
         new double[]{1, 1000, 454, 28.35},           
        };

        public double convertir(double porcentaje, int Ab, int Dc, int opcion)
        {
            return Val[opcion][Ab] / Val[opcion][Dc] * porcentaje;
        }
    }

}
