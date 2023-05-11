using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1_ProyectoFinal
{
    public class Producto
    {
        //Atributos

        private int id = 0;
        private string descripcion = string.Empty;
        private double costo = 0;
        private double precioVenta = 0;
        private int stock = 0;
        private int idUsuario = 0;

        // Constructor

        public Producto( int id, string drescripcion, double costo, double precioVenta, int stock, int idUsuario )

        {
            this.id = id;
           this.descripcion = drescripcion;
            this.costo = costo;
            this.precioVenta= precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }



    }
}
