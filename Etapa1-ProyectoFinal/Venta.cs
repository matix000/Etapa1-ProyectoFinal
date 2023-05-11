using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1_ProyectoFinal
{
    public class Venta
    {
        //Atributos
        private int id = 0;
        private string comentarios = string.Empty;
        private int idUsuario = 0;

        //Constructor

        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios; 
            this.idUsuario = idUsuario;


        }
    }
}
