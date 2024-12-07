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
    public partial class FrmAlumnos1C : Form
    {
        public FrmAlumnos1C()
        {
            InitializeComponent();
        }

        public FrmAlumnos1C(string nombreCurso, string paralelo, string nombreColumna)
        {
            NombreCurso = nombreCurso;
            Paralelo = paralelo;
            NombreColumna = nombreColumna;
        }

        public string NombreCurso { get; }
        public string Paralelo { get; }
        public string NombreColumna { get; }

        private void FrmAlumnos1C_Load(object sender, EventArgs e)
        {

        }
    }
}
