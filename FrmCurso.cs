using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace proyecto_colegio
{
    public partial class FrmCurso : Form
    {
        private string filePath = "cursos.txt";
        private List<ListaCurso> cursos = new List<ListaCurso>();
        private Dictionary<string, Func<Form>> formularios = new Dictionary<string, Func<Form>>(); // para que identifique los diccionarios
        public class ListaCurso
        {
            public string NombreCurso { get; set; }
            public string ParaleloA { get; set; }
            public string ParaleloB { get; set; }
            public string ParaleloC { get; set; }

        }
        public FrmCurso()
        {
            InitializeComponent();
            CargarCursos();
            ConfigurarDataGridView();
            InicializarDiccionarioFormularios(); 
        }
        private void InicializarDiccionarioFormularios()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (char paralelo = 'A'; paralelo <= 'C'; paralelo++)
                {
                    string key = $"Curso{i}Paralelo{paralelo}";
                    string nombreFormulario = $"FrmAlumnos{i}{paralelo}";

                    formularios.Add(key, () =>
                    {
                        Type tipoFormulario = Type.GetType(nombreFormulario); 
                        if (tipoFormulario != null)
                        {
                            return (Form)Activator.CreateInstance(tipoFormulario);
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró el formulario: {nombreFormulario}");
                            return null;
                        }
                    });
                }
            }
        }


        private void ConfigurarDataGridView()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Nombre Curso";
            dataGridView1.Columns[1].Name = "Paralelo A";
            dataGridView1.Columns[2].Name = "Paralelo B";
            dataGridView1.Columns[3].Name = "Paralelo C";

            //Para agregar nuevas filas de manera automatica sin necesidad de editar el datagridview
            dataGridView1.AllowUserToAddRows = true;


            //para guardar al agregar una nueva fila no tocar
            dataGridView1.RowsAdded += (s, e) =>
            {
                if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    GuardarCursos();
                }
            };

            // guarda los datos cuando modifico una celda
            dataGridView1.CellValueChanged += (s, e) =>
            {
                if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    GuardarCursos();
                }
            };

        }

        private void Curso_Load(object sender, EventArgs e)
        {
            MostrarCursos();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarCursos();
        }

        private void GuardarCursos()
        {
            try
            {
                List<ListaCurso> cursosAGuardar = new List<ListaCurso>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string nombre = row.Cells["Nombre Curso"].Value?.ToString() ?? "";
                        string paraleloA = row.Cells["Paralelo A"].Value?.ToString() ?? "";
                        string paraleloB = row.Cells["Paralelo B"].Value?.ToString() ?? "";
                        string paraleloC = row.Cells["Paralelo C"].Value?.ToString() ?? "";

                        cursosAGuardar.Add(new ListaCurso { NombreCurso = nombre, ParaleloA = paraleloA, ParaleloB = paraleloB, ParaleloC = paraleloC });
                    }
                }

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (ListaCurso curso in cursosAGuardar)
                    {
                        writer.WriteLine($"{curso.NombreCurso},{curso.ParaleloA},{curso.ParaleloB},{curso.ParaleloC}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cursos: {ex.Message}");
            }
        }

        private void CargarCursos()
        {
            cursos.Clear();
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');
                        if (values.Length == 4)
                        {
                            cursos.Add(new ListaCurso { NombreCurso = values[0], ParaleloA = values[1], ParaleloB = values[2], ParaleloC = values[3] });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los cursos: {ex.Message}");
                }
            }
        }

        private void MostrarCursos()
        {
            dataGridView1.Rows.Clear();
            foreach (ListaCurso curso in cursos)
            {
                dataGridView1.Rows.Add(curso.NombreCurso, curso.ParaleloA, curso.ParaleloB, curso.ParaleloC);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)  
            {
                return; 
            }

            string nombreCurso = dataGridView1.Rows[e.RowIndex].Cells["Nombre Curso"].Value?.ToString() ?? ""; 
            string nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;

            string numeroCurso = nombreCurso.Replace("ero", "").Replace("do", "").Replace("to", "");
            string key = $"Curso{numeroCurso}Paralelo{nombreColumna.Replace("Paralelo ", "")}";

            if (formularios.ContainsKey(key))
            {
                Form formulario = formularios[key](); 
                if (formulario != null) 
                {
                    formulario.ShowDialog(); 
                }
            }
            else
            {
                MessageBox.Show($"No se encontró la clave: {key}"); 
            }
        }
        
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}