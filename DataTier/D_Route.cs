using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataTier
{
    public class D_Route
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public List<E_Route> ListAllRoute(string find)
        {

            SqlCommand command = new SqlCommand("SP_FIND_JOURNEY", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();

            command.Parameters.AddWithValue("@FIND", find);
            SqlDataReader Reader = command.ExecuteReader();

            List<E_Route> Listar = new List<E_Route>();

            while (Reader.Read())
            {
                Listar.Add(new E_Route
                {

                    IdRoute = Reader.GetInt32(0),
                    Name = Reader.GetString(1),
                    Distance = Reader.GetString(2),
                    Stop = Reader.GetInt32(3)
                   
                });
            }
            conn.Close();
            Reader.Close();
            return Listar;
        }

        public void InsertRoute(E_Route route)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_JOURNEY", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NAME_", route.Name);
            cmd.Parameters.AddWithValue("@DISTANCE", route.Distance);
            cmd.Parameters.AddWithValue("@BIRTH_DATE", route.Stop);



            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditRoute(E_Route route)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_JOURNEY", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID", route.IdRoute);
            cmd.Parameters.AddWithValue("@NAME_", route.Name);
            cmd.Parameters.AddWithValue("@SURNAME", route.Distance);
            cmd.Parameters.AddWithValue("@BIRTH_DATE", route.Stop);



            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteRoute(E_Route route)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETE_JOURNEY", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID", route.IdRoute);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
