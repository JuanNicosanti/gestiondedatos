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

        public EmpresaDOA()
        {
            db = DataBase.GetInstance();
        }

        public Empresa crearUnaEmpresa(String userEmpresa)
        {
            //especifico que SP voy a ejecutar
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Traer_Empresa_Completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            //seteo los parametros que recibe el stored procedure
            cmd.Parameters.AddWithValue("@idEmpresa", SqlDbType.NVarChar).Value = userEmpresa;
            Empresa unaEmpresa = null;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                unaEmpresa = LoadObject(sdr);
            }
            sdr.Close();
            return unaEmpresa;
        }

        private Empresa LoadObject(SqlDataReader reader)
        {
            Empresa unaEmpresa = new Empresa();
            //lo que va entre parentesis son los nombres de las columnas que devuelve el SP
            unaEmpresa.username = reader["username"].ToString();
            unaEmpresa.password = reader["password"].ToString();
            unaEmpresa.mail = reader["mail"].ToString();
            unaEmpresa.cuit = int.Parse(reader["cuit"].ToString());
            unaEmpresa.nombreContacto = reader["nombreContacto"].ToString();
            unaEmpresa.razonSocial = reader["razonSocial"].ToString();
            unaEmpresa.telefono = int.Parse(reader["telefono"].ToString());
            unaEmpresa.rubro = reader["rubro"].ToString();
            unaEmpresa.codPostal = int.Parse(reader["codPostal"].ToString());
            unaEmpresa.localidad = reader["localidad"].ToString();
            unaEmpresa.piso = int.Parse(reader["piso"].ToString());
            unaEmpresa.numero = int.Parse(reader["numero"].ToString());
            unaEmpresa.calle = reader["calle"].ToString();
            unaEmpresa.departamento = reader["departamento"].ToString();
            unaEmpresa.creacion = Convert.ToDateTime(reader["Creacion"]);
            return unaEmpresa;
        }
    }
}

