namespace Lab
{
    partial class Pedidos
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
            this.verbtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.recargarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // busquedatxt
            // 
            this.busquedatxt.Location = new System.Drawing.Point(12, 12);
            this.busquedatxt.Name = "busquedatxt";
            this.busquedatxt.Size = new System.Drawing.Size(358, 20);
            this.busquedatxt.TabIndex = 1;
            this.busquedatxt.TextChanged += new System.EventHandler(this.busquedatxt_TextChanged);
            // 
            // verbtn
            // 
            this.verbtn.Location = new System.Drawing.Point(375, 9);
            this.verbtn.Name = "verbtn";
            this.verbtn.Size = new System.Drawing.Size(75, 23);
            this.verbtn.TabIndex = 4;
            this.verbtn.Text = "Ver";
            this.verbtn.UseVisualStyleBackColor = true;
            this.verbtn.Click += new System.EventHandler(this.verbtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 38);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(358, 188);
            this.dataGrid.TabIndex = 5;
            // 
            // recargarbtn
            // 
            this.recargarbtn.Location = new System.Drawing.Point(376, 38);
            this.recargarbtn.Name = "recargarbtn";
            this.recargarbtn.Size = new System.Drawing.Size(75, 23);
            this.recargarbtn.TabIndex = 6;
            this.recargarbtn.Text = "Recargar";
            this.recargarbtn.UseVisualStyleBackColor = true;
            this.recargarbtn.Click += new System.EventHandler(this.recargarbtn_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 238);
            this.Controls.Add(this.recargarbtn);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.verbtn);
            this.Controls.Add(this.busquedatxt);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox busquedatxt;
        private System.Windows.Forms.Button verbtn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button recargarbtn;
    }
}