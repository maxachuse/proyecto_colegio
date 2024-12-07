using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
namespace proyecto_colegio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string usuarioRegistrado = "admin";
        private string contraseñaRegistrada = "1234";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            /*if (textBox1.Text == "USUARIO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
            */
            textBox1.Text = "";
            textBox1.ForeColor = Color.LightGray;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /*
            if (textBox1.Text == "")
            {
                textBox1.Text = "USUARIO";
                textBox1.ForeColor = Color.DimGray;
            }
            */

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "CONTRASEÑA")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.LightGray;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                textBox2.Text = "CONTRASEÑA";
                textBox2.ForeColor = Color.DimGray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = textBox1.Text.Trim();
            string contraseñaIngresada = textBox2.Text;
            if (usuarioIngresado == usuarioRegistrado && contraseñaIngresada == contraseñaRegistrada)
            {
                //MessageBox.Show("Inicio de sesión exitoso.");
                FrmBienvenido fb = new FrmBienvenido();
                fb.Show();
                this.Hide(); // Oculta el formulario actual si es necesario
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
