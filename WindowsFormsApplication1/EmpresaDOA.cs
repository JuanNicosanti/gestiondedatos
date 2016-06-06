using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class EmpresaDOA
    {
        private DataBase db;

        public Empresa crearUnaEmpresa(String userEmpresa)
        {
            //especifico que SP voy a ejecutar
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Traer_Empresa_Completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //seteo los parametros que recibe el stored procedure
            cmd.Parameters.AddWithValue("@idEmpresa", SqlDbType.NVarChar).Value = userEmpresa;
            Empresa unaEmpresa = null;
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            unaEmpresa = LoadObject(sdr);
            return unaEmpresa;
        }

        private Empresa LoadObject(SqlDataReader reader)
        {
            Empresa unaEmpresa = new Empresa();
            //lo que va entre parentesis son los nombres de las columnas que devuelve el SP
            unaEmpresa.username = reader["username"].ToString();
            unaEmpresa.password = reader["password"].ToString();
            unaEmpresa.mail = reader["mail"].ToString();
            unaEmpresa.cuit = (int)reader["cuit"];
            unaEmpresa.nombreContacto = reader["nombreContacto"].ToString();
            unaEmpresa.razonSocial = reader["razonSocial"].ToString();
            unaEmpresa.telefono = (int)reader["telefono"];
            unaEmpresa.rubro = reader["rubro"].ToString();
            unaEmpresa.codPostal = (int)reader["codPostal"];
            unaEmpresa.localidad = reader["localidad"].ToString();
            unaEmpresa.piso = (int)reader["piso"];
            unaEmpresa.numero = (int)reader["numero"];
            unaEmpresa.calle = reader["calle"].ToString();
            unaEmpresa.departamento = reader["departamento"].ToString();
            return unaEmpresa;
        }
    }
}

