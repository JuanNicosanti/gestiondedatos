using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PublicacionDOA 
    {
        private DataBase db;
        public PublicacionDOA()
        {
            db = DataBase.GetInstance();
        }

        public void crearPublicacion(string descripcion, int stock, DateTime fechainicio, int precio, string visidesc, string rubrodesc, string tipodesc, string vendedor, bool envioHabilitado)
        {
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Alta_Publicacion", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descipcion", SqlDbType.NVarChar).Value = descripcion;
            cmd.Parameters.AddWithValue("@Stock", SqlDbType.Int).Value = stock;
            cmd.Parameters.AddWithValue("@FechaInicio", SqlDbType.DateTime).Value = fechainicio;
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Int).Value = precio;
            cmd.Parameters.AddWithValue("@VisiDesc", SqlDbType.NVarChar).Value = visidesc;
            cmd.Parameters.AddWithValue("@RubroDesc", SqlDbType.NVarChar).Value = rubrodesc;
            cmd.Parameters.AddWithValue("@TipoDesc", SqlDbType.NVarChar).Value = tipodesc;
            cmd.Parameters.AddWithValue("@VendedorId", SqlDbType.NVarChar).Value = "ariasz";
            cmd.Parameters.AddWithValue("@EnvioHabilitado", SqlDbType.Bit).Value = envioHabilitado;
            cmd.ExecuteNonQuery();

        }

    } 

  
}
