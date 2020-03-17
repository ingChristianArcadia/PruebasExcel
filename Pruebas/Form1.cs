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
            WorkBook archivoExcel = WorkBook.Create(ExcelFileFormat.XLSX);
            archivoExcel.Metadata.Author = "Arcadia";
            WorkSheet hojaExcel = archivoExcel.CreateWorkSheet("Productos");
            int i = 1; 
            foreach(DataGridViewRow fila in dgvProductos.Rows)
            {
                Console.WriteLine("Fila: "+i);
                hojaExcel["A" + i].Value = fila.Cells["idProducto"].ToString();
                Console.WriteLine("IdProducto: " + fila.Cells["idProducto"].ToString());
                hojaExcel["B" + i].Value = fila.Cells["nombreProducto"].ToString();
                Console.WriteLine("nombre: " + fila.Cells["nombreProducto"].ToString());
                hojaExcel["C" + i].Value = fila.Cells["cantidadProducto"].ToString();
                Console.WriteLine("Cantidad: " + fila.Cells["cantidadProducto"].ToString());
                i++;
            }
            archivoExcel.SaveAs("C:\\Users\\Arcadia\\Desktop\\Prueba1.xlsx");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idProducto = tbId.Text;
            string nombreProducto = tbNombre.Text;
            string cantidadProducto = tbCantidad.Text;
            this.dgvProductos.Rows.Add(idProducto,nombreProducto,cantidadProducto);

            tbId.Text = "";
            tbNombre.Text = "";
            tbCantidad.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.Columns.Add("idProducto","ID");
            dgvProductos.Columns.Add("nombreProducto", "PRODUCTO");
            dgvProductos.Columns.Add("cantidadProducto", "CANTIDAD");
        }
    }
}
