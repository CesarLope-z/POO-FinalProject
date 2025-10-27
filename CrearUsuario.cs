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
    public partial class CrearUsuario : Form
    {
        string connectionString = @"Server=DESKTOP-1TN96GE;Database=GestionCitasMedicas;Trusted_Connection=True;";

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //primero determinar si es paciente o medico 
            //luego insertar en la tabla correspondiente y finalmente insertar en la tabla usuario
            string nombre = textBox4.Text;
            string apellido = textBox3.Text;
            string telefono = textBox6.Text;
            string username = textBox1.Text;
            //insertar en la tabla Medico o Paciente y con el id obtenido insertar en la tabla Usuario
            string password = textBox2.Text;
            int rol = comboBox1.SelectedIndex + 1; //1 para paciente, 2 para medico
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int idPersona = 0;
                if (rol == 1) //paciente
                {
                    string queryPaciente = "INSERT INTO Paciente (Nombre, Apellido, Telefono, Correo) OUTPUT INSERTED.ID_Paciente VALUES (@Nombre, @Apellido, @Telefono, @Correo)";
                    SqlCommand commandPaciente = new SqlCommand(queryPaciente, connection);
                    commandPaciente.Parameters.AddWithValue("@Nombre", nombre);
                    commandPaciente.Parameters.AddWithValue("@Apellido", apellido);
                    commandPaciente.Parameters.AddWithValue("@Telefono", telefono);
                    commandPaciente.Parameters.AddWithValue("@Correo", username);
                    idPersona = (int)commandPaciente.ExecuteScalar();

                    //nsertar en la tabla Usuario
                    string queryUsuario = "INSERT INTO Usuario (Username, Password, ID_Rol, ID_Paciente) VALUES (@Username, @Password, @ID_Rol, @ID_Paciente)";
                    SqlCommand commandUsuario = new SqlCommand(queryUsuario, connection);
                    commandUsuario.Parameters.AddWithValue("@Username", username);
                    commandUsuario.Parameters.AddWithValue("@Password", password);
                    commandUsuario.Parameters.AddWithValue("@ID_Rol", rol);
                    commandUsuario.Parameters.AddWithValue("@ID_Paciente", idPersona);
                    commandUsuario.ExecuteNonQuery();


                }
                else if (rol == 2) //medico
                {
                    string queryMedico = "INSERT INTO Medico (Nombre, Apellido, Telefono, ID_Especialidad) OUTPUT INSERTED.ID_Medico VALUES (@Nombre, @Apellido, @Telefono, 1)";
                    SqlCommand commandMedico = new SqlCommand(queryMedico, connection);
                    commandMedico.Parameters.AddWithValue("@Nombre", nombre);
                    commandMedico.Parameters.AddWithValue("@Apellido", apellido);
                    commandMedico.Parameters.AddWithValue("@Telefono", telefono);

                    idPersona = (int)commandMedico.ExecuteScalar();

                    //insertar en la tabla Usuario
                    string queryUsuario = "INSERT INTO Usuario (Username, Password, ID_Rol, ID_Medico) VALUES (@Username, @Password, @ID_Rol, @ID_Medico)";
                    SqlCommand commandUsuario = new SqlCommand(queryUsuario, connection);
                    commandUsuario.Parameters.AddWithValue("@Username", username);
                    commandUsuario.Parameters.AddWithValue("@Password", password);
                    commandUsuario.Parameters.AddWithValue("@ID_Rol", rol);
                    commandUsuario.Parameters.AddWithValue("@ID_Medico", idPersona);
                    //retornar el id generado
                    using (especialidaMedico esp = new especialidaMedico())
                    {
                        esp.ShowDialog();
                        int idEspecialidad = esp.idEspecialidad;
                        //actualizar la especialidad del medico
                        string queryActualizarEspecialidad = "UPDATE Medico SET ID_Especialidad = @ID_Especialidad WHERE ID_Medico = @ID_Medico";
                        SqlCommand commandActualizarEspecialidad = new SqlCommand(queryActualizarEspecialidad, connection);
                        commandActualizarEspecialidad.Parameters.AddWithValue("@ID_Especialidad", idEspecialidad);
                        commandActualizarEspecialidad.Parameters.AddWithValue("@ID_Medico", idPersona);
                        commandActualizarEspecialidad.ExecuteNonQuery();
                    }
                    


                    commandUsuario.ExecuteNonQuery();

                }
                else if (rol > 2) //secretario u otro rol futuro
                {
                    string queryMedico = "INSERT INTO Secretaria (Nombre, Apellido, Telefono) OUTPUT INSERTED.ID_Secretaria VALUES (@Nombre, @Apellido, @Telefono)";
                    SqlCommand commandMedico = new SqlCommand(queryMedico, connection);
                    commandMedico.Parameters.AddWithValue("@Nombre", nombre);
                    commandMedico.Parameters.AddWithValue("@Apellido", apellido);
                    commandMedico.Parameters.AddWithValue("@Telefono", telefono);
                    idPersona = (int)commandMedico.ExecuteScalar();

                    string queryUsuario = "INSERT INTO Usuario (Username, Password, ID_Rol, ID_Secretaria) VALUES (@Username, @Password, @ID_Rol, @ID_Secretaria)";
                    SqlCommand commandUsuario = new SqlCommand(queryUsuario, connection);
                    commandUsuario.Parameters.AddWithValue("@Username", username);
                    commandUsuario.Parameters.AddWithValue("@Password", password);
                    commandUsuario.Parameters.AddWithValue("@ID_Rol", rol);
                    commandUsuario.Parameters.AddWithValue("@ID_Secretaria", idPersona);
                }
                MessageBox.Show("Usuario creado exitosamente.");
                Administrador administrador = new Administrador();
                administrador.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //volver al formulario Administrador
            Administrador administrador = new Administrador();
            administrador.Show();
            this.Hide();
        }
    }
}
