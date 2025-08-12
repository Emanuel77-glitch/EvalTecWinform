namespace ExamenTecnicoWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewProductos = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lblPrecioPromedio = new Label();
            txtCategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(35, 89);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(399, 23);
            txtPrecio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 71);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 124);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Categoria";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(35, 242);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(399, 128);
            dataGridViewProductos.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(141, 171);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(181, 48);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(141, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(181, 48);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblPrecioPromedio
            // 
            lblPrecioPromedio.AutoSize = true;
            lblPrecioPromedio.Location = new Point(582, 188);
            lblPrecioPromedio.Name = "lblPrecioPromedio";
            lblPrecioPromedio.Size = new Size(105, 15);
            lblPrecioPromedio.TabIndex = 9;
            lblPrecioPromedio.Text = "lblPrecioPromedio";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(35, 142);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(399, 23);
            txtCategoria.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrecioPromedio);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridViewProductos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewProductos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label lblPrecioPromedio;
        private TextBox txtCategoria;
    }
}
