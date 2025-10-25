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
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "diálogo"
                    //    (El código se pausa aquí hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el código sigue
                    //    y cerramos el formulario de Login, terminando la aplicación.
                    this.Close();
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
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "diálogo"
                    //    (El código se pausa aquí hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el código sigue
                    //    y cerramos el formulario de Login, terminando la aplicación.
                    this.Close();
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
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "diálogo"
                    //    (El código se pausa aquí hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el código sigue
                    //    y cerramos el formulario de Login, terminando la aplicación.
                    this.Close();
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
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "diálogo"
                    //    (El código se pausa aquí hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el código sigue
                    //    y cerramos el formulario de Login, terminando la aplicación.
                    this.Close();
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
