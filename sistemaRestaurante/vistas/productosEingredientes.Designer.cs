namespace sistemaRestaurante.vistas
{
    partial class productosEingredientes
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPRODUCTOS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwIngredientes = new System.Windows.Forms.DataGridView();
            this.dgwProducto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProdut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblm = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Listo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Agregar Ingredientes al Producto";
            // 
            // cbPRODUCTOS
            // 
            this.cbPRODUCTOS.FormattingEnabled = true;
            this.cbPRODUCTOS.Location = new System.Drawing.Point(364, 53);
            this.cbPRODUCTOS.Name = "cbPRODUCTOS";
            this.cbPRODUCTOS.Size = new System.Drawing.Size(121, 21);
            this.cbPRODUCTOS.TabIndex = 13;
            this.cbPRODUCTOS.SelectedIndexChanged += new System.EventHandler(this.cbPRODUCTOS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione el producto que necesita ingredientes.";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgwIngredientes);
            this.panel3.Location = new System.Drawing.Point(46, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 270);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agregue los ingredientes que necesita el produto";
            // 
            // dgwIngredientes
            // 
            this.dgwIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIngredientes.Location = new System.Drawing.Point(25, 16);
            this.dgwIngredientes.Name = "dgwIngredientes";
            this.dgwIngredientes.Size = new System.Drawing.Size(359, 229);
            this.dgwIngredientes.TabIndex = 3;
            this.dgwIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIngredientes_CellContentClick);
            // 
            // dgwProducto
            // 
            this.dgwProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducto.Location = new System.Drawing.Point(32, 16);
            this.dgwProducto.Name = "dgwProducto";
            this.dgwProducto.Size = new System.Drawing.Size(316, 229);
            this.dgwProducto.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgwProducto);
            this.panel1.Location = new System.Drawing.Point(547, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 270);
            this.panel1.TabIndex = 17;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(601, 80);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(183, 13);
            this.lblProducto.TabIndex = 18;
            this.lblProducto.Text = "Vista de los ingredientes del producto";
            // 
            // lblProdut
            // 
            this.lblProdut.AutoSize = true;
            this.lblProdut.Location = new System.Drawing.Point(790, 80);
            this.lblProdut.Name = "lblProdut";
            this.lblProdut.Size = new System.Drawing.Size(178, 13);
            this.lblProdut.TabIndex = 19;
            this.lblProdut.Text = ":                                                        ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarProductoToolStripMenuItem
            // 
            this.administrarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.detalleProductosToolStripMenuItem});
            this.administrarProductoToolStripMenuItem.Name = "administrarProductoToolStripMenuItem";
            this.administrarProductoToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.administrarProductoToolStripMenuItem.Text = "Administrar Producto";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // detalleProductosToolStripMenuItem
            // 
            this.detalleProductosToolStripMenuItem.Name = "detalleProductosToolStripMenuItem";
            this.detalleProductosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.detalleProductosToolStripMenuItem.Text = "DetalleProductos";
            this.detalleProductosToolStripMenuItem.Click += new System.EventHandler(this.detalleProductosToolStripMenuItem_Click);
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Location = new System.Drawing.Point(544, 448);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(151, 13);
            this.lblm.TabIndex = 21;
            this.lblm.Text = "                                                ";
            // 
            // productosEingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 490);
            this.Controls.Add(this.lblm);
            this.Controls.Add(this.lblProdut);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPRODUCTOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "productosEingredientes";
            this.Text = "productosEingredientes";
            this.Load += new System.EventHandler(this.productosEingredientes_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPRODUCTOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwIngredientes;
        private System.Windows.Forms.DataGridView dgwProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProdut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleProductosToolStripMenuItem;
        private System.Windows.Forms.Label lblm;
    }
}