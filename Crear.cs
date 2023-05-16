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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            Buscar(sender, e);
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 1)
            {
                string material = dataGrid.SelectedCells[1].Value.ToString();
                string cantidad = Interaction.InputBox("Ingresa la cantidad", "Cantidad");
                int disponible = 0, enLista = 0;
                using (LaboratorioEntities db = new LaboratorioEntities())
                {
                    disponible = (int)(from d in db.Inventario where d.nombre.Contains(material) select d.disponible).FirstOrDefault();
                }
                foreach (DataGridViewRow row in dataGridOrden.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(material))
                    {
                        MessageBox.Show("Material ya en la lista!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        enLista = 1;
                        break;
                    }
                }
                if (enLista == 0)
                {
                    if (disponible >= int.Parse(cantidad))
                        dataGridOrden.Rows.Add(material, cantidad);
                    else
                        MessageBox.Show("Cantidad no disponible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
                MessageBox.Show("Selecciona una sola fila!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Buscar(object sender, EventArgs e)
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

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridOrden.SelectedRows)
            {
                dataGridOrden.Rows.Remove(row);
            }
        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridOrden.SelectedRows)
            {
                string cantidad = Interaction.InputBox("Ingresa la cantidad", "Cantidad");
                string material = row.Cells[0].Value.ToString();
                int disponible = 0;
                using (LaboratorioEntities db = new LaboratorioEntities())
                {
                    disponible = (int)(from d in db.Inventario where d.nombre.Contains(material) select d.disponible).FirstOrDefault();
                }
                if (disponible >= int.Parse(cantidad))
                    row.Cells[1].Value = cantidad;
                else
                    MessageBox.Show("Cantidad no disponible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                break;
            }
        }

        private void crearbtn_Click(object sender, EventArgs e)
        {
            if (dataGridOrden.Rows.Count > 0)
            {
                string Nombre = Interaction.InputBox("Ingresa nombre o matricula", "Nombre");
                string Material = "", Cantidad = "", tmp = "";
                using (LaboratorioEntities db = new LaboratorioEntities())
                {
                    foreach (DataGridViewRow row in dataGridOrden.Rows)
                    {
                        tmp = row.Cells[0].Value.ToString();
                        Material += row.Cells[0].Value.ToString() + ",";
                        Cantidad += row.Cells[1].Value.ToString() + ",";
                        var update = (from d in db.Inventario where d.nombre == tmp select d).First();
                        update.disponible = int.Parse(update.disponible.ToString()) - int.Parse(row.Cells[1].Value.ToString());
                        update.pendiente = int.Parse(update.pendiente.ToString()) + int.Parse(row.Cells[1].Value.ToString());
                        db.SaveChanges();
                    }
                    Material = Material.Remove(Material.Length - 1);
                    Cantidad = Cantidad.Remove(Cantidad.Length - 1);
                    var Nueva_Orden = new Orden
                    {
                        nombre = Nombre,
                        id_inventario = Material,
                        cantidad = Cantidad
                    };

                    db.Orden.Add(Nueva_Orden);
                    db.SaveChanges();
                }
                dataGridOrden.Rows.Clear();
            }
            else
                MessageBox.Show("Agrega material!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Buscar(sender, e);
        }
    }
}
