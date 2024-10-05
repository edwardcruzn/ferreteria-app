using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarMensaje();

        }
        //Metodo
        //Crear un metodo publico, los metodos deben comenzar por verbos
        public void mostrarMensaje()
        {
            //Crear un objeto de Car
            Car objCar = new Car();
            //Creo una variable local de tipo string
            string msj = objCar.stop();
            LblMensaje.Text = msj;

        }
            

    }
}