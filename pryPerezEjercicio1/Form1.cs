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
            string contrase�a = txtContrase�a.Text;
            string modulo = cmbModulo.Text;

            // 2. Inicia la cadena de validaci�n
            // �Es Adm?
            if (usuario == "Adm" && contrase�a == "@1a")
            {
                if (modulo == "ADM" || modulo == "COM" || modulo == "VTA")
                {
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
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");
                }
            }
            // �Es John?
            else if (usuario == "John" && contrase�a == "*2b")
            {
                if (modulo == "SIST")
                {
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
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");
                }
            }
            // �Es Ceci? (Tu c�digo corregido)
            else if (usuario == "Ceci" && contrase�a == "*@3c")
            {
                if (modulo == "ADM" || modulo == "VTA")
                {
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
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado.");
                }
            }
            // �Es God? (Tu c�digo corregido)
            else if (usuario == "God" && contrase�a == "*@#4d")
            {
                if (modulo == "ADM" || modulo == "SIST" || modulo == "COM" || modulo == "VTA")
                {
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
                    MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado."); // Faltaba ;
                }
            }
            // �No es NINGUNO de los anteriores?
            else
            {
                // Este es el 'else' final que atrapa a todos los dem�s.
                MessageBox.Show("Usuario y/o contrase�a incorrectos para el m�dulo seleccionado."); // Faltaba ;
            }
        }
    }
    
}
