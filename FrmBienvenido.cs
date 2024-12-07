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
    public partial class FrmBienvenido : Form
    {
        public FrmBienvenido()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.5;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0) 
            {
                timer2.Stop();
                this.Close();
                FrmOpcionesDeAministracion foda = new FrmOpcionesDeAministracion();
                foda.Show();
            }

        }
    }
}
