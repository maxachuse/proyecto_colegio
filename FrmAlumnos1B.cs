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
    public partial class FrmAlumnos1B : Form
    {
        private string nombreCurso;
        private string paralelo;

        public FrmAlumnos1B()
        {
            InitializeComponent();
        }

        public FrmAlumnos1B(string nombreCurso, string paralelo, string nombreColumna)
        {
            this.nombreCurso = nombreCurso;
            this.paralelo = paralelo;
        }

        private void FrmAlumnos1B_Load(object sender, EventArgs e)
        {

        }
    }
}
