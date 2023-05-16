namespace Lab
{
    partial class Laboratorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.crearbtn = new System.Windows.Forms.Button();
            this.pedidosbtn = new System.Windows.Forms.Button();
            this.editarbtn = new System.Windows.Forms.Button();
            this.recargarbtn = new System.Windows.Forms.Button();
            this.busquedatxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 70);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(466, 368);
            this.dataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTARIO";
            // 
            // crearbtn
            // 
            this.crearbtn.Location = new System.Drawing.Point(322, 15);
            this.crearbtn.Name = "crearbtn";
            this.crearbtn.Size = new System.Drawing.Size(75, 23);
            this.crearbtn.TabIndex = 2;
            this.crearbtn.Text = "Crear";
            this.crearbtn.UseVisualStyleBackColor = true;
            this.crearbtn.Click += new System.EventHandler(this.crearbtn_Click);
            // 
            // pedidosbtn
            // 
            this.pedidosbtn.Location = new System.Drawing.Point(403, 15);
            this.pedidosbtn.Name = "pedidosbtn";
            this.pedidosbtn.Size = new System.Drawing.Size(75, 23);
            this.pedidosbtn.TabIndex = 3;
            this.pedidosbtn.Text = "Pedidos";
            this.pedidosbtn.UseVisualStyleBackColor = true;
            this.pedidosbtn.Click += new System.EventHandler(this.pedidosbtn_Click);
            // 
            // editarbtn
            // 
            this.editarbtn.Location = new System.Drawing.Point(403, 41);
            this.editarbtn.Name = "editarbtn";
            this.editarbtn.Size = new System.Drawing.Size(75, 23);
            this.editarbtn.TabIndex = 4;
            this.editarbtn.Text = "Editar";
            this.editarbtn.UseVisualStyleBackColor = true;
            this.editarbtn.Click += new System.EventHandler(this.editarbtn_Click);
            // 
            // recargarbtn
            // 
            this.recargarbtn.Location = new System.Drawing.Point(241, 15);
            this.recargarbtn.Name = "recargarbtn";
            this.recargarbtn.Size = new System.Drawing.Size(75, 23);
            this.recargarbtn.TabIndex = 5;
            this.recargarbtn.Text = "Recargar";
            this.recargarbtn.UseVisualStyleBackColor = true;
            this.recargarbtn.Click += new System.EventHandler(this.recargarbtn_Click);
            // 
            // busquedatxt
            // 
            this.busquedatxt.Location = new System.Drawing.Point(12, 44);
            this.busquedatxt.Name = "busquedatxt";
            this.busquedatxt.Size = new System.Drawing.Size(385, 20);
            this.busquedatxt.TabIndex = 6;
            this.busquedatxt.TextChanged += new System.EventHandler(this.busquedatxt_TextChanged);
            // 
            // Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.busquedatxt);
            this.Controls.Add(this.recargarbtn);
            this.Controls.Add(this.editarbtn);
            this.Controls.Add(this.pedidosbtn);
            this.Controls.Add(this.crearbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Laboratorio";
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crearbtn;
        private System.Windows.Forms.Button pedidosbtn;
        private System.Windows.Forms.Button editarbtn;
        private System.Windows.Forms.Button recargarbtn;
        private System.Windows.Forms.TextBox busquedatxt;
    }
}

