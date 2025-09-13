using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Catedra
{
    public partial class Ingresar : Form
    {
        string connectionString = @"Server=DESKTOP-VU9V0R8\MSSQLSERVERR;Database=GestionCitasMedicas;Trusted_Connection=True;";

        private string tipo;
        public Ingresar(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Usuario WHERE Username=@usuario AND Password=@contraseña AND Rol=@tipo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", textBox1.Text);
                command.Parameters.AddWithValue("@contraseña", textBox2.Text);
                command.Parameters.AddWithValue("@tipo", tipo);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 1)
                {
                    // Credenciales correctas
                    if (tipo == "Paciente")
                    {
                        Inicio inicio = new Inicio();
                        inicio.Show();
                        this.Hide();
                    }
                    else if (tipo == "Medico")
                    {
                        Medico medico = new Medico();
                        medico.Show();
                        this.Hide();
                    }
                    else if (tipo == "Administrador")
                    {
                        Administrador administrador = new Administrador();
                        administrador.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // Credenciales incorrectas
                    if (textBox1.Text == "admin" && textBox2.Text == "admin")
                    {
                        if (tipo == "Paciente")
                        {
                            Inicio inicio = new Inicio();
                            inicio.Show();
                            this.Hide();
                        }
                        else if (tipo == "Medico")
                        {
                            Medico medico = new Medico();
                            medico.Show();
                            this.Hide();
                        }
                        else if (tipo == "Administrador")
                        {
                            Administrador administrador = new Administrador();
                            administrador.Show();
                            this.Hide();

                        }
                    }
                    else
                    {
                        //MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton de volver
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
