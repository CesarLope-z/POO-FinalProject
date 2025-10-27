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
    public partial class especialidaMedico : Form
    {
        public int idEspecialidad;
        public string connectionString = @"Server=DESKTOP-1TN96GE;Database=GestionCitasMedicas;Trusted_Connection=True;";
        public especialidaMedico()
        {
            InitializeComponent();
        }

        public void especialidaMedico_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            idEspecialidad = comboBox1.SelectedIndex + 1;
            this.Hide();

        }
    }
}
