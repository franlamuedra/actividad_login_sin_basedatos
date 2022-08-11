namespace BugTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
            /*Validamos que las credenciales sean las correctas, caso contrario mostramos un mensaje
            mediante un MessageBox (Esto se implementa en la actividad 3)*/

            /*if (ValidarCredenciales(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Usted a ingresado al sistema");
                    this.Close();
            }*/

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario");
                return;
            }

            //Validamos que se haya ingresado una contraseña
            if ((txtContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña");
                return;
            }
            MessageBox.Show("Usted a ingresado al sistema");
            this.Close();
        }
    }
}