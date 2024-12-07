using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_colegio
{
    public partial class ProfesoresNombres : Form
    {
        public ProfesoresNombres()
        {
            InitializeComponent();
        }

        private void ProfesoresNombres_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Mayra " + " " + "Artes Plasticas");
            listBox1.Items.Add("Elsa" + " " + "Quimica");
            listBox1.Items.Add("Carmen" + " " + "Fisica");
            listBox1.Items.Add("Sandra" + " " + "Ciencias Sociales");
            listBox1.Items.Add("Carlos" + " " + "Educacion Fisica");
            listBox1.Items.Add("Luis" + " " + "Literatura");
            listBox1.Items.Add("Ivan" + " " + "Matematicas");
            listBox1.Items.Add("Jesenia" + " " + "Biologia");
            listBox1.Items.Add("Mateo" + " " + "Matematicas");
            listBox1.Items.Add("Ruth" + " " + "Computacion");
            listBox1.Items.Add("Diego" + " " + "Ingles");
            listBox1.Items.Add("Nicolas" + " " + "Lengua Originaria");
            listBox1.Items.Add("Sofia" + " " + "Musica");
            listBox1.Items.Add("Lucas" + " " + "Religion");
            listBox1.Items.Add("Valentina" + " " + "Lenguaje");
            listBox1.Items.Add("Gabriel" + " " + "Educacion Fisica");
            listBox1.Items.Add("Camila" + " " + "Biologia");
            listBox1.Items.Add("Eduardo" + " " + "Quimica");
            listBox1.Items.Add("Samuel" + " " + "Fisica");
            listBox1.Items.Add("Andrea" + " " + "Psicologia");
            listBox1.Items.Add("Maria" + "  " + "suplente");
            listBox1.Items.Add("Dennis" + "  " + "suplente");
            listBox1.Items.Add("Ana" + "  " + "suplente");
            listBox1.Items.Add("Olivia" + "  " + "suplente");
            listBox1.Items.Add("Damaris" + "  " + "suplente");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CrearHorario CH = new CrearHorario();
            CH.ShowDialog();
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
