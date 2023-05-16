using Lab.Models;
using Microsoft.VisualBasic;
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
    public partial class DetalladoPedido : Form
    {
        int id;
        public DetalladoPedido(int ID)
        {
            this.id = ID;
            InitializeComponent();
        }

        private void DetalladoPedido_Load(object sender, EventArgs e)
        {
            using (LaboratorioEntities db = new LaboratorioEntities())
            {
                var query = (from d in db.Orden where d.id == id select d).FirstOrDefault();
                nombrelbl.Text = "Nombre: " + query.nombre.ToString();
                string[] materiales = query.id_inventario.ToString().Split(',');
                string[] cantidades = query.cantidad.ToString().Split(',');

                for (int i = 0; i < materiales.Length; i++)
                    dataGrid.Rows.Add(materiales[i], cantidades[i]);
            }

            busquedatxt_TextChanged(sender, e);
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void entregadobtn_Click(object sender, EventArgs e)
        {
            string tmp = "";
            using (LaboratorioEntities db = new LaboratorioEntities())
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    tmp = row.Cells[0].Value.ToString();
                    var update = (from d in db.Inventario where d.nombre == tmp select d).First();
                    update.disponible = int.Parse(update.disponible.ToString()) + int.Parse(row.Cells[1].Value.ToString());
                    update.pendiente = int.Parse(update.pendiente.ToString()) - int.Parse(row.Cells[1].Value.ToString());
                    db.SaveChanges();
                }
                var orden = (from d in db.Orden where d.id == id select d).First();
                db.Orden.Remove(orden);
                db.SaveChanges();
            }
            this.Visible = false;
        }

        private void busquedatxt_TextChanged(object sender, EventArgs e)
        {
            using (LaboratorioEntities db = new LaboratorioEntities())
            {
                string busqueda = busquedatxt.Text;
                var lst = from d in db.Inventario where d.nombre.Contains(busqueda) select d;
                dataGridAdd.DataSource = lst.ToList();

                dataGridAdd.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridAdd.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridAdd.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i <= dataGrid.Columns.Count - 1; i++)
                {
                    int colw = dataGridAdd.Columns[i].Width;

                    dataGridAdd.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    dataGridAdd.Columns[i].Width = colw;
                }
            }
        }

        private void agregarbtn_Click(object sender, EventArgs e)
        {
            if (dataGridAdd.SelectedRows.Count == 1)
            {
                string material = dataGridAdd.SelectedCells[1].Value.ToString();
                string cantidad = Interaction.InputBox("Ingresa la cantidad", "Cantidad");
                int disponible = 0, enLista = 0;
                using (LaboratorioEntities db = new LaboratorioEntities())
                {
                    disponible = (int)(from d in db.Inventario where d.nombre.Contains(material) select d.disponible).FirstOrDefault();
                }
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(material))
                    {
                        MessageBox.Show("Material ya en la lista! Edita la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        enLista = 1;
                        break;
                    }
                }
                if (enLista == 0)
                {
                    if (disponible >= int.Parse(cantidad))
                        dataGrid.Rows.Add(material, cantidad);
                    else
                        MessageBox.Show("Cantidad no disponible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
                MessageBox.Show("Selecciona una sola fila!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void editarbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                string cantidad = Interaction.InputBox("Ingresa la cantidad", "Cantidad");
                string material = row.Cells[0].Value.ToString();
                string prestado = row.Cells[1].Value.ToString();
                int disponible = 0;
                using (LaboratorioEntities db = new LaboratorioEntities())
                {
                    disponible = (int)(from d in db.Inventario where d.nombre.Contains(material) select d.disponible).FirstOrDefault();
                }
                if (disponible >= int.Parse(cantidad) - int.Parse(prestado))
                    row.Cells[1].Value = cantidad;
                else
                    MessageBox.Show("Cantidad no disponible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                break;
            }
        }

        private void actualizarbtn_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count > 0)
            {
                string Material = "", Cantidad = "", tmp = "";
                using (LaboratorioEntities db = new LaboratorioEntities())
                {
                    var orden = (from d in db.Orden where d.id == id select d).First();
                    string[] materiales = orden.id_inventario.Split(',');
                    string[] cantidades = orden.cantidad.Split(',');
                    int enLista;
                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        enLista = 0;
                        for (int i = 0; i < materiales.Length; i++)
                        {
                            if (materiales[i] == row.Cells[0].Value.ToString())
                            {
                                if (int.Parse(cantidades[i]) != int.Parse(row.Cells[1].Value.ToString()))
                                {
                                    string Nombre_Mat = materiales[i].ToString();
                                    var cambiar_cantidad = (from d in db.Inventario where d.nombre == Nombre_Mat select d).First();
                                    cambiar_cantidad.disponible = int.Parse(cambiar_cantidad.disponible.ToString()) - int.Parse(row.Cells[1].Value.ToString()) + int.Parse(cantidades[i]);
                                    cambiar_cantidad.pendiente = int.Parse(cambiar_cantidad.pendiente.ToString()) + int.Parse(row.Cells[1].Value.ToString()) - int.Parse(cantidades[i]);
                                    db.SaveChanges();
                                }
                                enLista++;
                                break;
                            }

                        }
                        Material += row.Cells[0].Value.ToString() + ",";
                        Cantidad += row.Cells[1].Value.ToString() + ",";
                        if (enLista == 0)
                        {
                            tmp = row.Cells[0].Value.ToString();
                            var update = (from d in db.Inventario where d.nombre == tmp select d).First();
                            update.disponible = int.Parse(update.disponible.ToString()) - int.Parse(row.Cells[1].Value.ToString());
                            update.pendiente = int.Parse(update.pendiente.ToString()) + int.Parse(row.Cells[1].Value.ToString());
                            db.SaveChanges();
                        }
                    }
                    Material = Material.Remove(Material.Length - 1);
                    Cantidad = Cantidad.Remove(Cantidad.Length - 1);
                    var Nueva_Orden = new Orden
                    {
                        nombre = orden.nombre,
                        id_inventario = Material,
                        cantidad = Cantidad
                    };
                    db.Orden.Remove(orden);
                    db.SaveChanges();
                    db.Orden.Add(Nueva_Orden);
                    db.SaveChanges();
                }
            }
            else
                MessageBox.Show("Agrega material!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
