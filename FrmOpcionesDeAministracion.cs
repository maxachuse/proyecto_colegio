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
    public partial class FrmOpcionesDeAministracion : Form
    {
        public FrmOpcionesDeAministracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCurso fcs = new FrmCurso();
            fcs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfesoresNombres pn = new ProfesoresNombres();
            pn.ShowDialog();

        }
    }
}
