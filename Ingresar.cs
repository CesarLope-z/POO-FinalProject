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
        string connectionString = @"Server=DESKTOP-1TN96GE;Database=GestionCitasMedicas;Trusted_Connection=True;";

        public Ingresar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Rol, ID_Paciente, ID_Medico FROM Usuario WHERE Username=@usuario AND Password=@contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", textBox1.Text);
                command.Parameters.AddWithValue("@contraseña", textBox2.Text);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int idRol = reader.GetInt32(0);

                        if (idRol == 1) // Rol Paciente
                        {
                            int idPersona = reader.GetInt32(1);
                            Inicio inicio = new Inicio(idPersona);
                            inicio.Show();
                            this.Hide();
                        }
                        else if (idRol == 2) // Rol Medico
                        {
                            int idPersona = reader.GetInt32(2);
                            Medico medico = new Medico(idPersona);
                            medico.Show();
                            this.Hide();
                        }
                        else if (idRol == 3) // Rol administrador o secretario
                        {
                            
                            Administrador admin = new Administrador();
                            admin.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
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
