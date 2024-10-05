using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Modelos
{
    public class Car
    {
        /*
         * Atributos del carro (color, cilindraje, modelo)
         */
        string color;
        int cilindraje;
        int modelo;

        /*
         * Metodo public de tipo string
         * Metodo que retorna un mensaje (para que desde el formulario web yo pueda mostrar una cadena)
         */
        public string stop()
        {
            string msj = "El carro esta detenido";
            return msj;
        }
    }
}