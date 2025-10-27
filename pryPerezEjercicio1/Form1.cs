namespace pryPerezEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intentosFallidos = 0;

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
                    intentosFallidos = 0; // ¡REINICIAMOS EL CONTADOR!
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
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya llegó a 2
                    if (intentosFallidos == 2)
                    {
                        // Si llegó a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el número de intentos. La aplicación se cerrará.");
                        this.Close();
                    }
                }
            }
            // ¿Es John?
            else if (usuario == "John" && contraseña == "*2b")
            {
                if (modulo == "SIST")
                {
                    intentosFallidos = 0; // ¡REINICIAMOS EL CONTADOR!
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
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya llegó a 2
                    if (intentosFallidos == 2)
                    {
                        // Si llegó a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el número de intentos. La aplicación se cerrará.");
                        this.Close();
                    }
                }
            }
            // ¿Es Ceci? (Tu código corregido)
            else if (usuario == "Ceci" && contraseña == "*@3c")
            {
                if (modulo == "ADM" || modulo == "VTA")
                {
                    intentosFallidos = 0; // ¡REINICIAMOS EL CONTADOR!
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
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya llegó a 2
                    if (intentosFallidos == 2)
                    {
                        // Si llegó a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el número de intentos. La aplicación se cerrará.");
                        this.Close();
                    }
                }
            }
            // ¿Es God? (Tu código corregido)
            else if (usuario == "God" && contraseña == "*@#4d")
            {
                if (modulo == "ADM" || modulo == "SIST" || modulo == "COM" || modulo == "VTA")
                {
                    intentosFallidos = 0; // ¡REINICIAMOS EL CONTADOR!
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
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya llegó a 2
                    if (intentosFallidos == 2)
                    {
                        // Si llegó a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el número de intentos. La aplicación se cerrará.");
                        this.Close();
                    }
                }
            }
            // ¿No es NINGUNO de los anteriores?
            else
            {
                // 1. Mostramos el error de siempre
                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado.");

                // 2. Sumamos 1 al contador
                intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                // 3. Verificamos si el contador ya llegó a 2
                if (intentosFallidos == 2)
                {
                    // Si llegó a 2, mostramos un mensaje final y cerramos
                    MessageBox.Show("Ha superado el número de intentos. La aplicación se cerrará.");
                    this.Close();
                }
            }
        }
    }
    
}
