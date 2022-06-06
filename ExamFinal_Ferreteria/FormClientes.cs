using System;
using ProyectFinalFerreteria.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace ExamFinal_Ferreteria
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }
        private void FormClientes_Load_1(object sender, EventArgs e)
        {
            ClaseConexión.Conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGridView1.DataSource = Full_data();
        }

        public DataTable Full_data()

        {
            ClaseConexión.Conectar();
            DataTable DataT = new DataTable();
            string consulta = "SELECT * FROM Tb_Clientes";
            SqlCommand cmd = new SqlCommand(consulta, ClaseConexión.Conectar());
            SqlDataAdapter dadap = new SqlDataAdapter(cmd);

            dadap.Fill(DataT);
            return DataT;
        }

        private void buttonagregar_Click(object sender, EventArgs e)
        {
            ClaseConexión.Conectar();
            string insertar = "INSERT INTO Tb_Clientes (CódigoCliente,Frecuencia,Nombre,Direccion,Telefono1,Telefono2,Correo) VALUES (@CódigoCliente,@Frecuencia,@Nombre,@Direccion,@Telefono1,@Telefono2,@Correo)";
            SqlCommand cmd1 = new SqlCommand(insertar, ClaseConexión.Conectar());
            cmd1.Parameters.AddWithValue("@CódigoCliente", textBoxcodigocliente.Text);
            cmd1.Parameters.AddWithValue("@Frecuencia", textBoxfrecuencia.Text);
            cmd1.Parameters.AddWithValue("@Nombre", textBoxnombre.Text);
            cmd1.Parameters.AddWithValue("@Direccion", textBoxdireccion.Text);
            cmd1.Parameters.AddWithValue("@Telefono1", textBoxtelefono1.Text);
            cmd1.Parameters.AddWithValue("@Telefono2", textBoxtelefono2.Text);
            cmd1.Parameters.AddWithValue("@Correo", textBoxcorreo.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron añadidos");
            dataGridView1.DataSource = Full_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxIdcliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxcodigocliente.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxfrecuencia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxnombre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxdireccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxtelefono1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxtelefono2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBoxcorreo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }

            catch { }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ClaseConexión.Conectar();
            String actualizar = "UPDATE Tb_Clientes SET CódigoCliente=@CódigoCliente, Frecuencia=@Frecuencia, Nombre=@Nombre, Direccion=@Direccion, Telefono1=@Telefono1, Telefono2=@Telefono2 WHERE CódigoCliente=@CódigoCliente";
            SqlCommand cmd2 = new SqlCommand(actualizar, ClaseConexión.Conectar());

            cmd2.Parameters.AddWithValue("@CódigoCliente", textBoxcodigocliente.Text);
            cmd2.Parameters.AddWithValue("@Frecuencia", textBoxfrecuencia.Text);
            cmd2.Parameters.AddWithValue("@Nombre", textBoxnombre.Text);
            cmd2.Parameters.AddWithValue("@Direccion", textBoxdireccion.Text);
            cmd2.Parameters.AddWithValue("@Telefono1", textBoxtelefono1.Text);
            cmd2.Parameters.AddWithValue("@Telefono2", textBoxtelefono2.Text);
            cmd2.Parameters.AddWithValue("@Correo", textBoxcorreo.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados");
            dataGridView1.DataSource = Full_data();
        }

        private void buttonneliminar_Click(object sender, EventArgs e)
        {
            ClaseConexión.Conectar();
            string eliminar = "DELETE FROM Tb_Clientes WHERE CódigoCliente = @CódigoCliente";
            SqlCommand cmd3 = new SqlCommand(eliminar, ClaseConexión.Conectar());
            cmd3.Parameters.AddWithValue("@CódigoCliente", textBoxcodigocliente.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Datos eliminados");

            dataGridView1.DataSource = Full_data();

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            textBoxIdcliente.Clear();
            textBoxcodigocliente.Clear();
            textBoxfrecuencia.Clear();
            textBoxnombre.Clear();
            textBoxdireccion.Clear();
            textBoxtelefono1.Clear();
            textBoxtelefono2.Clear();
            textBoxcorreo.Clear();
            textBoxcodigocliente.Focus();
        }

        private void buttonbackmenu_Click(object sender, EventArgs e)
        {
            FormMenu ventana = new FormMenu();
            ventana.Show();

            this.Hide();
        }
    }
}
