using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Fecha
    {
        public static void asignarFecha() 
        {
            SqlCommand cmd = new SqlCommand("ROAD_TO_PROYECTO.Asignar_Fecha", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fecha", SqlDbType.NVarChar).Value = Fecha.getFechaActual();
        }

        public static DateTime getFechaActual()
        {            
            return DateTime.ParseExact(ConfigurationManager.AppSettings["FechaSistema"], "yyyy-MM-dd HH:mm:ss",
                System.Globalization.CultureInfo.InvariantCulture);          
        }
    }
}
