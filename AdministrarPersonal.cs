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
    public partial class AdministrarPersonal : Form
    {
        public AdministrarPersonal()
        {
            InitializeComponent();
        }

        private void AdministrarPersonal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfesoresNombres pn = new ProfesoresNombres();
            pn.Show();
        }
    }
}
