
namespace POO_Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(50, 48);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(65, 20);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(50, 112);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(65, 20);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "Apellido";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(63, 179);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(47, 20);
            this.edad.TabIndex = 2;
            this.edad.Text = "Edad";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(147, 45);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(224, 26);
            this.textNombre.TabIndex = 3;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(147, 109);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(224, 26);
            this.textApellido.TabIndex = 4;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(147, 176);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(224, 26);
            this.textEdad.TabIndex = 5;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(67, 271);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(141, 58);
            this.botonAgregar.TabIndex = 6;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(230, 271);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(141, 58);
            this.botonBorrar.TabIndex = 7;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(464, 284);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 388);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

