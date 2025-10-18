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
    public partial class Medico : Form
    {
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
    }
}
