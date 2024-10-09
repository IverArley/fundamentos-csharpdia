using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2
{
    public class Car
    {
        //Atributos del carro
        string color;
        int cilindraje;
        int modelo;

        //Metodo
        public string stop()
        {
            string msj = "El carro esta detenido";
            return msj;
        }
    }
}