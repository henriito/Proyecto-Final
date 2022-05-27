using p1ACrud13.Clases.entidades;
using p1ACrud13.Clases.Servicio;

namespace WFP1AC14
{
    public partial class Form1 : Form
    {
        ServicioAlumno srvAlumno = new();
        MdAlumnos oAlumnos = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void DesplegarGrid()
        {
            var respuesta = srvAlumno.ConsultaSQL("select * from db_alumnos");
            dataGridViewAlumnos.DataSource = respuesta;
        }

        private void buttonObtenerDatos_Click(object sender, EventArgs e)
        {
            DesplegarGrid();
        }

        private void MapaoDatosFormulario(MdAlumnos _alumnos)
        {
            textBoxCarnet.Text = _alumnos.carnet;
            textBoxNombre.Text = _alumnos.nombre;
            textBoxCorreo.Text = _alumnos.correo;
            comboBoxClase.Text = _alumnos.clase;
            comboBoxSeccion.Text = _alumnos.seccion;
            textBoxParcial1.Text = _alumnos.parcial1;
            textBoxParcial2.Text = _alumnos.parcial2;
            textBoxParcial3.Text = _alumnos.parcial3;
        }

        private void LimpiarDatos()
        {
            oAlumnos = new();
            MapaoDatosFormulario(oAlumnos);
        }

        private void buscaAlumno(string carnet)
        {
            oAlumnos = null;
            oAlumnos = srvAlumno.ObtenerAlumno(carnet);
            if (oAlumnos == null)
            {
                MessageBox.Show("no existe este cuate");
                LimpiarDatos();
            } else
            {
                MapaoDatosFormulario(oAlumnos);
            }
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            buscaAlumno(carnet);
        }

        private MdAlumnos DatosFormulario()
        {
            MdAlumnos _alumnos = new();
            _alumnos.carnet = textBoxCarnet.Text.Trim();
            _alumnos.nombre = textBoxNombre.Text.Trim();
            _alumnos.correo =  textBoxCorreo.Text.Trim();
            _alumnos.clase = comboBoxClase.Text;
            _alumnos.seccion = comboBoxSeccion.Text;
            _alumnos.parcial1 = textBoxParcial1.Text;
            _alumnos.parcial2 = textBoxParcial2.Text;
            _alumnos.parcial3 = textBoxParcial3.Text;
            return _alumnos;

        }

        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            oAlumnos = DatosFormulario();
            int p1, p2, p3;
            p1 = Convert.ToInt32(textBoxParcial1.Text);
            p2 = Convert.ToInt32(textBoxParcial2.Text);
            p3 = Convert.ToInt32(textBoxParcial3.Text);
            if (20 < p1)
            {
                MessageBox.Show("Lo sentimos, las notas del Parcial 1 no pueden ser mayores a 20.");
            }
            else if (20 < p2)
            {
                MessageBox.Show("Lo sentimos, las notas del Parcial 2 no pueden ser mayores a 20.");
            }
            else if (35 < p3)
            {
                MessageBox.Show("Lo sentimos, las notas del Parcial 3 no pueden ser mayores a 35.");
            }
            else
            {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Lo siento, 'nombre' no puede quedar vacio");
            }
            else
            {
            int respuesta = srvAlumno.CrearAlumno(oAlumnos);

                if (respuesta > 0)
                {
                    MessageBox.Show("Se creo con exito el Alumno");
                    LimpiarDatos();
                    DesplegarGrid();
                } 
                else
                {
                    MessageBox.Show("Perdon hay un problema con la Grabacion");
                }
            }
        }
    }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            oAlumnos = DatosFormulario();
            int p1, p2, p3;
            p1 = Convert.ToInt32(textBoxParcial1.Text);
            p2 = Convert.ToInt32(textBoxParcial2.Text);
            p3 = Convert.ToInt32(textBoxParcial3.Text);
            if (20 < p1)
            {
                MessageBox.Show("Lo sentimos, las notas del Parcial 1 no pueden ser mayores a 20.");
            }
            else if (20 < p2)
            {
                MessageBox.Show("Lo sentimos, las notas del Parcial 2 no pueden ser mayores a 20.");
            }
            else if (35 < p3)
            {
                MessageBox.Show("Lo sentimos, las notas del Parcial 3 no pueden ser mayores a 35.");
            }
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Lo siento, 'nombre' no puede quedar vacio");
            }
            else
            {
                int respuesta = srvAlumno.actualizarAlumno(oAlumnos);

                if (respuesta > 0)
                {
                    MessageBox.Show("Se actualizo el Alumno");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Perdon hay un problema con la Grabacion");
                }
            }
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Downloads\alunos.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Downloads\salida.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from db_alumnos where seccion='A'", archivo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oAlumnos = DatosFormulario();
            DialogResult ev = MessageBox.Show("¿Esta seguro de borrar al alumno?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ev == DialogResult.Yes)
            {
                int respuesta = srvAlumno.EliminarAlumno(oAlumnos);

                if (respuesta > 0)
                {
                    MessageBox.Show("El alumno ha sido borrado");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Perdon, hay un problema con la Eliminacion");
                }
            }
            else if (ev == DialogResult.No)
            {
                DesplegarGrid();
            }
        }
    }
}