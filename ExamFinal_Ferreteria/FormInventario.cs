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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            dbExamFinal_FerreteriaEntities contexto = new dbExamFinal_FerreteriaEntities();
            dataGridView2.DataSource = contexto.Tb_Inventario.ToList();
        }

        private void insertarVacios()
        {
            this.textBoxID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            this.textBoxCODIGO.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            this.textBoxtipoPro.Text= dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            this.textBoxproducto.Text= dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            this.textBoxexistencias.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            this.textBoxIngreso.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            this.textBoxcosto.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            this.textBoxPrecioP.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
        }
        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textBoxID.Text);
            int Codigo = int.Parse(this.textBoxCODIGO.Text);
            string tipoProducto = textBoxtipoPro.Text;
            string producto = textBoxproducto.Text;
            int existencias = int.Parse(this.textBoxexistencias.Text); ;
            DateTime fechaIngreso = DateTime.Parse(this.textBoxIngreso.Text);
            decimal costo = decimal.Parse(this.textBoxcosto.Text);
            decimal precioPublico = decimal.Parse(this.textBoxPrecioP.Text);

            using (dbExamFinal_FerreteriaEntities contexto = new dbExamFinal_FerreteriaEntities())
            {
                Tb_Inventario v = new Tb_Inventario
                {
                    idNoProducto = id,
                    Código_de_Producto = Codigo,
                    Tipo_De_Producto = tipoProducto,
                    Producto = producto,
                    Existencias = existencias,
                    Fecha_de_Ingreso = fechaIngreso,
                    Costo = costo,
                    Precio_Público = precioPublico
                };
                contexto.Tb_Inventario.Add(v);
                contexto.SaveChanges();
                cargar();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            insertarVacios();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.textBoxID.Text);
            int Codigo = int.Parse(this.textBoxCODIGO.Text);
            string tipoProducto = textBoxtipoPro.Text;
            string producto = textBoxproducto.Text;
            int existencias = int.Parse(this.textBoxexistencias.Text); ;
            DateTime fechaIngreso = DateTime.Parse(this.textBoxIngreso.Text);
            decimal costo = decimal.Parse(this.textBoxcosto.Text);
            decimal precioPublico = decimal.Parse(this.textBoxPrecioP.Text);

            using (dbExamFinal_FerreteriaEntities contexto = new dbExamFinal_FerreteriaEntities())
            {
                Tb_Inventario v = contexto.Tb_Inventario.FirstOrDefault( x => x.idNoProducto==id);
                v.Código_de_Producto = Codigo;
                v.Tipo_De_Producto = tipoProducto;
                v.Producto=producto;
                v.Existencias=existencias;
                v.Fecha_de_Ingreso = fechaIngreso;
                v.Costo= costo;
                v.Precio_Público= precioPublico;
                contexto.SaveChanges();
                cargar();

            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(this.textBoxID.Text);

            using (dbExamFinal_FerreteriaEntities contexto = new dbExamFinal_FerreteriaEntities())
            {
                Tb_Inventario v = contexto.Tb_Inventario.FirstOrDefault(x => x.idNoProducto == id);
                contexto.Tb_Inventario.Remove(v);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void buttonLimpiarDt_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxCODIGO.Clear();
            textBoxtipoPro.Clear();
            textBoxproducto.Clear();
            textBoxexistencias.Clear();
            textBoxIngreso.Clear();
            textBoxcosto.Clear();
            textBoxPrecioP.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu ventana = new FormMenu();
            ventana.Show();

            this.Hide();
        }
    }
}

       
    
