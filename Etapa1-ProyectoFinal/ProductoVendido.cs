using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1_ProyectoFinal
{
    public class ProductoVendido
    {

        //Atributos de la clase

        private int id = 0;
        private int idProducto = 0;
        private int stock = 0;
        private int idVenta = 0;

        //Constructor


    public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;

        }
    }
}
