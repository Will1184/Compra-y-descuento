// Eva:3
// Ejercicio:
// Fecha: 10/11/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GD: #1
// Instructora: ING. NELLY LISSETTE HENRIQUEZ SANCHEZ
namespace PE3GL01GM21057
{
    public partial class Form1 : Form
    {
        List <Invitado> invitados=new List<Invitado>();
        List<Socio> socios =new List<Socio>();
        List<Empleado> empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            try
            {
                if (textBoxTipo.Text.ToLower().Equals("socio"))
                {
                    Socio socio = new Socio(textBoxNombre.Text, textBoxUsuario.Text,
                        textBoxTelefono.Text, textBoxCorreo.Text, textBoxDireccion.Text,
                        textBoxContraseña.Text);
                    MessageBox.Show("Su codigo es: " + socio.Codigo(),"Codigo");
                    socios.Add(socio);
                    form2.Show();

                }
                else if (textBoxTipo.Text.ToLower().Equals("empleado"))
                {
                    Empleado empleado = new Empleado(textBoxNombre.Text, textBoxUsuario.Text,
                        textBoxTelefono.Text, textBoxCorreo.Text, textBoxDireccion.Text,
                        textBoxContraseña.Text);
                    MessageBox.Show("Su codigo es: " + empleado.Codigo(), "Codigo");
                    empleados.Add(empleado);
                    form2.Show();
                }
                else if (textBoxTipo.Text.ToLower().Equals("invitado"))
                {
                    Invitado invitado = new Invitado(textBoxNombre.Text, textBoxUsuario.Text,
                        textBoxTelefono.Text, textBoxCorreo.Text, textBoxDireccion.Text,
                        textBoxContraseña.Text);
                    MessageBox.Show("Su codigo es: " + invitado.Codigo(), "Codigo");
                    invitados.Add(invitado);
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Error: No se introdujo Datos", "Error");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error :"+a.Message,"Error");
            }
           
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void borrar()
        {

        }
    }
}