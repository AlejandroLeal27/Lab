using Lab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void busquedatxt_TextChanged(object sender, EventArgs e)
        {
            using (LaboratorioEntities db = new LaboratorioEntities())
            {
                string busqueda = busquedatxt.Text;
                var lst = from d in db.Orden where d.nombre.Contains(busqueda) select d;
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

        private void Pedidos_Load(object sender, EventArgs e)
        {
            busquedatxt_TextChanged(sender, e);
        }

        private void verbtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGrid.SelectedCells[0].Value.ToString());
                DetalladoPedido det = new DetalladoPedido(id);
                det.Show();
                busquedatxt_TextChanged(sender, e);
            }
            else
                MessageBox.Show("Selecciona una sola fila!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void recargarbtn_Click(object sender, EventArgs e)
        {
            busquedatxt_TextChanged(sender, e);
        }
    }
}
