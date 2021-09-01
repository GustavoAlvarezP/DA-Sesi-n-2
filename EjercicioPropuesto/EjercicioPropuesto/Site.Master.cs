using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Electrodomesticos.Items.Add(new ListItem("Microondas","1"));
                Electrodomesticos.Items.Add(new ListItem("Refrigeradora", "2"));
                Electrodomesticos.Items.Add(new ListItem("Batidora", "3"));
                Electrodomesticos.Items.Add(new ListItem("Cafetera", "4"));
                Electrodomesticos.Items.Add(new ListItem("Estufa", "5"));
                Electrodomesticos.Items.Add(new ListItem("Tostadora", "6"));


            }
            Grafico.Visible = false;
        }
        protected void Aceptar_ServerClick(object sender, EventArgs e)
        {
            ListItem elemento = Electrodomesticos.Items[Electrodomesticos.SelectedIndex];
            Grafico.Src = "figura" + Electrodomesticos.SelectedIndex.ToString() + ".jpg";
            Grafico.Alt = "Grafico";
            Grafico.Visible = true;
            Nombre.InnerText = "Nombre: ";
            Codigo.InnerText = "Codigo: ";
            Descripcion.InnerText = "Descripcion: ";
            Marca.InnerText = "Marca: ";
            Precio.InnerText = "Precio: ";
            if (elemento.Value == "1")
            {
                Nombre.InnerText = Nombre.InnerText+ "Horno Microondas";
                Codigo.InnerText = Codigo.InnerText + "159874";
                Descripcion.InnerText = Descripcion.InnerText + "Aparato eléctrico que permite la cocción o el " +
                    "calentamiento de alimentos por acción de ondas ultracortas a muy alta frecuencia";
                Marca.InnerText = Marca.InnerText + "Electrolux";
                Precio.InnerText = Precio.InnerText+" S/.250";
            }
            if (elemento.Value == "2")
            {
                Nombre.InnerText = Nombre.InnerText + "Refrigeradora";
                Codigo.InnerText = Codigo.InnerText + "123478";
                Descripcion.InnerText = Descripcion.InnerText + "Aparato eléctrico en forma de armario de metal esmaltado" +
                    " de doble pared, equipado con estantes de rejilla y recipientes, destinado a conservar en frío los alimentos perecederos";
                Marca.InnerText = Marca.InnerText + "Samsung";
                Precio.InnerText = Precio.InnerText + " S/.1700";
            }
            if (elemento.Value == "3")
            {
                Nombre.InnerText = Nombre.InnerText + "Batidora";
                Codigo.InnerText = Codigo.InnerText + "165389";
                Descripcion.InnerText = Descripcion.InnerText + "Utensilio de preparación provisto de accesorios giratorios que sirven para batir," +
                    " mezclar o emulsionar; es un aparato eléctrico que funciona a varias velocidades:";
                Marca.InnerText = Marca.InnerText + "Philips";
                Precio.InnerText = Precio.InnerText + " S/.230";
            }
            if (elemento.Value == "4")
            {
                Nombre.InnerText = Nombre.InnerText + "Cafetera";
                Codigo.InnerText = Codigo.InnerText + "589632";
                Descripcion.InnerText = Descripcion.InnerText + "La cafetera es un recipiente utilizado para servir café y el aparato de cocina q" +
                    "ue permite preparar café como bebida caliente.";
                Marca.InnerText = Marca.InnerText + "General electric";
                Precio.InnerText = Precio.InnerText + " S/.100";
            }
            if (elemento.Value == "5")
            {
                Nombre.InnerText = Nombre.InnerText + "Estufa";
                Codigo.InnerText = Codigo.InnerText + "469853";
                Descripcion.InnerText = Descripcion.InnerText + "Aparato de invención posterior que produce calor y que sirve para calentar, y en alg" +
                    "unos países para cocinar. Funciona tradicionalmente por medio de la combustión";
                Marca.InnerText = Marca.InnerText + "Bosch";
                Precio.InnerText = Precio.InnerText + " S/.500";
            }
            if (elemento.Value == "6")
            {
                Nombre.InnerText = Nombre.InnerText + "Tostadora";
                Codigo.InnerText = Codigo.InnerText + "654789";
                Descripcion.InnerText = Descripcion.InnerText + "Una tostadora o tostador es un pequeño aparato, habitualmente un electrodoméstico, que" +
                    " sirve para tostar rebanadas de pan. A una rebanada de pan sometida a la acción de una tostadora se le llama una tostada.";
                Marca.InnerText = Marca.InnerText + "Whirlpool";
                Precio.InnerText = Precio.InnerText + " S/.127";
            }

        }

    }
}
