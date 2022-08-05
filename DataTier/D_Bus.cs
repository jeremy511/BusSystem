using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTier;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataTier
{
    public class D_Bus
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public List<E_Bus> ListAllBus(string find)
         {
            
            SqlCommand command = new SqlCommand("SP_FIND_BUS", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();

            command.Parameters.AddWithValue("@FIND", find);
            SqlDataReader Reader = command.ExecuteReader();
            

           List<E_Bus> Listar = new List<E_Bus>();
            while (Reader.Read()) {
                Listar.Add(new E_Bus
                {
                    IdBus = Reader.GetInt32(0),
                    Brand = Reader.GetString(1),
                    Model = Reader.GetString(2),
                    License_Plate = Reader.GetString(3),
                    Color = Reader.GetString(4),
                    year = Reader.GetString(5)
                });
            }
            conn.Close();
            Reader.Close();
            return Listar;
        }


        public void InsertBus(E_Bus autobuses)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_BUS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@BRAND", autobuses.Brand);
            cmd.Parameters.AddWithValue("@MODEL", autobuses.Model);
            cmd.Parameters.AddWithValue("@LICENSE_PLATE", autobuses.License_Plate);
            cmd.Parameters.AddWithValue("@COLOR", autobuses.Color);
            cmd.Parameters.AddWithValue("@YEAR_", autobuses.year);


            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void EditBus(E_Bus autobuses)
        {
            SqlCommand cmd = new SqlCommand("SP_EDIT_BUS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID", autobuses.IdBus);
            cmd.Parameters.AddWithValue("@BRAND", autobuses.Brand);
            cmd.Parameters.AddWithValue("@MODEL", autobuses.Model);
            cmd.Parameters.AddWithValue("@LICENSE_PLATE", autobuses.License_Plate);
            cmd.Parameters.AddWithValue("@COLOR", autobuses.Color);
            cmd.Parameters.AddWithValue("@YEAR_", autobuses.year);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteBus(E_Bus autobuses)
        {
                SqlCommand cmd = new SqlCommand("SP_DELETE_BUS", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                cmd.Parameters.AddWithValue("@ID", autobuses.IdBus);
                cmd.ExecuteNonQuery();
                conn.Close();

        }
    }
}
