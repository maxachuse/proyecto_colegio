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
    public partial class FrmAlumnos1A : Form
    {
        private string nombreColumna;
        private string paralelo;

        public FrmAlumnos1A(string nombreCurso)
        {
            InitializeComponent();
        }

        public FrmAlumnos1A(string nombreCurso, string nombreColumna, string paralelo) : this(nombreCurso)
        {
            this.nombreColumna = nombreColumna;
            this.paralelo = paralelo;
        }

        private void FrmAlumnos1A_Load(object sender, EventArgs e)
        {
            //mostrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
