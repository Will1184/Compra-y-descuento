using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3GL01GM21057
{
    internal class Invitado : Persona
    {
        public Invitado()
        {
        }

        public Invitado(string nombre, string nombreUsuario, string telefono, string correoElectronico, string direccion, string contraseña) : base(nombre, nombreUsuario, telefono, correoElectronico, direccion, contraseña)
        {
        }

        public override void CalcularPagosPorServicios()
        {
            throw new NotImplementedException();
        }

        public override string Codigo()
        {
            return "I01023";
        }
    }
}
