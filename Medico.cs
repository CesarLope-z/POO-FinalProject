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
    public partial class Medico : Form
    {
        public string connectionString = @"Server=DESKTOP-1TN96GE;Database=GestionCitasMedicas;Trusted_Connection=True;";
        public int idMedico;
        public Medico(int idMedico)
        {
            InitializeComponent();
            this.idMedico = idMedico;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverM_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Hide();
        }

        private void Medico_Load(object sender, EventArgs e)
        {
            //solo usa un select from citas where id_medico = this.idMedico
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Fecha, Hora, P.Nombre as Paciente, telefono " +
                               "FROM Cita C " +
                               "JOIN Paciente P ON C.ID_Paciente = P.ID_Paciente " +
                               "WHERE C.ID_Medico = @ID_Medico";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID_Medico", idMedico);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

            //en el data grid view coloca una tabla de horarios de atencion aleatoria sin consultar la base de datos
            DataTable horariosTable = new DataTable();
            horariosTable.Columns.Add("Día");
            horariosTable.Columns.Add("Horario de Atención");
            horariosTable.Rows.Add("Lunes", "09:00 - 12:00");
            horariosTable.Rows.Add("Martes", "14:00 - 18:00");
            horariosTable.Rows.Add("Miércoles", "09:00 - 12:00");
            horariosTable.Rows.Add("Jueves", "14:00 - 18:00");
            dataGridView3.DataSource = horariosTable;


        }
    }
}
