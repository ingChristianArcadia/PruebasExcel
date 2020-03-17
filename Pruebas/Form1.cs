using System;
using IronXL;
using System.Linq;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkBook archivoExcel = WorkBook.Create(ExcelFileFormat.XLS);
            archivoExcel.Metadata.Author = "Arcadia";

            WorkSheet hojaExcel = archivoExcel.CreateWorkSheet("Productos");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idProducto = tbId.Text;
            string nombreProducto = tbNombre.Text;
            string cantidadProducto = tbCantidad.Text;
            this.dgvProductos.Rows.Add(idProducto,nombreProducto,cantidadProducto);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.Columns.Add("idProducto","ID");
            dgvProductos.Columns.Add("nombreProducto", "PRODUCTO");
            dgvProductos.Columns.Add("cantidadProducto", "CANTIDAD");
        }
    }
}
