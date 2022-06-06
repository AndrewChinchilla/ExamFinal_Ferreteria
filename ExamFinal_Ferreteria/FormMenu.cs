using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamFinal_Ferreteria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            FormInventario formulario = new FormInventario();
            formulario.Show();

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormClientes formulario = new FormClientes();
            formulario.Show();
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formulario = new FormProveedores();
            formulario.Show();
        }

        private void buttonsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
