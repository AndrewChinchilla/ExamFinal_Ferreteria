using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProyectFinalFerreteria.Clases
{
    public class ClaseConexión
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conect = new SqlConnection("SERVER=UMG-LAB\\SQLEXPRESS;DATABASE=ExamFinal_Ferreteria;integrated security=true");
            conect.Open();
            return conect;
        }


    }
    



}
