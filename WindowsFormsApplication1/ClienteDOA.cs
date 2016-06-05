using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ClienteDOA
    {
        private DataBase db;

        public Cliente crearUnCliente(int idCliente)
        {
            //especifico que SP voy a ejecutar
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Traer_Cliente_Completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //seteo los parametros que recibe el stored procedure
            cmd.Parameters.AddWithValue("@idCliente", SqlDbType.Int).Value = idCliente;
            Cliente unCliente = null;
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            unCliente = LoadObject(sdr);
            return unCliente;
        }

        private Cliente LoadObject(SqlDataReader reader)
        {
            Cliente unCliente = new Cliente();
            //lo que va entre parentesis son los nombres de las columnas que devuelve el SP
            unCliente.username = reader["username"].ToString();
            unCliente.password = reader["password"].ToString();
            unCliente.mail = reader["mail"].ToString();
            unCliente.nombre = reader["nombre"].ToString();
            unCliente.apellido = reader["apellido"].ToString();
            unCliente.dni = (int)reader["dni"];
            unCliente.telefono = (int)reader["telefono"];
            unCliente.tipoDocumento = reader["tipoDocumento"].ToString();
            unCliente.codPostal = (int)reader["codPostal"];
            unCliente.localidad = reader["localidad"].ToString();
            unCliente.piso = (int)reader["piso"];
            unCliente.numero = (int)reader["numero"];
            unCliente.calle = reader["calle"].ToString();
            unCliente.departamento = reader["departamento"].ToString();
            unCliente.nacimiento = Convert.ToDateTime(reader["nacimiento"]);
            return unCliente;
        }
    }
}