using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class FormularioClientes : Form
    {
        public FormularioClientes()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear un nuevo cliente
            Cliente cliente = new Cliente();

            // Asignar los datos del formulario al cliente
            cliente.Nombre = textboxNombre.Text;
            cliente.Direccion = textboxDireccion.Text;

            // Agregar el cliente a la lista
            listViewClientes.Items.Add(cliente.ToString());
            
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
