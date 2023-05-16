namespace Lab
{
    partial class Crear
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.busquedatxt = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridOrden = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.crearbtn = new System.Windows.Forms.Button();
            this.editarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // busquedatxt
            // 
            this.busquedatxt.Location = new System.Drawing.Point(12, 12);
            this.busquedatxt.Name = "busquedatxt";
            this.busquedatxt.Size = new System.Drawing.Size(358, 20);
            this.busquedatxt.TabIndex = 0;
            this.busquedatxt.TextChanged += new System.EventHandler(this.Buscar);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 38);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(358, 185);
            this.dataGrid.TabIndex = 1;
            // 
            // dataGridOrden
            // 
            this.dataGridOrden.AllowUserToAddRows = false;
            this.dataGridOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.Cantidad});
            this.dataGridOrden.Location = new System.Drawing.Point(12, 229);
            this.dataGridOrden.Name = "dataGridOrden";
            this.dataGridOrden.ReadOnly = true;
            this.dataGridOrden.Size = new System.Drawing.Size(358, 185);
            this.dataGridOrden.TabIndex = 2;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // agregarbtn
            // 
            this.agregarbtn.Location = new System.Drawing.Point(376, 9);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(75, 23);
            this.agregarbtn.TabIndex = 3;
            this.agregarbtn.Text = "Agregar";
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Location = new System.Drawing.Point(376, 258);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarbtn.TabIndex = 4;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // crearbtn
            // 
            this.crearbtn.Location = new System.Drawing.Point(376, 287);
            this.crearbtn.Name = "crearbtn";
            this.crearbtn.Size = new System.Drawing.Size(75, 23);
            this.crearbtn.TabIndex = 5;
            this.crearbtn.Text = "Crear";
            this.crearbtn.UseVisualStyleBackColor = true;
            this.crearbtn.Click += new System.EventHandler(this.crearbtn_Click);
            // 
            // editarbtn
            // 
            this.editarbtn.Location = new System.Drawing.Point(376, 229);
            this.editarbtn.Name = "editarbtn";
            this.editarbtn.Size = new System.Drawing.Size(75, 23);
            this.editarbtn.TabIndex = 7;
            this.editarbtn.Text = "Editar";
            this.editarbtn.UseVisualStyleBackColor = true;
            this.editarbtn.Click += new System.EventHandler(this.editarbtn_Click);
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 426);
            this.Controls.Add(this.editarbtn);
            this.Controls.Add(this.crearbtn);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.dataGridOrden);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.busquedatxt);
            this.Name = "Crear";
            this.Text = "Crear";
            this.Load += new System.EventHandler(this.Crear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox busquedatxt;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridView dataGridOrden;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button crearbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button editarbtn;
    }
}