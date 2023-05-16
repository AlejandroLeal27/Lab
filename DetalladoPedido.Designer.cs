namespace Lab
{
    partial class DetalladoPedido
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.entregadobtn = new System.Windows.Forms.Button();
            this.cancelarbtn = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.dataGridAdd = new System.Windows.Forms.DataGridView();
            this.busquedatxt = new System.Windows.Forms.TextBox();
            this.editarbtn = new System.Windows.Forms.Button();
            this.actualizarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.Cantidad});
            this.dataGrid.Location = new System.Drawing.Point(12, 41);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(358, 181);
            this.dataGrid.TabIndex = 6;
            // 
            // entregadobtn
            // 
            this.entregadobtn.Location = new System.Drawing.Point(377, 145);
            this.entregadobtn.Name = "entregadobtn";
            this.entregadobtn.Size = new System.Drawing.Size(75, 23);
            this.entregadobtn.TabIndex = 7;
            this.entregadobtn.Text = "Entregado";
            this.entregadobtn.UseVisualStyleBackColor = true;
            this.entregadobtn.Click += new System.EventHandler(this.entregadobtn_Click);
            // 
            // cancelarbtn
            // 
            this.cancelarbtn.Location = new System.Drawing.Point(377, 174);
            this.cancelarbtn.Name = "cancelarbtn";
            this.cancelarbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarbtn.TabIndex = 8;
            this.cancelarbtn.Text = "Cancelar";
            this.cancelarbtn.UseVisualStyleBackColor = true;
            this.cancelarbtn.Click += new System.EventHandler(this.cancelarbtn_Click);
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
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Location = new System.Drawing.Point(12, 12);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.nombrelbl.TabIndex = 9;
            this.nombrelbl.Text = "Nombre";
            // 
            // agregarbtn
            // 
            this.agregarbtn.Location = new System.Drawing.Point(376, 41);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(75, 23);
            this.agregarbtn.TabIndex = 12;
            this.agregarbtn.Text = "Agregar";
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // dataGridAdd
            // 
            this.dataGridAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdd.Location = new System.Drawing.Point(12, 253);
            this.dataGridAdd.Name = "dataGridAdd";
            this.dataGridAdd.ReadOnly = true;
            this.dataGridAdd.Size = new System.Drawing.Size(358, 185);
            this.dataGridAdd.TabIndex = 11;
            // 
            // busquedatxt
            // 
            this.busquedatxt.Location = new System.Drawing.Point(12, 227);
            this.busquedatxt.Name = "busquedatxt";
            this.busquedatxt.Size = new System.Drawing.Size(358, 20);
            this.busquedatxt.TabIndex = 10;
            this.busquedatxt.TextChanged += new System.EventHandler(this.busquedatxt_TextChanged);
            // 
            // editarbtn
            // 
            this.editarbtn.Location = new System.Drawing.Point(377, 70);
            this.editarbtn.Name = "editarbtn";
            this.editarbtn.Size = new System.Drawing.Size(75, 23);
            this.editarbtn.TabIndex = 13;
            this.editarbtn.Text = "Editar";
            this.editarbtn.UseVisualStyleBackColor = true;
            this.editarbtn.Click += new System.EventHandler(this.editarbtn_Click);
            // 
            // actualizarbtn
            // 
            this.actualizarbtn.Location = new System.Drawing.Point(377, 99);
            this.actualizarbtn.Name = "actualizarbtn";
            this.actualizarbtn.Size = new System.Drawing.Size(75, 40);
            this.actualizarbtn.TabIndex = 14;
            this.actualizarbtn.Text = "Actualizar Pedido";
            this.actualizarbtn.UseVisualStyleBackColor = true;
            this.actualizarbtn.Click += new System.EventHandler(this.actualizarbtn_Click);
            // 
            // DetalladoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.actualizarbtn);
            this.Controls.Add(this.editarbtn);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.dataGridAdd);
            this.Controls.Add(this.busquedatxt);
            this.Controls.Add(this.nombrelbl);
            this.Controls.Add(this.cancelarbtn);
            this.Controls.Add(this.entregadobtn);
            this.Controls.Add(this.dataGrid);
            this.Name = "DetalladoPedido";
            this.Text = "DetalladoPedido";
            this.Load += new System.EventHandler(this.DetalladoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button entregadobtn;
        private System.Windows.Forms.Button cancelarbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.DataGridView dataGridAdd;
        private System.Windows.Forms.TextBox busquedatxt;
        private System.Windows.Forms.Button editarbtn;
        private System.Windows.Forms.Button actualizarbtn;
    }
}