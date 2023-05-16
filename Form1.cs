using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab.Models;
using Microsoft.VisualBasic;

namespace Lab
{
    public partial class Laboratorio : Form
    {
        public Laboratorio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (LaboratorioEntities db = new LaboratorioEntities())
            {
                var lst = from d in db.Inventario select d;
                dataGrid.DataSource = lst.ToList();
                // Set your desired AutoSize Mode:
                dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
                for (int i = 0; i <= dataGrid.Columns.Count - 1; i++)
                {
                    // Store Auto Sized Widths:
                    int colw = dataGrid.Columns[i].Width;

                    // Remove AutoSizing:
                    dataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    // Set Width to calculated AutoSize value:
                    dataGrid.Columns[i].Width = colw;
                }
            }
        }

        private void crearbtn_Click(object sender, EventArgs e)
        {
            Crear crear_orden = new Crear();
            crear_orden.Show();
        }

        private void pedidosbtn_Click(object sender, EventArgs e)
        {
            Pedidos lstPedidos = new Pedidos();
            lstPedidos.Show();
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            if(dataGrid.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGrid.SelectedRows)
                {
                    string cantidad = Interaction.InputBox("Ingresa la cantidad disponible", "Cantidad");
                    string material = row.Cells[1].Value.ToString();
                    using (LaboratorioEntities db = new LaboratorioEntities())
                    {
                        var query = (from d in db.Inventario where d.nombre.Contains(material) select d).FirstOrDefault();
                        query.disponible = int.Parse(cantidad);
                        db.SaveChanges();
                    }
                    break;
                }
                busquedatxt_TextChanged(sender, e);
            }
        }

        private void busquedatxt_TextChanged(object sender, EventArgs e)
        {
            using (LaboratorioEntities db = new LaboratorioEntities())
            {
                string busqueda = busquedatxt.Text;
                var lst = from d in db.Inventario where d.nombre.Contains(busqueda) select d;
                dataGrid.DataSource = lst.ToList();

                dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i <= dataGrid.Columns.Count - 1; i++)
                {
                    int colw = dataGrid.Columns[i].Width;

                    dataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    dataGrid.Columns[i].Width = colw;
                }
            }
        }
    }
}
