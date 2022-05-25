using p1ACrud13.Clases.entidades;
using p1ACrud13.Clases.Servicio;

ServicioAlumno alu = new();
string cuerito = "select * from db_alumnos where seccion='C'";
MdAlumnos oAlumno = new();

oAlumno = alu.ObtenerAlumno("18-11486");

if (oAlumno == null)
{
    Console.WriteLine($"Ese cuate no existe");
} else
{
    Console.WriteLine($"nombre: {oAlumno.nombre}");
}













