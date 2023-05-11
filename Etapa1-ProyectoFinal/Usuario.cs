using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa1_ProyectoFinal
{
    public class Usuario

    {
        //Atributos de la clase Usuario 

        private int id = 0;
        private string nombre = string.Empty;
        private string apellido = string.Empty;
        private string nombreUsuario = string.Empty;
        private string contraseña = string.Empty;
        private string mail = string.Empty;

        //Constructor
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)

        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.mail = mail;
        }

    

    }
}
