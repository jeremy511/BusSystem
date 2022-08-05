using EntityTier;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataTier
{
    public class D_Driver
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public List<E_Driver> ListAllDriver (string find)
        {
            
            SqlCommand command = new SqlCommand("SP_FIND_DRIVER", conn);
            command.CommandType = CommandType.StoredProcedure;
            conn.Open();

            command.Parameters.AddWithValue("@FIND", find);
            SqlDataReader Reader = command.ExecuteReader();

            List<E_Driver> Listar = new List<E_Driver>();
            
            while (Reader.Read())
            {
                Listar.Add(new E_Driver
                {

                    IdDriver = Reader.GetInt32(0),
                    Name = Reader.GetString(1),
                    Lastname = Reader.GetString(2),
                    BirthDate = Reader.GetDateTime(3),
                    Cedula = Reader.GetString(4),
                });
            }
            conn.Close();
            Reader.Close();
            return Listar;
        }

        public void InsertDriver(E_Driver driver)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_DRIVER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NAME_", driver.Name);
            cmd.Parameters.AddWithValue("@SURNAME", driver.Lastname);
            cmd.Parameters.AddWithValue("@BIRTH_DATE", driver.BirthDate);
            cmd.Parameters.AddWithValue("@IDENTIFICATION_CARD", driver.Cedula);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditDriver(E_Driver driver)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERT_DRIVER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID", driver.IdDriver);
            cmd.Parameters.AddWithValue("@NAME_", driver.Name);
            cmd.Parameters.AddWithValue("@SURNAME", driver.Lastname);
            cmd.Parameters.AddWithValue("@BIRTH_DATE", driver.BirthDate);
            cmd.Parameters.AddWithValue("@IDENTIFICATION_CARD", driver.Cedula);


            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteDriver(E_Driver driver)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETE_DRIVER", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@ID", driver.IdDriver);

            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
