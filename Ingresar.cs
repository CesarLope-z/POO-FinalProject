using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Catedra
{
    public partial class Ingresar : Form
    {
        private string tipo;
        public Ingresar(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Usuario o contraseña incorrectos");
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
