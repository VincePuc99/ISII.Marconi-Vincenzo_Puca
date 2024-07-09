using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Punto
    {
        //Attributi
        private double x;  //Coordinata ascissa
        private double y;  //Coordinata ordinata

        //Metodi

        //Costruttore di questa classe
        public Punto()
        {
            x = 0.0;
            y = 0.0;
        }

        public Punto(double ValX,double ValY)
        {
            x = ValX;
            y = ValY;
        }
        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public void IncX()
        {           
                x++;           
        }

        public void IncY()
        {          
                y++;
        }

    }
}
