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
    public partial class Inicio : Form
    {
        string connectionString = @"Server=DESKTOP-1TN96GE;Database=GestionCitasMedicas;Trusted_Connection=True;";

        public int idPaciente;

        public Inicio(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarCita generarCita = new GenerarCita(idPaciente);
            generarCita.Show();
            this.Hide();
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // cargar las citas del pacientecon su idPaciente
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * " +
                               "FROM Cita " +
                               "WHERE ID_Paciente = @idPaciente";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPaciente", idPaciente);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }
    }
}
