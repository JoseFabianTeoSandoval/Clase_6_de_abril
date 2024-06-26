﻿using System;
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
        public string Owner { get; set; }
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
                return "El carro esta encendido";
            }
            else
            {
                return "El carro ya esta encendido";
            }
        }
        public int Acelerar()
        {
            if (Encendido == 0)
            {
                return 0;
            }
            else
            {
                velocidad_actual += 10;
                return velocidad_actual;
            }

        }
        public string Apagar()
        {
            if (velocidad_actual == 0)
            {
                Encendido = 0;
                return "El carro esta apagado";
            }
            else
            {
                return "El carro esta en movimiento, no se puede apagar";
            }
        }
    }
}