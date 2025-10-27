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
    public partial class Administrador : Form
    {
        string connectionString = @"Server=DESKTOP-1TN96GE;Database=GestionCitasMedicas;Trusted_Connection=True;";

        public Administrador()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Hide();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            //al cargar el formulario cargar los usuarios desde la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select ID_Usuario, Username, NombreRol from Usuario u inner join RolUsuario r on u.ID_Rol = r.ID_Rol";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //filtrar el datagridview por el username ingresado en el textbox
            string filterText = textBox1.Text;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Username LIKE '%{0}%'", filterText);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ir a crear usuario
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //eliminar el usuario seleccionado en el datagridview
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedUserId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Usuario"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Usuario WHERE ID_Usuario = @ID_Usuario";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_Usuario", selectedUserId);
                    command.ExecuteNonQuery();
                }
                //borar el paciente o medico asociado al usuario eliminado
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //primero obtener el rol del usuario eliminado
                    string queryRol = "SELECT ID_Rol, ID_Paciente, ID_Medico FROM Usuario WHERE ID_Usuario = @ID_Usuario";
                    SqlCommand commandRol = new SqlCommand(queryRol, connection);
                    commandRol.Parameters.AddWithValue("@ID_Usuario", selectedUserId);
                    SqlDataReader reader = commandRol.ExecuteReader();
                    if (reader.Read())
                    {
                        int rol = Convert.ToInt32(reader["ID_Rol"]);
                        if (rol == 1) //paciente
                        {
                            int idPaciente = Convert.ToInt32(reader["ID_Paciente"]);
                            reader.Close();
                            string queryPaciente = "DELETE FROM Paciente WHERE ID_Paciente = @ID_Paciente";
                            SqlCommand commandPaciente = new SqlCommand(queryPaciente, connection);
                            commandPaciente.Parameters.AddWithValue("@ID_Paciente", idPaciente);
                            commandPaciente.ExecuteNonQuery();
                        }
                        else if (rol == 2) //medico
                        {
                            int idMedico = Convert.ToInt32(reader["ID_Medico"]);
                            reader.Close();
                            string queryMedico = "DELETE FROM Medico WHERE ID_Medico = @ID_Medico";
                            SqlCommand commandMedico = new SqlCommand(queryMedico, connection);
                            commandMedico.Parameters.AddWithValue("@ID_Medico", idMedico);
                            commandMedico.ExecuteNonQuery();
                        }
                    }
                    reader.Close();
                }
                //refrescar el datagridview
                Administrador_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un usuario para eliminar.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gestionarCita gestionarCita = new gestionarCita();
            gestionarCita.Show();
            this.Hide();
        }
    }
}
