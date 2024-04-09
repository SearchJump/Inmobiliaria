using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inmobiliaria.Propiedad;

namespace Inmobiliaria
{
    public partial class FormularioPropiedades : Form
    {
        public FormularioPropiedades()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Propiedades_Load(object sender, EventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            // Crear una nueva propiedad
            Propiedad propiedad = new Propiedad();

            // Asignar los datos del formulario a la propiedad
            propiedad.Tipo = (TipoPropiedad)Enum.Parse(typeof(TipoPropiedad), comboBoxTipo.Text);
            propiedad.PrecioPorDia = Convert.ToDouble(textBoxPrecioPorDia.Text);

            // Agregar la propiedad a la lista
            listViewPropiedades.Items.Add(propiedad.ToString());
            // Abrir el formulario de clientes
            FormularioClientes form = new FormularioClientes();
            form.Show();


        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textboxTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
