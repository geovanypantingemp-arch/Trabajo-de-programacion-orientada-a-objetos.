using System;
using System.Colections.Generic;
namespace ElTrueque
{
  class Producto
  {
    public string Nombre {get; set;}
    public string Productora {get, set;}
    public int Cantidad {get; set;}
    public Producto(string nombre, string productora, int cantidad)
    {
      Nombre = nombre;
      Productora = productora;
      Cantidad = cantidad;
    }
  }
      

    

