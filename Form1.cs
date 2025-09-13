namespace POO_Catedra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar("Paciente");
            ingresar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar("Medico");
            ingresar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar("Administrador");
            ingresar.Show();
            this.Hide();
        }
    }
}
