using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_de_abril.Clases
{
     public class Carro
    {
        public string Marca { get; }
        public int Modelo { get; }
        public string Color { get; set; }
        public string Owner{ get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        public int MAXVELOCIDAD { get; set; }

        public Carro(string m, int model, string col)
        {
            Marca = m;
            Modelo = model;
            Color = col;
        }
        public string Encender()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                velocidad_actual = 0; 
                return "Carro encendido correctamente.";
            }
            else
            {
                return "El carro ya está encendido.";
            }
        }

        public void Apagar()
        {
            if (Encendido == 1)
            {
                Encendido = 0;
                velocidad_actual = 0;
            }
        }

        public int Acelerar()
        {
            if (Encendido == 1 && velocidad_actual < MAXVELOCIDAD)
            {
                velocidad_actual += 10;
            }
            return velocidad_actual;
        }

        public int Desacelerar()
        {
            if (Encendido == 1 && velocidad_actual > 0)
            {
                velocidad_actual -= 10;
                if (velocidad_actual < 0)
                {
                    velocidad_actual = 0;
                }
            }
            return velocidad_actual;
        }

        public int Frenar()
        {
            if (Encendido == 1 && velocidad_actual > 0)
            {
               velocidad_actual = 0;
            }
            return velocidad_actual;
        }

    }
}
