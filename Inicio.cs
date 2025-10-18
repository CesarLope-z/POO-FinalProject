using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Catedra
{
    public partial class Inicio : Form
    {
        public int idPaciente;

        public Inicio(int idPaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarCita generarCita = new GenerarCita();
            generarCita.Show();
            this.Hide();
        }

        private void btnVolverP_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Hide();
        }
    }
}
