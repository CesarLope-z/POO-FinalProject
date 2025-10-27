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
    public partial class GenerarCita : Form
    {
        string connectionString = @"Server=DESKTOP-1TN96GE;Database=GestionCitasMedicas;Trusted_Connection=True;";
        public int idPaciente;
        public GenerarCita(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(idPaciente);
            inicio.Show();
            this.Hide();
        }

        private void GenerarCita_Load(object sender, EventArgs e)
        {
            //cargar las especialidades en el comboBox 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Especialidad";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["NombreEspecialidad"].ToString());
                }
                reader.Close();
            }



        }
        private void cargarMedicosPorEspecialidad(int idEspecialidad)
        {
            //limpiar el comboBox2
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Medico WHERE ID_Especialidad = @idEspecialidad";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["Nombre"].ToString());
                }
                reader.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // obtener el id de la especialidad seleccionada
            string especialidadSeleccionada = comboBox1.SelectedItem.ToString();
            int idEspecialidad = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Especialidad FROM Especialidad WHERE NombreEspecialidad = @nombreEspecialidad";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreEspecialidad", especialidadSeleccionada);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    idEspecialidad = Convert.ToInt32(reader["ID_Especialidad"]);
                }
                reader.Close();
            }
            // cargar los medicos de la especialidad seleccionada
            cargarMedicosPorEspecialidad(idEspecialidad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //crear la cita en la base de datos, fecha, hora, idPaciente, idMedico, idestado=1
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Cita (Fecha, Hora, ID_Paciente, ID_Medico, ID_Estado) " +
                               "VALUES (@fecha, @hora, @idPaciente, @idMedico, @idEstado)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                command.Parameters.AddWithValue("@hora", dateTimePicker2.Value.TimeOfDay);
                command.Parameters.AddWithValue("@idPaciente", idPaciente); // cambiar por el id del paciente logueado
                // obtener el id del medico seleccionado
                string medicoSeleccionado = comboBox2.SelectedItem.ToString();
                int idMedico = 0;
                string queryMedico = "SELECT ID_Medico FROM Medico WHERE Nombre = @nombreMedico";
                SqlCommand commandMedico = new SqlCommand(queryMedico, connection);
                commandMedico.Parameters.AddWithValue("@nombreMedico", medicoSeleccionado);
                SqlDataReader reader = commandMedico.ExecuteReader();
                if (reader.Read())
                {
                    idMedico = Convert.ToInt32(reader["ID_Medico"]);
                }
                reader.Close();
                command.Parameters.AddWithValue("@idMedico", idMedico);
                command.Parameters.AddWithValue("@idEstado", 1); // estado pendiente
                command.ExecuteNonQuery();
                MessageBox.Show("Cita generada correctamente");
            }
        }
    }
}
