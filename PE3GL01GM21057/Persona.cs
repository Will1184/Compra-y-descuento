using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3GL01GM21057
{
    internal abstract class Persona
    {
        private string nombre, nombreUsuario, telefono, correoElectronico, direccion, contraseña;

        public Persona()
        {
        }

        public Persona(string nombre, string nombreUsuario, string telefono, string correoElectronico, string direccion, string contraseña)
        {
            this.nombre = nombre;
            this.nombreUsuario = nombreUsuario;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.contraseña = contraseña;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public abstract void CalcularPagosPorServicios();
        public abstract string Codigo();
    }
}
