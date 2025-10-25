namespace pryPerezEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // 1. Leemos los datos de los controles
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string modulo = cmbModulo.Text;

            // 2. Inicia la cadena de validación
            // ¿Es Adm?
            if (usuario == "Adm" && contraseña == "@1a")
            {
                if (modulo == "ADM" || modulo == "COM" || modulo == "VTA")
                {
                    MessageBox.Show("¡Login Exitoso!");
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");
                }
            }
            // ¿Es John?
            else if (usuario == "John" && contraseña == "*2b")
            {
                if (modulo == "SIST")
                {
                    MessageBox.Show("¡Login Exitoso!");
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");
                }
            }
            // ¿Es Ceci? (Tu código corregido)
            else if (usuario == "Ceci" && contraseña == "*@3c")
            {
                if (modulo == "ADM" || modulo == "VTA")
                {
                    MessageBox.Show("¡Login exitoso!"); // 'M' y 'B' mayúsculas
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");
                }
            }
            // ¿Es God? (Tu código corregido)
            else if (usuario == "God" && contraseña == "*@#4d")
            {
                if (modulo == "ADM" || modulo == "SIST" || modulo == "COM" || modulo == "VTA")
                {
                    MessageBox.Show("¡Login exitoso!"); // Faltaba ;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado."); // Faltaba ;
                }
            }
            // ¿No es NINGUNO de los anteriores?
            else
            {
                // Este es el 'else' final que atrapa a todos los demás.
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado."); // Faltaba ;
            }
        }
    }
    
}
