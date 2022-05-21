using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Ejercicio1
{
    public partial class Form1 : Form
    {
        List<Empleado> Empleados = new List<Empleado>();

        private int rowIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            //n = indice del registro
            //int n = dataGridViewUsers.Rows.Add();

            //agregar nombre, apellido y edad al gridView
            /*dataGridViewUsers.Rows[n].Cells[0].Value = textName.Text;
            dataGridViewUsers.Rows[n].Cells[1].Value = textLastName.Text;
            dataGridViewUsers.Rows[n].Cells[2].Value = textAge.Text;*/

            bool VerificaEntero = int.TryParse(textAge.Text, out int asd);  // Intenta convertir la caja de texto de la edad, en un nuevo entero llamado asd, si es verdadero, la variable VerificaEntero va a ser verdadero
            IEnumerable<Empleado> lst = from a in Empleados                 // Crea una especie de lista de "Empleado" llamada lst, y crea una especie de variable "a" para traer datos de la lista "Empleados"
                                        where a.Name == textName.Text       // donde coincidan, si es que sucede, que algun objeto de la lista Empleados, sea igual a la caja de texto textName
                                        && a.LastName == textLastName.Text  // idem
                                        select a;                           // lo guardo en "a" y lo mete en "lst"
            
            //lst.ToList(); lo puedo transformar en lista, lo cual para un registro grande, por ejemplo el censo, podes encontrar muchos nombres y apellidos coincidentes


            if (VerificaEntero == true && int.Parse(textAge.Text) >0 && int.Parse(textAge.Text) < 120) // si la caja de texto de la edadse pudo convertir a entero, y la edad es mayor a 0 y menor a 120 se ejectura las siguientes acciones
            {
                if (textName.Text.Length >= 2 && textLastName.Text.Length >= 2) // si el nombre es mayor 2, idem apellido, por obvias razons, ejecuta las siguientes acciones
                {
                    if (lst.FirstOrDefault() == null)       // de lst tomo el primer valor, o el correspondiente, y si no hay empleados con el mismo nombre y apellido ejecuto lo siguiente
                    {
                        Empleado Emp = new Empleado();      // creo una instancia de empleado, para despues agregarlo a la lista de EMPLEADOS
                        Emp.Name = textName.Text;           // primer parametro del objeto
                        Emp.LastName = textLastName.Text;   // segundo
                        Emp.Age = int.Parse(textAge.Text);  // Tercer parametro, al ser entero, lo convierto, de string a int
                        Empleados.Add(Emp);                 // lo agrego a la lista
                    }
                    else
                    {
                        MessageBox.Show("El empleado ya existe");
                    }
                    
                }
                else
                {
                    MessageBox.Show("El nombre no se ingreso correctamente");
                }
                
            }
            else
            {
                MessageBox.Show("Agrega una edad correcta");
            }
            


            dataGridViewUsers.DataSource = null;            // en wFORMS hay que nullear el datasource para despues volver a agregar
            dataGridViewUsers.DataSource = Empleados;       // mi cuadrito (DataGridView) se va a llenar con los datos de la lista "Empleados", AGREGANDO el nombre de la columna como el nombre del parametro correspondiete

            textName.Text = "";                             //por ultimo vacio las cajas de texto, para no tener que borrarlas a mano
            textLastName.Text = "";
            textAge.Text = "";
            //este comentario
    
        }

        private void delete_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.RemoveAt(rowIndex);

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private class Empleado //creo una clase empleado la cual voy a usar en el programa
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }
    }

    
}
