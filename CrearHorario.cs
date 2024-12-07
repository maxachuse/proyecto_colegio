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
    public partial class CrearHorario : Form
    {
        private string filePath = "horarios.txt";
        private List<Horario> horarios = new List<Horario>();
        public class Horario
        {
            public string Hora { get; set; }
            public string Lunes { get; set; }
            public string Martes { get; set; }
            public string Miercoles { get; set; }
            public string Jueves { get; set; }
            public string Viernes { get; set; }
            public string Sabado { get; set; }
        }
        public CrearHorario()
        {
            InitializeComponent();
            CargarHorarios();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.ColumnCount = 7; // Cuatro columnas: Nombre y tres paralelos
            dataGridView1.Columns[0].Name = "Hora";
            dataGridView1.Columns[1].Name = "Lunes";
            dataGridView1.Columns[2].Name = "Martes";
            dataGridView1.Columns[3].Name = "Miercoles";
            dataGridView1.Columns[4].Name = "Jueves";
            dataGridView1.Columns[5].Name = "Viernes";
            dataGridView1.Columns[6].Name = "Sabado";



            //Permitir agregar nuevas filas
            dataGridView1.AllowUserToAddRows = true;


            // Evento para guardar al agregar una nueva fila
            dataGridView1.RowsAdded += (s, e) =>
            {
                if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    GuardarHorarios();
                }
            };

            // Evento para guardar al modificar una celda
            dataGridView1.CellValueChanged += (s, e) =>
            {
                if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    GuardarHorarios();
                }
            };

        }

        private void CrearHorario_Load(object sender, EventArgs e)
        {
            MostrarHorarios();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarHorarios();
        }
        private void GuardarHorarios()
        {
            try
            {
                List<Horario> horariosAGuardar = new List<Horario>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string hora = row.Cells["Hora"].Value?.ToString() ?? "";
                        string lunes = row.Cells["Lunes"].Value?.ToString() ?? "";
                        string martes = row.Cells["Martes"].Value?.ToString() ?? "";
                        string miercoles = row.Cells["Miercoles"].Value?.ToString() ?? "";
                        string jueves = row.Cells["Jueves"].Value?.ToString() ?? "";
                        string viernes = row.Cells["Viernes"].Value?.ToString() ?? "";
                        string sabado = row.Cells["Sabado"].Value?.ToString() ?? "";




                        horariosAGuardar.Add(new Horario { Hora = hora, Lunes = lunes, Martes = martes, Miercoles = miercoles, Jueves = jueves, Viernes = viernes, Sabado = sabado });
                    }
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Horario horario in horariosAGuardar)
                    {
                        writer.WriteLine($"{horario.Hora},{horario.Lunes},{horario.Martes},{horario.Miercoles},{horario.Jueves},{horario.Viernes},{horario.Sabado}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cursos: {ex.Message}");
            }
        }

        private void CargarHorarios()
        {
            horarios.Clear();
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');
                        if (values.Length == 7) // Ahora son 4 valores: Nombre y 3 paralelos
                        {
                            horarios.Add(new Horario { Hora = values[0], Lunes = values[1], Martes = values[2], Miercoles = values[3], Jueves = values[4], Viernes = values[5], Sabado = values[6] });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los cursos: {ex.Message}");
                }
            }
        }

        private void MostrarHorarios()
        {
            dataGridView1.Rows.Clear();
            foreach (Horario horario in horarios)
            {
                dataGridView1.Rows.Add(horario.Hora, horario.Lunes, horario.Martes, horario.Miercoles, horario.Jueves, horario.Viernes, horario.Sabado);
            }
        }
    }
}
