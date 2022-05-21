
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(33, 31);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(33, 73);
            this.apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(44, 13);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "Apellido";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(42, 116);
            this.edad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(32, 13);
            this.edad.TabIndex = 2;
            this.edad.Text = "Edad";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(98, 29);
            this.textName.Margin = new System.Windows.Forms.Padding(2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(151, 20);
            this.textName.TabIndex = 3;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(98, 71);
            this.textLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(151, 20);
            this.textLastName.TabIndex = 4;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(98, 114);
            this.textAge.Margin = new System.Windows.Forms.Padding(2);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(151, 20);
            this.textAge.TabIndex = 5;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(45, 176);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(94, 38);
            this.botonAgregar.TabIndex = 6;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.add_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(153, 176);
            this.botonBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(94, 38);
            this.botonBorrar.TabIndex = 7;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvLastName,
            this.dgvAge});
            this.dataGridViewUsers.Location = new System.Drawing.Point(286, 29);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(375, 185);
            this.dataGridViewUsers.TabIndex = 8;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Nombre";
            this.dgvName.Name = "dgvName";
            // 
            // dgvLastName
            // 
            this.dgvLastName.HeaderText = "Apellido";
            this.dgvLastName.Name = "dgvLastName";
            // 
            // dgvAge
            // 
            this.dgvAge.HeaderText = "Edad";
            this.dgvAge.Name = "dgvAge";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(672, 252);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAge;
    }
}

