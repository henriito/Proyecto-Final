using p1ACrud13.Clases.CapaDatos;
using p1ACrud13.Clases.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1ACrud13.Clases.Servicio
{
    public class ServicioAlumno
    {
        ClsConexion cone = new ClsConexion();

        public void lee(string instruccion)
        {
            DataTable respuesta = cone.consultaTablaDirecta(instruccion);
            foreach (DataRow dr in respuesta.Rows)
            {
                Console.WriteLine($"Carnet = {dr["carnet"]} Nombre = {dr["nombre"]} Seccion = {dr["seccion"]}  P1 = {dr["parcial1"]} P2 = {dr["parcial2"]} P3 = {dr["parcial3"]}");
            }
        }
        public DataTable ConsultaSQL(string instruccion)
        {
            DataTable respuesta = cone.consultaTablaDirecta(instruccion);
            return respuesta;
        }

        public int CrearAlumno(MdAlumnos alu)
        {
            string instruccion = $"insert into db_alumnos (carnet,nombre,correo,clase,seccion,parcial1,parcial2,parcial3) values('{alu.carnet}','{alu.nombre}','{alu.correo}','{alu.clase}','{alu.seccion}','{alu.parcial1}','{alu.parcial2}','{alu.parcial3}')";
            return cone.EjecutarSQLDirecto(instruccion);
        }

        public int EliminarAlumno(MdAlumnos alu)
        {
            string instruccion = $"Delete from db_alumnos where carnet='{alu.carnet}'";
            return cone.EjecutarSQLDirecto(instruccion);
        }

        public MdAlumnos ObtenerAlumno(string carnet)
        {
            MdAlumnos alu = new MdAlumnos();

            DataTable resp = cone.consultaTablaDirecta($"select * from db_alumnos where carnet ='{carnet}'");
            if (resp.Rows.Count > 0)
            {
                foreach (DataRow item in resp.Rows)
                {
                    alu.idAlumno = Convert.ToInt32(item["idAlumno"]);
                    alu.carnet = item["carnet"].ToString();
                    alu.nombre = item["nombre"].ToString();
                    alu.seccion = item["seccion"].ToString();
                    alu.clase = item["clase"].ToString();
                    alu.correo = item["correo"].ToString();
                    alu.parcial1 = item["parcial1"].ToString();
                    alu.parcial2 = item["parcial2"].ToString();
                    alu.parcial3 = item["parcial3"].ToString();
                }
                return alu;
            }
            else
            {
                return null;
            }
        }
        public int actualizarAlumno(MdAlumnos alu)
        {
            string instruccion = $"update db_alumnos set nombre = '{alu.nombre}',correo = '{alu.correo}',clase = '{alu.clase}',seccion= '{alu.seccion}',parcial1 = '{alu.parcial1}',parcial2 = '{alu.parcial2}',parcial3 = '{alu.parcial3}' where carnet='{alu.carnet}'";
            return cone.EjecutarSQLDirecto(instruccion);
        }
    }
}
