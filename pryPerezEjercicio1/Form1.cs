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
            string contrase�a = txtContrase�a.Text;
            string modulo = cmbModulo.Text;

            // 2. Inicia la cadena de validaci�n
            // �Es Adm?
            if (usuario == "Adm" && contrase�a == "@1a")
            {
                if (modulo == "ADM" || modulo == "COM" || modulo == "VTA")
                {
                    intentosFallidos = 0; // �REINICIAMOS EL CONTADOR!
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "di�logo"
                    //    (El c�digo se pausa aqu� hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el c�digo sigue
                    //    y cerramos el formulario de Login, terminando la aplicaci�n.
                    this.Close();
                }
                else
                {
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya lleg� a 2
                    if (intentosFallidos == 2)
                    {
                        // Si lleg� a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el n�mero de intentos. La aplicaci�n se cerrar�.");
                        this.Close();
                    }
                }
            }
            // �Es John?
            else if (usuario == "John" && contrase�a == "*2b")
            {
                if (modulo == "SIST")
                {
                    intentosFallidos = 0; // �REINICIAMOS EL CONTADOR!
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "di�logo"
                    //    (El c�digo se pausa aqu� hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el c�digo sigue
                    //    y cerramos el formulario de Login, terminando la aplicaci�n.
                    this.Close();
                }
                else
                {
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya lleg� a 2
                    if (intentosFallidos == 2)
                    {
                        // Si lleg� a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el n�mero de intentos. La aplicaci�n se cerrar�.");
                        this.Close();
                    }
                }
            }
            // �Es Ceci? (Tu c�digo corregido)
            else if (usuario == "Ceci" && contrase�a == "*@3c")
            {
                if (modulo == "ADM" || modulo == "VTA")
                {
                    intentosFallidos = 0; // �REINICIAMOS EL CONTADOR!
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "di�logo"
                    //    (El c�digo se pausa aqu� hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el c�digo sigue
                    //    y cerramos el formulario de Login, terminando la aplicaci�n.
                    this.Close();
                }
                else
                {
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya lleg� a 2
                    if (intentosFallidos == 2)
                    {
                        // Si lleg� a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el n�mero de intentos. La aplicaci�n se cerrar�.");
                        this.Close();
                    }
                }
            }
            // �Es God? (Tu c�digo corregido)
            else if (usuario == "God" && contrase�a == "*@#4d")
            {
                if (modulo == "ADM" || modulo == "SIST" || modulo == "COM" || modulo == "VTA")
                {
                    intentosFallidos = 0; // �REINICIAMOS EL CONTADOR!
                    // 1. Ocultamos el formulario de Login para que no se vea
                    this.Hide();

                    // 2. Creamos el OBJETO a partir de la CLASE frmBienvenida
                    frmBienvenida ventanaBienvenida = new frmBienvenida();

                    // 3. Mostramos la nueva ventana en modo "di�logo"
                    //    (El c�digo se pausa aqu� hasta que se cierre la ventana Bienvenida)
                    ventanaBienvenida.ShowDialog();

                    // 4. Cuando el usuario cierra la ventana de Bienvenida, el c�digo sigue
                    //    y cerramos el formulario de Login, terminando la aplicaci�n.
                    this.Close();
                }
                else
                {
                    // 1. Mostramos el error de siempre
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");

                    // 2. Sumamos 1 al contador
                    intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                    // 3. Verificamos si el contador ya lleg� a 2
                    if (intentosFallidos == 2)
                    {
                        // Si lleg� a 2, mostramos un mensaje final y cerramos
                        MessageBox.Show("Ha superado el n�mero de intentos. La aplicaci�n se cerrar�.");
                        this.Close();
                    }
                }
            }
            // �No es NINGUNO de los anteriores?
            else
            {
                // 1. Mostramos el error de siempre
                MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");

                // 2. Sumamos 1 al contador
                intentosFallidos = intentosFallidos + 1; // O puedes usar la forma corta: intentosFallidos++;

                // 3. Verificamos si el contador ya lleg� a 2
                if (intentosFallidos == 2)
                {
                    // Si lleg� a 2, mostramos un mensaje final y cerramos
                    MessageBox.Show("Ha superado el n�mero de intentos. La aplicaci�n se cerrar�.");
                    this.Close();
                }
            }
        }
    }
    
}
